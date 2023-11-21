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
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();
            Fake();
        }

        private void txtMaNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void iconButtonThem_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Fake()
        {
            dgv_NhanVien.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_NhanVien.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgv_NhanVien.ColumnCount = 9;
            dgv_NhanVien.Columns[0].Name = "Mã Nhân Viên";

            dgv_NhanVien.Columns[1].Name = "Họ Tên";
            dgv_NhanVien.Columns[2].Name = "Sđt";
            dgv_NhanVien.Columns[2].DefaultCellStyle.Format = "N0";
            dgv_NhanVien.Columns[3].Name = "Email";
            dgv_NhanVien.Columns[4].Name = "CCCD";
            dgv_NhanVien.Columns[5].Name = "Giới Tính";
            dgv_NhanVien.Columns[6].Name = "Chúc Vụ";
            dgv_NhanVien.Columns[7].Name = "Địa Chỉ";
            dgv_NhanVien.Columns[8].Name = "Mật Khẩu";

            dgv_NhanVien.Rows.Clear();

            var row = new DataGridViewRow();
            row.CreateCells(dgv_NhanVien);
            row.Cells[0].Value = $"NV001";
            row.Cells[1].Value = $"Nguyễn Văn A";
            row.Cells[2].Value = "0336610829";
            row.Cells[3].Value = "A@a";
            row.Cells[4].Value = "121212121012";
            row.Cells[5].Value = "Nam";
            row.Cells[6].Value = "Quản lý";
            row.Cells[7].Value = "Kiều Mai";
            row.Cells[8].Value = "hieu123";

            dgv_NhanVien.Rows.Add(row);
        }
    }
}
