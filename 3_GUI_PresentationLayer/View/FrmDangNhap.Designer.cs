namespace _3_GUI_PresentationLayer.View
{
    partial class FrmDangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtEmail = new CustomControl.TextBoxCustom2_0();
            txtMatKhau = new CustomControl.TextBoxCustom2_0();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            cb_nhoMatKhau = new CheckBox();
            lbQuenMatKhau = new LinkLabel();
            btnDangNhap = new CustomControl.ButtonCustom();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(204, 204, 204);
            txtEmail.BorderColor = Color.FromArgb(79, 175, 156);
            txtEmail.BorderFocusColor = Color.HotPink;
            txtEmail.BorderRadius = 0;
            txtEmail.BorderSize = 2;
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(77, 195);
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(42, 7, 7, 7);
            txtEmail.PasswordChar = false;
            txtEmail.PlaceholderColor = Color.DarkGray;
            txtEmail.PlaceholderText = "";
            txtEmail.Size = new Size(245, 36);
            txtEmail.TabIndex = 1;
            txtEmail.Texts = "";
            txtEmail.UnderlinedStyle = true;
            txtEmail.Load += txtEmail_Load;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BackColor = Color.FromArgb(204, 204, 204);
            txtMatKhau.BorderColor = Color.FromArgb(79, 175, 156);
            txtMatKhau.BorderFocusColor = Color.SlateBlue;
            txtMatKhau.BorderRadius = 0;
            txtMatKhau.BorderSize = 2;
            txtMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatKhau.Location = new Point(76, 263);
            txtMatKhau.Multiline = false;
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Padding = new Padding(42, 7, 7, 7);
            txtMatKhau.PasswordChar = false;
            txtMatKhau.PlaceholderColor = Color.DarkGray;
            txtMatKhau.PlaceholderText = "";
            txtMatKhau.Size = new Size(246, 36);
            txtMatKhau.TabIndex = 2;
            txtMatKhau.Texts = "";
            txtMatKhau.UnderlinedStyle = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(75, 192);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.pasword;
            pictureBox2.Location = new Point(74, 261);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // cb_nhoMatKhau
            // 
            cb_nhoMatKhau.AutoSize = true;
            cb_nhoMatKhau.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cb_nhoMatKhau.Location = new Point(61, 325);
            cb_nhoMatKhau.Name = "cb_nhoMatKhau";
            cb_nhoMatKhau.Size = new Size(109, 21);
            cb_nhoMatKhau.TabIndex = 3;
            cb_nhoMatKhau.Text = "Nhớ mật khẩu";
            cb_nhoMatKhau.UseVisualStyleBackColor = true;
            cb_nhoMatKhau.CheckedChanged += cb_nhoMatKhau_CheckedChanged;
            // 
            // lbQuenMatKhau
            // 
            lbQuenMatKhau.AutoSize = true;
            lbQuenMatKhau.DisabledLinkColor = Color.Black;
            lbQuenMatKhau.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbQuenMatKhau.ForeColor = Color.Coral;
            lbQuenMatKhau.LinkColor = Color.Crimson;
            lbQuenMatKhau.Location = new Point(243, 329);
            lbQuenMatKhau.Name = "lbQuenMatKhau";
            lbQuenMatKhau.Size = new Size(96, 17);
            lbQuenMatKhau.TabIndex = 4;
            lbQuenMatKhau.TabStop = true;
            lbQuenMatKhau.Text = "Quên mật khẩu";
            lbQuenMatKhau.LinkClicked += lbQuenMatKhau_LinkClicked;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.FromArgb(255, 192, 128);
            btnDangNhap.BackgroundColor = Color.FromArgb(255, 192, 128);
            btnDangNhap.BorderColor = Color.PaleVioletRed;
            btnDangNhap.BorderRadius = 10;
            btnDangNhap.BorderSize = 0;
            btnDangNhap.FlatAppearance.BorderSize = 0;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangNhap.ForeColor = Color.FromArgb(64, 0, 0);
            btnDangNhap.Location = new Point(122, 369);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(150, 40);
            btnDangNhap.TabIndex = 5;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.TextColor = Color.FromArgb(64, 0, 0);
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.airplane;
            pictureBox3.Location = new Point(142, 25);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(120, 119);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // FrmDangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(204, 204, 204);
            ClientSize = new Size(378, 432);
            Controls.Add(pictureBox3);
            Controls.Add(btnDangNhap);
            Controls.Add(lbQuenMatKhau);
            Controls.Add(cb_nhoMatKhau);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txtMatKhau);
            Controls.Add(txtEmail);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmDangNhap";
            Text = "FrmDangNhap";
            FormClosing += FrmDangNhap_FormClosing;
            Load += FrmDangNhap_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControl.TextBoxCustom2_0 txtEmail;
        private CustomControl.TextBoxCustom2_0 txtMatKhau;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private CheckBox cb_nhoMatKhau;
        private LinkLabel lbQuenMatKhau;
        private CustomControl.ButtonCustom btnDangNhap;
        private PictureBox pictureBox3;
    }
}