using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace _3_GUI_PresentationLayer.View
{
    public partial class FrmQuenMatKhau : Form
    {
        INhanVienService _BUS_NhanViens;
        List<NhanVien> _lst_NhanVienl;

        public FrmQuenMatKhau()
        {
            _BUS_NhanViens = new NhanvienService();
            _lst_NhanVienl = new List<NhanVien>();
            InitializeComponent();
            txt_Email.Select();
        }
        Random random = new Random();
        private int _randomCode;

        private void btnGuiEmail_Click(object sender, EventArgs e)
        {
            var employee = _BUS_NhanViens.GetAllNhanViens().Find(nv => nv.Email == txt_Email.Texts);

            if (employee == null)
            {
                MessageBox.Show("Email không tồn tại trong hệ thống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                _randomCode = new Random().Next(100000, 999999);
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("nguyenhieuhieu.1012@gmail.com");
                mail.To.Add(txt_Email.Texts);
                mail.Body = "Mã code của bạn là: " + _randomCode;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                NetworkCredential nc = new NetworkCredential();
                nc.UserName = "nguyenhieuhieu.1012@gmail.com";
                nc.Password = "opmi aqre tbnz bflo";
                smtp.Credentials = nc;
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.Send(mail);
                MessageBox.Show("Gửi thành công");
                txt_Email.Enabled = false;
            }
        }

        private void btnCheckMa_Click(object sender, EventArgs e)
        {
            if (txt_OTP.Texts == _randomCode.ToString())
            {
                txt_MK_New.Visible = true;
                txt_XacNhan_MK.Visible = true;

                MessageBox.Show("Mã xác nhận đúng");
                return;
            }


            MessageBox.Show("Sai mã xác nhận kiểm tra lại");

        }

        private void textBoxCustom2_03_Load(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txt_MK_New.Texts == txt_XacNhan_MK.Texts)
            {
                var x = _BUS_NhanViens.GetAllNhanViens().FirstOrDefault(e => e.Email == txt_Email.Texts);
                // var a = _BUS_NhanViens.GetAllNhanViens().FirstOrDefault(e => e.Id == x);
                x.MatKhau = txt_MK_New.Texts;
                _BUS_NhanViens.UpdateNV(x);
                MessageBox.Show("Đổi mật khẩu thành công!");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Không thành công vui lòng kiểm tra lại mật khẩu mới đã nhập");
            }
        }

        private void FrmQuenMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void FrmQuenMatKhau_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Hide();
            //FrmDangNhap frmdn = new FrmDangNhap();
            //frmdn.ShowDialog();
        }
    }
}
