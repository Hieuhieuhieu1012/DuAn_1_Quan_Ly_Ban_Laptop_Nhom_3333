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
    public partial class FrmDangNhap : Form
    {
        INhanVienService _nhanVienServices;

        public FrmDangNhap()
        {
            _nhanVienServices = new NhanvienService();
            InitializeComponent();
            txtEmail.Select();
            txtMatKhau.PasswordChar = true;
            this.CenterToScreen();
        }

        private bool checkNhap()
        {
            if (txtEmail.Texts == "" || txtMatKhau.Texts == "") return true;
            return false;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (checkNhap())
            {
                MessageBox.Show("Không được bỏ trống tên đăng nhập hoặc mật khẩu");
                return;
            }
            else
            {
                foreach (var x in _nhanVienServices.GetAllNhanViens())
                {
                    if (x.Email.ToLower() == txtEmail.Texts.ToLower())
                    {
                        if (x.MatKhau == txtMatKhau.Texts)
                        {
                            MessageBox.Show("Đăng nhập thành công");
                            Hide();
                            SaveInfor();
                            Form home = new FrmMain();
                            home.Show();
                            this.Hide();
                            return;

                        }
                        MessageBox.Show("Mật khẩu chưa chính xác");
                        return;
                    }
                }
                MessageBox.Show("Tài khoản không chính xác");
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {

        }


        private void cb_nhoMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (txtEmail.Texts != "" && txtMatKhau.Texts != "")
            {
                if (cb_nhoMatKhau.Checked == true)
                {
                    string use = txtEmail.Texts;
                    string pass = txtMatKhau.Text;
                    Properties.Settings.Default._user = use;
                    Properties.Settings.Default._pass = pass;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Reset();
                }
            }
        }

        private void lbQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // this.Hide();
            FrmQuenMatKhau quenMatKhau = new FrmQuenMatKhau();
            quenMatKhau.ShowDialog();

        }
        public void SaveInfor()
        {
            if (cb_nhoMatKhau.Checked == true)
            {
                Properties.Settings.Default._user = txtEmail.Texts;
                Properties.Settings.Default._pass = txtMatKhau.Texts;
                Properties.Settings.Default._TKdaLogin = txtEmail.Texts;
                Properties.Settings.Default._MKdaLogin = txtMatKhau.Texts;
                Properties.Settings.Default._SaveInfo = true;
                Properties.Settings.Default.Save();

            }
            else
            {
                Properties.Settings.Default._user = "";
                Properties.Settings.Default._pass = "";
                Properties.Settings.Default._TKdaLogin = txtEmail.Texts;
                Properties.Settings.Default._MKdaLogin = txtMatKhau.Texts;
                Properties.Settings.Default._SaveInfo = false;
                Properties.Settings.Default.Save();

            }
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default._SaveInfo == true)
            {
                txtEmail.Texts = Properties.Settings.Default._user;
                txtMatKhau.Texts = Properties.Settings.Default._pass;
                cb_nhoMatKhau.Checked = true;

            }
            else
            {
                txtEmail.PlaceholderText = "Email";
                txtMatKhau.PlaceholderText = "Mật khẩu";
            }
        }

        private void txtEmail_Load(object sender, EventArgs e)
        {

        }

        private void FrmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }


}

