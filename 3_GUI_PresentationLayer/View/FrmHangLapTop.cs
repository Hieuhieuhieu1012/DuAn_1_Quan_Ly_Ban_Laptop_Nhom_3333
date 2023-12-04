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
    public partial class FrmHangLaptop : Form
    {
        IHangLaptopServices _hangLaptopServices;
        Guid _idHangLapTop;
        public FrmHangLaptop(List<HangLaptop> _lstHangLaptop)
        {
            InitializeComponent();
            _hangLaptopServices = new HangLaptopServices();
            LoadDgv();
            txtFalse();
        }
        private void LoadDgv()
        {
            dgvHang.ColumnCount = 3;
            dgvHang.Columns[0].Visible = false;
            dgvHang.Columns[1].Name = "Mã";
            dgvHang.Columns[2].Name = "Tên";
            dgvHang.Rows.Clear();
            foreach (var x in _hangLaptopServices.GetAllHangLaptops())
            {
                dgvHang.Rows.Add(x.Id, x.Ma, x.Ten);
            }
        }
        private void txtTrue()
        {
            btnSua.Enabled = true;
            txtTen.Enabled = true;
        }
        private void txtFalse()
        {
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            txtTen.Enabled = false;
        }
        private string RandomMa()
        {
            Random random = new Random();
            int randomNumber = random.Next(10000, 100000); // Sinh ra một số nguyên ngẫu nhiên từ 10000 đến 99999
            return randomNumber.ToString(); // Chuyển đổi giá trị số nguyên thành chuỗi và trả về chuỗi đó
        }
        private bool checkNhap()
        {
            if (txtTen.Texts == "") return true;
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
            HangLaptop hangLaptop = new HangLaptop()
            {
                Ma = lbMa.Text,
                Ten = txtTen.Texts
            };
            if (MessageBox.Show("Bạn có chắc chắn", "Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(_hangLaptopServices.AddHangLaptop(hangLaptop));
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
            HangLaptop hangLaptop = new HangLaptop()
            {
                Id = _idHangLapTop,
                Ma = lbMa.Text,
                Ten = txtTen.Texts
            };
            if (MessageBox.Show("Bạn có chắc chắn", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(_hangLaptopServices.UpdateHangLaptop(hangLaptop));
            }
            LoadDgv();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtFalse();
            btnThem.Enabled = true;
            txtTen.Enabled = true;
            txtTen.Texts = "";
            lbMa.Text = "";
        }

        private void dgvHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex == -1||rowindex == _hangLaptopServices.GetAllHangLaptops().Count)
            {
                return;
            }
            _idHangLapTop = Guid.Parse(dgvHang.Rows[rowindex].Cells[0].Value.ToString());
            var hangLapTop = _hangLaptopServices.GetAllHangLaptops().FirstOrDefault(c=>c.Id == _idHangLapTop);
            txtTen.Texts = hangLapTop.Ten;
            lbMa.Text = hangLapTop.Ma;
            btnThem.Enabled = false;
            txtTrue();
        }
    }
}
