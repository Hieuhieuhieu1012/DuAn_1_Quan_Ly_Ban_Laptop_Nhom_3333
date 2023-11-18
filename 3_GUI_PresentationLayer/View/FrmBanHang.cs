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
    public partial class FrmBanHang : Form
    {
        public FrmBanHang()
        {
            InitializeComponent();
        }

        private void FrmBanHang_Load(object sender, EventArgs e)
        {
            LoadGioHang();
            LoadSanPham();
            LoadChoThanhToan();
        }
        private void LoadSanPham()
        {
            dgvSanPham.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSanPham.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgvSanPham.ColumnCount = 4;
            dgvSanPham.Columns[0].Name = "Tên laptop";
            dgvSanPham.Columns[1].Name = "Giá bán";
            dgvSanPham.Columns[1].DefaultCellStyle.Format = "N0";
            dgvSanPham.Columns[2].Name = "Tồn kho";
            dgvSanPham.Columns[3].Name = "Danh sách Serial";

            dgvSanPham.Rows.Clear();
            for (int i = 0; i < dgvSanPham.Columns.Count -1; i++)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dgvSanPham);
                row.Cells[0].Value = $"MSI Modern 14 C11M";
                row.Cells[1].Value = "10.000.000";
                row.Cells[2].Value = "23";

    
                row.Cells[3].Value = "4343782889";

                dgvSanPham.Rows.Add(row);
            }
           
            

  
        }


        private void LoadGioHang()
        {
            dgvGioHang.ColumnCount = 8;
            dgvGioHang.Columns[0].Name = "Tên khách hàng";
            dgvGioHang.Columns[1].Name = "Số điện thoại";
            dgvGioHang.Columns[2].Name = "Tên sản phẩm";
            dgvGioHang.Columns[3].Name = "Số serial";
            dgvGioHang.Columns[4].Name = "Số lượng";
            dgvGioHang.Columns[5].Name = "Giá tiền";
            dgvGioHang.Columns[5].DefaultCellStyle.Format = "N0";
            dgvGioHang.Columns[6].Name = "Giảm giá";
            dgvGioHang.Columns[6].DefaultCellStyle.Format = "N0";
            dgvGioHang.Columns[7].Name = "Thành tiền";
            dgvGioHang.Columns[7].DefaultCellStyle.Format = "N0";


            var row = new DataGridViewRow();
            row.CreateCells(dgvGioHang);
            row.Cells[0].Value = "Hiếu";
            row.Cells[1].Value = "0123456789";
            row.Cells[2].Value = "Laptop Laptop Dell Vostro 3530";
            row.Cells[3].Value = "1435466788";
            row.Cells[4].Value = "3";
            row.Cells[5].Value = "12.500.000";
            row.Cells[6].Value = "0";
            row.Cells[7].Value = "37.500.000";


            dgvGioHang.Rows.Add(row);



        }

        private void LoadChoThanhToan()
        {
            dgvChoThanhToan.ColumnCount = 8;
            dgvChoThanhToan.Columns[0].Name = "Tên khách hàng";
            dgvChoThanhToan.Columns[1].Name = "Số điện thoại";
            dgvChoThanhToan.Columns[2].Name = "Tên sản phẩm";
            dgvChoThanhToan.Columns[3].Name = "Số serial";
            dgvChoThanhToan.Columns[4].Name = "Số lượng";
            dgvChoThanhToan.Columns[5].Name = "Giá tiền";
            dgvChoThanhToan.Columns[5].DefaultCellStyle.Format = "N0";
            dgvChoThanhToan.Columns[6].Name = "Giảm giá";
            dgvChoThanhToan.Columns[6].DefaultCellStyle.Format = "N0";
            dgvChoThanhToan.Columns[7].Name = "Thành tiền";
            dgvChoThanhToan.Columns[7].DefaultCellStyle.Format = "N0";


            var row = new DataGridViewRow();
            row.CreateCells(dgvChoThanhToan);
            row.Cells[0].Value = "Vinh";
            row.Cells[1].Value = "0866899999";
            row.Cells[2].Value = "Laptop ASUS VIVO BOOK";
            row.Cells[3].Value = "43255435345351";
            row.Cells[4].Value = "1";
            row.Cells[5].Value = "7.500.000";
            row.Cells[6].Value = "0";
            row.Cells[7].Value = "7.500.000";


            dgvChoThanhToan.Rows.Add(row);



        }
    }
}
