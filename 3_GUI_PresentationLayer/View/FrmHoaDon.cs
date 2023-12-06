using _1_DAL_DataAccessLayer.IRepositories;
using _1_DAL_DataAccessLayer.Models;
using _1_DAL_DataAccessLayer.Repositories;
using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.Services;
using _2_BUS_BusinessLayer.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;

namespace _3_GUI_PresentationLayer.View
{
    public partial class FrmHoaDon : Form
    {
        private IKhachHangService _khachHangService;
        private ILaptopService _Bus_LapTop;
        private IHoaDonSerevice _Bus_hoaDon;
        private List<HoaDonView> _lst_hoaDon;
        private IChiTietHoaDonService _bus_chiTietHoaDon;
        private List<ChiTietHoaDon> _lst_CTHD;
        private Guid _idHoaDonCellClick;
        private string _tenNhanVien;
        private Guid _idKhachHangCellClick;

        public FrmHoaDon()
        {
            _Bus_LapTop = new LaptopService();
            _bus_chiTietHoaDon = new ChiTietHoaDonService();
            _lst_CTHD = new List<ChiTietHoaDon>();
            _Bus_hoaDon = new HoaDonService();
            _lst_hoaDon = new List<HoaDonView>();
            _khachHangService = new KhachhangService();
            InitializeComponent();
            ShowHĐ();
        }

        public void loadHDCT(Guid id)
        {
            _idHoaDonCellClick = id;
            dgv_CTHD.ColumnHeadersHeight = 40;
            dgv_CTHD.RowTemplate.Height = 30;
            dgv_CTHD.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_CTHD.ColumnHeadersDefaultCellStyle.Font =
                new Font(dgv_CTHD.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dgv_CTHD.Rows.Clear();
            dgv_CTHD.ColumnCount = 7;
            dgv_CTHD.Columns[0].Visible = false;
            dgv_CTHD.Columns[1].Name = "Tên laptop";
            dgv_CTHD.Columns[2].Name = "Số serial";
            dgv_CTHD.Columns[3].Name = "Số lượng";
            dgv_CTHD.Columns[4].Name = "Đơn giá";
            dgv_CTHD.Columns[4].DefaultCellStyle.Format = "N0";
            dgv_CTHD.Columns[5].Name = "Giảm giá";
            dgv_CTHD.Columns[5].DefaultCellStyle.Format = "N0";
            dgv_CTHD.Columns[6].Name = "Thành tiền";
            dgv_CTHD.Columns[6].DefaultCellStyle.Format = "N0";

            dgv_CTHD.Rows.Clear();
            foreach (var item in _bus_chiTietHoaDon.GetAllCTHĐ(id))
            {
                dgv_CTHD.Rows.Add(item.Id, $"{item.Hang} {item.Dong} {item.TenSanPham}", item.SerialSanPham, item.SoLuong, item.DonGia, item.GiamGia, item.ThanhTien);
            }
        }

        public void ShowHĐ()
        {
            dgv_hoaDon.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_hoaDon.ColumnHeadersDefaultCellStyle.Font =
                new Font(dgv_hoaDon.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dgv_hoaDon.ColumnHeadersHeight = 40;
            dgv_hoaDon.RowTemplate.Height = 30;
            dgv_hoaDon.ColumnCount = 9;
            dgv_hoaDon.Columns[0].Visible = false;
            dgv_hoaDon.Columns[1].Visible = false;
            dgv_hoaDon.Columns[2].Name = "Tên Nhân Viên";
            dgv_hoaDon.Columns[3].Name = "Tên Khách Hàng";
            dgv_hoaDon.Columns[4].Name = "Mã hóa đơn";
            dgv_hoaDon.Columns[5].Name = "Hình thức TT";
            dgv_hoaDon.Columns[6].Name = "Ngày tạo";
            dgv_hoaDon.Columns[7].Name = "Ghi chú";
            dgv_hoaDon.Columns[8].Name = "Tổng tiền";
            dgv_hoaDon.Columns[8].DefaultCellStyle.Format = "N0";

            dgv_hoaDon.Rows.Clear();
            foreach (var item in _Bus_hoaDon.GetAllHoaDonViews().Where(c => c.TrangThaiHD == 0))
            {
                dgv_hoaDon.Rows.Add(item.Id, item.IdKhachHang, item.TenNhanVien, item.TenKhachHang, item.MaHd, item.HTThanhToan, item.NgayTao, item.GhiChu, item.TongTien);
            }
        }

        private void radioButtonCustom1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void bt_theongay_Click(object sender, EventArgs e)
        {
            var id = txtTimKiem.Text;
            dgv_hoaDon.Rows.Clear();
            dgv_hoaDon.Rows.Clear();
            var items = _Bus_hoaDon.GetAllHoaDonViews().Where(x => x.SDT == id);
            if (items.Any())
            {
                foreach (var a in items)
                {
                    ShowHĐ();
                }
            }
            else
            {
                MessageBox.Show("Không có");
            }
        }

        private void dgv_hoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _idKhachHangCellClick = Guid.Parse(dgv_hoaDon.Rows[e.RowIndex].Cells[1].Value.ToString());
                _tenNhanVien = dgv_hoaDon.Rows[e.RowIndex].Cells[2].Value.ToString();
                _idHoaDonCellClick = Guid.Parse(dgv_hoaDon.Rows[e.RowIndex].Cells[0].Value.ToString());
                loadHDCT(_idHoaDonCellClick);
            }
        }

