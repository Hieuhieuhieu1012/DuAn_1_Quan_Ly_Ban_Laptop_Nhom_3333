namespace _3_GUI_PresentationLayer.View
{
    partial class FrmKhachHang
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
            dgvKhachHang = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            txtEmail = new CustomControl.TextBoxCustom();
            label2 = new Label();
            iconButtonClear = new FontAwesome.Sharp.IconButton();
            txtDiaChi = new CustomControl.TextBoxCustom2_0();
            iconButtonSua = new FontAwesome.Sharp.IconButton();
            iconButtonThem = new FontAwesome.Sharp.IconButton();
            rbtNu = new CustomControl.RadioButtonCustom();
            txtMa = new CustomControl.TextBoxCustom();
            rbtNam = new CustomControl.RadioButtonCustom();
            label3 = new Label();
            label12 = new Label();
            label4 = new Label();
            txtHoTen = new CustomControl.TextBoxCustom();
            label5 = new Label();
            txtSoDienThoai = new CustomControl.TextBoxCustom();
            label6 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            iconButton8 = new FontAwesome.Sharp.IconButton();
            txtTimKiem = new CustomControl.TextBoxCustom2_0();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column7, Column4, Column5, Column6 });
            dgvKhachHang.Location = new Point(3, 3);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowTemplate.Height = 25;
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachHang.Size = new Size(992, 494);
            dgvKhachHang.TabIndex = 8;
            dgvKhachHang.CellClick += dgvKhachHang_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã khách hàng";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Họ tên";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Số điện thoại";
            Column3.Name = "Column3";
            // 
            // Column7
            // 
            Column7.HeaderText = "Email";
            Column7.Name = "Column7";
            // 
            // Column4
            // 
            Column4.HeaderText = "Giới tính";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Địa chỉ";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Id";
            Column6.Name = "Column6";
            Column6.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(iconButtonClear);
            panel1.Controls.Add(txtDiaChi);
            panel1.Controls.Add(iconButtonSua);
            panel1.Controls.Add(iconButtonThem);
            panel1.Controls.Add(rbtNu);
            panel1.Controls.Add(txtMa);
            panel1.Controls.Add(rbtNam);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtHoTen);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtSoDienThoai);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(1063, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(421, 624);
            panel1.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BorderColor = Color.MediumSlateBlue;
            txtEmail.BorderFocusColor = Color.HotPink;
            txtEmail.BorderSize = 2;
            txtEmail.Location = new Point(154, 249);
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(7);
            txtEmail.PasswordChar = false;
            txtEmail.Size = new Size(229, 30);
            txtEmail.TabIndex = 55;
            txtEmail.Texts = "";
            txtEmail.UnderlinedStyle = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(76, 258);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 54;
            label2.Text = "Email";
            // 
            // iconButtonClear
            // 
            iconButtonClear.BackColor = Color.White;
            iconButtonClear.FlatAppearance.BorderSize = 0;
            iconButtonClear.FlatStyle = FlatStyle.Flat;
            iconButtonClear.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            iconButtonClear.IconColor = Color.Navy;
            iconButtonClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonClear.IconSize = 45;
            iconButtonClear.Location = new Point(262, 533);
            iconButtonClear.Name = "iconButtonClear";
            iconButtonClear.Size = new Size(97, 43);
            iconButtonClear.TabIndex = 53;
            iconButtonClear.UseVisualStyleBackColor = false;
            iconButtonClear.Click += iconButtonClear_Click;
            // 
            // txtDiaChi
            // 
            txtDiaChi.BorderColor = Color.MediumSlateBlue;
            txtDiaChi.BorderFocusColor = Color.HotPink;
            txtDiaChi.BorderRadius = 10;
            txtDiaChi.BorderSize = 1;
            txtDiaChi.Location = new Point(154, 407);
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Padding = new Padding(7);
            txtDiaChi.PasswordChar = false;
            txtDiaChi.PlaceholderColor = Color.DarkGray;
            txtDiaChi.PlaceholderText = "";
            txtDiaChi.Size = new Size(229, 85);
            txtDiaChi.TabIndex = 44;
            txtDiaChi.Texts = "";
            txtDiaChi.UnderlinedStyle = false;
            // 
            // iconButtonSua
            // 
            iconButtonSua.BackColor = Color.White;
            iconButtonSua.FlatAppearance.BorderSize = 0;
            iconButtonSua.FlatStyle = FlatStyle.Flat;
            iconButtonSua.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            iconButtonSua.IconColor = Color.Navy;
            iconButtonSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonSua.IconSize = 40;
            iconButtonSua.Location = new Point(142, 533);
            iconButtonSua.Name = "iconButtonSua";
            iconButtonSua.Size = new Size(97, 43);
            iconButtonSua.TabIndex = 43;
            iconButtonSua.UseVisualStyleBackColor = false;
            iconButtonSua.Click += iconButtonSua_Click;
            // 
            // iconButtonThem
            // 
            iconButtonThem.BackColor = Color.White;
            iconButtonThem.FlatAppearance.BorderSize = 0;
            iconButtonThem.FlatStyle = FlatStyle.Flat;
            iconButtonThem.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            iconButtonThem.IconColor = Color.Navy;
            iconButtonThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonThem.IconSize = 40;
            iconButtonThem.Location = new Point(18, 533);
            iconButtonThem.Name = "iconButtonThem";
            iconButtonThem.Size = new Size(97, 43);
            iconButtonThem.TabIndex = 42;
            iconButtonThem.UseVisualStyleBackColor = false;
            iconButtonThem.Click += iconButtonThem_Click;
            // 
            // rbtNu
            // 
            rbtNu.AutoSize = true;
            rbtNu.CheckedColor = Color.MediumSlateBlue;
            rbtNu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rbtNu.Location = new Point(308, 332);
            rbtNu.MinimumSize = new Size(0, 21);
            rbtNu.Name = "rbtNu";
            rbtNu.Padding = new Padding(10, 0, 0, 0);
            rbtNu.Size = new Size(62, 25);
            rbtNu.TabIndex = 41;
            rbtNu.TabStop = true;
            rbtNu.Text = "Nữ";
            rbtNu.UnCheckedColor = Color.Gray;
            rbtNu.UseVisualStyleBackColor = true;
            // 
            // txtMa
            // 
            txtMa.BackColor = Color.White;
            txtMa.BorderColor = Color.MediumSlateBlue;
            txtMa.BorderFocusColor = Color.HotPink;
            txtMa.BorderSize = 2;
            txtMa.Location = new Point(154, 25);
            txtMa.Multiline = false;
            txtMa.Name = "txtMa";
            txtMa.Padding = new Padding(7);
            txtMa.PasswordChar = false;
            txtMa.Size = new Size(229, 30);
            txtMa.TabIndex = 29;
            txtMa.Texts = "";
            txtMa.UnderlinedStyle = true;
            // 
            // rbtNam
            // 
            rbtNam.AutoSize = true;
            rbtNam.CheckedColor = Color.MediumSlateBlue;
            rbtNam.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rbtNam.Location = new Point(164, 332);
            rbtNam.MinimumSize = new Size(0, 21);
            rbtNam.Name = "rbtNam";
            rbtNam.Padding = new Padding(10, 0, 0, 0);
            rbtNam.Size = new Size(75, 25);
            rbtNam.TabIndex = 40;
            rbtNam.TabStop = true;
            rbtNam.Text = "Nam";
            rbtNam.UnCheckedColor = Color.Gray;
            rbtNam.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(3, 34);
            label3.Name = "label3";
            label3.Size = new Size(127, 21);
            label3.TabIndex = 30;
            label3.Text = "Mã khách hàng";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.Highlight;
            label12.Location = new Point(53, 334);
            label12.Name = "label12";
            label12.Size = new Size(76, 21);
            label12.TabIndex = 39;
            label12.Text = "Giới tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(68, 108);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 32;
            label4.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            txtHoTen.BackColor = Color.White;
            txtHoTen.BorderColor = Color.MediumSlateBlue;
            txtHoTen.BorderFocusColor = Color.HotPink;
            txtHoTen.BorderSize = 2;
            txtHoTen.Location = new Point(154, 99);
            txtHoTen.Multiline = false;
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Padding = new Padding(7);
            txtHoTen.PasswordChar = false;
            txtHoTen.Size = new Size(229, 30);
            txtHoTen.TabIndex = 31;
            txtHoTen.Texts = "";
            txtHoTen.UnderlinedStyle = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(18, 182);
            label5.Name = "label5";
            label5.Size = new Size(111, 21);
            label5.TabIndex = 34;
            label5.Text = "Số điện thoại";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.BackColor = Color.White;
            txtSoDienThoai.BorderColor = Color.MediumSlateBlue;
            txtSoDienThoai.BorderFocusColor = Color.HotPink;
            txtSoDienThoai.BorderSize = 2;
            txtSoDienThoai.Location = new Point(154, 173);
            txtSoDienThoai.Multiline = false;
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Padding = new Padding(7);
            txtSoDienThoai.PasswordChar = false;
            txtSoDienThoai.Size = new Size(229, 30);
            txtSoDienThoai.TabIndex = 33;
            txtSoDienThoai.Texts = "";
            txtSoDienThoai.UnderlinedStyle = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(64, 407);
            label6.Name = "label6";
            label6.Size = new Size(65, 21);
            label6.TabIndex = 36;
            label6.Text = "Địa Chỉ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dgvKhachHang);
            panel2.Location = new Point(26, 146);
            panel2.Name = "panel2";
            panel2.Size = new Size(998, 500);
            panel2.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.Controls.Add(iconButton8);
            panel3.Controls.Add(txtTimKiem);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(38, 56);
            panel3.Name = "panel3";
            panel3.Size = new Size(287, 87);
            panel3.TabIndex = 11;
            // 
            // iconButton8
            // 
            iconButton8.FlatAppearance.BorderSize = 0;
            iconButton8.FlatStyle = FlatStyle.Flat;
            iconButton8.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconButton8.IconColor = Color.Black;
            iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton8.IconSize = 23;
            iconButton8.Location = new Point(21, 44);
            iconButton8.Name = "iconButton8";
            iconButton8.Size = new Size(32, 25);
            iconButton8.TabIndex = 51;
            iconButton8.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderColor = Color.MediumSlateBlue;
            txtTimKiem.BorderFocusColor = Color.HotPink;
            txtTimKiem.BorderRadius = 10;
            txtTimKiem.BorderSize = 1;
            txtTimKiem.Location = new Point(15, 40);
            txtTimKiem.Multiline = false;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Padding = new Padding(42, 7, 7, 7);
            txtTimKiem.PasswordChar = false;
            txtTimKiem.PlaceholderColor = Color.DarkGray;
            txtTimKiem.PlaceholderText = "Tìm kiếm";
            txtTimKiem.Size = new Size(250, 30);
            txtTimKiem.TabIndex = 50;
            txtTimKiem.Texts = "";
            txtTimKiem.UnderlinedStyle = false;
            txtTimKiem._TextChanged += txtTimKiem__TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(3, 2);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 32;
            label1.Text = "Tìm kiếm";
            // 
            // FrmKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 245, 255);
            ClientSize = new Size(1521, 690);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmKhachHang";
            Text = "Khách hàng";
            Load += FrmKhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvKhachHang;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButtonSua;
        private FontAwesome.Sharp.IconButton iconButtonThem;
        private CustomControl.RadioButtonCustom rbtNu;
        private CustomControl.TextBoxCustom txtMa;
        private CustomControl.RadioButtonCustom rbtNam;
        private Label label3;
        private Label label12;
        private Label label4;
        private CustomControl.TextBoxCustom txtHoTen;
        private Label label5;
        private CustomControl.TextBoxCustom txtSoDienThoai;
        private Label label6;
        private Panel panel2;
        private CustomControl.TextBoxCustom2_0 txtDiaChi;
        private Panel panel3;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton8;
        private CustomControl.TextBoxCustom2_0 txtTimKiem;
        private FontAwesome.Sharp.IconButton iconButtonClear;
        private CustomControl.TextBoxCustom txtEmail;
        private Label label2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}