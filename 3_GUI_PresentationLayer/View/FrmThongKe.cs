using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.Services;
using _2_BUS_BusinessLayer.ViewModel;

namespace _3_GUI_PresentationLayer.View
{

    public partial class FrmThongKe : Form
    {
        private ThongKeService _thongKeService;
        public FrmThongKe()
        {
            InitializeComponent();

            //dtpStartDate.Value = DateTime.Today.AddDays(-7);
            //dtpEndDate.Value = DateTime.Now;

            _thongKeService = new ThongKeService();

            LoadData();
        }

        private void LoadData()
        {
            dgvUnderStock.ColumnCount = 2;
            dgvUnderStock.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUnderStock.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvUnderStock.Columns[0].Name = "Hãng";
            dgvUnderStock.Columns[1].Name = "Dòng Laptop";
            #region
            /*var refresData = _thongKeService.LoadData(dtpStartDate.Value, dtpEndDate.Value);
            if (refresData == true)
            {
                chartTop5.DataSource = _thongKeService.TopProductList;
                chartTop5.Series[0].XValueMember = "Key";
                chartTop5.Series[0].YValueMembers = "Value";
                chartTop5.DataBind();

                chartDoanhThu.DataSource = _thongKeService.DoanhThuByDaysList;
                chartDoanhThu.Series[0].XValueMember = "Date";
                chartDoanhThu.Series[0].YValueMembers = "Doanh thu";
                chartDoanhThu.DataBind();

                dgvUnderStock.DataSource = _thongKeService.UnderStockList;
                dgvUnderStock.Columns[0].HeaderText = "Tên Laptop";
                dgvUnderStock.Columns[1].HeaderText = "Số lượng";

                lblNumHoaDons.Text = _thongKeService.NumHoaDons.ToString();
                lblTotalDoanhThu.Text = _thongKeService.TongDoanhThu.ToString("N0") + "CND";
                lblNumCustomers.Text = _thongKeService.NumCustomers.ToString();
                lblNumNhaCungCaps.Text = _thongKeService.NumNhaCungCaps.ToString();
                lblNumProducts.Text = _thongKeService.NumProducts.ToString();
            }*/
            #endregion
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            #region
            chartDoanhThu.Series["Số lượng máy bán ra"].Points.AddXY("Tháng 6", 11);
            chartDoanhThu.Series["Số lượng máy bán ra"].Points.AddXY("Tháng 7", 8);
            chartDoanhThu.Series["Số lượng máy bán ra"].Points.AddXY("Tháng 8", 30);
            chartDoanhThu.Series["Số lượng máy bán ra"].Points.AddXY("Tháng 9", 20);
            chartDoanhThu.Series["Số lượng máy bán ra"].Points.AddXY("Tháng 10", 16);
            chartDoanhThu.Series["Số lượng máy bán ra"].Points.AddXY("Tháng 11", 9);
            #endregion

            #region 
            Chart_Top5.Series["charttop5"].Points.AddXY("Dell", 35);
            Chart_Top5.Series["charttop5"].Points.AddXY("HP", 25);
            Chart_Top5.Series["charttop5"].Points.AddXY("Acer", 12);
            Chart_Top5.Series["charttop5"].Points.AddXY("ASUS", 18);
            Chart_Top5.Series["charttop5"].Points.AddXY("Lenovo", 10);
            #endregion  fake data

            #region
            dgvUnderStock.Rows.Add("                                      Dell", "                              Lenovo ThinkPad X1 Carbon");
            dgvUnderStock.Rows.Add("                                      Asus", "                              Asus VivoBook W202NA");
            dgvUnderStock.Rows.Add("                                      Acer", "                              Chromebook 11 N7");
            #endregion
        }
    }
}
