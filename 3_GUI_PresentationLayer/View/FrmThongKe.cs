using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            btnLast7Days.Select();
            _thongKeService = new ThongKeService();
            LoadData();
        }

        private void LoadData()
        {
            var refreshData = _thongKeService.LoadData(dtpStartDate.Value, dtpEndDate.Value);
            if (refreshData == true)
            {
                chartTop5.DataSource = _thongKeService.TopProductList;
                chartTop5.Series[0].XValueMember = "Key";
                chartTop5.Series[0].YValueMembers = "Value";
                chartTop5.DataBind();

                chartDoanhThu.DataSource = _thongKeService.DoanhThuByDaysList;
                chartDoanhThu.Series[0].XValueMember = "Date";
                chartDoanhThu.Series[0].YValueMembers = "DoanhThu";
                chartDoanhThu.DataBind();

                dgvUnderStock.DataSource = _thongKeService.UnderStockList;
                dgvUnderStock.Columns[0].HeaderText = "Tên laptop";
                dgvUnderStock.Columns[1].HeaderText = "Số lượng";

                lblNumHoaDons.Text = _thongKeService.NumHoaDons.ToString();
                lblTotalDoanhThu.Text = _thongKeService.TongDoanhThu.ToString("N0") + " VND";
                lblNumCustomers.Text = _thongKeService.NumCustomers.ToString();
                lblNumNhaCungCaps.Text = _thongKeService.NumNhaCungCaps.ToString();
                lblNumProducts.Text = _thongKeService.NumProducts.ToString();
            }


        }
        private void DisableCustomDate()
        {
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            btnOk.Visible = false;
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDate();
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDate();
        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDate();
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            dtpStartDate.Enabled = true;
            dtpEndDate.Enabled = true;
            btnOk.Visible = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
