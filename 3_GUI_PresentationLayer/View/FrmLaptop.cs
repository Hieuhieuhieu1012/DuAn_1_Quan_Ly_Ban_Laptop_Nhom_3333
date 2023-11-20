using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.Services;
using _2_BUS_BusinessLayer.ViewModel;
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
using System.Windows.Input;
using static System.Resources.ResXFileRef;

namespace _3_GUI_PresentationLayer.View
{
    public partial class FrmLaptop : Form
    {
        private ILaptopService _lapTopService;
        private ICpuServices _cpuServices;
        private IVgaServices _vgaServices;
        private IMauSacServices _mauSacServices;
        private IOCungServices _oCungServices;
        private IRamServices _ramServices;
        private IManHinhServices _manHinhServices;
        private INhaCungCapServices _nhaCungCapServices;
        private IHangLaptopServices _hangLaptopServices;
        private IDongLaptopServices _dongLaptopServices;
        private ISerialLaptopService _serialLaptopService;

        private List<Cpu> _lstCpu;
        private List<Vga> _lstVga;
        private List<MauSac> _lstMauSac;
        private List<OCung> _lstOCung;
        private List<Ram> _lstRam;
        private List<ManHinh> _lstManHinh;
        private List<NhaCungCap> _lstNhaCungCap;
        private List<HangLaptop> _lstHangLaptop;
        private List<DongLaptop> _lstDongLaptop;
        private List<SerialLaptop> _lstserialLaptops;

        private string fileAnh;
        private Guid _idLaptop;

        public FrmLaptop()
        {
            InitializeComponent();
            _lapTopService = new LaptopService();
            _cpuServices = new CpuServices();
            _vgaServices = new VgaServices();
            _mauSacServices = new MauSacServices();
            _oCungServices = new OCungServices();
            _ramServices = new RamServices();
            _manHinhServices = new ManHinhServices();
            _nhaCungCapServices = new NhaCungCapServices();
            _hangLaptopServices = new HangLaptopServices();
            _dongLaptopServices = new DongLaptopServices();
            _serialLaptopService = new SerialLaptopService();

            _lstCpu = new List<Cpu>();
            _lstVga = new List<Vga>();
            _lstMauSac = new List<MauSac>();
            _lstOCung = new List<OCung>();
            _lstRam = new List<Ram>();
            _lstManHinh = new List<ManHinh>();
            _lstNhaCungCap = new List<NhaCungCap>();
            _lstHangLaptop = new List<HangLaptop>();
            _lstDongLaptop = new List<DongLaptop>();
            _lstserialLaptops = new List<SerialLaptop>();

            Loadcbb();
            LoadDgv();
            txtFalse();
        }

        #region ShowFormCon
        //Cpu
        public FrmLaptop(List<Cpu> cpus)
        {
            this._lstCpu = cpus;
        }
        private void btnCpu_Click(object sender, EventArgs e)
        {
            FrmCpu newCpu = new FrmCpu(_lstCpu);
            //newCpu.Location = new Point(915, 67);
            newCpu.ShowDialog();
            Loadcbb();
        }

        //Vga
        public FrmLaptop(List<Vga> vgas)
        {
            this._lstVga = vgas;
        }
        private void btnVga_Click(object sender, EventArgs e)
        {
            FrmVga newVga = new FrmVga(_lstVga);
            newVga.ShowDialog();
            Loadcbb();
        }

        //NhaCungCap
        public FrmLaptop(List<NhaCungCap> nhaCungCaps)
        {
            this._lstNhaCungCap = nhaCungCaps;
        }
        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            FrmNhaCungCap frmNhaCungCap = new FrmNhaCungCap(_lstNhaCungCap);
            frmNhaCungCap.ShowDialog();
            Loadcbb();
        }

        //DongLaptop
        public FrmLaptop(List<DongLaptop> dongLaptops)
        {
            this._lstDongLaptop = dongLaptops;
        }
        private void btnDongLaptop_Click(object sender, EventArgs e)
        {
            FrmDongLaptop frmDongLaptop = new FrmDongLaptop(_lstDongLaptop);
            frmDongLaptop.ShowDialog();
            Loadcbb();
        }

        //Hang san xuat
        public FrmLaptop(List<HangLaptop> hangLaptops)
        {
            this._lstHangLaptop = hangLaptops;
        }
        private void btnHangSanXuat_Click(object sender, EventArgs e)
        {
            FrmHangLaptop frmHangLaptop = new FrmHangLaptop(_lstHangLaptop);
            frmHangLaptop.ShowDialog();
            Loadcbb();
        }

