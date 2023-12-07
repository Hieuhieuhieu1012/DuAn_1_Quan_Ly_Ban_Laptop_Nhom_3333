using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_DAL_DataAccessLayer.IRepositories;
using _1_DAL_DataAccessLayer.Models;
using _1_DAL_DataAccessLayer.Repositories;
using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.Services;
using _2_BUS_BusinessLayer.ViewModel;
using _3_GUI_PresentationLayer.CustomControl;
using AForge.Video.DirectShow;
using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.EntityFrameworkCore.Diagnostics;
using ZXing;
using ZXing.Windows.Compatibility;

namespace _3_GUI_PresentationLayer.View
{
    public partial class FrmBanHang : Form
    {
        private IChiTietHoaDonService _Bus_CThoaDon;
        private IHoaDonSerevice _Bus_hoaDon;
        private ILaptopService _laptopService;
        private ISerialLaptopService _serialLaptopService;
        private IHoaDonSerevice _hoaDonSerevice;
        private IChiTietHoaDonService _chiTietHoaDonService;
        private IKhuyenMaiServices _khuyenMaiServices;
        private IHangLapTopRepositories _hangLapTop;
        private IDongLapTopRepositories _dongLapTop;
        private IKhachHangService _khachHangService;
        private INhanVienService _nhanVienService;
        private Guid _idHoaDonCellClick;
        private string _tenNhanVien;
        private Guid _idKhachHangCellClick;

        private List<ChiTietHoaDonView> _lstCtHoaDonXoa;
        private List<ChiTietHoaDonView> _lstCtHoaDonViews;
        private FilterInfoCollection _captureVideo;
        private VideoCaptureDevice _videoCaptureDevice;
        private List<LaptopView> _lstLaptopViews;
        private Laptop _laptop;
        private HoaDonView _hoaDon;
        private Guid _idHoaDon;
        private Guid _idChiTietHD;
        private string _serialSelected;
        public FrmBanHang()
        {
            InitializeComponent();
            _Bus_CThoaDon = new ChiTietHoaDonService();
            _Bus_hoaDon = new HoaDonService();
            _laptopService = new LaptopService();
            _serialLaptopService = new SerialLaptopService();
            _laptop = new Laptop();
            _lstLaptopViews = new List<LaptopView>();
            _khachHangService = new KhachhangService();
            _hoaDonSerevice = new HoaDonService();
            _chiTietHoaDonService = new ChiTietHoaDonService();
            _khuyenMaiServices = new KhuyenMaiServices();
            _hangLapTop = new HangLaptopRepositories();
            _dongLapTop = new DongLapTopReposittoies();
            _nhanVienService = new NhanvienService();

            _lstCtHoaDonXoa = new List<ChiTietHoaDonView>();
            _lstLaptopViews = _laptopService.GetAllLaptop();

            GetDeviceVideoCapture();
            LoadData();
        }

        private void LoadData()
        {
            _lstCtHoaDonViews = new List<ChiTietHoaDonView>();
            _hoaDon = new HoaDonView();
            _idHoaDon = Guid.Empty;

            txtMaHD.Texts = _hoaDonSerevice.AutoGenerateMa();

            LoadSanPham();
            ResetForm();
            LoadGioHang();
            LoadKhachHang();
            LoadHoaDonCho();

        }

        #region LoadSanPham
        private void LoadSanPham()
        {
            dgvSanPham.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSanPham.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgvSanPham.ColumnCount = 4;
            dgvSanPham.Columns[0].Name = "Tên laptop";
            dgvSanPham.Columns[1].Name = "Giá bán";
            dgvSanPham.Columns[1].DefaultCellStyle.Format = "N0";
            dgvSanPham.Columns[2].Name = "Tồn kho";
            dgvSanPham.Columns[3].Name = "Danh sách Serial";

            dgvSanPham.Rows.Clear();
            foreach (var a in _lstLaptopViews)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dgvSanPham);
                row.Cells[0].Value = $"{a.HangLaptop} {a.DongLaptop} {a.Ten}";
                row.Cells[1].Value = a.GiaBan;
                row.Cells[2].Value = a.SoLuongTon;

                var lstSerial = new List<string>();
                var serial = _serialLaptopService.GetSerialLaptopList().Where(c => c.TrangThai && c.IdLaptop == a.Id);

                if (serial != null)
                    lstSerial = serial.Select(c => c.Serial).ToList();

                var cbbCell = new DataGridViewComboBoxCell();
                cbbCell.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
                cbbCell.AutoComplete = true;
                cbbCell.Items.AddRange(lstSerial.ToArray());
                row.Cells[3] = cbbCell;

