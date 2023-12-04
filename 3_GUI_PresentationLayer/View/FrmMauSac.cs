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
    public partial class FrmMauSac : Form
    {
        IMauSacServices _mauSacServices;
        Guid _idMauSac;
        public FrmMauSac(List<MauSac> _lstMauSac)
        {
            InitializeComponent();
            _mauSacServices = new MauSacServices();
            Loaddgv();
            txtFalse();
        }
        private void Loaddgv()
        {
            dgvMauSac.ColumnCount = 3;
            dgvMauSac.Columns[0].Visible = false;
            dgvMauSac.Columns[1].Name = "Mã";
            dgvMauSac.Columns[2].Name = "Tên";
            dgvMauSac.Rows.Clear();
            foreach (var x in _mauSacServices.GetAllMauSac())
            {
                dgvMauSac.Rows.Add(x.Id, x.Ma, x.Ten);
            }
        }
        public void txtTrue()
        {
            txtTenMauSac.Enabled = true;
            lbMa.Enabled = true;
            btnSua.Enabled = true;
        }
        public void txtFalse()
        {
            txtTenMauSac.Enabled = false;
            lbMa.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
        }
        private string RandomMa()
        {
            Random random = new Random();
            int randomNumber = random.Next(10000, 100000); // Sinh ra một số nguyên ngẫu nhiên từ 10000 đến 99999
            return randomNumber.ToString(); // Chuyển đổi giá trị số nguyên thành chuỗi và trả về chuỗi đó
        }
        private bool checkNhap()
        {
            if (txtTenMauSac.Texts == "") return true;
            return false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            lbMa.Text = RandomMa();
            if (checkNhap())
            {
                MessageBox.Show("Không được để trống");
            }
            else
            {
                MauSac mauSac = new MauSac()
                {
                    Ma = lbMa.Text,
                    Ten = txtTenMauSac.Texts,
                };
                if (MessageBox.Show("Bạn có chắc chắn", "Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show(_mauSacServices.AddMauSac(mauSac));
                }
                Loaddgv();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtFalse();
            if (checkNhap())
            {
                MessageBox.Show("Không được để trống");
                return;
            }
            MauSac mauSac = new MauSac()
            {
                Id = _idMauSac,
                Ma = lbMa.Text,
                Ten = txtTenMauSac.Texts
            };
            if (MessageBox.Show("Bạn có chắc chắn", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(_mauSacServices.UpdateMauSac(mauSac));
            }
            Loaddgv();

        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtFalse();
            btnThem.Enabled = true;
            txtTenMauSac.Enabled = true;
            txtTenMauSac.Texts = "";
            lbMa.Text = "";
        }

        private void dgvMauSac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex == -1 || rowindex == _mauSacServices.GetAllMauSac().Count)
            {
                return;
            }
            _idMauSac = Guid.Parse(dgvMauSac.Rows[rowindex].Cells[0].Value.ToString());
            var mauSac = _mauSacServices.GetAllMauSac().FirstOrDefault(c => c.Id == _idMauSac);
            lbMa.Text = mauSac.Ma;
            txtTenMauSac.Texts = mauSac.Ten;
            btnThem.Enabled = false;
            txtTrue();
        }
    }
}