        // Ram
        public FrmLaptop(List<Ram> rams)
        {
            this._lstRam = rams;
        }
        private void btnRam_Click(object sender, EventArgs e)
        {
            FrmRam frmRam = new FrmRam(_lstRam);
            frmRam.ShowDialog();
            Loadcbb();
        }

        // Ổ cứng
        public FrmLaptop(List<OCung> oCungs)
        {
            this._lstOCung = oCungs;
        }
        private void btnOCung_Click(object sender, EventArgs e)
        {
            FrmOCung frmOCung = new FrmOCung(_lstOCung);
            frmOCung.ShowDialog();
            Loadcbb();
        }

        //Màn hình
        public FrmLaptop(List<ManHinh> manHinhs)
        {
            this._lstManHinh = manHinhs;
        }
        private void btnManHinh_Click(object sender, EventArgs e)
        {
            FrmManHinh frmManHinh = new FrmManHinh(_lstManHinh);
            frmManHinh.ShowDialog();
            Loadcbb();
        }

        //Màu sắc
        public FrmLaptop(List<MauSac> mauSacs)
        {
            this._lstMauSac = mauSacs;
        }
        private void btnMauSac_Click(object sender, EventArgs e)
        {
            FrmMauSac frmMauSac = new FrmMauSac(_lstMauSac);
            //frmMauSac.Show();
            // Lấy vị trí của nút thêm nhanh
            //Point buttonPosition = btnMauSac.PointToScreen(Point.Empty);

            //// Tính toán vị trí của form con
            //int x = buttonPosition.X + btnMauSac.Width;
            //int y = buttonPosition.Y;

            //// Hiển thị form con
            //frmMauSac.Location = new Point(x, y);
            frmMauSac.ShowDialog();
            Loadcbb();
        }

