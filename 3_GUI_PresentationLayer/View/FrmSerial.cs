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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xaml;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Windows.Compatibility;

namespace _3_GUI_PresentationLayer.View
{
    public partial class FrmSerial : Form
    {
        private ISerialLaptopService _serialLaptopService;
        private Guid _idLaptop;
        private List<SerialLaptop> _serialLaptopList;

        private FilterInfoCollection _infoCollection;
        private VideoCaptureDevice _captureDevice;
        public FrmSerial(Guid idLaptop)
        {
            InitializeComponent();
            this.CenterToScreen();

            _infoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo a in _infoCollection)
            {
                cbbCamera.Items.Add(a.Name);
            }
            cbbCamera.SelectedIndex = 0;

            _idLaptop = idLaptop;

            _serialLaptopService = new SerialLaptopService();
            _serialLaptopList = new List<SerialLaptop>();
            LoadDgv();
        }

        private void LoadDgv()
        {
            dgvLaptop.ColumnCount = 1;
            dgvLaptop.Columns[0].Name = "Số serial";

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Thao tác";
            btn.Text = "Xóa";
            btn.UseColumnTextForButtonValue = true;
            dgvLaptop.Columns.Add(btn);
            dgvLaptop.Columns[1].Width = 70;

            dgvLaptop.Rows.Clear();
            foreach (var x in _serialLaptopList)
            {
                dgvLaptop.Rows.Add(x.Serial);
            }
        }
        private bool checkNhap()
        {
            if (txtSerial.Texts == "") return true;
            return false;
        }
        private bool Validate()
        {
            string serial = txtSerial.Texts;

            if (serial.Length >= 15) return true;
            return false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkNhap())
            {
                MessageBox.Show("Không được để trống");
                return;
            }
            if (!Validate())
            {
                MessageBox.Show("Phải lớn hơn 15 ký tự");
                return;
            }

            if (_serialLaptopList.Any(c => c.Serial == txtSerial.Texts))
            {
                MessageBox.Show("Serial đã tồn tại");
                return;
            }
            SerialLaptop serialLaptop = new SerialLaptop()
            {
                IdLaptop = _idLaptop,
                Serial = txtSerial.Texts,
                TrangThai = true,
            };
            _serialLaptopList.Add(serialLaptop);
            LoadDgv();


            //if (MessageBox.Show("Bạn có chắc chắn", "Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    MessageBox.Show(_serialLaptopService.AddSerialLaptop(serialLaptop));
            //}
        }

        private void dgvLaptop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex == -1 || rowindex == _serialLaptopService.GetAllLaptopView().Count) return;
            _idLaptop = Guid.Parse(dgvLaptop.Rows[rowindex].Cells[0].Value.ToString());
            btnThem.Enabled = true;
            txtSerial.Enabled = true;

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvLaptop.ColumnCount = 1;
            dgvLaptop.Columns[0].Name = "Số Serial";
            dgvLaptop.Rows.Clear();
            foreach (var x in _serialLaptopList.Where(c => c.Serial.Contains(txtTimKiem.Text)))
            {
                dgvLaptop.Rows.Add(x.Serial);
            }
        }

        private void FrmSerial_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_serialLaptopList.Any())
            {
                return;
            }
            if (MessageBox.Show("Bạn có chắn chắn muốn thêm những serial trên không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _serialLaptopService.AddListSerial(_serialLaptopList);
            }
        }

        private void btnBatCamera_Click(object sender, EventArgs e)
        {
            if (btnBatCamera.Text == "Bật camera")
            {
                _captureDevice = new VideoCaptureDevice(_infoCollection[cbbCamera.SelectedIndex].MonikerString);
                _captureDevice.NewFrame += CaptureDevice_NewFrame;
                _captureDevice.Start();
                tCamera.Enabled = true;
                tCamera.Start();
                btnBatCamera.Text = "Tắt camera";
            }
            else
            {
                _captureDevice.SignalToStop();
                while (_captureDevice.IsRunning)
                {
                    Thread.Sleep(100);
                }
                _captureDevice.Stop();
                tCamera.Stop();
                pcbCamera.Image = null;
                btnBatCamera.Text = "Bật camera";
            }
        }

        private void CaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            pcbCamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void tCamera_Tick(object sender, EventArgs e)
        {
            Bitmap img = (Bitmap)pcbCamera.Image;
            if (img != null)
            {
                BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode((Bitmap)pcbCamera.Image);
                if (result != null)
                {
                    try
                    {
                        string decoded = result.ToString();
                        if (decoded != String.Empty)
                        {
                            txtSerial.Texts = decoded;
                        }
                    }
                    catch (Exception)
                    {
                        _captureDevice.Stop();
                    }
                }
            }
        }

        private void txtTimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            txtTimKiem.Text = string.Empty;
        }

        private void dgvLaptop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string serial = dgvLaptop.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (e.ColumnIndex == 1)
            {
                _serialLaptopList.Remove(_serialLaptopList.Find(c => c.Serial == serial));
                LoadDgv();
            }
        }
    }
}
