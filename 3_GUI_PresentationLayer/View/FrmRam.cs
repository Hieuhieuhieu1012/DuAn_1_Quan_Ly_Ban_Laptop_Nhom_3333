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
    public partial class FrmRam : Form
    {
        IRamServices _ramServices;
        Guid _idRam;
        public FrmRam(List<Ram> _lstRam)
        {
            InitializeComponent();
            _ramServices = new RamServices();
            LoadDgv();
            txtFalse();
        }
        private void LoadDgv()
        {
            dgvRam.ColumnCount = 4;
            dgvRam.Columns[0].Visible = false;
            dgvRam.Columns[1].Name = "Mã";
            dgvRam.Columns[2].Name = "Tên";
            dgvRam.Columns[3].Name = "Dung Lượng";
            dgvRam.Rows.Clear();
            foreach (var x in _ramServices.GetAllRam())
            {
                dgvRam.Rows.Add(x.Id, x.Ma, x.Ten, x.DungLuong);
            }
        }
        private void txtTrue()
        {
            txtTenRam.Enabled = true;
            txtDungLuong.Enabled = true;
            lbMa.Enabled = true;
            btnSua.Enabled = true;
        }
        private void txtFalse()
        {
            txtTenRam.Enabled = false;
            txtDungLuong.Enabled = false;
            lbMa.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
        }
        private bool checkNhap()
        {
            if (txtTenRam.Texts == "") return true;
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
                MessageBox.Show("Không được để trống");
                return;
            }
            Ram ram = new Ram()
            {
                Ma = lbMa.Text,
                Ten = txtTenRam.Texts,
                DungLuong = Convert.ToInt32(txtDungLuong.Texts)
            };
            if (MessageBox.Show("Bạn có chắc chắn", "Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(_ramServices.AddRam(ram));
            }
            LoadDgv();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtFalse();
            if (checkNhap())
            {
                MessageBox.Show("Không được để rỗng");
                return;
            }
            Ram ram = new Ram()
            {
                Id = _idRam,
                Ma = lbMa.Text,
                Ten = txtTenRam.Texts,
                DungLuong = Convert.ToInt32(txtDungLuong.Texts)
                // dung lượng ram
            };

            if (MessageBox.Show("Bạn có chắc chắn", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(_ramServices.UpdateRam(ram));
            }
            LoadDgv();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtFalse();
            btnThem.Enabled = true;
            txtTenRam.Enabled = true;
            txtDungLuong.Enabled = true;
            txtTenRam.Texts = "";
            lbMa.Text = "";
            txtDungLuong.Texts = "";
        }

        private void dgvRam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex == -1 || rowindex == _ramServices.GetAllRam().Count)
            {
                return;
            }
            _idRam = Guid.Parse(dgvRam.Rows[rowindex].Cells[0].Value.ToString());
            var ram = _ramServices.GetAllRam().FirstOrDefault(c => c.Id == _idRam);
            txtTenRam.Texts = ram.Ten;
            lbMa.Text = ram.Ma;
            txtDungLuong.Texts = ram.DungLuong.ToString();
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
