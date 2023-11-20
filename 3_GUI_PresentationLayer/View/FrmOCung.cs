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

namespace _3_GUI_PresentationLayer.View
{
    public partial class FrmOCung : Form
    {
        IOCungServices _oCungServices;
        Guid _idOCung;
        public FrmOCung(List<OCung> _lstOCung)
        {
            InitializeComponent();
            _oCungServices = new OCungServices();
            Loaddgv();
            txtFalse();
        }
        private void Loaddgv()
        {
            dgvOCung.ColumnCount = 6;
            dgvOCung.Columns[0].Visible = false;
            dgvOCung.Columns[1].Name = "Mã";
            dgvOCung.Columns[2].Name = "Tên";
            dgvOCung.Columns[3].Name = "Loại";
            dgvOCung.Columns[4].Name = "Dung Lượng";
            dgvOCung.Rows.Clear();
            foreach (var x in _oCungServices.GetAllOCungs())
            {
                dgvOCung.Rows.Add(x.Id, x.Ma, x.Ten, x.Loai, x.DungLuong);
            }
        }
        private void txtTrue()
        {
            txtTenOCung.Enabled = true;
            txtDungLuong.Enabled = true;
            rbtnHdd.Enabled = true;
            rbtnSdd.Enabled = true;
            btnSua.Enabled = true;
        }
        private void txtFalse()
        {
            txtTenOCung.Enabled = false;
            txtDungLuong.Enabled = false;
            lbMa.Enabled = false;
            rbtnSdd.Enabled = false;
            rbtnHdd.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
        }
        private bool checkNhap()
        {
            if (txtTenOCung.Texts == "" || txtDungLuong.Texts == "" || rbtnSdd.Checked == false && rbtnHdd.Checked == false) return true;
            return false;
        }
        private string RandomMa()
        {
            Random random = new Random();
            int randomNumber = random.Next(10000, 100000); // Sinh ra một số nguyên ngẫu nhiên từ 10000 đến 99999
            return randomNumber.ToString(); // Chuyển đổi giá trị số nguyên thành chuỗi và trả về chuỗi đó
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            lbMa.Text = RandomMa();
            if (checkNhap())
            {
                MessageBox.Show("Không được để rỗng");
                return;
            }
            OCung oCung = new OCung()
            {
                Ma = lbMa.Text,
                Ten = txtTenOCung.Texts,
                Loai = rbtnSdd.Checked ? "Sdd" : "Hdd",
                DungLuong = Convert.ToInt32(txtDungLuong.Texts)
            };
            if (MessageBox.Show("Bạn có chắc chắn", "Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(_oCungServices.AddOCung(oCung));
            }
            Loaddgv();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtFalse();
            if (checkNhap())
            {
                MessageBox.Show("Không được để rỗng hoặc trùng dữ liệu");
                return;
            }
            OCung oCung = new OCung()
            {
                Id = _idOCung,
                Ma = lbMa.Text,
                Ten = txtTenOCung.Texts,
                Loai = rbtnSdd.Checked ? "Sdd" : "Hdd",
                DungLuong = int.Parse(txtDungLuong.Texts),
            };
            if (MessageBox.Show("Bạn có chắc chắn", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(_oCungServices.UpdateOCung(oCung));
            }
            Loaddgv();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtFalse();
            btnThem.Enabled = true;
            txtDungLuong.Enabled = true;
            txtTenOCung.Enabled = true;
            rbtnHdd.Enabled = true;
            rbtnSdd.Enabled = true;
            txtTenOCung.Texts = "";
            txtDungLuong.Texts = "";
            rbtnSdd.Checked = false;
            rbtnHdd.Checked = false;
            lbMa.Text = "";
        }

        private void dgvOCung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex == -1 || rowindex == _oCungServices.GetAllOCungs().Count)
            {
                return;
            }
            _idOCung = Guid.Parse(dgvOCung.Rows[rowindex].Cells[0].Value.ToString());
            var oCung = _oCungServices.GetAllOCungs().FirstOrDefault(c => c.Id == _idOCung);
            lbMa.Text = oCung.Ma;
            txtTenOCung.Texts = oCung.Ten;
            txtDungLuong.Texts = oCung.DungLuong.ToString();
            if (oCung.Loai == "Sdd")
            {
                rbtnSdd.Checked = true;
            }
            else
            {
                rbtnHdd.Checked = true;
            }
            btnThem.Enabled = false;
            txtTrue();
        }

        private void txtDungLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
