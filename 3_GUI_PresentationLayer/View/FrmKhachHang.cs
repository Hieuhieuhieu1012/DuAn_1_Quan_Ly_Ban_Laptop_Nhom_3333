using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI_PresentationLayer.View
{
    public partial class FrmKhachHang : Form
    {

        private KhachHang _KhachHang;
        private KhachhangService _khachhangService;
        Guid _idKhachHang;


        public FrmKhachHang()
        {
            InitializeComponent();
            _khachhangService = new KhachhangService();
            loadata();
        }
        public void loadata()
        {
            int i = 1;
            dgvKhachHang.Rows.Clear();
            foreach (var item in _khachhangService.GetAllKhachHangs())
            {
                dgvKhachHang.Rows.Add(item.Ma, item.Hoten, item.SoDienThoai, item.Email, item.GioiTinh == false ? "Nam" : "Nữ", item.DiaChi, item.Id);
            }
            txtMa.Enabled = false;
        }

       

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {

        }
        private string RandomMa()
        {
            Random random = new Random();
            int randomNumber = random.Next(10000, 100000); // Sinh ra một số nguyên ngẫu nhiên từ 10000 đến 99999
            return randomNumber.ToString(); // Chuyển đổi giá trị số nguyên thành chuỗi và trả về chuỗi đó
        }

        private void iconButtonThem_Click(object sender, EventArgs e)
        {
            _KhachHang = new KhachHang();
            _KhachHang.Ma = RandomMa();
            _KhachHang.Hoten = txtHoTen.Texts;
            _KhachHang.SoDienThoai = txtSoDienThoai.Texts;
            _KhachHang.DiaChi = txtDiaChi.Texts;
            _KhachHang.Email = txtEmail.Texts;
            _khachhangService.AddKhachHang( _KhachHang );
            loadata();

        }
    }
}
