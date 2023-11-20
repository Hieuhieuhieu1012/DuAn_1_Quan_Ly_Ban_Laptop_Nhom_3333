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
    public partial class FrmNhaCungCap : Form
    {
        INhaCungCapServices _nhaCungCapServices;
        Guid _idNhaCungCap;
        public FrmNhaCungCap(List<NhaCungCap> _lstNhaCungCap)
        {
            InitializeComponent();
            _nhaCungCapServices = new NhaCungCapServices();
            LoadDgv();
            txtFalse();
        }
        private void LoadDgv()
        {
            dgvNhaCungCap.ColumnCount = 3;
            dgvNhaCungCap.Columns[0].Visible = false;
            dgvNhaCungCap.Columns[1].Name = "Mã";
            dgvNhaCungCap.Columns[2].Name = "Tên";
            dgvNhaCungCap.Rows.Clear();
            foreach (var x in _nhaCungCapServices.GetAllNhaCungCap())
            {
                dgvNhaCungCap.Rows.Add(x.Id, x.Ma, x.Ten);
            }
        }
        private void txtTrue()
        {
            btnSua.Enabled = true;
            txtTenNhaCungCap.Enabled = true;
            lbMa.Enabled = true;
        }
        private void txtFalse()
        {
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            txtTenNhaCungCap.Enabled = false;
            lbMa.Enabled = false;
        }
        private string RandomMa()
        {
            Random random = new Random();
            int randomNumber = random.Next(10000, 100000); // Sinh ra một số nguyên ngẫu nhiên từ 10000 đến 99999
            return randomNumber.ToString(); // Chuyển đổi giá trị số nguyên thành chuỗi và trả về chuỗi đó
        }
        private bool checkNhap()
        {
            if (txtTenNhaCungCap.Texts == "") return true;
            return false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            lbMa.Text = RandomMa();
            if (checkNhap())
            {
                MessageBox.Show("Không được để rỗng");
                return;
            }
            NhaCungCap nhaCungCap = new NhaCungCap()
            {
                Ma = lbMa.Text,
                Ten = txtTenNhaCungCap.Texts,
            };
            if (MessageBox.Show("Bạn có chắc chắn", "Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(_nhaCungCapServices.AddNhaCungCap(nhaCungCap));
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
            NhaCungCap nhaCungCap = new NhaCungCap()
            {
                Id = _idNhaCungCap,
                Ma = lbMa.Text,
                Ten = txtTenNhaCungCap.Texts
            };
            if (MessageBox.Show("Bạn có chắc chắn", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(_nhaCungCapServices.UpdateNhaCungCap(nhaCungCap));
            }
            LoadDgv();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtFalse();
            txtTenNhaCungCap.Enabled = true;
            btnThem.Enabled = true;
            txtTenNhaCungCap.Texts = "";
            lbMa.Text = "";
        }

        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex;
            rowindex = e.RowIndex;
            if(rowindex == -1 || rowindex == _nhaCungCapServices.GetAllNhaCungCap().Count)
            {
                return;
            }
            _idNhaCungCap = Guid.Parse(dgvNhaCungCap.Rows[rowindex].Cells[0].Value.ToString());
            var nhaCungCap = _nhaCungCapServices.GetAllNhaCungCap().FirstOrDefault(c=>c.Id == _idNhaCungCap);
            txtTenNhaCungCap.Texts = nhaCungCap.Ten;
            lbMa.Text = nhaCungCap.Ma;
            btnThem.Enabled = false;
            txtTrue();
        }
    }
}