        private void bt_TheoNgayTuyChinh_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date.AddDays(1).AddSeconds(-1);

            if (startDate > endDate)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var listHoaDon = _Bus_hoaDon.GetAllHoaDonViews().Where(hd => hd.NgayTao >= startDate && hd.NgayTao <= endDate).ToList();

            if (listHoaDon.Count == 0)
            {
                MessageBox.Show("Không có hoá đơn nào được tạo trong khoảng thời gian bạn đã chọn, vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dgv_hoaDon.Rows.Clear();

            foreach (var item in listHoaDon)
            {
                ShowHĐ();
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn in hóa đơn này không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                printPreviewDialog1.Document = printHD;
                printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printHD.Print();
                }
            }
        }

        private void printHD_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var hoaDon = _Bus_hoaDon.GetAllHoaDonViews().Find(c => c.Id == _idHoaDonCellClick);
            var khachHang = _khachHangService.GetAllKhachHangs().Find(c => c.Id == _idKhachHangCellClick);

            e.Graphics.DrawString("CỬA HÀNG LAPTOP ĐỂ BÀN", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(250, 100));
            e.Graphics.DrawString("HÓA ĐƠN THANH TOÁN", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(300, 150));
            e.Graphics.DrawString("==========================================================================================", new Font("Arial", 10), Brushes.Black, new Point(50, 190));
            e.Graphics.DrawString("Ngày tạo:", new Font("Arial", 10), Brushes.Black, new Point(530, 230));
            e.Graphics.DrawString(hoaDon.NgayTao.ToString("g"), new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(600, 230));
            e.Graphics.DrawString("NV bán hàng: ", new Font("Arial", 10), Brushes.Black, new Point(530, 260));
            e.Graphics.DrawString(_tenNhanVien, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(620, 260));
            e.Graphics.DrawString("Mã hóa đơn:", new Font("Arial", 10), Brushes.Black, new Point(180, 230));
            e.Graphics.DrawString(hoaDon.MaHd, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(280, 230));
            e.Graphics.DrawString("Khách hàng:", new Font("Arial", 10), Brushes.Black, new Point(180, 260));
            e.Graphics.DrawString(khachHang.Hoten, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(280, 260));
            e.Graphics.DrawString("Số điện thoại:", new Font("Arial", 10), Brushes.Black, new Point(180, 290));
            e.Graphics.DrawString(khachHang.SoDienThoai, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(280, 290));

