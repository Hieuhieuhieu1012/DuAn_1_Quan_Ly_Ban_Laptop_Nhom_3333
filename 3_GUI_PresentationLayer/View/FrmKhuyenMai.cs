using _1_DAL_DataAccessLayer.IRepositories;
using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI_PresentationLayer.View
{
    public partial class FrmKhuyenMai : Form
    {
        private IKhuyenMaiServices _khuyenMaiServices;
        private ILaptopService _laptopService;
        private IHangLaptopServices _hangLaptopServices;
        private IDongLaptopServices _dongLaptopServices;
        private IKhachHangService _khachHangService;
        private Guid _idKhuyenMai;
        public FrmKhuyenMai()
        {
            InitializeComponent();
            _khuyenMaiServices = new KhuyenMaiServices();
            _laptopService = new LaptopService();
            _hangLaptopServices = new HangLaptopServices();
            _dongLaptopServices = new DongLaptopServices();
            _khachHangService = new KhachhangService();

            ChuyenTrangThai();
            LoadData();
            ClearForm();
        }

        private void LoadData()
        {
            ClearForm();
            LoadConboBox();

            dgvKhuyenMai.ColumnCount = 7;
            dgvKhuyenMai.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvKhuyenMai.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvKhuyenMai.Columns[0].Visible = false;
            dgvKhuyenMai.Columns[1].Name = "Tên";
            dgvKhuyenMai.Columns[2].Name = "Loại";
            dgvKhuyenMai.Columns[3].Name = "Giá trị";
            dgvKhuyenMai.Columns[3].DefaultCellStyle.Format = "N0";
            dgvKhuyenMai.Columns[4].Name = "Trạng thái";
            dgvKhuyenMai.Columns[5].Name = "Ngày bắt đầu";
            dgvKhuyenMai.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvKhuyenMai.Columns[6].Name = "Ngày kết thúc";
            dgvKhuyenMai.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";

            dgvKhuyenMai.Rows.Clear();
            foreach (var x in _khuyenMaiServices.GetAllKhuyenMai())
            {
                string trangThai = x.TrangThai == 0 ? "Đang khuyến mại" : (x.TrangThai == 1 ? "Sắp khuyến mại" : "Đã kết thúc");
                string giaTri = x.LoaiKhuyenMai == "Giảm %" ? $"{x.GiaTri:N0} %" : $"{x.GiaTri:N0} VND";
                dgvKhuyenMai.Rows.Add(x.Id, x.Ten, x.LoaiKhuyenMai, giaTri, trangThai, x.NgayBatDau, x.NgayKetThuc);
            }

            dgvSanPham.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSanPham.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvSanPham.ColumnCount = 2;
            dgvSanPham.Columns[0].Visible = false;
            dgvSanPham.Columns[1].Name = "Tên laptop";

            DataGridViewCheckBoxColumn checkBox = new DataGridViewCheckBoxColumn();
            checkBox.FillWeight = 15;
            checkBox.HeaderText = "Chọn";
            checkBox.Name = "cb";
            dgvSanPham.Columns.Add(checkBox);

            dgvSanPham.Rows.Clear();
            foreach (var a in _laptopService.GetAllLaptop().Where(c => c.TrangThai == true))
            {
                dgvSanPham.Rows.Add(a.Id, $"{a.HangLaptop} {a.DongLaptop} {a.Ten}");
            }
        }

        private void LoadConboBox()
        {
            cbbLoaiKhuyenMai.Items.Clear();
            cbbLoaiKhuyenMai.Items.Add("Giảm tiền trực tiếp");
            cbbLoaiKhuyenMai.Items.Add("Giảm %");
            cbbLoaiKhuyenMai.SelectedIndex = 0;

            cbbHang.DisplayMember = "Ten";
            cbbHang.ValueMember = "Id";
            cbbHang.DataSource = _hangLaptopServices.GetAllHangLaptops();
            cbbHang.SelectedIndex = -1;

            cbbDong.DisplayMember = "Ten";
            cbbDong.ValueMember = "Id";
            cbbDong.DataSource = _dongLaptopServices.GetAllDongLaptop();
            cbbDong.SelectedIndex = -1;

        }

        private string RandomMa()
        {
            Random random = new Random();
            int randomNumber = random.Next(10000, 100000); // Sinh ra một số nguyên ngẫu nhiên từ 10000 đến 99999
            return randomNumber.ToString(); // Chuyển đổi giá trị số nguyên thành chuỗi và trả về chuỗi đó
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenCT.Texts == "" || txtMucGia.Texts == "")
            {
                MessageBox.Show("Không được để trống dữ liệu", "Thông báo");
                return;
            }

            if (dtBatDau.Value.Date >= DateTime.Now.Date && dtKetThuc.Value < dtBatDau.Value)
            {
                MessageBox.Show("Ngày bắt đầu phải lớn hơn ngày kết thúc", "Thông báo");
                return;
            }

            if (lblLoai.Text == "%" && (decimal.Parse(txtMucGia.Texts) <= 0 || decimal.Parse(txtMucGia.Texts) > 100))
            {
                MessageBox.Show("Mức giá khuyến mại phải trong khoảng 0-100%");
                return;
            }

            int totalCheckBoxCheked = dgvSanPham.Rows.Cast<DataGridViewRow>()
                .Count(c => Convert.ToBoolean(c.Cells["cb"].Value) == true);
            if (totalCheckBoxCheked == 0)
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm áp dụng khuyến mại", "Thông báo");
                return;
            }


            //txtMa.Texts = RandomMa();

            if (MessageBox.Show("Bạn có chắc chắn muốn thêm khuyến mại này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                KhuyenMai khuyenMai = new KhuyenMai()
                {
                    Id = Guid.NewGuid(),
                    Ten = txtTenCT.Texts,
                    Ma = RandomMa(),
                    LoaiKhuyenMai = cbbLoaiKhuyenMai.Text,
                    GiaTri = decimal.Parse(txtMucGia.Texts),
                    NgayBatDau = dtBatDau.Value,
                    NgayKetThuc = dtKetThuc.Value,
                    TrangThai = dtBatDau.Value.Date == DateTime.Now.Date ? 0 : 1,
                };
                MessageBox.Show(_khuyenMaiServices.AddKhuyenMai(khuyenMai));

                foreach (DataGridViewRow row in dgvSanPham.Rows)
                {
                    DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)row.Cells["cb"];
                    if (Convert.ToBoolean(checkBoxCell.Value))
                    {
                        Guid idLaptop = Guid.Parse(row.Cells[0].Value.ToString());
                        _laptopService.UpdateKhuyeMaiLaptop(idLaptop, khuyenMai.Id);
                    }
                }

                if (MessageBox.Show("Bạn có muốn gửi thông tin khuyến mại này cho các khách hàng không?", "Hỏi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var khachHangList = _khachHangService.GetAllKhachHangs().Where(c => c.Email != "").ToList();
                    int khachHangCount = 0;
                    foreach (var a in khachHangList)
                    {
                        SendEmailKhuyenMai(a.Hoten, a.Email, khuyenMai.Ten);
                        khachHangCount++;
                    }

                    MessageBox.Show($"Đã gửi email đến cho: {khachHangCount} khách hàng", "Thông  báo");
                }
                LoadData();
            }
        }

        private void ChuyenTrangThai()
        {
            foreach (var x in _khuyenMaiServices.GetAllKhuyenMai())
            {
                _khuyenMaiServices.ChuyenTrangThai(x);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txtTenCT.Texts == "" || txtMucGia.Texts == "")
            {
                MessageBox.Show("Không được để trống dữ liệu", "Thông báo");
                return;
            }

            if (dtBatDau.Value.Date >= DateTime.Now.Date && dtKetThuc.Value < dtBatDau.Value)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc", "Thông báo");
                return;
            }

            int totalCheckBoxCheked = dgvSanPham.Rows.Cast<DataGridViewRow>()
                .Count(c => Convert.ToBoolean(c.Cells["cb"].Value) == true);

            if (totalCheckBoxCheked == 0)
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm áp dụng khuyến mại", "Thông báo");
                return;
            }

            if (lblLoai.Text == "%" && (decimal.Parse(txtMucGia.Texts) <= 0 && decimal.Parse(txtMucGia.Texts) > 100))
            {
                MessageBox.Show("Mức giá khuyến mại phải trong khoảng 0-100%");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn sửa khuyến mại này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                KhuyenMai khuyenMai = new KhuyenMai()
                {
                    Id = _idKhuyenMai,
                    Ten = txtTenCT.Texts,
                    LoaiKhuyenMai = cbbLoaiKhuyenMai.Text,
                    GiaTri = decimal.Parse(txtMucGia.Texts),
                    NgayBatDau = dtBatDau.Value,
                    NgayKetThuc = dtKetThuc.Value,
                    TrangThai = dtBatDau.Value.Date == DateTime.Now.Date ? 0 : 1,
                };
                MessageBox.Show(_khuyenMaiServices.UpdateKhuyenMai(khuyenMai));

                foreach (DataGridViewRow row in dgvSanPham.Rows)
                {
                    DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)row.Cells["cb"];
                    Guid idLaptop = Guid.Parse(row.Cells[0].Value.ToString());
                    var laptop = _laptopService.GetAllLaptop().Find(c => c.Id == idLaptop);

                    if (Convert.ToBoolean(checkBoxCell.Value) && laptop.IdKhuyenMai == null)
                    {
                        _laptopService.UpdateKhuyeMaiLaptop(idLaptop, khuyenMai.Id);
                    }

                    if (Convert.ToBoolean(checkBoxCell.Value) == false && laptop.IdKhuyenMai == _idKhuyenMai)
                    {
                        _laptopService.UpdateKhuyeMaiLaptop(idLaptop, null);
                    }
                }
                LoadData();
            }
        }

        private void dgvKhuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex == -1 || rowindex == _khuyenMaiServices.GetAllKhuyenMai().Count)
            {
                return;
            }
            btn_Sua.Enabled = true;
            btnThem.Enabled = false;

            _idKhuyenMai = Guid.Parse(dgvKhuyenMai.Rows[rowindex].Cells[0].Value.ToString());
            var khuyenMai = _khuyenMaiServices.GetAllKhuyenMai().FirstOrDefault(c => c.Id == _idKhuyenMai);
            txtMa.Texts = khuyenMai.Ma;
            txtTenCT.Texts = khuyenMai.Ten;
            cbbLoaiKhuyenMai.Text = khuyenMai.LoaiKhuyenMai;
            dtBatDau.Value = khuyenMai.NgayBatDau;
            dtKetThuc.Value = khuyenMai.NgayKetThuc;
            txtMucGia.Texts = khuyenMai.GiaTri.ToString();


            var laptopList = _laptopService.GetAllLaptop().Where(c => c.IdKhuyenMai == _idKhuyenMai);
            foreach (DataGridViewRow row in dgvSanPham.Rows)
            {
                Guid idLaptop = Guid.Parse(row.Cells[0].Value.ToString());
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)row.Cells["cb"];

                if (laptopList.Any(c => c.Id == idLaptop))
                {
                    checkBoxCell.Value = true;
                }
                else
                {
                    checkBoxCell.Value = false;
                }

            }
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadData();
        }

        private void ClearForm()
        {
            btn_Sua.Enabled = false;
            btnThem.Enabled = true;
            txtMa.Texts = "";
            txtTenCT.Texts = "";
            cbbLoaiKhuyenMai.Text = "";
            txtMucGia.Texts = "";
            dtBatDau.Value = DateTime.Now;
            dtKetThuc.Value = DateTime.Now;
        }

       

        private void btnAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvSanPham.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCellcell = (DataGridViewCheckBoxCell)row.Cells["cb"];
                checkBoxCellcell.Value = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvSanPham.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCellcell = (DataGridViewCheckBoxCell)row.Cells["cb"];
                checkBoxCellcell.Value = false;
            }
        }

        private void cbbHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbHang.SelectedIndex == -1)
            {
                cbbHang.Text = "Tất cả";
                return;
            }

            var idHangLaptopSelected = Guid.Parse(cbbHang.SelectedValue.ToString());
            var dongLaptopList = _dongLaptopServices.GetAllDongLaptop().Where(c => c.IdHangLaptop == idHangLaptopSelected).ToList();
            cbbDong.DisplayMember = "Ten";
            cbbDong.ValueMember = "Id";
            cbbDong.DataSource = dongLaptopList;

            dgvSanPham.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSanPham.ColumnHeadersDefaultCellStyle.Font =
                new Font(dgvSanPham.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dgvSanPham.ColumnCount = 2;
            dgvSanPham.Columns[0].Visible = false;
            dgvSanPham.Columns[1].Name = "Tên laptop";

            DataGridViewCheckBoxColumn checkBox = new DataGridViewCheckBoxColumn();
            checkBox.FillWeight = 20;
            checkBox.HeaderText = "Chọn";
            checkBox.Name = "cb";
            dgvSanPham.Columns.Add(checkBox);

            dgvSanPham.Rows.Clear();
            foreach (var a in _laptopService.GetAllLaptop().Where(c => c.IdHangLaptop == idHangLaptopSelected && c.TrangThai == true))
            {
                dgvSanPham.Rows.Add(a.Id, $"{a.HangLaptop} {a.DongLaptop} {a.Ten}");
            }

        }

        private void cbbDong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDong.SelectedIndex == -1 && cbbHang.SelectedIndex == -1)
            {
                cbbDong.Text = "Tất cả";
                return;
            }

            var idDongLaptopSelected = Guid.Parse(cbbDong.SelectedValue.ToString());

            dgvSanPham.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSanPham.ColumnHeadersDefaultCellStyle.Font =
                new Font(dgvSanPham.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dgvSanPham.ColumnCount = 2;
            dgvSanPham.Columns[0].Visible = false;
            dgvSanPham.Columns[1].Name = "Tên laptop";

            DataGridViewCheckBoxColumn checkBox = new DataGridViewCheckBoxColumn();
            checkBox.FillWeight = 20;
            checkBox.HeaderText = "Chọn";
            checkBox.Name = "cb";
            dgvSanPham.Columns.Add(checkBox);

            dgvSanPham.Rows.Clear();
            foreach (var a in _laptopService.GetAllLaptop().Where(c => c.IdDongLaptop == idDongLaptopSelected || c.TrangThai == true))
            {
                dgvSanPham.Rows.Add(a.Id, $"{a.HangLaptop} {a.DongLaptop} {a.Ten}");
            }
        }

        private void btnrbDang_CheckedChanged(object sender, EventArgs e)
        {
            dgvKhuyenMai.ColumnCount = 7;
            dgvKhuyenMai.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvKhuyenMai.ColumnHeadersDefaultCellStyle.Font = new Font(dgvKhuyenMai.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dgvKhuyenMai.Columns[0].Visible = false;
            dgvKhuyenMai.Columns[1].Name = "Tên";
            dgvKhuyenMai.Columns[2].Name = "Loại";
            dgvKhuyenMai.Columns[3].Name = "Giá trị";
            dgvKhuyenMai.Columns[4].Name = "Trạng thái";
            dgvKhuyenMai.Columns[5].Name = "Ngày bắt đầu";
            dgvKhuyenMai.Columns[6].Name = "Ngày kết thúc";

            dgvKhuyenMai.Rows.Clear();
            foreach (var x in _khuyenMaiServices.GetAllKhuyenMai().Where(c => c.TrangThai == 0))
            {
                string trangThai = x.TrangThai == 0 ? "Đang khuyến mại" : (x.TrangThai == 1 ? "Sắp khuyến mại" : "Đã kết thúc");
                string giaTri = x.LoaiKhuyenMai == "Giảm %" ? $"{x.GiaTri:N0} %" : $"{x.GiaTri:N0} VND";
                dgvKhuyenMai.Rows.Add(x.Id, x.Ten, x.LoaiKhuyenMai, giaTri, trangThai, x.NgayBatDau, x.NgayKetThuc);
            }
        }
        private void cbbLoaiKhuyenMai_TextChanged(object sender, EventArgs e)
        {
            if (cbbLoaiKhuyenMai.Text == "Giảm %")
            {
                lblLoai.Text = "%";
            }
            else
            {
                lblLoai.Text = "VND";
            }
        }

        private void txtMucGia_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void SendEmailKhuyenMai(string ten, string email, string tenKM)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("maituandat087804@gmail.com");
            mail.To.Add(email);
            mail.Body = $"Xin chào anh/chị: <b>{ten}</b>\n." +
                        $"Hiện tại cửa hàng bên em đang có chương trình khuyến mại: {tenKM} với nhiều giảm giá của các dòng Laptop.\n" +
                        "Xin kính mời anh/chị qua bên cửa hàng để tham khảo cũng như trải nghiệm.";
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            NetworkCredential nc = new NetworkCredential();
            nc.UserName = "maituandat087804@gmail.com";
            nc.Password = "dyeeqsadlarqjync";
            smtp.Credentials = nc;
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.Send(mail);
            //MessageBox.Show("Gửi thành công");
        }

    }
}