        //Serial
        public FrmLaptop(List<SerialLaptop> serialLaptops)
        {
            this._lstserialLaptops = serialLaptops;
        }
        private void btnSerial_Click(object sender, EventArgs e)
        {
            if (_idLaptop == Guid.Empty)
            {
                MessageBox.Show("Bạn chưa chọn Laptop", "Thông báo");
                return;
            }
            FrmSerial frmSerial = new FrmSerial(_idLaptop);
            frmSerial.ShowDialog();
            LoadDgv();
        }
        #endregion
        #region LoadForm
        private void Loadcbb()
        {
            // CPU
            cbbCpu.DisplayMember = "Ten";
            cbbCpu.ValueMember = "Id";
            _lstCpu = _cpuServices.GetAllCpu();
            cbbCpu.DataSource = _lstCpu;
            // VGA
            cbbVga.DisplayMember = "Ten";
            cbbVga.ValueMember = "Id";
            _lstVga = _vgaServices.GetAllVga();
            cbbVga.DataSource = _lstVga;
            //Màu Sắc
            cbbMauSac.DisplayMember = "Ten";
            cbbMauSac.ValueMember = "Id";
            _lstMauSac = _mauSacServices.GetAllMauSac();
            cbbMauSac.DataSource = _lstMauSac;
            //Ổ cứng
            // cbbOCung.DisplayMember = "Ten";
            cbbOCung.ValueMember = "Id";
            _lstOCung = _oCungServices.GetAllOCungs();
            cbbOCung.Items.Clear();
            _lstOCung.ForEach(c => cbbOCung.Items.Add($"{c.Loai}-{c.DungLuong}GB"));
            //cbbOCung.DataSource = _oCungServices.GetAllOCungs();
            //Ram
            //cbbRam.DisplayMember = "Ten";
            cbbRam.ValueMember = "Id";
            _lstRam = _ramServices.GetAllRam();
            cbbRam.Items.Clear();
            _lstRam.ForEach(c => cbbRam.Items.Add($"{c.Ten}-{c.DungLuong}GB"));
            //Màn hình
            cbbManHinh.DisplayMember = "Ten";
            cbbManHinh.ValueMember = "Id";
            cbbManHinh.DataSource = _manHinhServices.GetAllManHinh();
            //Nha cung cấp
            cbbNhaCungCap.DisplayMember = "Ten";
            cbbNhaCungCap.ValueMember = "Id";
            cbbNhaCungCap.DataSource = _nhaCungCapServices.GetAllNhaCungCap();
            //Hãng Laptop
            cbbHangSanXuat.DisplayMember = "Ten";
            cbbHangSanXuat.ValueMember = "Id";
            cbbHangSanXuat.DataSource = _hangLaptopServices.GetAllHangLaptops();
            //Dòng Laptop
            cbbDong.DisplayMember = "Ten";
            cbbDong.ValueMember = "Id";
            cbbDong.DataSource = _dongLaptopServices.GetAllDongLaptop();

        }
        private void LoadDgv()
        {
            rdbtnDangBan.Checked = true;
            dgvLaptop.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLaptop.ColumnHeadersDefaultCellStyle.Font =
                new Font(dgvLaptop.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dgvLaptop.ColumnHeadersHeight = 40;
            dgvLaptop.RowTemplate.Height = 30;
            dgvLaptop.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLaptop.ColumnCount = 6;
            dgvLaptop.Columns[0].Visible = false;
            dgvLaptop.Columns[1].Name = "Tên laptop";
            dgvLaptop.Columns[2].Name = "Số lượng";
            dgvLaptop.Columns[2].FillWeight = 50;
            dgvLaptop.Columns[3].Name = "Giá nhập";
            dgvLaptop.Columns[3].DefaultCellStyle.Format = "N0";
            dgvLaptop.Columns[3].FillWeight = 70;
            dgvLaptop.Columns[4].Name = "Giá bán";
            dgvLaptop.Columns[4].DefaultCellStyle.Format = "N0";
            dgvLaptop.Columns[4].FillWeight = 70;
            dgvLaptop.Columns[5].Name = "Năm bảo hành";
            dgvLaptop.Columns[5].FillWeight = 50;

            dgvLaptop.Rows.Clear();
            foreach (var x in _lapTopService.GetAllLaptop().Where(c => c.TrangThai == true))
            {
                dgvLaptop.Rows.Add(x.Id, $"{x.HangLaptop} {x.DongLaptop} {x.Ten}", x.SoLuongTon, x.GiaNhap, x.GiaBan, x.NamBh);
            }
        }
        #endregion

        #region btnIcon
        private bool checkNhap()
        {
            if (_lapTopService.GetAllLaptop().Any(c => c.Ten == txtTen.Texts)) return true;
            return false;
        }
        private bool checkNhap1()
        {
            if (txtTen.Texts == "" || txtTrongLuong.Texts == "" || txtNamBh.Texts == "" || txtGiaBan.Texts == "" || txtGiaNhap.Texts == "" ||
                cbbHangSanXuat.Text == "" || cbbDong.Text == "" || cbbNhaCungCap.Text == "" || cbbCpu.Text == "" || cbbVga.Text == "" ||
                cbbRam.Text == "" || cbbOCung.Text == "" || cbbManHinh.Text == "" || cbbMauSac.Text == "") return true;
            return false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkNhap())
            {
                MessageBox.Show("Bạn đã bị trùng tên, mời nhập lại !!!");
                return;
            }
            if (checkNhap1())
            {
                MessageBox.Show("Không được để trống");
                return;
            }
            LaptopView laptop = new LaptopView()
            {
                Id = Guid.Empty,
                IdCpu = Guid.Parse(cbbCpu.SelectedValue.ToString()),
                IdVga = Guid.Parse(cbbVga.SelectedValue.ToString()),
                IdMauSac = Guid.Parse(cbbMauSac.SelectedValue.ToString()),
                IdOCung = _oCungServices.GetAllOCungs()[cbbOCung.SelectedIndex].Id,
                IdRam = _ramServices.GetAllRam()[cbbRam.SelectedIndex].Id,
                IdManHinh = Guid.Parse(cbbManHinh.SelectedValue.ToString()),
                IdNhaCungCap = Guid.Parse(cbbNhaCungCap.SelectedValue.ToString()),
                IdHangLaptop = Guid.Parse(cbbHangSanXuat.SelectedValue.ToString()),
                IdDongLaptop = Guid.Parse(cbbDong.SelectedValue.ToString()),
                Ten = txtTen.Texts,
                GiaNhap = decimal.Parse(txtGiaNhap.Texts),
                GiaBan = decimal.Parse(txtGiaBan.Texts),
                Mota = txtMoTa.Texts,
                TrongLuong = decimal.Parse(txtTrongLuong.Texts),
                NamBh = int.Parse(txtNamBh.Texts),
                TrangThai = true,
                Anh = Extension.ImageToArrBytes(pcbHinhAnh.Image)
            };
            if (MessageBox.Show("Bạn có chắc chắn", "Thêm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show(_lapTopService.AddLaptop(laptop));
            }
            LoadDgv();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtFalse();
            if (checkNhap1())
            {
                MessageBox.Show("Không được để trống");
                return;
            }
            var lt = _lapTopService.GetAllLaptop().FirstOrDefault(c => c.Id == _idLaptop);
            if (_lapTopService.GetAllLaptop().Any(c => c.Ten == txtTen.Texts && txtTen.Texts != lt.Ten))
            {
                MessageBox.Show("Bạn đã bị trùng tên, mời nhập lại !!!");
                return;
            }
            lt.Ten = txtTen.Texts;
            lt.Id = _idLaptop;
            lt.IdCpu = Guid.Parse(cbbCpu.SelectedValue.ToString());
            lt.IdVga = Guid.Parse(cbbVga.SelectedValue.ToString());
            lt.IdMauSac = Guid.Parse(cbbMauSac.SelectedValue.ToString());
            lt.IdOCung = _oCungServices.GetAllOCungs()[cbbOCung.SelectedIndex].Id;
            lt.IdRam = _ramServices.GetAllRam()[cbbRam.SelectedIndex].Id;
            lt.IdManHinh = Guid.Parse(cbbManHinh.SelectedValue.ToString());
            lt.IdNhaCungCap = Guid.Parse(cbbNhaCungCap.SelectedValue.ToString());
            lt.IdHangLaptop = Guid.Parse(cbbHangSanXuat.SelectedValue.ToString());
            lt.IdDongLaptop = Guid.Parse(cbbDong.SelectedValue.ToString());
            lt.GiaNhap = decimal.Parse(txtGiaNhap.Texts);
            lt.GiaBan = decimal.Parse(txtGiaBan.Texts);
            lt.Mota = txtMoTa.Texts;
            lt.TrongLuong = decimal.Parse(txtTrongLuong.Texts);
            lt.NamBh = int.Parse(txtNamBh.Texts);
            lt.TrangThai = true;
            lt.Anh = Extension.ImageToArrBytes(pcbHinhAnh.Image);

            if (MessageBox.Show("Bạn có chắc chắn", "Thêm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show(_lapTopService.UpdateLaptop(lt));
            }
            btnThem.Enabled = false;
            ClearForm();
            LoadDgv();
        }

        private void btnDoiTT_Click(object sender, EventArgs e)
        {
            txtFalse();
            var lstLaptop = _lapTopService.GetLaptopFromDb().Where(c => c.Id == _idLaptop).ToList();
            if (MessageBox.Show("Bạn có chắc chắn muốn chuyển trạng thái", "Chuyển trạng thái", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(_lapTopService.UpdateStatusLaptop(lstLaptop));
            }
            if (rdbtnDangBan.Checked)
            {
                LoadDgv();
            }
            if (rdbtnNgungBan.Checked)
            {
                dgvLaptop.Rows.Clear();
                dgvLaptop.ColumnCount = 6;
                dgvLaptop.Columns[0].Visible = false;
                dgvLaptop.Columns[1].Name = "Tên";
                dgvLaptop.Columns[2].Name = "Số lượng";
                dgvLaptop.Columns[3].Name = "Giá nhập";
                dgvLaptop.Columns[4].Name = "Giá bán";
                dgvLaptop.Columns[5].Name = "Năm bảo hành";
                foreach (var x in _lapTopService.GetAllLaptop().Where(c => c.TrangThai == false))
                {
                    dgvLaptop.Rows.Add(x.Id, $"{x.HangLaptop} {x.DongLaptop} {x.Ten}", x.SoLuongTon, x.GiaNhap, x.GiaBan, x.NamBh);
                }
            }
        }
        private void ClearForm()
        {
            txtTen.Texts = "";
            txtTrongLuong.Texts = "";
            txtNamBh.Texts = "";
            txtGiaNhap.Texts = "";
            txtGiaBan.Texts = "";
            txtMoTa.Texts = "";
            cbbCpu.Text = "";
            cbbVga.Text = "";
            cbbMauSac.Text = "";
            cbbOCung.Text = "";
            cbbRam.Text = "";
            cbbManHinh.Text = "";
            cbbNhaCungCap.Text = "";
            cbbHangSanXuat.Text = "";
            cbbDong.Text = "";
            pcbHinhAnh.Image = null;
        }
        private void btnClearForm_Click(object sender, EventArgs e)
        {
            txtFalse();
            btnThem.Enabled = true;
            txtTen.Texts = "";
            txtTrongLuong.Texts = "";
            txtNamBh.Texts = "";
            txtGiaNhap.Texts = "";
            txtGiaBan.Texts = "";
            txtMoTa.Texts = "";
            cbbCpu.Text = "";
            cbbVga.Text = "";
            cbbMauSac.Text = "";
            cbbOCung.Text = "";
            cbbRam.Text = "";
            cbbManHinh.Text = "";
            cbbNhaCungCap.Text = "";
            cbbHangSanXuat.Text = "";
            cbbDong.Text = "";
            pcbHinhAnh.Image = null;
            //Loadcbb();
            LoadDgv();
        }
        private void txtFalse()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnDoiTT.Enabled = false;
        }
        #endregion

        private void pcbHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileAnh = ofd.FileName;
                pcbHinhAnh.Image = Image.FromFile(fileAnh);
            }
        }

