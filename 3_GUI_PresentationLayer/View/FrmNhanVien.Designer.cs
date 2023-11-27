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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtDaNghiViec = new _3_GUI_PresentationLayer.CustomControl.RadioButtonCustom();
            this.rbtDangLam = new _3_GUI_PresentationLayer.CustomControl.RadioButtonCustom();
            this.iconButton8 = new FontAwesome.Sharp.IconButton();
            this.txtTimKiem = new _3_GUI_PresentationLayer.CustomControl.TextBoxCustom2_0();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rbtQuanLy = new _3_GUI_PresentationLayer.CustomControl.RadioButtonCustom();
            this.rbtNhanVien = new _3_GUI_PresentationLayer.CustomControl.RadioButtonCustom();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbtNam = new _3_GUI_PresentationLayer.CustomControl.RadioButtonCustom();
            this.rbtNu = new _3_GUI_PresentationLayer.CustomControl.RadioButtonCustom();
            this.txtDiaChi = new _3_GUI_PresentationLayer.CustomControl.TextBoxCustom2_0();
            this.ptbAnh = new _3_GUI_PresentationLayer.CustomControl.PictrueBoxCustom();
            this.iconButtonXoa = new FontAwesome.Sharp.IconButton();
            this.iconButtonLoad = new FontAwesome.Sharp.IconButton();
            this.iconButtonThem = new FontAwesome.Sharp.IconButton();
            this.iconButtonSua = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoCanCuoc = new _3_GUI_PresentationLayer.CustomControl.TextBoxCustom();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEmail = new _3_GUI_PresentationLayer.CustomControl.TextBoxCustom();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHoTen = new _3_GUI_PresentationLayer.CustomControl.TextBoxCustom();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMatKhau = new _3_GUI_PresentationLayer.CustomControl.TextBoxCustom();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new _3_GUI_PresentationLayer.CustomControl.TextBoxCustom();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new _3_GUI_PresentationLayer.CustomControl.TextBoxCustom();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnh)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.rbtDaNghiViec);
            this.panel1.Controls.Add(this.rbtDangLam);
            this.panel1.Controls.Add(this.iconButton8);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 78);
            this.panel1.TabIndex = 1;
            // 
            // rbtDaNghiViec
            // 
            this.rbtDaNghiViec.AutoSize = true;
            this.rbtDaNghiViec.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rbtDaNghiViec.Location = new System.Drawing.Point(573, 42);
            this.rbtDaNghiViec.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtDaNghiViec.Name = "rbtDaNghiViec";
            this.rbtDaNghiViec.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtDaNghiViec.Size = new System.Drawing.Size(100, 21);
            this.rbtDaNghiViec.TabIndex = 52;
            this.rbtDaNghiViec.TabStop = true;
            this.rbtDaNghiViec.Text = "Đã nghỉ việc";
            this.rbtDaNghiViec.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtDaNghiViec.UseVisualStyleBackColor = true;
            this.rbtDaNghiViec.Click += new System.EventHandler(this.rbtDaNghiViec_Click);
            // 
            // rbtDangLam
            // 
            this.rbtDangLam.AutoSize = true;
            this.rbtDangLam.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rbtDangLam.Location = new System.Drawing.Point(457, 40);
            this.rbtDangLam.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtDangLam.Name = "rbtDangLam";
            this.rbtDangLam.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtDangLam.Size = new System.Drawing.Size(86, 21);
            this.rbtDangLam.TabIndex = 52;
            this.rbtDangLam.TabStop = true;
            this.rbtDangLam.Text = "Đang làm";
            this.rbtDangLam.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtDangLam.UseVisualStyleBackColor = true;
            this.rbtDangLam.Click += new System.EventHandler(this.rbtDangLam_Click);
            // 
            // iconButton8
            // 
            this.iconButton8.FlatAppearance.BorderSize = 0;
            this.iconButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton8.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton8.IconColor = System.Drawing.Color.Black;
            this.iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton8.IconSize = 23;
            this.iconButton8.Location = new System.Drawing.Point(30, 40);
            this.iconButton8.Name = "iconButton8";
            this.iconButton8.Size = new System.Drawing.Size(32, 25);
            this.iconButton8.TabIndex = 51;
            this.iconButton8.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTimKiem.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTimKiem.BorderRadius = 10;
            this.txtTimKiem.BorderSize = 1;
            this.txtTimKiem.Location = new System.Drawing.Point(24, 36);
            this.txtTimKiem.Multiline = false;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Padding = new System.Windows.Forms.Padding(42, 7, 7, 7);
            this.txtTimKiem.PasswordChar = false;
            this.txtTimKiem.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTimKiem.PlaceholderText = "Tìm kiếm";
            this.txtTimKiem.Size = new System.Drawing.Size(250, 30);
            this.txtTimKiem.TabIndex = 50;
            this.txtTimKiem.Texts = "";
            this.txtTimKiem.UnderlinedStyle = false;
            this.txtTimKiem._TextChanged += new System.EventHandler(this.txtTimKiem__TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(485, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Trạng Thái";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(15, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tìm Kiếm";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column11});
            this.dgv.Location = new System.Drawing.Point(3, 3);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 25;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(854, 477);
            this.dgv.TabIndex = 2;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã nv";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Họ tên";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Sđt";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Email";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Số căn cước";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Giới tính";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Chức vụ";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Địa chỉ";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Mật khẩu";
            this.Column9.Name = "Column9";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Id";
            this.Column11.Name = "Column11";
            this.Column11.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.txtDiaChi);
            this.panel2.Controls.Add(this.ptbAnh);
            this.panel2.Controls.Add(this.iconButtonXoa);
            this.panel2.Controls.Add(this.iconButtonLoad);
            this.panel2.Controls.Add(this.iconButtonThem);
            this.panel2.Controls.Add(this.iconButtonSua);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtSoCanCuoc);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtHoTen);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtMatKhau);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtSoDienThoai);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtMaNhanVien);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(904, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 582);
            this.panel2.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.rbtQuanLy);
            this.panel5.Controls.Add(this.rbtNhanVien);
            this.panel5.Location = new System.Drawing.Point(341, 382);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(232, 42);
            this.panel5.TabIndex = 34;
            // 
            // rbtQuanLy
            // 
            this.rbtQuanLy.AutoSize = true;
            this.rbtQuanLy.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rbtQuanLy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtQuanLy.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rbtQuanLy.Location = new System.Drawing.Point(142, 12);
            this.rbtQuanLy.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtQuanLy.Name = "rbtQuanLy";
            this.rbtQuanLy.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtQuanLy.Size = new System.Drawing.Size(84, 21);
            this.rbtQuanLy.TabIndex = 27;
            this.rbtQuanLy.TabStop = true;
            this.rbtQuanLy.Text = "Quản lý";
            this.rbtQuanLy.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtQuanLy.UseVisualStyleBackColor = true;
            // 
            // rbtNhanVien
            // 
            this.rbtNhanVien.AutoSize = true;
            this.rbtNhanVien.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rbtNhanVien.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtNhanVien.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rbtNhanVien.Location = new System.Drawing.Point(13, 12);
            this.rbtNhanVien.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtNhanVien.Name = "rbtNhanVien";
            this.rbtNhanVien.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtNhanVien.Size = new System.Drawing.Size(99, 21);
            this.rbtNhanVien.TabIndex = 27;
            this.rbtNhanVien.TabStop = true;
            this.rbtNhanVien.Text = "Nhân viên";
            this.rbtNhanVien.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtNhanVien.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rbtNam);
            this.panel4.Controls.Add(this.rbtNu);
            this.panel4.Location = new System.Drawing.Point(341, 238);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(232, 42);
            this.panel4.TabIndex = 33;
            // 
            // rbtNam
            // 
            this.rbtNam.AutoSize = true;
            this.rbtNam.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rbtNam.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtNam.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rbtNam.Location = new System.Drawing.Point(13, 11);
            this.rbtNam.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtNam.Name = "rbtNam";
            this.rbtNam.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtNam.Size = new System.Drawing.Size(65, 21);
            this.rbtNam.TabIndex = 31;
            this.rbtNam.TabStop = true;
            this.rbtNam.Text = "Nam";
            this.rbtNam.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtNam.UseVisualStyleBackColor = true;
            // 
            // rbtNu
            // 
            this.rbtNu.AutoSize = true;
            this.rbtNu.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rbtNu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtNu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rbtNu.Location = new System.Drawing.Point(142, 11);
            this.rbtNu.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtNu.Name = "rbtNu";
            this.rbtNu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtNu.Size = new System.Drawing.Size(55, 21);
            this.rbtNu.TabIndex = 32;
            this.rbtNu.TabStop = true;
            this.rbtNu.Text = "Nữ";
            this.rbtNu.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtNu.UseVisualStyleBackColor = true;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDiaChi.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDiaChi.BorderRadius = 10;
            this.txtDiaChi.BorderSize = 1;
            this.txtDiaChi.Location = new System.Drawing.Point(341, 441);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Padding = new System.Windows.Forms.Padding(7);
            this.txtDiaChi.PasswordChar = false;
            this.txtDiaChi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDiaChi.PlaceholderText = "";
            this.txtDiaChi.Size = new System.Drawing.Size(232, 119);
            this.txtDiaChi.TabIndex = 30;
            this.txtDiaChi.Texts = "";
            this.txtDiaChi.UnderlinedStyle = false;
            // 
            // ptbAnh
            // 
            this.ptbAnh.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.ptbAnh.BorderColor = System.Drawing.Color.RoyalBlue;
            this.ptbAnh.BorderColor2 = System.Drawing.Color.HotPink;
            this.ptbAnh.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.ptbAnh.BorderSize = 2;
            this.ptbAnh.GradientAngle = 50F;
            this.ptbAnh.Location = new System.Drawing.Point(18, 35);
            this.ptbAnh.Name = "ptbAnh";
            this.ptbAnh.Size = new System.Drawing.Size(171, 171);
            this.ptbAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAnh.TabIndex = 29;
            this.ptbAnh.TabStop = false;
            this.ptbAnh.Click += new System.EventHandler(this.ptbAnh_Click);
            // 
            // iconButtonXoa
            // 
            this.iconButtonXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.iconButtonXoa.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
            this.iconButtonXoa.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(82)))), ((int)(((byte)(31)))));
            this.iconButtonXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonXoa.Location = new System.Drawing.Point(37, 371);
            this.iconButtonXoa.Name = "iconButtonXoa";
            this.iconButtonXoa.Size = new System.Drawing.Size(83, 53);
            this.iconButtonXoa.TabIndex = 25;
            this.iconButtonXoa.UseVisualStyleBackColor = false;
            this.iconButtonXoa.Click += new System.EventHandler(this.iconButtonXoa_Click);
            // 
            // iconButtonLoad
            // 
            this.iconButtonLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.iconButtonLoad.IconChar = FontAwesome.Sharp.IconChar.RotateBackward;
            this.iconButtonLoad.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(82)))), ((int)(((byte)(31)))));
            this.iconButtonLoad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonLoad.Location = new System.Drawing.Point(37, 430);
            this.iconButtonLoad.Name = "iconButtonLoad";
            this.iconButtonLoad.Size = new System.Drawing.Size(83, 53);
            this.iconButtonLoad.TabIndex = 24;
            this.iconButtonLoad.UseVisualStyleBackColor = false;
            this.iconButtonLoad.Click += new System.EventHandler(this.iconButtonLoad_Click);
            // 
            // iconButtonThem
            // 
            this.iconButtonThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.iconButtonThem.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.iconButtonThem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(82)))), ((int)(((byte)(31)))));
            this.iconButtonThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonThem.Location = new System.Drawing.Point(37, 253);
            this.iconButtonThem.Name = "iconButtonThem";
            this.iconButtonThem.Size = new System.Drawing.Size(83, 53);
            this.iconButtonThem.TabIndex = 22;
            this.iconButtonThem.UseVisualStyleBackColor = false;
            this.iconButtonThem.Click += new System.EventHandler(this.iconButtonThem_Click);
            // 
            // iconButtonSua
            // 
            this.iconButtonSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.iconButtonSua.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iconButtonSua.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(82)))), ((int)(((byte)(31)))));
            this.iconButtonSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSua.Location = new System.Drawing.Point(37, 312);
            this.iconButtonSua.Name = "iconButtonSua";
            this.iconButtonSua.Size = new System.Drawing.Size(83, 53);
            this.iconButtonSua.TabIndex = 23;
            this.iconButtonSua.UseVisualStyleBackColor = false;
            this.iconButtonSua.Click += new System.EventHandler(this.iconButtonSua_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(231, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số căn cước";
            // 
            // txtSoCanCuoc
            // 
            this.txtSoCanCuoc.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSoCanCuoc.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSoCanCuoc.BorderSize = 2;
            this.txtSoCanCuoc.Location = new System.Drawing.Point(341, 286);
            this.txtSoCanCuoc.Multiline = false;
            this.txtSoCanCuoc.Name = "txtSoCanCuoc";
            this.txtSoCanCuoc.Padding = new System.Windows.Forms.Padding(7);
            this.txtSoCanCuoc.PasswordChar = false;
            this.txtSoCanCuoc.Size = new System.Drawing.Size(232, 30);
            this.txtSoCanCuoc.TabIndex = 8;
            this.txtSoCanCuoc.Texts = "";
            this.txtSoCanCuoc.UnderlinedStyle = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label12.Location = new System.Drawing.Point(250, 253);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "Giới tính";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtEmail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtEmail.BorderSize = 2;
            this.txtEmail.Location = new System.Drawing.Point(341, 188);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.Size = new System.Drawing.Size(232, 30);
            this.txtEmail.TabIndex = 20;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(270, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Email";
            // 
            // txtHoTen
            // 
            this.txtHoTen.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtHoTen.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtHoTen.BorderSize = 2;
            this.txtHoTen.Location = new System.Drawing.Point(341, 74);
            this.txtHoTen.Multiline = false;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Padding = new System.Windows.Forms.Padding(7);
            this.txtHoTen.PasswordChar = false;
            this.txtHoTen.Size = new System.Drawing.Size(232, 30);
            this.txtHoTen.TabIndex = 18;
            this.txtHoTen.Texts = "";
            this.txtHoTen.UnderlinedStyle = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label11.Location = new System.Drawing.Point(260, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "Họ tên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(263, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Vai trò";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMatKhau.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMatKhau.BorderSize = 2;
            this.txtMatKhau.Location = new System.Drawing.Point(341, 335);
            this.txtMatKhau.Multiline = false;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Padding = new System.Windows.Forms.Padding(7);
            this.txtMatKhau.PasswordChar = false;
            this.txtMatKhau.Size = new System.Drawing.Size(232, 30);
            this.txtMatKhau.TabIndex = 12;
            this.txtMatKhau.Texts = "";
            this.txtMatKhau.UnderlinedStyle = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(244, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mật khẩu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(259, 441);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Địa Chỉ";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSoDienThoai.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSoDienThoai.BorderSize = 2;
            this.txtSoDienThoai.Location = new System.Drawing.Point(341, 132);
            this.txtSoDienThoai.Multiline = false;
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Padding = new System.Windows.Forms.Padding(7);
            this.txtSoDienThoai.PasswordChar = false;
            this.txtSoDienThoai.Size = new System.Drawing.Size(232, 30);
            this.txtSoDienThoai.TabIndex = 6;
            this.txtSoDienThoai.Texts = "";
            this.txtSoDienThoai.UnderlinedStyle = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(217, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số điện thoại";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMaNhanVien.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMaNhanVien.BorderSize = 2;
            this.txtMaNhanVien.Location = new System.Drawing.Point(341, 18);
            this.txtMaNhanVien.Multiline = false;
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Padding = new System.Windows.Forms.Padding(7);
            this.txtMaNhanVien.PasswordChar = false;
            this.txtMaNhanVien.Size = new System.Drawing.Size(232, 30);
            this.txtMaNhanVien.TabIndex = 5;
            this.txtMaNhanVien.Texts = "";
            this.txtMaNhanVien.UnderlinedStyle = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(216, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã nhân viên";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.dgv);
            this.panel3.Location = new System.Drawing.Point(12, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(860, 483);
            this.panel3.TabIndex = 5;
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1521, 690);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNhanVien";
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.FrmNhanVien_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnh)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Label label2;
        private Label label1;
        private DataGridView dgv;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconButtonSua;
        private FontAwesome.Sharp.IconButton iconButtonThem;
        private CustomControl.TextBoxCustom txtEmail;
        private Label label10;
        private CustomControl.TextBoxCustom txtHoTen;
        private Label label11;
        private Label label8;
        private CustomControl.TextBoxCustom txtMatKhau;
        private Label label7;
        private Label label6;
        private CustomControl.TextBoxCustom txtSoCanCuoc;
        private Label label5;
        private CustomControl.TextBoxCustom txtSoDienThoai;
        private Label label4;
        private CustomControl.TextBoxCustom txtMaNhanVien;
        private Label label3;
        private Label label12;
        private CustomControl.PictrueBoxCustom ptbAnh;
        private FontAwesome.Sharp.IconButton iconButtonLoad;
        private FontAwesome.Sharp.IconButton iconButtonXoa;
        private CustomControl.TextBoxCustom2_0 txtDiaChi;
        private CustomControl.RadioButtonCustom rbtQuanLy;
        private CustomControl.RadioButtonCustom rbtNhanVien;
        private FontAwesome.Sharp.IconButton iconButton8;
        private CustomControl.TextBoxCustom2_0 txtTimKiem;
        private Panel panel3;
        private CustomControl.RadioButtonCustom rbtDaNghiViec;
        private CustomControl.RadioButtonCustom rbtDangLam;
        private CustomControl.RadioButtonCustom rbtNu;
        private CustomControl.RadioButtonCustom rbtNam;
        private Panel panel4;
        private Panel panel5;
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
    }
}