            e.Graphics.DrawString("STT", new Font("Arial", 10), Brushes.Black, new Point(70, 350));
            e.Graphics.DrawString("Sản phẩm", new Font("Arial", 10), Brushes.Black, new Point(110, 350));
            e.Graphics.DrawString("Serial", new Font("Arial", 10), Brushes.Black, new Point(300, 350));
            e.Graphics.DrawString("Số lượng", new Font("Arial", 10), Brushes.Black, new Point(440, 350));
            e.Graphics.DrawString("Đơn giá", new Font("Arial", 10), Brushes.Black, new Point(530, 350));
            e.Graphics.DrawString("Giảm giá", new Font("Arial", 10), Brushes.Black, new Point(630, 350));
            e.Graphics.DrawString("Thành tiền", new Font("Arial", 10), Brushes.Black, new Point(730, 350));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 10), Brushes.Black, new Point(70, 360));
            int a = 0;

            foreach (DataGridViewRow row in dgv_CTHD.Rows)
            {
                int x = 385;
                int y = 386;
                int y1 = 396;
                decimal donGia = decimal.Parse(row.Cells[4].Value.ToString());
                decimal giamGia = decimal.Parse(row.Cells[5].Value.ToString());
                decimal thanhTien = decimal.Parse(row.Cells[6].Value.ToString());

                e.Graphics.DrawString((a + 1).ToString(), new Font("Arial", 10), Brushes.Black, new Point(70, x + (a * 40)));
                e.Graphics.DrawString(row.Cells[1].Value.ToString(), new Font("Arial", 10), Brushes.Black, new Point(110, y + (a * 40)));
                e.Graphics.DrawString(row.Cells[2].Value.ToString(), new Font("Arial", 10), Brushes.Black, new Point(300, y + (a * 40)));
                e.Graphics.DrawString(row.Cells[3].Value.ToString(), new Font("Arial", 10), Brushes.Black, new Point(440, y + (a * 40)));
                e.Graphics.DrawString(donGia.ToString("N0"), new Font("Arial", 10), Brushes.Black, new Point(530, y + (a * 40)));
                e.Graphics.DrawString(giamGia.ToString("N0"), new Font("Arial", 10), Brushes.Black, new Point(630, y + (a * 40)));
                e.Graphics.DrawString(thanhTien.ToString("N0"), new Font("Arial", 10), Brushes.Black, new Point(730, y + (a * 40)));
                e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 10), Brushes.Black, new Point(70, y1 + (a * 40)));
                a++;
            }

            int sl = dgv_CTHD.Rows.Count;
            e.Graphics.DrawString("Tổng cộng", new Font("Arial", 15), Brushes.Black, new Point(70, 370 + ((sl + 1) * 45)));
            e.Graphics.DrawString(hoaDon.TongTien.ToString("N0") + " VND", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(580, 370 + ((sl + 1) * 45)));
            e.Graphics.DrawString("==========================================================================================", new Font("Arial", 10), Brushes.Black, new Point(50, 420 + ((sl + 1) * 45)));
            e.Graphics.DrawString("XIN CẢM ƠN QUÝ KHÁCH", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(300, 500 + ((sl + 1) * 45)));
            e.Graphics.DrawString("HẸN GẶP LẠI!", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(360, 540 + ((sl + 1) * 45)));
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            foreach (DataGridViewColumn column in dgv_hoaDon.Columns.Cast<DataGridViewColumn>().Skip(2))
            {
                dt.Columns.Add(column.HeaderText);
            }

            foreach (DataGridViewRow row in dgv_hoaDon.Rows)
            {
                dt.Rows.Add();
                foreach (DataGridViewCell cel in row.Cells.Cast<DataGridViewCell>().Skip(2))
                {
                    dt.Rows[dt.Rows.Count - 1][cel.ColumnIndex - 2] = cel.Value != null ? cel.Value.ToString() : "";
                }
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Title = "Chọn vị trí lưu file";
            saveFileDialog.Filter = "(*.xlsx) | *.xlsx | All files (*.*) | *.*";
            saveFileDialog.FilterIndex = 1;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string folderPath = saveFileDialog.FileName;
                folderPath = Path.ChangeExtension(folderPath, ".xlsx");
                if (!Directory.Exists(folderPath))
                {
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        wb.Worksheets.Add(dt, "Hóa đơn");

                        wb.Worksheet(1).Cells("A1:C1").Style.Fill.BackgroundColor = XLColor.DarkGreen;

                        wb.Worksheet(1).Columns().AdjustToContents();
                        wb.SaveAs(folderPath);
                        MessageBox.Show("Lưu thành công");
                    }
                }
            }

        }

        private void txtTimKiem__TextChanged(object sender, EventArgs e)
        {
            dgv_hoaDon.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_hoaDon.ColumnHeadersDefaultCellStyle.Font =
                new Font(dgv_hoaDon.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dgv_hoaDon.ColumnHeadersHeight = 40;
            dgv_hoaDon.RowTemplate.Height = 30;
            dgv_hoaDon.ColumnCount = 9;
            dgv_hoaDon.Columns[0].Visible = false;
            dgv_hoaDon.Columns[1].Visible = false;
            dgv_hoaDon.Columns[2].Name = "Tên Nhân Viên";
            dgv_hoaDon.Columns[3].Name = "Tên Khách Hàng";
            dgv_hoaDon.Columns[4].Name = "Mã hóa đơn";
            dgv_hoaDon.Columns[5].Name = "Hình thức TT";
            dgv_hoaDon.Columns[6].Name = "Ngày tạo";
            dgv_hoaDon.Columns[7].Name = "Ghi chú";
            dgv_hoaDon.Columns[8].Name = "Tổng tiền";
            dgv_hoaDon.Columns[8].DefaultCellStyle.Format = "N0";

            dgv_hoaDon.Rows.Clear();
            foreach (var item in _Bus_hoaDon.GetAllHoaDonViews().Where(c => c.SDT.Contains(txtTimKiem.Texts) || c.TenKhachHang.ToLower().Contains(txtTimKiem.Texts.ToLower())))

            {
                dgv_hoaDon.Rows.Add(item.Id, item.IdKhachHang, item.TenNhanVien, item.TenKhachHang, item.MaHd,
                    item.HTThanhToan, item.NgayTao, item.GhiChu, item.TongTien);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            dgv_hoaDon.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_hoaDon.ColumnHeadersDefaultCellStyle.Font =
                new Font(dgv_hoaDon.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dgv_hoaDon.ColumnHeadersHeight = 40;
            dgv_hoaDon.RowTemplate.Height = 30;
            dgv_hoaDon.ColumnCount = 9;
            dgv_hoaDon.Columns[0].Visible = false;
            dgv_hoaDon.Columns[1].Visible = false;
            dgv_hoaDon.Columns[2].Name = "Tên Nhân Viên";
            dgv_hoaDon.Columns[3].Name = "Tên Khách Hàng";
            dgv_hoaDon.Columns[4].Name = "Mã hóa đơn";
            dgv_hoaDon.Columns[5].Name = "Hình thức TT";
            dgv_hoaDon.Columns[6].Name = "Ngày tạo";
            dgv_hoaDon.Columns[7].Name = "Ghi chú";
            dgv_hoaDon.Columns[8].Name = "Tổng tiền";
            dgv_hoaDon.Columns[8].DefaultCellStyle.Format = "N0";

            dgv_hoaDon.Rows.Clear();
            foreach (var item in _Bus_hoaDon.GetAllHoaDonViews().Where(c =>
                         c.NgayTao.Date >= dtpStartDate.Value.Date && c.NgayTao.Date <= dtpEndDate.Value.Date))
            {
                dgv_hoaDon.Rows.Add(item.Id, item.IdKhachHang, item.TenNhanVien, item.TenKhachHang, item.MaHd,
                    item.HTThanhToan, item.NgayTao, item.GhiChu, item.TongTien);
            }
        }

        private void rd_ThanhToan_Click(object sender, EventArgs e)
        {
            dgv_hoaDon.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_hoaDon.ColumnHeadersDefaultCellStyle.Font =
                new Font(dgv_hoaDon.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dgv_hoaDon.ColumnHeadersHeight = 40;
            dgv_hoaDon.RowTemplate.Height = 30;
            dgv_hoaDon.ColumnCount = 9;
            dgv_hoaDon.Columns[0].Visible = false;
            dgv_hoaDon.Columns[1].Visible = false;
            dgv_hoaDon.Columns[2].Name = "Tên Nhân Viên";
            dgv_hoaDon.Columns[3].Name = "Tên Khách Hàng";
            dgv_hoaDon.Columns[4].Name = "Mã hóa đơn";
            dgv_hoaDon.Columns[5].Name = "Hình thức TT";
            dgv_hoaDon.Columns[6].Name = "Ngày tạo";
            dgv_hoaDon.Columns[7].Name = "Ghi chú";
            dgv_hoaDon.Columns[8].Name = "Tổng tiền";
            dgv_hoaDon.Columns[8].DefaultCellStyle.Format = "N0";

            dgv_hoaDon.Rows.Clear();
            foreach (var item in _Bus_hoaDon.GetAllHoaDonViews().Where(c => c.TrangThaiHD == 0))
            {
                dgv_hoaDon.Rows.Add(item.Id, item.IdKhachHang, item.TenNhanVien, item.TenKhachHang, item.MaHd, item.HTThanhToan, item.NgayTao, item.GhiChu, item.TongTien);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dgv_hoaDon.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_hoaDon.ColumnHeadersDefaultCellStyle.Font =
                new Font(dgv_hoaDon.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dgv_hoaDon.ColumnHeadersHeight = 40;
            dgv_hoaDon.RowTemplate.Height = 30;
            dgv_hoaDon.ColumnCount = 9;
            dgv_hoaDon.Columns[0].Visible = false;
            dgv_hoaDon.Columns[1].Visible = false;
            dgv_hoaDon.Columns[2].Name = "Tên Nhân Viên";
            dgv_hoaDon.Columns[3].Name = "Tên Khách Hàng";
            dgv_hoaDon.Columns[4].Name = "Mã hóa đơn";
            dgv_hoaDon.Columns[5].Name = "Hình thức TT";
            dgv_hoaDon.Columns[6].Name = "Ngày tạo";
            dgv_hoaDon.Columns[7].Name = "Ghi chú";
            dgv_hoaDon.Columns[8].Name = "Tổng tiền";
            dgv_hoaDon.Columns[8].DefaultCellStyle.Format = "N0";

            dgv_hoaDon.Rows.Clear();
            foreach (var item in _Bus_hoaDon.GetAllHoaDonViews().Where(c => c.TrangThaiHD == 2))
            {
                dgv_hoaDon.Rows.Add(item.Id, item.IdKhachHang, item.TenNhanVien, item.TenKhachHang, item.MaHd, item.HTThanhToan, item.NgayTao, item.GhiChu, item.TongTien);
            }
        }
    }
}