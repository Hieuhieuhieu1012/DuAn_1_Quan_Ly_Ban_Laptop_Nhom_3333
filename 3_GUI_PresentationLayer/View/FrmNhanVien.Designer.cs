namespace _3_GUI_PresentationLayer.View
{
    partial class FrmNhanVien
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
            dgv = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            panel5 = new Panel();
            rbtQuanLy = new CustomControl.RadioButtonCustom();
            rbtNhanVien = new CustomControl.RadioButtonCustom();
            panel4 = new Panel();
            rbtNam = new CustomControl.RadioButtonCustom();
            rbtNu = new CustomControl.RadioButtonCustom();
            txtDiaChi = new CustomControl.TextBoxCustom2_0();
            iconButtonXoa = new FontAwesome.Sharp.IconButton();
            iconButtonLoad = new FontAwesome.Sharp.IconButton();
            iconButtonThem = new FontAwesome.Sharp.IconButton();
            iconButtonSua = new FontAwesome.Sharp.IconButton();
            label5 = new Label();
            txtSoCanCuoc = new CustomControl.TextBoxCustom();
            label12 = new Label();
            txtEmail = new CustomControl.TextBoxCustom();
            label10 = new Label();
            txtHoTen = new CustomControl.TextBoxCustom();
            label11 = new Label();
            label8 = new Label();
            txtMatKhau = new CustomControl.TextBoxCustom();
            label7 = new Label();
            label6 = new Label();
            txtSoDienThoai = new CustomControl.TextBoxCustom();
            label4 = new Label();
            label3 = new Label();
            ptbAnh = new PictureBox();
            txtMaNhanVien = new CustomControl.TextBoxCustom();
            panel1 = new Panel();
            rbtDaNghiViec = new CustomControl.RadioButtonCustom();
            rbtDangLam = new CustomControl.RadioButtonCustom();
            iconButton8 = new FontAwesome.Sharp.IconButton();
            txtTimKiem = new CustomControl.TextBoxCustom2_0();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbAnh).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column11 });
            dgv.Location = new Point(12, 184);
            dgv.Name = "dgv";
            dgv.RowHeadersVisible = false;
            dgv.RowTemplate.Height = 25;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(753, 477);
            dgv.TabIndex = 3;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã nv";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Họ tên";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Sđt";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Email";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Số căn cước";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Giới tính";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Chức vụ";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Địa chỉ";
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.HeaderText = "Mật khẩu";
            Column9.Name = "Column9";
            // 
            // Column11
            // 
            Column11.HeaderText = "Id";
            Column11.Name = "Column11";
            Column11.Visible = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtMaNhanVien);
            panel2.Controls.Add(ptbAnh);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(txtDiaChi);
            panel2.Controls.Add(iconButtonXoa);
            panel2.Controls.Add(iconButtonLoad);
            panel2.Controls.Add(iconButtonThem);
            panel2.Controls.Add(iconButtonSua);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtSoCanCuoc);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txtHoTen);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtMatKhau);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtSoDienThoai);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(778, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(650, 631);
            panel2.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.Controls.Add(rbtQuanLy);
            panel5.Controls.Add(rbtNhanVien);
            panel5.Location = new Point(341, 382);
            panel5.Name = "panel5";
            panel5.Size = new Size(225, 42);
            panel5.TabIndex = 34;
            // 
            // rbtQuanLy
            // 
            rbtQuanLy.AutoSize = true;
            rbtQuanLy.CheckedColor = Color.MediumSlateBlue;
            rbtQuanLy.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbtQuanLy.ForeColor = SystemColors.Highlight;
            rbtQuanLy.Location = new Point(142, 12);
            rbtQuanLy.MinimumSize = new Size(0, 21);
            rbtQuanLy.Name = "rbtQuanLy";
            rbtQuanLy.Padding = new Padding(10, 0, 0, 0);
            rbtQuanLy.Size = new Size(84, 21);
            rbtQuanLy.TabIndex = 27;
            rbtQuanLy.TabStop = true;
            rbtQuanLy.Text = "Quản lý";
            rbtQuanLy.UnCheckedColor = Color.Gray;
            rbtQuanLy.UseVisualStyleBackColor = true;
            // 
            // rbtNhanVien
            // 
            rbtNhanVien.AutoSize = true;
            rbtNhanVien.CheckedColor = Color.MediumSlateBlue;
            rbtNhanVien.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbtNhanVien.ForeColor = SystemColors.Highlight;
            rbtNhanVien.Location = new Point(13, 12);
            rbtNhanVien.MinimumSize = new Size(0, 21);
            rbtNhanVien.Name = "rbtNhanVien";
            rbtNhanVien.Padding = new Padding(10, 0, 0, 0);
            rbtNhanVien.Size = new Size(99, 21);
            rbtNhanVien.TabIndex = 27;
            rbtNhanVien.TabStop = true;
            rbtNhanVien.Text = "Nhân viên";
            rbtNhanVien.UnCheckedColor = Color.Gray;
            rbtNhanVien.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(rbtNam);
            panel4.Controls.Add(rbtNu);
            panel4.Location = new Point(341, 238);
            panel4.Name = "panel4";
            panel4.Size = new Size(225, 42);
            panel4.TabIndex = 33;
            // 
            // rbtNam
            // 
            rbtNam.AutoSize = true;
            rbtNam.CheckedColor = Color.MediumSlateBlue;
            rbtNam.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbtNam.ForeColor = SystemColors.Highlight;
            rbtNam.Location = new Point(13, 11);
            rbtNam.MinimumSize = new Size(0, 21);
            rbtNam.Name = "rbtNam";
            rbtNam.Padding = new Padding(10, 0, 0, 0);
            rbtNam.Size = new Size(65, 21);
            rbtNam.TabIndex = 31;
            rbtNam.TabStop = true;
            rbtNam.Text = "Nam";
            rbtNam.UnCheckedColor = Color.Gray;
            rbtNam.UseVisualStyleBackColor = true;
            // 
            // rbtNu
            // 
            rbtNu.AutoSize = true;
            rbtNu.CheckedColor = Color.MediumSlateBlue;
            rbtNu.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbtNu.ForeColor = SystemColors.Highlight;
            rbtNu.Location = new Point(142, 11);
            rbtNu.MinimumSize = new Size(0, 21);
            rbtNu.Name = "rbtNu";
            rbtNu.Padding = new Padding(10, 0, 0, 0);
            rbtNu.Size = new Size(55, 21);
            rbtNu.TabIndex = 32;
            rbtNu.TabStop = true;
            rbtNu.Text = "Nữ";
            rbtNu.UnCheckedColor = Color.Gray;
            rbtNu.UseVisualStyleBackColor = true;
            // 
            // txtDiaChi
            // 
            txtDiaChi.BorderColor = Color.MediumSlateBlue;
            txtDiaChi.BorderFocusColor = Color.HotPink;
            txtDiaChi.BorderRadius = 10;
            txtDiaChi.BorderSize = 1;
            txtDiaChi.Location = new Point(341, 441);
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Padding = new Padding(7);
            txtDiaChi.PasswordChar = false;
            txtDiaChi.PlaceholderColor = Color.DarkGray;
            txtDiaChi.PlaceholderText = "";
            txtDiaChi.Size = new Size(225, 119);
            txtDiaChi.TabIndex = 30;
            txtDiaChi.Texts = "";
            txtDiaChi.UnderlinedStyle = false;
            // 
            // iconButtonXoa
            // 
            iconButtonXoa.BackColor = Color.White;
            iconButtonXoa.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
            iconButtonXoa.IconColor = Color.FromArgb(0, 0, 192);
            iconButtonXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonXoa.Location = new Point(37, 371);
            iconButtonXoa.Name = "iconButtonXoa";
            iconButtonXoa.Size = new Size(83, 53);
            iconButtonXoa.TabIndex = 25;
            iconButtonXoa.UseVisualStyleBackColor = false;
            // 
            // iconButtonLoad
            // 
            iconButtonLoad.BackColor = Color.White;
            iconButtonLoad.IconChar = FontAwesome.Sharp.IconChar.RotateBackward;
            iconButtonLoad.IconColor = Color.FromArgb(0, 0, 192);
            iconButtonLoad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonLoad.Location = new Point(37, 430);
            iconButtonLoad.Name = "iconButtonLoad";
            iconButtonLoad.Size = new Size(83, 53);
            iconButtonLoad.TabIndex = 24;
            iconButtonLoad.UseVisualStyleBackColor = false;
            // 
            // iconButtonThem
            // 
            iconButtonThem.BackColor = Color.White;
            iconButtonThem.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            iconButtonThem.IconColor = Color.FromArgb(0, 0, 192);
            iconButtonThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonThem.Location = new Point(37, 253);
            iconButtonThem.Name = "iconButtonThem";
            iconButtonThem.Size = new Size(83, 53);
            iconButtonThem.TabIndex = 22;
            iconButtonThem.UseVisualStyleBackColor = false;
            // 
            // iconButtonSua
            // 
            iconButtonSua.BackColor = Color.White;
            iconButtonSua.IconChar = FontAwesome.Sharp.IconChar.Pen;
            iconButtonSua.IconColor = Color.Blue;
            iconButtonSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonSua.Location = new Point(37, 312);
            iconButtonSua.Name = "iconButtonSua";
            iconButtonSua.Size = new Size(83, 53);
            iconButtonSua.TabIndex = 23;
            iconButtonSua.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(231, 299);
            label5.Name = "label5";
            label5.Size = new Size(81, 17);
            label5.TabIndex = 9;
            label5.Text = "Số căn cước";
            // 
            // txtSoCanCuoc
            // 
            txtSoCanCuoc.BorderColor = Color.MediumSlateBlue;
            txtSoCanCuoc.BorderFocusColor = Color.HotPink;
            txtSoCanCuoc.BorderSize = 2;
            txtSoCanCuoc.Location = new Point(341, 286);
            txtSoCanCuoc.Multiline = false;
            txtSoCanCuoc.Name = "txtSoCanCuoc";
            txtSoCanCuoc.Padding = new Padding(7);
            txtSoCanCuoc.PasswordChar = false;
            txtSoCanCuoc.Size = new Size(225, 30);
            txtSoCanCuoc.TabIndex = 8;
            txtSoCanCuoc.Texts = "";
            txtSoCanCuoc.UnderlinedStyle = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.Highlight;
            label12.Location = new Point(250, 253);
            label12.Name = "label12";
            label12.Size = new Size(62, 17);
            label12.TabIndex = 26;
            label12.Text = "Giới tính";
            // 
            // txtEmail
            // 
            txtEmail.BorderColor = Color.MediumSlateBlue;
            txtEmail.BorderFocusColor = Color.HotPink;
            txtEmail.BorderSize = 2;
            txtEmail.Location = new Point(341, 188);
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(7);
            txtEmail.PasswordChar = false;
            txtEmail.Size = new Size(225, 30);
            txtEmail.TabIndex = 20;
            txtEmail.Texts = "";
            txtEmail.UnderlinedStyle = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.Highlight;
            label10.Location = new Point(270, 202);
            label10.Name = "label10";
            label10.Size = new Size(42, 17);
            label10.TabIndex = 21;
            label10.Text = "Email";
            // 
            // txtHoTen
            // 
            txtHoTen.BorderColor = Color.MediumSlateBlue;
            txtHoTen.BorderFocusColor = Color.HotPink;
            txtHoTen.BorderSize = 2;
            txtHoTen.Location = new Point(341, 74);
            txtHoTen.Multiline = false;
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Padding = new Padding(7);
            txtHoTen.PasswordChar = false;
            txtHoTen.Size = new Size(225, 30);
            txtHoTen.TabIndex = 18;
            txtHoTen.Texts = "";
            txtHoTen.UnderlinedStyle = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.Highlight;
            label11.Location = new Point(260, 86);
            label11.Name = "label11";
            label11.Size = new Size(50, 17);
            label11.TabIndex = 19;
            label11.Text = "Họ tên";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Highlight;
            label8.Location = new Point(263, 395);
            label8.Name = "label8";
            label8.Size = new Size(49, 17);
            label8.TabIndex = 15;
            label8.Text = "Vai trò";
            // 
            // txtMatKhau
            // 
            txtMatKhau.BorderColor = Color.MediumSlateBlue;
            txtMatKhau.BorderFocusColor = Color.HotPink;
            txtMatKhau.BorderSize = 2;
            txtMatKhau.Location = new Point(341, 335);
            txtMatKhau.Multiline = false;
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Padding = new Padding(7);
            txtMatKhau.PasswordChar = false;
            txtMatKhau.Size = new Size(225, 30);
            txtMatKhau.TabIndex = 12;
            txtMatKhau.Texts = "";
            txtMatKhau.UnderlinedStyle = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(244, 349);
            label7.Name = "label7";
            label7.Size = new Size(66, 17);
            label7.TabIndex = 13;
            label7.Text = "Mật khẩu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(259, 441);
            label6.Name = "label6";
            label6.Size = new Size(53, 17);
            label6.TabIndex = 11;
            label6.Text = "Địa Chỉ";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.BorderColor = Color.MediumSlateBlue;
            txtSoDienThoai.BorderFocusColor = Color.HotPink;
            txtSoDienThoai.BorderSize = 2;
            txtSoDienThoai.Location = new Point(341, 132);
            txtSoDienThoai.Multiline = false;
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Padding = new Padding(7);
            txtSoDienThoai.PasswordChar = false;
            txtSoDienThoai.Size = new Size(225, 30);
            txtSoDienThoai.TabIndex = 6;
            txtSoDienThoai.Texts = "";
            txtSoDienThoai.UnderlinedStyle = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(217, 145);
            label4.Name = "label4";
            label4.Size = new Size(90, 17);
            label4.TabIndex = 7;
            label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(216, 31);
            label3.Name = "label3";
            label3.Size = new Size(92, 17);
            label3.TabIndex = 5;
            label3.Text = "Mã nhân viên";
            // 
            // ptbAnh
            // 
            ptbAnh.BackColor = Color.DarkGray;
            ptbAnh.BackgroundImageLayout = ImageLayout.None;
            ptbAnh.BorderStyle = BorderStyle.Fixed3D;
            ptbAnh.Location = new Point(20, 30);
            ptbAnh.Name = "ptbAnh";
            ptbAnh.Size = new Size(164, 170);
            ptbAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbAnh.TabIndex = 6;
            ptbAnh.TabStop = false;
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.BorderColor = Color.MediumSlateBlue;
            txtMaNhanVien.BorderFocusColor = Color.HotPink;
            txtMaNhanVien.BorderSize = 2;
            txtMaNhanVien.Location = new Point(341, 18);
            txtMaNhanVien.Multiline = false;
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Padding = new Padding(7);
            txtMaNhanVien.PasswordChar = false;
            txtMaNhanVien.Size = new Size(225, 30);
            txtMaNhanVien.TabIndex = 36;
            txtMaNhanVien.Texts = "";
            txtMaNhanVien.UnderlinedStyle = true;
            txtMaNhanVien.Load += txtMaNhanVien_Load;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(rbtDaNghiViec);
            panel1.Controls.Add(rbtDangLam);
            panel1.Controls.Add(iconButton8);
            panel1.Controls.Add(txtTimKiem);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(28, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(714, 86);
            panel1.TabIndex = 6;
            // 
            // rbtDaNghiViec
            // 
            rbtDaNghiViec.AutoSize = true;
            rbtDaNghiViec.CheckedColor = Color.MediumSlateBlue;
            rbtDaNghiViec.Location = new Point(444, 52);
            rbtDaNghiViec.MinimumSize = new Size(0, 21);
            rbtDaNghiViec.Name = "rbtDaNghiViec";
            rbtDaNghiViec.Padding = new Padding(10, 0, 0, 0);
            rbtDaNghiViec.Size = new Size(100, 21);
            rbtDaNghiViec.TabIndex = 52;
            rbtDaNghiViec.TabStop = true;
            rbtDaNghiViec.Text = "Đã nghỉ việc";
            rbtDaNghiViec.UnCheckedColor = Color.Gray;
            rbtDaNghiViec.UseVisualStyleBackColor = true;
            // 
            // rbtDangLam
            // 
            rbtDangLam.AutoSize = true;
            rbtDangLam.CheckedColor = Color.MediumSlateBlue;
            rbtDangLam.Location = new Point(328, 50);
            rbtDangLam.MinimumSize = new Size(0, 21);
            rbtDangLam.Name = "rbtDangLam";
            rbtDangLam.Padding = new Padding(10, 0, 0, 0);
            rbtDangLam.Size = new Size(86, 21);
            rbtDangLam.TabIndex = 52;
            rbtDangLam.TabStop = true;
            rbtDangLam.Text = "Đang làm";
            rbtDangLam.UnCheckedColor = Color.Gray;
            rbtDangLam.UseVisualStyleBackColor = true;
            // 
            // iconButton8
            // 
            iconButton8.FlatAppearance.BorderSize = 0;
            iconButton8.FlatStyle = FlatStyle.Flat;
            iconButton8.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconButton8.IconColor = Color.Black;
            iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton8.IconSize = 23;
            iconButton8.Location = new Point(30, 40);
            iconButton8.Name = "iconButton8";
            iconButton8.Size = new Size(32, 25);
            iconButton8.TabIndex = 51;
            iconButton8.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderColor = Color.Black;
            txtTimKiem.BorderFocusColor = Color.Black;
            txtTimKiem.BorderRadius = 10;
            txtTimKiem.BorderSize = 1;
            txtTimKiem.Location = new Point(24, 36);
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
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(389, 10);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 3;
            label2.Text = "Trạng Thái";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(15, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 2;
            label1.Text = "Tìm Kiếm";
            // 
            // FrmNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1440, 676);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(dgv);
            Name = "FrmNhanVien";
            Text = "FrmNhanVien";
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbAnh).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column11;
        private Panel panel2;
        private CustomControl.TextBoxCustom txtMaNhanVien;
        private PictureBox ptbAnh;
        private Panel panel5;
        private CustomControl.RadioButtonCustom rbtQuanLy;
        private CustomControl.RadioButtonCustom rbtNhanVien;
        private Panel panel4;
        private CustomControl.RadioButtonCustom rbtNam;
        private CustomControl.RadioButtonCustom rbtNu;
        private CustomControl.TextBoxCustom2_0 txtDiaChi;
        private FontAwesome.Sharp.IconButton iconButtonXoa;
        private FontAwesome.Sharp.IconButton iconButtonLoad;
        private FontAwesome.Sharp.IconButton iconButtonThem;
        private FontAwesome.Sharp.IconButton iconButtonSua;
        private Label label5;
        private CustomControl.TextBoxCustom txtSoCanCuoc;
        private Label label12;
        private CustomControl.TextBoxCustom txtEmail;
        private Label label10;
        private CustomControl.TextBoxCustom txtHoTen;
        private Label label11;
        private Label label8;
        private CustomControl.TextBoxCustom txtMatKhau;
        private Label label7;
        private Label label6;
        private CustomControl.TextBoxCustom txtSoDienThoai;
        private Label label4;
        private Label label3;
        private Panel panel1;
        private CustomControl.RadioButtonCustom rbtDaNghiViec;
        private CustomControl.RadioButtonCustom rbtDangLam;
        private FontAwesome.Sharp.IconButton iconButton8;
        private CustomControl.TextBoxCustom2_0 txtTimKiem;
        private Label label2;
        private Label label1;
    }
}