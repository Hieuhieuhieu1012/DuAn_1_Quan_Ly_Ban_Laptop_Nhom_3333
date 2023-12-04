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
    public partial class FrmCpu : Form
    {
        ICpuServices _cpuServices;
        Guid _idCpu;
        private List<Cpu> _lstCpu;
        public FrmCpu(List<Cpu> lst)
        {
            InitializeComponent();
            _cpuServices = new CpuServices();
            txtFalse();
            _lstCpu = new List<Cpu>();
            LoadDgv();
            this.CenterToScreen();
            _lstCpu = lst;
        }
        //public FrmCpu(List<Cpu> lst):this()
        //{
        //}
        private void LoadDgv()
        {
            _lstCpu = _cpuServices.GetAllCpu();
            dgvCpu.ColumnCount = 3;
            dgvCpu.Columns[0].Visible = false;
            dgvCpu.Columns[1].Name = "Mã Vga";
            dgvCpu.Columns[2].Name = "Tên Vga";

            dgvCpu.Rows.Clear();
            foreach (var x in _cpuServices.GetAllCpu())
            {
                dgvCpu.Rows.Add(x.Id, x.Ma, x.Ten);
            }
        }
        public void txtFalse()
        {
           txtTenCpu.Enabled = false;
            lbMa.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
        }
        public void txtTrue()
        {
            txtTenCpu.Enabled = true;
            lbMa.Enabled = true;
            btnSua.Enabled = true;
        }
        public bool checkNhap()
        {
            if (txtTenCpu.Texts == "") return true;
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
            }
            //MessageBox.Show(lbMa.Text);
            else
            {
                Cpu cpu = new Cpu()
                {
                    Ma = lbMa.Text,
                    Ten = txtTenCpu.Texts
                };
                //MessageBox.Show(txtTenCard.Text);
                if (MessageBox.Show("Bạn có chắc chắn", "Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show(_cpuServices.AddCpu(cpu));
                }
                LoadDgv();
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
            Cpu cpu = new Cpu()
            {
                Id = _idCpu,
                Ma = lbMa.Text,
                Ten = txtTenCpu.Texts
            };

            if (MessageBox.Show("Bạn có chắc chắn", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(_cpuServices.UpdateCpu(cpu));
            }
            LoadDgv();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtFalse();
            btnThem.Enabled = true;
            txtTenCpu.Enabled = true;
            lbMa.Text = "";
            txtTenCpu.Texts = "";
        }

        private void dgvCpu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex == -1 || rowIndex == _cpuServices.GetAllCpu().Count)
            {
                return;
            }
            _idCpu = Guid.Parse(dgvCpu.Rows[rowIndex].Cells[0].Value.ToString());
            var cpu = _cpuServices.GetAllCpu().FirstOrDefault(c => c.Id == _idCpu);
            lbMa.Text = cpu.Ma;
            txtTenCpu.Texts = cpu.Ten;
            btnThem.Enabled = false;
            txtTrue();
        }
    }
}
