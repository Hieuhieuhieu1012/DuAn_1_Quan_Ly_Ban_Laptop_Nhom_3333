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
    public partial class FrmHoaDon : Form
    {
        public FrmHoaDon()
        {
            InitializeComponent();
        }
        private void LoadHoaDon()
        {
            dgv_hoaDon.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_hoaDon.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgv_hoaDon.ColumnCount = 4;
            dgv_hoaDon.Columns[0].Name = "Mã Hóa Đơn";
            dgv_hoaDon.Columns[1].Name = "Ngày Tạo";
            dgv_hoaDon.Columns[1].DefaultCellStyle.Format = "N0";
            dgv_hoaDon.Columns[2].Name = "Ngày Thanh Toán";
            dgv_hoaDon.Columns[3].Name = "Tổng Tiền";

            dgv_hoaDon.Rows.Clear();
            for (int i = 0; i < dgv_hoaDon.Columns.Count - 1; i++)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dgv_hoaDon);
                row.Cells[0].Value = $"HD001";
                row.Cells[1].Value = "19:00 21-11-2023";
                row.Cells[2].Value = "19:00 21-11-2023";
                row.Cells[3].Value = "10,000,000";

                dgv_hoaDon.Rows.Add(row);
            }

        }

        private void LoadHoaDonCT()
        {
            dgv_CTHD.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_CTHD.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgv_CTHD.ColumnCount = 5;
            dgv_CTHD.Columns[0].Name = "Sản Phẩm";
            dgv_CTHD.Columns[1].Name = "Số Lượng";
            dgv_CTHD.Columns[1].DefaultCellStyle.Format = "N0";
            dgv_CTHD.Columns[2].Name = "Đơn Giá";
            dgv_CTHD.Columns[3].Name = "Giảm Giá";
            dgv_CTHD.Columns[4].Name = "Thành Tiền";

            dgv_CTHD.Rows.Clear();
           
                var row = new DataGridViewRow();
                row.CreateCells(dgv_CTHD);
                row.Cells[0].Value = $"Laptop 123";
                row.Cells[1].Value = "2";
                row.Cells[2].Value = "10,000,000";
                row.Cells[3].Value = "5,000,000";
                row.Cells[4].Value = "5,000,000";

                dgv_CTHD.Rows.Add(row);
            

        }

        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
            LoadHoaDon();
            LoadHoaDonCT();
        }
    }
}
