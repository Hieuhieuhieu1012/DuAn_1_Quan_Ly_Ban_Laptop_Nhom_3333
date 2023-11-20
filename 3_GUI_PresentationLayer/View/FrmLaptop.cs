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
    public partial class FrmLaptop : Form
    {
        public FrmLaptop()
        {
            InitializeComponent();
        }

        private void btnHangSanXuat_Click(object sender, EventArgs e)
        {
            FrmHangLapTop frmHangLapTop = new FrmHangLapTop();
            frmHangLapTop.ShowDialog();
        }

        private void btnDongLaptop_Click(object sender, EventArgs e)
        {
            FrmDongLaptop frmDongLaptop = new FrmDongLaptop();
            frmDongLaptop.ShowDialog();
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            FrmNCC frmNCC = new FrmNCC();
            frmNCC.ShowDialog();
        }

        private void btnCpu_Click(object sender, EventArgs e)
        {
            FrmCpu frmCpu = new FrmCpu();
            frmCpu.ShowDialog();
        }

        private void btnVga_Click(object sender, EventArgs e)
        {
           
        }
    }
}