        private void dgvLaptop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex == -1 || rowindex == _lapTopService.GetAllLaptop().Count)
            {
                return;
            }

            _idLaptop = Guid.Parse(dgvLaptop.Rows[rowindex].Cells[0].Value.ToString());
            var lt = _lapTopService.GetAllLaptop().FirstOrDefault(c => c.Id == _idLaptop);
            var oCung = _oCungServices.GetAllOCungs().Find(c => c.Id == lt.IdOCung);
            var ram = _ramServices.GetAllRam().Find(c => c.Id == lt.IdRam);
            txtTen.Texts = lt.Ten;
            txtTrongLuong.Texts = lt.TrongLuong.ToString();
            txtNamBh.Texts = lt.NamBh.ToString();
            txtGiaNhap.Texts = lt.GiaNhap.ToString();
            txtGiaBan.Texts = lt.GiaBan.ToString();
            txtMoTa.Texts = lt.Mota;
            cbbCpu.Text = lt.Cpu;
            cbbVga.Text = lt.Vga;
            cbbMauSac.Text = lt.MauSac;
            cbbOCung.Text = $"{oCung.Loai}-{oCung.DungLuong}GB";
            cbbRam.Text = $"{ram.Ten}-{ram.DungLuong}GB";
            cbbManHinh.Text = lt.ManHinh;
            cbbNhaCungCap.Text = lt.NhaCungCap;
            cbbHangSanXuat.Text = lt.HangLaptop;
            cbbDong.Text = lt.DongLaptop;

            //Load Serial
            cbbSerial.Items.Clear();
            foreach (var x in _serialLaptopService.GetSerialLaptopList().Where(c => c.IdLaptop == lt.Id && c.TrangThai))
            {
                cbbSerial.Items.Insert(0, x.Serial);
            }

            var img = Extension.ArrBytesToImage(lt.Anh);
            if (img != null)
            {
                pcbHinhAnh.Image = img;
            }
            else
            {
                pcbHinhAnh.Image = null;
            }
            // lấy dữ liệu ảnh từ cơ sở dữ liệu
            //byte[] imageData = (byte[])lt.Anh;
            //if (imageData != null)
            //{
            //    // chuyển đổi dữ liệu byte thành kiểu MemoryStream
            //    using (MemoryStream ms = new MemoryStream(imageData))
            //    {
            //        // chuyển đổi kiểu MemoryStream thành kiểu Image
            //        Image image = Image.FromStream(ms);
            //        // hiển thị ảnh lên PictureBox
            //        pcbHinhAnh.Image = image;
            //    }
            //}
            //else
            //    {
            //        pcbHinhAnh.Image = null;
            //    }
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnDoiTT.Enabled = true;

        }

        #region Lọc

        // rdbtn lọc trạng thái
        private void rdbtnDangBan_Click(object sender, EventArgs e)
        {

            dgvLaptop.Rows.Clear();
            dgvLaptop.ColumnCount = 6;
            dgvLaptop.Columns[0].Visible = false;
            dgvLaptop.Columns[1].Name = "Tên";
            dgvLaptop.Columns[2].Name = "Số lượng";
            dgvLaptop.Columns[3].Name = "Giá nhập";
            dgvLaptop.Columns[4].Name = "Giá bán";
            dgvLaptop.Columns[5].Name = "Năm bảo hành";
            foreach (var x in _lapTopService.GetAllLaptop().Where(c => c.TrangThai == true))
            {
                dgvLaptop.Rows.Add(x.Id, $"{x.HangLaptop} {x.DongLaptop} {x.Ten}", x.SoLuongTon, x.GiaNhap, x.GiaBan, x.NamBh);
            }
        }
        private void rdbtnNgungBan_Click(object sender, EventArgs e)
        {
            dgvLaptop.Rows.Clear();
            dgvLaptop.ColumnCount = 6;
            dgvLaptop.Columns[0].Visible = false;
            dgvLaptop.Columns[1].Name = "Tên";
            dgvLaptop.Columns[2].Name = "Số lượng";
            dgvLaptop.Columns[3].Name = "Giá nhập";
            dgvLaptop.Columns[4].Name = "Giá bán";
            dgvLaptop.Columns[5].Name = "Năm bảo hành";
            foreach (var x in _lapTopService.GetAllLaptop().Where(c => c.TrangThai == false))
            {
                dgvLaptop.Rows.Add(x.Id, $"{x.HangLaptop} {x.DongLaptop} {x.Ten}", x.SoLuongTon, x.GiaNhap, x.GiaBan, x.NamBh);
            }

        }

        //txtTimKiem
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvLaptop.Rows.Clear();
            dgvLaptop.ColumnCount = 6;
            dgvLaptop.Columns[0].Visible = false;
            dgvLaptop.Columns[1].Name = "Tên";
            dgvLaptop.Columns[2].Name = "Số lượng";
            dgvLaptop.Columns[3].Name = "Giá nhập";
            dgvLaptop.Columns[4].Name = "Giá bán";
            dgvLaptop.Columns[5].Name = "Năm bảo hành";
            foreach (var x in _lapTopService.GetAllLaptop().Where(c => String.Concat(c.HangLaptop, c.DongLaptop, c.Ten).ToLower().Contains(txtTimKiem.Text.ToLower()) && c.TrangThai == true))
            {
                dgvLaptop.Rows.Add(x.Id, $"{x.HangLaptop} {x.DongLaptop} {x.Ten}", x.SoLuongTon, x.GiaNhap, x.GiaBan, x.NamBh);
            }
        }
        private void txtTimKiem_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            txtTimKiem.Text = "";
        }
        private void btnTang_Click(object sender, EventArgs e)
        {
            dgvLaptop.Rows.Clear();
            dgvLaptop.ColumnCount = 6;
            dgvLaptop.Columns[0].Visible = false;
            dgvLaptop.Columns[1].Name = "Tên";
            dgvLaptop.Columns[2].Name = "Số lượng";
            dgvLaptop.Columns[3].Name = "Giá nhập";
            dgvLaptop.Columns[4].Name = "Giá bán";
            dgvLaptop.Columns[5].Name = "Năm bảo hành";
            foreach (var x in _lapTopService.GetAllLaptop().Where(c => c.TrangThai == true).OrderBy(c => c.GiaBan))
            {
                dgvLaptop.Rows.Add(x.Id, $"{x.HangLaptop} {x.DongLaptop} {x.Ten}", x.SoLuongTon, x.GiaNhap, x.GiaBan, x.NamBh);
            }
        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
            dgvLaptop.Rows.Clear();
            dgvLaptop.ColumnCount = 6;
            dgvLaptop.Columns[0].Visible = false;
            dgvLaptop.Columns[1].Name = "Tên";
            dgvLaptop.Columns[2].Name = "Số lượng";
            dgvLaptop.Columns[3].Name = "Giá nhập";
            dgvLaptop.Columns[4].Name = "Giá bán";
            dgvLaptop.Columns[5].Name = "Năm bảo hành";
            foreach (var x in _lapTopService.GetAllLaptop().Where(c => c.TrangThai == true).OrderByDescending(c => c.GiaBan))
            {
                dgvLaptop.Rows.Add(x.Id, $"{x.HangLaptop} {x.DongLaptop} {x.Ten}", x.SoLuongTon, x.GiaNhap, x.GiaBan, x.NamBh);
            }
        }
        #endregion


    }
}