                dgvSanPham.Rows.Add(row);
            }

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.HeaderText = "Thao tac";
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Normal;
            imageColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            imageColumn.Image = Image.FromFile(@"C:\Users\Admin\Downloads\DuAn_1_Quan_Ly_Ban_Laptop-Dev_backup\DuAn_1_Quan_Ly_Ban_Laptop-Dev_backup\3_GUI_PresentationLayer\Resources\add-to-cart.png");
            dgvSanPham.Columns.Add(imageColumn);
        }

        private void LoadSanPham(string value)
        {
            dgvSanPham.ColumnCount = 4;
            dgvSanPham.Columns[0].Name = "Tên laptop";
            dgvSanPham.Columns[1].Name = "Giá bán";
            dgvSanPham.Columns[1].DefaultCellStyle.Format = "N0";
            dgvSanPham.Columns[2].Name = "Tồn kho";
            dgvSanPham.Columns[3].Name = "Danh sách Serial";

            dgvSanPham.Rows.Clear();
            foreach (var a in _lstLaptopViews.Where(c => c.HangLaptop.Contains(value) || c.DongLaptop.Contains(value) || c.Ten.Contains(value)))
            {
                var row = new DataGridViewRow();
                row.CreateCells(dgvSanPham);
                row.Cells[0].Value = $"{a.HangLaptop} {a.DongLaptop} {a.Ten}";
                row.Cells[1].Value = a.GiaBan;
                row.Cells[2].Value = a.SoLuongTon;

                var lstSerial = new List<string>();
                var serial = _serialLaptopService.GetSerialLaptopList().Where(c => c.TrangThai && c.IdLaptop == a.Id);

                if (serial != null)
                    lstSerial = serial.Select(c => c.Serial).ToList();

                var cbbCell = new DataGridViewComboBoxCell();
                cbbCell.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
                cbbCell.FlatStyle = FlatStyle.Flat;
                cbbCell.AutoComplete = true;
                cbbCell.Items.AddRange(lstSerial.ToArray());
                row.Cells[3] = cbbCell;

                dgvSanPham.Rows.Add(row);
            }

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.HeaderText = "Thao tac";
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Normal;
            imageColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            imageColumn.Image = Image.FromFile(@"C:\Users\Admin\Downloads\DuAn_1_Quan_Ly_Ban_Laptop-Dev_backup\DuAn_1_Quan_Ly_Ban_Laptop-Dev_backup\3_GUI_PresentationLayer\Resources\add-to-cart.png");
            dgvSanPham.Columns.Add(imageColumn);
        }

        private void LoadSanPham(string value1, string value2)
        {
            dgvSanPham.ColumnCount = 4;
            dgvSanPham.Columns[0].Name = "Tên laptop";
            dgvSanPham.Columns[1].Name = "Giá bán";
            dgvSanPham.Columns[1].DefaultCellStyle.Format = "N0";
            dgvSanPham.Columns[2].Name = "Tồn kho";
            dgvSanPham.Columns[3].Name = "Danh sách Serial";

            dgvSanPham.Rows.Clear();
            foreach (var a in _lstLaptopViews.Where(c => c.GiaBan >= decimal.Parse(value1) && c.GiaBan <= decimal.Parse(value2)))
            {
                var row = new DataGridViewRow();
                row.CreateCells(dgvSanPham);
                row.Cells[0].Value = $"{a.HangLaptop} {a.DongLaptop} {a.Ten}";
                row.Cells[1].Value = a.GiaBan;
                row.Cells[2].Value = a.SoLuongTon;

                var lstSerial = new List<string>();
                var serial = _serialLaptopService.GetSerialLaptopList().Where(c => c.TrangThai && c.IdLaptop == a.Id);

                if (serial != null)
                    lstSerial = serial.Select(c => c.Serial).ToList();

                var cbbCell = new DataGridViewComboBoxCell();
                cbbCell.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
                cbbCell.AutoComplete = true;
                cbbCell.Items.AddRange(lstSerial.ToArray());
                row.Cells[3] = cbbCell;

                dgvSanPham.Rows.Add(row);
            }

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.HeaderText = "Thao tac";
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Normal;
            imageColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            imageColumn.Image = Image.FromFile(@"C:\Users\Admin\Downloads\DuAn_1_Quan_Ly_Ban_Laptop-Dev_backup\DuAn_1_Quan_Ly_Ban_Laptop-Dev_backup\3_GUI_PresentationLayer\Resources\add-to-cart.png");
            dgvSanPham.Columns.Add(imageColumn);
        }
        #endregion

        #region LoadGioHang 
        private void LoadGioHang()
        {
            dgvGioHang.ColumnCount = 8;
            dgvGioHang.Columns[0].Visible = false;
            dgvGioHang.Columns[1].Visible = false;
            dgvGioHang.Columns[2].Name = "Tên sản phẩm";
            dgvGioHang.Columns[3].Name = "Số serial";
            dgvGioHang.Columns[4].Name = "Số lượng";
            dgvGioHang.Columns[5].Name = "Giá tiền";
            dgvGioHang.Columns[5].DefaultCellStyle.Format = "N0";
            dgvGioHang.Columns[6].Name = "Giảm giá";
            dgvGioHang.Columns[6].DefaultCellStyle.Format = "N0";
            dgvGioHang.Columns[7].Name = "Thành tiền";
            dgvGioHang.Columns[7].DefaultCellStyle.Format = "N0";


            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img.HeaderText = "Thao tác";
            img.ImageLayout = DataGridViewImageCellLayout.Normal;
            img.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            img.Image = Image.FromFile(@"C:\Users\Admin\Downloads\DuAn_1_Quan_Ly_Ban_Laptop-Dev_backup\DuAn_1_Quan_Ly_Ban_Laptop-Dev_backup\3_GUI_PresentationLayer\Resources\remove_to_cart.png");
            dgvGioHang.Columns.Add(img);

            dgvGioHang.Rows.Clear();
            foreach (var a in _lstCtHoaDonViews)
            {
                dgvGioHang.Rows.Add(a.Id, a.IdSanPham, $"{a.Hang} {a.Dong} {a.TenSanPham}", a.SerialSanPham, a.SoLuong, a.DonGia, a.GiamGia, a.ThanhTien);
            }

        }
        #endregion

        private void LoadKhachHang()
        {
            var lst = _khachHangService.GetAllKhachHangs();
            AutoCompleteStringCollection lstKhachHang = new AutoCompleteStringCollection();
            lst.ForEach(c => lstKhachHang.Add(c.SoDienThoai));
            cbbSdtKH.AutoCompleteCustomSource = lstKhachHang;
            cbbSdtKH.AutoCompleteSource = AutoCompleteSource.CustomSource;

            cbbSdtKH.DisplayMember = "SoDienThoai";
            cbbSdtKH.Text = "Chọn số điện thoại";
            cbbSdtKH.Items.Clear();
            lst.ForEach(c => cbbSdtKH.Items.Add(c.SoDienThoai));
            cbbSdtKH.DropDownStyle = ComboBoxStyle.DropDown;
        }

        private void LoadKhuyenMai(Guid? idKhuyenMai)
        {
            var khuyenMai = _khuyenMaiServices.GetAllKhuyenMai().Where(c => c.TrangThai == 0 && c.Id == idKhuyenMai);
            cbbGiamGia.Text = "";
            cbbGiamGia.Items.Clear();
            if (khuyenMai.Any())
            {
                foreach (var a in khuyenMai)
                {
                    cbbGiamGia.Items.Add(a.Ten);
                }
            }
        }
        private void dgvSanPham_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvSanPham.CurrentCell.ColumnIndex == 3 && e.Control is ComboBox)
            {
                ComboBox cbb = (ComboBox)e.Control;
                cbb.Name = "cbbSerial";
                cbb.DropDownStyle = ComboBoxStyle.DropDown;
                cbb.AutoCompleteMode = AutoCompleteMode.Suggest;
            }
        }

        //Cell click San pham
        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            _serialSelected = Convert.ToString(dgvSanPham.Rows[rowIndex].Cells[3].Value);

            if (e.ColumnIndex == 4)
            {
                if (_serialSelected == "")
                {
                    MessageBox.Show("Bạn chưa chọn serial cho sản phẩm", "Thông báo");
                    return;
                }

                AddGioHang(_serialSelected);
                _serialLaptopService.UpdateStatusSerial(_serialSelected);
                LoadSanPham();
                LoadGioHang();
                TinhTien();
            }

        }

        private void AddGioHang(string serial)
        {
            btnThanhToan.Enabled = true;
            var serialLaptop = _serialLaptopService.GetSerialLaptopList().Find(c => c.Serial == serial);
            if (serialLaptop == null)
            {
                MessageBox.Show("Không tìm được sản phẩm", "Thông báo");
                return;
            }
            _laptop = _laptopService.GetLaptopFromDb().Find(c => c.Id == serialLaptop.IdLaptop);

            if (_laptop is Laptop)
            {
                var hangLaptop = _hangLapTop.GetAllHangLaptops().Find(c => c.Id == _laptop.IdHangLaptop);
                var donLaptop = _dongLapTop.GetAllDongLaptop().Find(c => c.Id == _laptop.IdDongLaptop);

                ChiTietHoaDonView ctHoaDon = new ChiTietHoaDonView()
                {
                    Id = Guid.NewGuid(),
                    IdSanPham = _laptop.Id,
                    SoLuong = 1,
                    DonGia = _laptop.GiaBan,
                    TenSanPham = _laptop.Ten,
                    Hang = hangLaptop.Ten,
                    Dong = donLaptop.Ten,
                    SerialSanPham = serial
                };
                _lstCtHoaDonViews.Add(ctHoaDon);

                foreach (var a in _lstLaptopViews)
                {
                    if (a.Ten == _laptop.Ten)
                    {
                        a.SoLuongTon--;
                    }
                }

            }
        }

        private void dgvGioHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0)
            {
                return;
            }
            _idChiTietHD = Guid.Parse(dgvGioHang.Rows[rowIndex].Cells[0].Value.ToString());
            _serialSelected = Convert.ToString(dgvGioHang.Rows[rowIndex].Cells[3].Value);


            if (e.ColumnIndex == 8)
            {
                if (_serialSelected == "")
                {
                    MessageBox.Show("Khong co so serial");
                    return;
                }
                RemoveGioHang(_idChiTietHD);
                LoadGioHang();
                _serialLaptopService.UpdateStatusSerial(_serialSelected);
                TinhTien();
                LoadSanPham();
            }
        }

        private void dgvGioHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0)
            {
                return;
            }
            _idChiTietHD = Guid.Parse(dgvGioHang.Rows[rowIndex].Cells[0].Value.ToString());
            var idLapttop = Guid.Parse(dgvGioHang.Rows[rowIndex].Cells[1].Value.ToString());
            var laptop = _laptopService.GetLaptopFromDb().FirstOrDefault(x => x.Id == idLapttop);
            if (laptop != null)
            {
                LoadKhuyenMai(laptop.IdKhuyenMai);

            }

        }

        private void RemoveGioHang(Guid idCtHoaDon)
        {
            var chiTietHD = _lstCtHoaDonViews.Find(x => x.Id == idCtHoaDon);
            // trc khi xóa trong lstCtHoaDonView thi phải thêm thằng chiTietHD vào 1 list tạm lstCtHoaDonXoa<CtHoaDonView>
            var serialupdatesoluong = _serialLaptopService.GetSerialLaptopList().Find(c => c.Serial == _serialSelected);


            _lstCtHoaDonXoa.Add(chiTietHD);

            _lstCtHoaDonViews.Remove(chiTietHD);

            if (serialupdatesoluong != null)
            {
                var laptop = _laptopService.GetLaptopFromDb().Find(c => c.Id == serialupdatesoluong.IdLaptop);
                if (laptop != null)
                {
                    foreach (var a in _lstLaptopViews)
                    {
                        if (a.Ten == laptop.Ten)
                        {
                            a.SoLuongTon++;
                        }
                    }
                }
            }
        }

        private void TinhTien()
        {
            if (_lstCtHoaDonViews.Count > 0)
            {
                decimal tongTien = 0;
                foreach (var a in _lstCtHoaDonViews)
                {
                    tongTien += a.ThanhTien;
                }
                lblTongTien.Text = tongTien.ToString("N0");
                return;
            }

            lblTongTien.Text = "0";
        }

        //Thanh toan
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (!_lstCtHoaDonViews.Any())
            {
                MessageBox.Show("Không có sản phẩm trong giỏ hàng");
                return;
            }

            var khachHang = _khachHangService.GetAllKhachHangs().Find(c => c.SoDienThoai == cbbSdtKH.Text);
            if (khachHang == null)
            {
                MessageBox.Show("Bạn chưa chọn thông tin khách mua hàng", "Thông báo");
                return;
            }

            if (!rbtnTransfer.Checked && !rbtnCash.Checked)
            {
                MessageBox.Show("Bạn chưa chọn hình thức thanh toán");
                return;
            }

            if (MessageBox.Show("Xác nhận thanh toán hóa đơn?", "Hỏi", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }

            var nhanien = _nhanVienService.GetAllNhanViens()
                .Find(c => c.Email == Properties.Settings.Default._TKdaLogin);
            if (nhanien == null) return;


            if (_idHoaDonCellClick == Guid.Empty)
            {
                _hoaDon = new HoaDonView()
                {
                    Id = Guid.NewGuid(),
                    IdNhanVien = nhanien.Id,
                    IdKhachHang = khachHang.Id,
                    MaHd = txtMaHD.Texts,
                    NgayTao = DateTime.Now,
                    NgayThanhToan = DateTime.Now,
                    GhiChu = txtGhiChu.Texts,
                    HTThanhToan = rbtnTransfer.Checked ? "Chuyển khoản" : "Tiền mặt",
                    TongTien = decimal.Parse(lblTongTien.Text),
                    TrangThaiHD = 0
                };
                _hoaDonSerevice.AddHoaDon(_hoaDon);

                foreach (var a in _lstCtHoaDonViews)
                {
                    a.IdHoaDon = _hoaDon.Id;
                    _chiTietHoaDonService.AddChiTietHoaDon(a);
                }
                MessageBox.Show("Thanh toán thành công", "Thông báo");
                if (MessageBox.Show("Bạn có muốn in hóa đơn này không?", "Hỏi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    printPerviewHD.Document = printHD;
                    printPerviewHD.PrintPreviewControl.Zoom = 1;
                    if (printPerviewHD.ShowDialog() == DialogResult.OK)
                    {
                        printHD.Print();
                    }
                }
                LoadData();
                LoadGioHang();
                //  LoadHoaDonCho();
            }
            else
            {
                var hoaDon = _hoaDonSerevice.GetAllHoaDonViews().FirstOrDefault(c => c.Id == _idHoaDonCellClick);
                hoaDon.TrangThaiHD = 0;
                hoaDon.NgayThanhToan = DateTime.Now;
                _hoaDonSerevice.UpdateHoaDon(hoaDon);
                LoadData();
                LoadGioHang();
                MessageBox.Show("Thanh toán thành công", "Thông báo");
            }


        }


        private void btnSuaHD_Click(object sender, EventArgs e)
        {

        }

        private void btnHuyHD_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (_lstCtHoaDonViews.Any())
            {
                foreach (var a in _lstCtHoaDonViews)
                {
                    if (a.IdHoaDon == Guid.Empty)
                    {
                        _serialLaptopService.UpdateStatusSerial(a.SerialSanPham);
                    }
                }
            }
            _lstLaptopViews = _laptopService.GetAllLaptop();
            LoadData();

        }

        private void activeCamera_Click(object sender, EventArgs e)
        {
            if (activeCamera.Text == "Bật camera")
            {
                _videoCaptureDevice = new VideoCaptureDevice(_captureVideo[cbbCamera.SelectedIndex].MonikerString);
                _videoCaptureDevice.NewFrame += VdeoCaptureDevice_NewFrame;
                _videoCaptureDevice.Start();
                tCamera.Enabled = true;
                tCamera.Start();
                activeCamera.Text = "Tắt camera";
            }
            else
            {
                _videoCaptureDevice.SignalToStop();
                while (_videoCaptureDevice.IsRunning)
                {
                    Thread.Sleep(100);
                }
                _videoCaptureDevice.Stop();
                tCamera.Stop();
                ptbCamera.Image = null;
                activeCamera.Text = "Bật camera";
            }
        }

        private void VdeoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            ptbCamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void GetDeviceVideoCapture()
        {
            _captureVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo a in _captureVideo)
            {
                cbbCamera.Items.Add(a.Name);
            }
            cbbCamera.SelectedIndex = 0;
        }

        private void tCamera_Tick(object sender, EventArgs e)
        {
            Bitmap img = (Bitmap)ptbCamera.Image;
            if (img != null)
            {
                BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode((Bitmap)ptbCamera.Image);
                if (result != null)
                {
                    try
                    {
                        string decoded = result.ToString();
                        if (_serialLaptopService.GetSerialLaptopList().Where(c => c.TrangThai).FirstOrDefault(c => c.Serial == decoded) == null)
                        {
                            tCamera.Stop();
                            DialogResult dialog = MessageBox.Show($"Không tìm được sản phẩm có số serial: {decoded}", "Thông báo", MessageBoxButtons.OK);
                            if (dialog == DialogResult.OK)
                            {
                                tCamera.Start();
                                return;
                            }
                        }
                        AddGioHang(decoded);
                        _serialLaptopService.UpdateStatusSerial(decoded);
                        LoadSanPham();
                        LoadGioHang();
                        TinhTien();

                    }
                    catch (Exception)
                    {
                        _videoCaptureDevice.Stop();
                    }
                }
            }
        }

        private void cbbSdtKH_TextChanged(object sender, EventArgs e)
        {
            var khachHang = _khachHangService.GetAllKhachHangs().Find(c => c.SoDienThoai == cbbSdtKH.Text);
            if (khachHang != null)
            {
                lblHoTen.Text = khachHang.Hoten;
                return;
            }

            lblHoTen.Text = "";
        }

        private void ResetForm()
        {
            lblHoTen.Text = string.Empty;
            txtTimKiem.Texts = "";
            txtGhiChu.Texts = "";
            lblTongTien.Text = "";
            rbtnTransfer.Checked = false;
            rbtnCash.Checked = false;
            // btnThanhToan.Enabled = false;

            cbbSdtKH.Text = "Chọn số điện thoại";


            //var seriaWhenClick = dgvSanPham.Rows[e.RowIndex].Cells[2].ToString();
            //var serial = _serialLaptopService.GetSerialLaptopList().FirstOrDefault(c => c.Serial == seriaWhenClick);
        }

        private void dgvGioHang_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dgvGioHang.Rows[e.RowIndex].Selected = true;
                this.menuStrip.Show(dgvGioHang, e.Location);
                menuStrip.Show(Cursor.Position);
            }

        }

        private void FrmBanHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_lstCtHoaDonViews.Any())
            {
                foreach (var a in _lstCtHoaDonViews)
                {
                    _serialLaptopService.UpdateStatusSerial(a.SerialSanPham);
                }
            }
        }

        private void strKhuyenMai_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn vừa click");
        }

        private void cbbGiamGia_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void cbbGiamGia_SelectedValueChanged(object sender, EventArgs e)
        {
            string result = cbbGiamGia.Text;
            if (result == "") return;

            var khuyenMai = _khuyenMaiServices.GetAllKhuyenMai().Find(c => c.Ten == result);
            var index = _lstCtHoaDonViews.FindIndex(c => c.Id == _idChiTietHD);
            if (index < 0) return;
            var chiTietHD = _lstCtHoaDonViews.ElementAt(index);
            if (khuyenMai.LoaiKhuyenMai == "Giảm %")
            {
                chiTietHD.GiamGia = chiTietHD.DonGia * (khuyenMai.GiaTri / 100);
            }
            else
            {
                chiTietHD.GiamGia = khuyenMai.GiaTri;
            }
            LoadGioHang();
            TinhTien();
        }

        private void printHD_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var nhanVien = _nhanVienService.GetAllNhanViens()
                .Find(c => c.Email == Properties.Settings.Default._TKdaLogin);
            if (nhanVien == null) return;

            var khachHang = _khachHangService.GetAllKhachHangs().Find(c => c.SoDienThoai == cbbSdtKH.Text);

            e.Graphics.DrawString("CỬA HÀNG LAPTOP ĐỂ BÀN", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(250, 100));
            e.Graphics.DrawString("HÓA ĐƠN THANH TOÁN", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(300, 150));
            e.Graphics.DrawString("==========================================================================================", new Font("Arial", 10), Brushes.Black, new Point(50, 190));
            e.Graphics.DrawString("Ngày tạo:", new Font("Arial", 10), Brushes.Black, new Point(530, 230));
            e.Graphics.DrawString(_hoaDon.NgayTao.ToString("g"), new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(600, 230));
            e.Graphics.DrawString("NV bán hàng: ", new Font("Arial", 10), Brushes.Black, new Point(530, 260));
            e.Graphics.DrawString(nhanVien.Hoten, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(620, 260));
            e.Graphics.DrawString("Mã hóa đơn:", new Font("Arial", 10), Brushes.Black, new Point(180, 230));
            e.Graphics.DrawString(_hoaDon.MaHd, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(280, 230));
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

            foreach (var item in _lstCtHoaDonViews)
            {
                int x = 385;
                int y = 386;
                int y1 = 396;
                e.Graphics.DrawString((a + 1).ToString(), new Font("Arial", 10), Brushes.Black, new Point(70, x + (a * 40)));
                e.Graphics.DrawString($"{item.Hang} {item.Dong} {item.TenSanPham}", new Font("Arial", 10), Brushes.Black, new Point(110, y + (a * 40)));
                e.Graphics.DrawString(item.SerialSanPham, new Font("Arial", 10), Brushes.Black, new Point(300, y + (a * 40)));
                e.Graphics.DrawString(item.SoLuong.ToString(), new Font("Arial", 10), Brushes.Black, new Point(440, y + (a * 40)));
                e.Graphics.DrawString(item.DonGia.ToString("N0"), new Font("Arial", 10), Brushes.Black, new Point(530, y + (a * 40)));
                e.Graphics.DrawString(item.GiamGia.ToString("N0"), new Font("Arial", 10), Brushes.Black, new Point(630, y + (a * 40)));
                e.Graphics.DrawString(item.ThanhTien.ToString("N0"), new Font("Arial", 10), Brushes.Black, new Point(730, y + (a * 40)));
                e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 10), Brushes.Black, new Point(70, y1 + (a * 40)));
                a++;
            }

            int sl = _lstCtHoaDonViews.Count;
            e.Graphics.DrawString("Tổng cộng", new Font("Arial", 15), Brushes.Black, new Point(70, 370 + ((sl + 1) * 45)));
            e.Graphics.DrawString(_hoaDon.TongTien.ToString("N0") + " VND", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(580, 370 + ((sl + 1) * 45)));
            e.Graphics.DrawString("==========================================================================================", new Font("Arial", 10), Brushes.Black, new Point(50, 420 + ((sl + 1) * 45)));
            e.Graphics.DrawString("XIN CẢM ƠN QUÝ KHÁCH", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(300, 500 + ((sl + 1) * 45)));
            e.Graphics.DrawString("HẸN GẶP LẠI!", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(360, 540 + ((sl + 1) * 45)));
        }

        private void txtTimKiem__TextChanged(object sender, EventArgs e)
        {
            LoadSanPham(txtTimKiem.Texts);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtGiaDau.Texts == "" || txtGiaCuoi.Texts == "")
            {
                MessageBox.Show("Cần nhập đủ giá đầu và giá cuối", "Thông báo");
                return;
            }

            if (decimal.Parse(txtGiaDau.Texts) > decimal.Parse(txtGiaCuoi.Texts))
            {
                MessageBox.Show("Khoảng giá bắt đầu phải lớn hơn cuối", "Thông báo");
                return;
            }
            LoadSanPham(txtGiaDau.Texts, txtGiaCuoi.Texts);
        }

        private void txtGiaDau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            FrmThemNhanhKH f = new FrmThemNhanhKH();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = new Point(Cursor.Position.X - f.Width, Cursor.Position.Y);
            f.ShowDialog();
            LoadKhachHang();
        }



        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (_idHoaDonCellClick == Guid.Empty)
            {
                if (!_lstCtHoaDonViews.Any())
                {
                    MessageBox.Show("Không có sản phẩm trong giỏ hàng");
                    return;
                }

                var khachHang = _khachHangService.GetAllKhachHangs().Find(c => c.SoDienThoai == cbbSdtKH.Text);
                if (khachHang == null)
                {
                    MessageBox.Show("Bạn chưa chọn thông tin khách mua hàng", "Thông báo");
                    return;
                }

                if (!rbtnTransfer.Checked && !rbtnCash.Checked)
                {
                    MessageBox.Show("Bạn chưa chọn hình thức thanh toán");
                    return;
                }

                if (MessageBox.Show("Xác nhận lưu hóa đơn chưa được thanh toán?", "Hỏi", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    return;
                }

                var nhanien = _nhanVienService.GetAllNhanViens()
                    .Find(c => c.Email == Properties.Settings.Default._TKdaLogin);
                if (nhanien == null) return;

                if (_idHoaDon == Guid.Empty)
                {
                    _hoaDon = new HoaDonView()
                    {
                        Id = Guid.NewGuid(),
                        IdNhanVien = nhanien.Id,
                        IdKhachHang = khachHang.Id,
                        MaHd = txtMaHD.Texts,
                        NgayTao = DateTime.Now,
                        NgayThanhToan = DateTime.Now,
                        GhiChu = txtGhiChu.Texts,
                        HTThanhToan = rbtnTransfer.Checked ? "Chuyển khoản" : "Tiền mặt",
                        TongTien = decimal.Parse(lblTongTien.Text),
                        TrangThaiHD = 1
                    };

                    _hoaDonSerevice.AddHoaDon(_hoaDon);

                    foreach (var a in _lstCtHoaDonViews)
                    {
                        a.IdHoaDon = _hoaDon.Id;
                        _chiTietHoaDonService.AddChiTietHoaDon(a);
                    }
                    MessageBox.Show("Lưu thành công", "Thông báo");
                    if (MessageBox.Show("Bạn có muốn in hóa đơn này không?", "Hỏi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        printPerviewHD.Document = printHD;
                        printPerviewHD.PrintPreviewControl.Zoom = 1;
                        if (printPerviewHD.ShowDialog() == DialogResult.OK)
                        {
                            printHD.Print();
                        }
                    }

                    LoadData();
                    LoadGioHang();

                }
                else
                {

                }
            }

            else
            {
                //check lstCtHoaDon xoa có item hay k
                if (_lstCtHoaDonXoa.Any() == true)
                {
                    foreach (var item in _lstCtHoaDonXoa)
                    {
                        _Bus_CThoaDon.RemoveChiTietHoaDon(item.Id);
                    }
                    _lstCtHoaDonXoa.Clear();
                    LoadData();
                    LoadGioHang();
                    MessageBox.Show("Lưu thành công", "Thông báo");
                }
                // lstCtHoaDonXoa.any() == true => thực hiện xóa trong csdl theo listCtHoaDonXOa
                else
                {
                    var hoaDon = _hoaDonSerevice.GetAllHoaDonViews().FirstOrDefault(c => c.Id == _idHoaDonCellClick);
                    foreach (var item in _lstCtHoaDonViews)
                    {
                        var chiTietHoaDon = _Bus_CThoaDon.GetAllChiTietHoaDon().FirstOrDefault(c => c.Id == item.Id);

                        if (chiTietHoaDon == null)
                        {
                            item.IdHoaDon = _idHoaDonCellClick;
                            _Bus_CThoaDon.AddChiTietHoaDon(item);
                        }
                    }
                    LoadData();
                    LoadGioHang();
                    MessageBox.Show("Lưu thành công", "Thông báo");
                }


            }

        }
        private void LoadHoaDonCho()
        {
            dgv_hoaDonCho.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_hoaDonCho.ColumnHeadersDefaultCellStyle.Font =
                new Font(dgv_hoaDonCho.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            // dgv_hoaDonCho.ColumnHeadersHeight = 40;
            // dgv_hoaDonCho.RowTemplate.Height = 30;
            dgv_hoaDonCho.ColumnCount = 5;
            dgv_hoaDonCho.Columns[0].Visible = false;
            dgv_hoaDonCho.Columns[1].Visible = false;
            dgv_hoaDonCho.Columns[2].Name = "Mã hóa đơn";
            dgv_hoaDonCho.Columns[3].Name = "Tên Khách Hàng";
            dgv_hoaDonCho.Columns[4].Name = "Tổng tiền";
            //dgv_hoaDonCho.Columns[5].DefaultCellStyle.Format = "N0";

            var lstoaDonCho = _Bus_hoaDon.GetHoaDonChoViews();
            dgv_hoaDonCho.Rows.Clear();
            foreach (var item in lstoaDonCho)

            {
                dgv_hoaDonCho.Rows.Add(item.Id, item.IdKhachHang, item.MaHd, item.TenKhachHang, item.TongTien);
            }
        }

        private void dgv_hoaDonCho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                _idKhachHangCellClick = Guid.Parse(dgv_hoaDonCho.Rows[e.RowIndex].Cells[1].Value.ToString());
                _tenNhanVien = dgv_hoaDonCho.Rows[e.RowIndex].Cells[2].Value.ToString();
                _idHoaDonCellClick = Guid.Parse(dgv_hoaDonCho.Rows[e.RowIndex].Cells[0].Value.ToString());
                LoadGioHang_to_HoaDonCho(_idHoaDonCellClick);
                LoadInfoOder_to_HoaDonCho(_idHoaDonCellClick);
            }
        }
        private void LoadGioHang_to_HoaDonCho(Guid id)
        {
            _idHoaDonCellClick = id;
            dgvGioHang.ColumnCount = 8;
            dgvGioHang.Columns[0].Visible = false;
            dgvGioHang.Columns[1].Visible = false;
            dgvGioHang.Columns[2].Name = "Tên sản phẩm";
            dgvGioHang.Columns[3].Name = "Số serial";
            dgvGioHang.Columns[4].Name = "Số lượng";
            dgvGioHang.Columns[5].Name = "Giá tiền";
            dgvGioHang.Columns[5].DefaultCellStyle.Format = "N0";
            dgvGioHang.Columns[6].Name = "Giảm giá";
            dgvGioHang.Columns[6].DefaultCellStyle.Format = "N0";
            dgvGioHang.Columns[7].Name = "Thành tiền";
            dgvGioHang.Columns[7].DefaultCellStyle.Format = "N0";


            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img.HeaderText = "Thao tác";
            img.ImageLayout = DataGridViewImageCellLayout.Normal;
            img.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            img.Image = Image.FromFile(@"C:\Users\Admin\Downloads\DuAn_1_Quan_Ly_Ban_Laptop-Dev_backup\DuAn_1_Quan_Ly_Ban_Laptop-Dev_backup\3_GUI_PresentationLayer\Resources\remove_to_cart.png");
            dgvGioHang.Columns.Add(img);

            _lstCtHoaDonViews = _Bus_CThoaDon.GetAllChiTietHoaDon().Where(c => c.IdHoaDon == id).ToList();
            dgvGioHang.Rows.Clear();
            foreach (var a in _lstCtHoaDonViews)
            {
                dgvGioHang.Rows.Add(a.Id, a.IdSanPham, $"{a.Hang} {a.Dong} {a.TenSanPham}", a.SerialSanPham, a.SoLuong, a.DonGia, a.GiamGia, a.ThanhTien);
            }
        }

        private void LoadInfoOder_to_HoaDonCho(Guid id)
        {
            _idHoaDonCellClick = id;
            var hoaDon = _Bus_hoaDon.GetAllHoaDonViews().Where(c => c.Id == id).FirstOrDefault();
            var khachHang = _khachHangService.GetAllKhachHangs().Where(c => c.Id == hoaDon.IdKhachHang).FirstOrDefault();

            cbbSdtKH.Text = khachHang.SoDienThoai;
            lblHoTen.Text = khachHang.Hoten;
            txtMaHD.Texts = hoaDon.MaHd.ToString();

            var hoaDonChiTiet = _Bus_CThoaDon.GetAllChiTietHoaDon().Where(c => c.IdHoaDon == id).ToList();
            decimal tinhTien = 0;
            foreach (var item in hoaDonChiTiet)
            {
                tinhTien = tinhTien + item.ThanhTien;

            }
            lblTongTien.Text = tinhTien.ToString();
        }

        private void btn_Remove_HdCho_Click(object sender, EventArgs e)
        {
            var hoaDon = _hoaDonSerevice.GetAllHoaDonViews().FirstOrDefault(c => c.Id == _idHoaDonCellClick);
            // var serial = _serialLaptopService.GetSerialLaptopList().FirstOrDefault(c => c.Id == _idHoaDonCellClick).ToString();
            var lstCtHd = _chiTietHoaDonService.GetAllChiTietHoaDon().Where(c => c.IdHoaDon == _idHoaDonCellClick).ToList();
            foreach (var item in lstCtHd)
            {
                _serialLaptopService.UpdateStatusSerial(item.SerialSanPham);
            }

            hoaDon.TrangThaiHD = 2;
            hoaDon.NgayThanhToan = DateTime.Now;
            _hoaDonSerevice.UpdateHoaDon(hoaDon);


            if (_lstCtHoaDonViews.Any())
            {
                foreach (var a in _lstCtHoaDonViews)
                {
                    if (a.IdHoaDon == Guid.Empty)
                    {
                        _serialLaptopService.UpdateStatusSerial(a.SerialSanPham);
                    }
                }
            }
            _lstLaptopViews = _laptopService.GetAllLaptop();
            LoadData();

            MessageBox.Show("Xóa thành công", "Thông báo");

        }

       
    }
}
