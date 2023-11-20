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
    public partial class FrmManHinh : Form
    {
        IManHinhServices _manHinhServices;
        Guid _idManHinh;
        public FrmManHinh(List<ManHinh> _lstManHinh)
        {
            InitializeComponent();
            _manHinhServices = new ManHinhServices();
            LoadDgv();
            txtFalse();
        }
        private void LoadDgv()
        {
            dgvManHinh.ColumnCount = 3;
            dgvManHinh.Columns[0].Visible = false;
            dgvManHinh.Columns[1].Name = "Mã";
            dgvManHinh.Columns[2].Name = "Tên";
            dgvManHinh.Rows.Clear();
            foreach (var x in _manHinhServices.GetAllManHinh())
            {
                dgvManHinh.Rows.Add(x.Id, x.Ma, x.Ten);
            }
        }
        private void txtTrue()
        {
            lbMa.Enabled = true;
            txtManHinh.Enabled = true;
            btnSua.Enabled = true;
        }
        private void txtFalse()
        {
            lbMa.Enabled = false;
            txtManHinh.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
        }
        private string RandomMa()
        {
            Random random = new Random();
            int randomNumber = random.Next(10000, 100000); // Sinh ra một số nguyên ngẫu nhiên từ 10000 đến 99999
            return randomNumber.ToString(); // Chuyển đổi giá trị số nguyên thành chuỗi và trả về chuỗi đó
        }
        private bool checkNhap()
        {
            if (txtManHinh.Texts == "") return true;
            return false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            lbMa.Text = RandomMa();
            if (checkNhap())
            {
                MessageBox.Show("Không được để trống");
                return;
            }
            ManHinh manHinh = new ManHinh()
            {
                Ma = lbMa.Text,
                Ten = txtManHinh.Texts,
            };
            if (MessageBox.Show("Bạn có chắc chắn", "Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(_manHinhServices.AddManHinh(manHinh));
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
            ManHinh manHinh = new ManHinh()
            {
                Id = _idManHinh,
                Ma = lbMa.Text,
                Ten = txtManHinh.Texts,
            };
            if (MessageBox.Show("Bạn có chắc chắn", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(_manHinhServices.UpdateManHinh(manHinh));
            }
            LoadDgv();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtFalse();
            btnThem.Enabled = true;
            txtManHinh.Enabled = true;
            txtManHinh.Texts = "";
            lbMa.Text = "";
        }

        private void dgvManHinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex;
            rowindex = e.RowIndex;
            if (rowindex == -1 || rowindex == _manHinhServices.GetAllManHinh().Count)
            {
                return;
            }
            _idManHinh = Guid.Parse(dgvManHinh.Rows[rowindex].Cells[0].Value.ToString());
            var manHinh = _manHinhServices.GetAllManHinh().FirstOrDefault(c => c.Id == _idManHinh);
            txtManHinh.Texts = manHinh.Ten;
            lbMa.Text = manHinh.Ma;
            btnThem.Enabled = false;
            txtTrue();
        }
    }
}
