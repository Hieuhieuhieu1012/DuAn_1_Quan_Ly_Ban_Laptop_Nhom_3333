namespace _3_GUI_PresentationLayer.View
{
    partial class FrmThemNhanhKH
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
            btClear = new CustomControl.ButtonCustom();
            btThem = new CustomControl.ButtonCustom();
            rbtNu = new CustomControl.RadioButtonCustom();
            label5 = new Label();
            rbtNam = new CustomControl.RadioButtonCustom();
            txtDiaChi = new CustomControl.TextBoxCustom2_0();
            label4 = new Label();
            txtEmail = new CustomControl.TextBoxCustom2_0();
            label3 = new Label();
            txtSoDienThoai = new CustomControl.TextBoxCustom2_0();
            label2 = new Label();
            txtHoTen = new CustomControl.TextBoxCustom2_0();
            label1 = new Label();
            SuspendLayout();
            // 
            // btClear
            // 
            btClear.BackColor = Color.MediumSlateBlue;
            btClear.BackgroundColor = Color.MediumSlateBlue;
            btClear.BorderColor = Color.PaleVioletRed;
            btClear.BorderRadius = 10;
            btClear.BorderSize = 0;
            btClear.FlatAppearance.BorderSize = 0;
            btClear.FlatStyle = FlatStyle.Flat;
            btClear.ForeColor = Color.White;
            btClear.Location = new Point(241, 350);
            btClear.Name = "btClear";
            btClear.Size = new Size(150, 35);
            btClear.TabIndex = 25;
            btClear.Text = "Làm mới";
            btClear.TextColor = Color.White;
            btClear.UseVisualStyleBackColor = false;
            // 
            // btThem
            // 
            btThem.BackColor = Color.MediumSlateBlue;
            btThem.BackgroundColor = Color.MediumSlateBlue;
            btThem.BorderColor = Color.PaleVioletRed;
            btThem.BorderRadius = 10;
            btThem.BorderSize = 0;
            btThem.FlatAppearance.BorderSize = 0;
            btThem.FlatStyle = FlatStyle.Flat;
            btThem.ForeColor = Color.White;
            btThem.Location = new Point(32, 350);
            btThem.Name = "btThem";
            btThem.Size = new Size(150, 35);
            btThem.TabIndex = 24;
            btThem.Text = "Thêm";
            btThem.TextColor = Color.White;
            btThem.UseVisualStyleBackColor = false;
            btThem.Click += btThem_Click_1;
            // 
            // rbtNu
            // 
            rbtNu.AutoSize = true;
            rbtNu.CheckedColor = Color.MediumSlateBlue;
            rbtNu.Location = new Point(305, 154);
            rbtNu.MinimumSize = new Size(0, 21);
            rbtNu.Name = "rbtNu";
            rbtNu.Padding = new Padding(10, 0, 0, 0);
            rbtNu.Size = new Size(51, 21);
            rbtNu.TabIndex = 23;
            rbtNu.TabStop = true;
            rbtNu.Text = "Nữ";
            rbtNu.UnCheckedColor = Color.Gray;
            rbtNu.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(42, 154);
            label5.Name = "label5";
            label5.Size = new Size(59, 17);
            label5.TabIndex = 22;
            label5.Text = "Giới tính";
            // 
            // rbtNam
            // 
            rbtNam.AutoSize = true;
            rbtNam.CheckedColor = Color.MediumSlateBlue;
            rbtNam.Location = new Point(163, 154);
            rbtNam.MinimumSize = new Size(0, 21);
            rbtNam.Name = "rbtNam";
            rbtNam.Padding = new Padding(10, 0, 0, 0);
            rbtNam.Size = new Size(61, 21);
            rbtNam.TabIndex = 21;
            rbtNam.TabStop = true;
            rbtNam.Text = "Nam";
            rbtNam.UnCheckedColor = Color.Gray;
            rbtNam.UseVisualStyleBackColor = true;
            // 
            // txtDiaChi
            // 
            txtDiaChi.BackColor = SystemColors.Control;
            txtDiaChi.BorderColor = Color.MediumSlateBlue;
            txtDiaChi.BorderFocusColor = Color.HotPink;
            txtDiaChi.BorderRadius = 0;
            txtDiaChi.BorderSize = 1;
            txtDiaChi.Location = new Point(145, 267);
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Padding = new Padding(7);
            txtDiaChi.PasswordChar = false;
            txtDiaChi.PlaceholderColor = Color.DarkGray;
            txtDiaChi.PlaceholderText = "";
            txtDiaChi.Size = new Size(228, 61);
            txtDiaChi.TabIndex = 20;
            txtDiaChi.Texts = "";
            txtDiaChi.UnderlinedStyle = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(53, 267);
            label4.Name = "label4";
            label4.Size = new Size(48, 17);
            label4.TabIndex = 19;
            label4.Text = "Địa chỉ";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.Control;
            txtEmail.BorderColor = Color.MediumSlateBlue;
            txtEmail.BorderFocusColor = Color.HotPink;
            txtEmail.BorderRadius = 0;
            txtEmail.BorderSize = 2;
            txtEmail.Location = new Point(145, 195);
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(7);
            txtEmail.PasswordChar = false;
            txtEmail.PlaceholderColor = Color.DarkGray;
            txtEmail.PlaceholderText = "";
            txtEmail.Size = new Size(228, 30);
            txtEmail.TabIndex = 18;
            txtEmail.Texts = "";
            txtEmail.UnderlinedStyle = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(61, 208);
            label3.Name = "label3";
            label3.Size = new Size(40, 17);
            label3.TabIndex = 17;
            label3.Text = "Email";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.BackColor = SystemColors.Control;
            txtSoDienThoai.BorderColor = Color.MediumSlateBlue;
            txtSoDienThoai.BorderFocusColor = Color.HotPink;
            txtSoDienThoai.BorderRadius = 0;
            txtSoDienThoai.BorderSize = 2;
            txtSoDienThoai.Location = new Point(145, 82);
            txtSoDienThoai.Multiline = false;
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Padding = new Padding(7);
            txtSoDienThoai.PasswordChar = false;
            txtSoDienThoai.PlaceholderColor = Color.DarkGray;
            txtSoDienThoai.PlaceholderText = "";
            txtSoDienThoai.Size = new Size(228, 30);
            txtSoDienThoai.TabIndex = 16;
            txtSoDienThoai.Texts = "";
            txtSoDienThoai.UnderlinedStyle = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(13, 95);
            label2.Name = "label2";
            label2.Size = new Size(88, 17);
            label2.TabIndex = 15;
            label2.Text = "Số điện thoại";
            // 
            // txtHoTen
            // 
            txtHoTen.BackColor = SystemColors.Control;
            txtHoTen.BorderColor = Color.MediumSlateBlue;
            txtHoTen.BorderFocusColor = Color.HotPink;
            txtHoTen.BorderRadius = 0;
            txtHoTen.BorderSize = 2;
            txtHoTen.Location = new Point(145, 23);
            txtHoTen.Multiline = false;
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Padding = new Padding(7);
            txtHoTen.PasswordChar = false;
            txtHoTen.PlaceholderColor = Color.DarkGray;
            txtHoTen.PlaceholderText = "";
            txtHoTen.Size = new Size(228, 30);
            txtHoTen.TabIndex = 14;
            txtHoTen.Texts = "";
            txtHoTen.UnderlinedStyle = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(51, 36);
            label1.Name = "label1";
            label1.Size = new Size(50, 17);
            label1.TabIndex = 13;
            label1.Text = "Họ tên";
            // 
            // FrmThemNhanhKH
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 450);
            Controls.Add(btClear);
            Controls.Add(btThem);
            Controls.Add(rbtNu);
            Controls.Add(label5);
            Controls.Add(rbtNam);
            Controls.Add(txtDiaChi);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtSoDienThoai);
            Controls.Add(label2);
            Controls.Add(txtHoTen);
            Controls.Add(label1);
            Name = "FrmThemNhanhKH";
            Text = "FrmThemNhanhKH";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControl.ButtonCustom btClear;
        private CustomControl.ButtonCustom btThem;
        private CustomControl.RadioButtonCustom rbtNu;
        private Label label5;
        private CustomControl.RadioButtonCustom rbtNam;
        private CustomControl.TextBoxCustom2_0 txtDiaChi;
        private Label label4;
        private CustomControl.TextBoxCustom2_0 txtEmail;
        private Label label3;
        private CustomControl.TextBoxCustom2_0 txtSoDienThoai;
        private Label label2;
        private CustomControl.TextBoxCustom2_0 txtHoTen;
        private Label label1;
    }
}