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
    public partial class FrmDongLaptop : Form
    {
        IDongLaptopServices _dongLaptopServices;
        IHangLaptopServices _hangLaptopServices;
        Guid _idDong;
        public FrmDongLaptop(List<DongLaptop> _lstDongLaptop)
        {
            InitializeComponent();
            _dongLaptopServices = new DongLaptopServices();
            _hangLaptopServices = new HangLaptopServices();
            LoadDgv();
            txtFalse();
        }
        private void LoadDgv()
        {
            cbbHang.DisplayMember = "Ten";
            cbbHang.ValueMember = "Id";
            cbbHang.DataSource = _hangLaptopServices.GetAllHangLaptops();
            dgvDong.ColumnCount = 3;
            dgvDong.Columns[0].Visible = false;
            dgvDong.Columns[1].Name = "Mã";
            dgvDong.Columns[2].Name = "Tên";
            dgvDong.Rows.Clear();
            foreach (var x in _dongLaptopServices.GetAllDongLaptop())
            {
                dgvDong.Rows.Add(x.Id, x.Ma, x.Ten);
            }
        }
        private void txtTrue()
        {
            btnSua.Enabled = true;
            txtDong.Enabled = true;
        }
        private void txtFalse()
        {
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            txtDong.Enabled = false;
        }
        private string RandomMa()
        {
            Random random = new Random();
            int randomNumber = random.Next(10000, 100000); // Sinh ra một số nguyên ngẫu nhiên từ 10000 đến 99999
            return randomNumber.ToString(); // Chuyển đổi giá trị số nguyên thành chuỗi và trả về chuỗi đó
        }
        private bool checkNhap()
        {
            if (txtDong.Texts == "") return true;
            return false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            lbMa.Text = RandomMa();
            if (checkNhap())
            {
                MessageBox.Show("Không được rỗng");
                return;
            }
            DongLaptop dongLaptop = new DongLaptop()
            {
                IdHangLaptop = Guid.Parse(cbbHang.GetItemText(cbbHang.SelectedValue).ToString()),
                Ten = txtDong.Texts,
                Ma = lbMa.Text,
            };
            if (MessageBox.Show("Bạn có chắc chắn", "Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(_dongLaptopServices.AddDongLapTop(dongLaptop));
            }
            LoadDgv();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtFalse();
            if (checkNhap())
            {
                MessageBox.Show("Không được rỗng");
                return;
            }
            DongLaptop dongLaptop = new DongLaptop()
            {
                Id = _idDong,
                Ten = txtDong.Texts,
                Ma = lbMa.Text,
            };
            if (MessageBox.Show("Bạn có chắc chắn", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(_dongLaptopServices.UpdateDongLapTop(dongLaptop));
            }
            LoadDgv();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtFalse();
            btnThem.Enabled = true;
            txtDong.Enabled = true;
            txtDong.Texts = "";
            lbMa.Text = "";
        }

        private void dgvDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex == -1 || rowindex == _dongLaptopServices.GetAllDongLaptop().Count)
            {
                return;
            }
            _idDong = Guid.Parse(dgvDong.Rows[rowindex].Cells[0].Value.ToString());
            var dong = _dongLaptopServices.GetAllDongLaptop().FirstOrDefault(c => c.Id == _idDong);
            var hang = _hangLaptopServices.GetAllHangLaptops().FirstOrDefault(c => c.Id == dong.IdHangLaptop);
            txtDong.Texts = dong.Ten;
            lbMa.Text = dong.Ma;
            cbbHang.Text = hang.Ten;
            btnThem.Enabled = false;
            txtTrue();
        }
    }
}
