using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.Services;
using _3_GUI_PresentationLayer.Utilities;
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
        private KhachHang _khachHang;
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

        private string RandomMa()
        {
            Random random = new Random();
            int randomNumber = random.Next(10000, 100000); // Sinh ra một số nguyên ngẫu nhiên từ 10000 đến 99999
            return randomNumber.ToString(); // Chuyển đổi giá trị số nguyên thành chuỗi và trả về chuỗi đó
        }

        private void iconButtonThem_Click(object sender, EventArgs e)
        {
            _khachHang = new KhachHang();
            if (txtHoTen.Texts == null || txtSoDienThoai.Texts == null
                 || rbtNam.Checked == false && rbtNu.Checked == false || txtDiaChi.Texts == null)
            {
                MessageBox.Show("Xin vui lòng nhập đầy đủ các trường dữ liệu!");
                return;
            }

            if (!Validation.checkSDT(txtSoDienThoai.Texts))
            {
                MessageBox.Show("Số điện thoại phải đủ 10 chữ số và bắt đầu bằng số 0.Mời bạn kiểm tra lại số điện thoại!", "Thông báo");
                return;
            }
            if (!Validation.checkEmail(txtEmail.Texts))
            {
                MessageBox.Show("Eamil phải theo đúng định dang! VD: long@gmail.com ", "Thông báo");
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
            txtMa.Enabled = false;


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
                MessageBox.Show("Thêm thành công");
                iconButtonThem.Enabled = false;
                loadata();
            }
        }

        private void iconButtonSua_Click(object sender, EventArgs e)
        {

            var kh = _khachhangService.GetAllKhachHangs().FirstOrDefault(c => c.Id == _idKhachHang);
            if (txtHoTen.Texts == null || txtSoDienThoai.Texts == null
                 || rbtNam.Checked == false && rbtNu.Checked == false || txtDiaChi.Texts == null)
            {
                MessageBox.Show("Xin vui lòng nhập đầy đủ các trường dữ liệu!");
                return;
            }

            if (!Validation.checkSDT(txtSoDienThoai.Texts))
            {
                MessageBox.Show("Số điện thoại phải đủ 10 chữ số và bắt đầu bằng số 0.Mời bạn kiểm tra lại số điện thoại!", "Thông báo");
                return;
            }
            if (!Validation.checkEmail(txtEmail.Texts))
            {
                MessageBox.Show("Eamil phải theo đúng định dang! VD: long@gmail.com ", "Thông báo");
                return;
            }
            kh.SoDienThoai = txtSoDienThoai.Texts;
            if (_khachhangService.GetAllKhachHangs().Any(c => c.SoDienThoai == txtSoDienThoai.Texts && txtSoDienThoai.Texts != kh.SoDienThoai))
            {
                MessageBox.Show("Số điện thoại bạn vừa sửa đã tồn tại!Vui lòng kiểm tra lại.");
                return;
            }
            kh.Email = txtEmail.Texts;
            kh.Hoten = txtHoTen.Texts;
            kh.DiaChi = txtDiaChi.Texts;
            txtMa.Enabled = false;

            if (rbtNam.Checked == true)
            {
                kh.GioiTinh = false;
            }
            else if (rbtNu.Checked == true)
            {
                kh.GioiTinh = true;
            }

            if (MessageBox.Show("Có muốn sửa hay ko ?", "Hỏi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _khachhangService.UpdateKhachHang(kh);
                MessageBox.Show("Sửa thành công");
                loadata();
            }
        }

        private void iconButtonClear_Click(object sender, EventArgs e)
        {
            txtMa.Texts = "";
            txtHoTen.Texts = "";
            txtSoDienThoai.Texts = "";
            txtEmail.Texts = "";
            txtDiaChi.Texts = "";
            txtTimKiem.Texts = "";
            rbtNam.Checked = false;
            rbtNu.Checked = false;
            txtMa.Enabled = false;
            iconButtonThem.Enabled = true;
        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvKhachHang.CurrentRow.Index;
            txtMa.Texts = dgvKhachHang.Rows[i].Cells[0].Value.ToString();
            txtHoTen.Texts = dgvKhachHang.Rows[i].Cells[1].Value.ToString();
            txtSoDienThoai.Texts = dgvKhachHang.Rows[i].Cells[2].Value.ToString();
            txtEmail.Texts = dgvKhachHang.Rows[i].Cells[3].Value.ToString();
            if (dgvKhachHang.Rows[i].Cells[4].Value.ToString() == "Nam")
            {
                rbtNam.Checked = true;
                rbtNu.Checked = false;
            }
            else if (dgvKhachHang.Rows[i].Cells[4].Value.ToString() == "Nữ")
            {
                rbtNam.Checked = false;
                rbtNu.Checked = true;
            }

            txtDiaChi.Texts = dgvKhachHang.Rows[i].Cells[5].Value.ToString();
            _idKhachHang = Guid.Parse(dgvKhachHang.Rows[i].Cells[6].Value.ToString());
            iconButtonThem.Enabled = false;
        }

        private void txtTimKiem__TextChanged(object sender, EventArgs e)
        {
            int i = 1;
            dgvKhachHang.Rows.Clear();
            foreach (var item in _khachhangService.GetByKhachHangs(txtTimKiem.Texts))
            {
                dgvKhachHang.Rows.Add(item.Ma, item.Hoten, item.SoDienThoai, item.Email, item.GioiTinh == false ? "Nam" : "Nữ", item.DiaChi, item.Id);
            }
        }
    }
}
