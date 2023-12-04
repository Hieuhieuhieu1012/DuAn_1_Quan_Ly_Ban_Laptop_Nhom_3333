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
using System.Windows.Controls;
using System.Windows.Forms;

namespace _3_GUI_PresentationLayer.View
{
    public partial class FrmVga : Form
    {
        IVgaServices _vgaServices;
        Guid _idVga;
        public FrmVga(List<Vga> _lstVga)
        {
            InitializeComponent();
            _vgaServices = new VgaServices();
            txtFalse();
            LoadDgv();
        }
        void LoadDgv()
        {
            dtgVga.ColumnCount = 3;
            dtgVga.Columns[0].Visible = false;
            dtgVga.Columns[1].Name = "Ma";
            dtgVga.Columns[2].Name = "Ten";
            dtgVga.Rows.Clear();
            foreach (var x in _vgaServices.GetAllVga())
            {
                dtgVga.Rows.Add(x.Id, x.Ma, x.Ten);
            }
        }
        void txtFalse()
        {
            lbMa.Enabled = false;
            txtCard.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
        }
        void txtTrue()
        {
            txtCard.Enabled = true;
            lbMa.Enabled = true;
            btnSua.Enabled = true;
        }
        private string RandomMa()
        {
            Random random = new Random();
            int randomNumber = random.Next(10000, 100000); // Sinh ra một số nguyên ngẫu nhiên từ 10000 đến 99999
            return randomNumber.ToString(); // Chuyển đổi giá trị số nguyên thành chuỗi và trả về chuỗi đó
        }
        private bool checkNhap()
        {
            if (txtCard.Texts == "") return true;
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
            Vga vga = new Vga()
            {
                Ma = lbMa.Text,
                Ten = txtCard.Texts
            };
            if (MessageBox.Show("Bạn có chắc chắn", "Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(_vgaServices.AddVga(vga));
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
            Vga vga = new Vga()
            {
                Id = _idVga,
                Ma = lbMa.Text,
                Ten = txtCard.Texts
            };
            if (MessageBox.Show("Bạn có chắc chắn", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(_vgaServices.UpdateVga(vga));
            }
            LoadDgv();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtFalse();
            btnThem.Enabled = true;
            txtCard.Enabled = true;
            txtCard.Texts = "";
            lbMa.Text = "";
        }

        private void dtgVga_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex == -1 || rowindex == _vgaServices.GetAllVga().Count)
            {
                return;
            }
            _idVga = Guid.Parse(dtgVga.Rows[rowindex].Cells[0].Value.ToString());
            var cpu = _vgaServices.GetAllVga().FirstOrDefault(c => c.Id == _idVga);
            lbMa.Text = cpu.Ma;
            txtCard.Texts = cpu.Ten;
            btnThem.Enabled = false;
            txtTrue();
        }
    }
}
