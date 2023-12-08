using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace _3_GUI_PresentationLayer.View
{
    public partial class FrmThemNhanhKH : Form
    {
        private KhachHang _khachHang;
        private KhachhangService _khachhangService;
        Guid _idKhachHang;
        public FrmThemNhanhKH()
        {
            InitializeComponent();
            _khachhangService = new KhachhangService();
        }

        private string RandomMa()
        {
            Random random = new Random();
            int randomNumber = random.Next(10000, 100000); // Sinh ra một số nguyên ngẫu nhiên từ 10000 đến 99999
            return randomNumber.ToString(); // Chuyển đổi giá trị số nguyên thành chuỗi và trả về chuỗi đó
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            _khachHang = new KhachHang();
            if (txtHoTen.Texts == null || txtSoDienThoai.Texts == null
                 || rbtNam.Checked == false && rbtNu.Checked == false || txtDiaChi.Texts == null)
            {
                MessageBox.Show("Xin vui lòng nhập đầy đủ các trường dữ liệu!");
                return;
            }

            
            if (_khachhangService.GetAllKhachHangs().Any(c => c.SoDienThoai == txtSoDienThoai.Texts))
            {
                MessageBox.Show("Số điện thoại đã bị tồn tai!Vui lòng kiểm tra lại số điện thoại!");
                return;
            }

            _khachHang.Ma = RandomMa();
            _khachHang.Hoten = txtHoTen.Texts;
            _khachHang.SoDienThoai = txtSoDienThoai.Texts;
            _khachHang.DiaChi = txtDiaChi.Texts;
            _khachHang.Email = txtEmail.Texts;

            if (rbtNam.Checked == true)
            {
                _khachHang.GioiTinh = false;
            }
            else if (rbtNu.Checked == true)
            {
                _khachHang.GioiTinh = true;
            }

            if (MessageBox.Show("Có muốn thêm hay ko ?", "Hỏi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show(_khachhangService.AddKhachHang(_khachHang));
                Close();
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txtHoTen.Texts = "";
            txtSoDienThoai.Texts = "";
            txtEmail.Texts = "";
            txtDiaChi.Texts = "";
            rbtNam.Checked = false;
            rbtNu.Checked = false;
        }

        private void btThem_Click_1(object sender, EventArgs e)
        {
            _khachHang = new KhachHang();
            if (txtHoTen.Texts == null || txtSoDienThoai.Texts == null
                 || rbtNam.Checked == false && rbtNu.Checked == false || txtDiaChi.Texts == null)
            {
                MessageBox.Show("Xin vui lòng nhập đầy đủ các trường dữ liệu!");
                return;
            }


            if (_khachhangService.GetAllKhachHangs().Any(c => c.SoDienThoai == txtSoDienThoai.Texts))
            {
                MessageBox.Show("Số điện thoại đã bị tồn tai!Vui lòng kiểm tra lại số điện thoại!");
                return;
            }

            _khachHang.Ma = RandomMa();
            _khachHang.Hoten = txtHoTen.Texts;
            _khachHang.SoDienThoai = txtSoDienThoai.Texts;
            _khachHang.DiaChi = txtDiaChi.Texts;
            _khachHang.Email = txtEmail.Texts;

            if (rbtNam.Checked == true)
            {
                _khachHang.GioiTinh = false;
            }
            else if (rbtNu.Checked == true)
            {
                _khachHang.GioiTinh = true;
            }

            if (MessageBox.Show("Có muốn thêm hay ko ?", "Hỏi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _khachhangService.AddKhachHang(_khachHang);
                MessageBox.Show("Thêm Thành Công !");
                Close();
            }

        }
    }
}
