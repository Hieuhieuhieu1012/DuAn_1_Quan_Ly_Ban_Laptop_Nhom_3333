namespace _3_GUI_PresentationLayer.View
{
    partial class FrmBanHang
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBanHang));
            panel1 = new Panel();
            cbbGiamGia = new ComboBox();
            label1 = new Label();
            btnRefresh = new FontAwesome.Sharp.IconButton();
            txtMaHD = new CustomControl.TextBoxCustom2_0();
            label10 = new Label();
            groupBox3 = new GroupBox();
            cbbSdtKH = new ComboBox();
            lblHoTen = new Label();
            label5 = new Label();
            label6 = new Label();
            btnThemKH = new FontAwesome.Sharp.IconButton();
            lblTongTien = new Label();
            btnThanhToan = new FontAwesome.Sharp.IconButton();
            txtGhiChu = new CustomControl.TextBoxCustom2_0();
            rbtnCash = new CustomControl.RadioButtonCustom();
            rbtnTransfer = new CustomControl.RadioButtonCustom();
            label3 = new Label();
            label4 = new Label();
            label11 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            label7 = new Label();
            btnCheck = new FontAwesome.Sharp.IconButton();
            txtGiaCuoi = new CustomControl.TextBoxCustom2_0();
            txtGiaDau = new CustomControl.TextBoxCustom2_0();
            cbbCamera = new ComboBox();
            panel4 = new Panel();
            ptbCamera = new PictureBox();
            activeCamera = new CustomControl.ButtonCustom();
            iconButton8 = new FontAwesome.Sharp.IconButton();
            txtTimKiem = new CustomControl.TextBoxCustom2_0();
            label2 = new Label();
            panel3 = new Panel();
            dgvSanPham = new DataGridView();
            groupBox2 = new GroupBox();
            dgvGioHang = new DataGridView();
            tCamera = new System.Windows.Forms.Timer(components);
            menuStrip = new ContextMenuStrip(components);
            strKhuyenMai = new ToolStripMenuItem();
            printHD = new System.Drawing.Printing.PrintDocument();
            printPerviewHD = new PrintPreviewDialog();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbCamera).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).BeginInit();
            menuStrip.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(cbbGiamGia);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(txtMaHD);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(lblTongTien);
            panel1.Controls.Add(btnThanhToan);
            panel1.Controls.Add(txtGhiChu);
            panel1.Controls.Add(rbtnCash);
            panel1.Controls.Add(rbtnTransfer);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label11);
            panel1.Location = new Point(1052, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(457, 661);
            panel1.TabIndex = 19;
            // 
            // cbbGiamGia
            // 
            cbbGiamGia.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbbGiamGia.FormattingEnabled = true;
            cbbGiamGia.Location = new Point(168, 472);
            cbbGiamGia.Name = "cbbGiamGia";
            cbbGiamGia.Size = new Size(241, 23);
            cbbGiamGia.TabIndex = 52;
            cbbGiamGia.SelectedIndexChanged += cbbGiamGia_SelectedIndexChanged;
            cbbGiamGia.SelectedValueChanged += cbbGiamGia_SelectedValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(60, 475);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 57;
            label1.Text = "Giảm giá";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(146, 185, 229);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.ForeColor = Color.FromArgb(148, 105, 215);
            btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            btnRefresh.IconColor = Color.FromArgb(148, 105, 215);
            btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRefresh.IconSize = 38;
            btnRefresh.Location = new Point(235, 596);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(143, 55);
            btnRefresh.TabIndex = 56;
            btnRefresh.Text = "Làm mới";
            btnRefresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtMaHD
            // 
            txtMaHD.BorderColor = Color.MediumSlateBlue;
            txtMaHD.BorderFocusColor = Color.HotPink;
            txtMaHD.BorderRadius = 0;
            txtMaHD.BorderSize = 2;
            txtMaHD.Location = new Point(168, 175);
            txtMaHD.Multiline = false;
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Padding = new Padding(7);
            txtMaHD.PasswordChar = false;
            txtMaHD.PlaceholderColor = Color.DarkGray;
            txtMaHD.PlaceholderText = "";
            txtMaHD.Size = new Size(241, 30);
            txtMaHD.TabIndex = 52;
            txtMaHD.Texts = "";
            txtMaHD.UnderlinedStyle = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.HotTrack;
            label10.Location = new Point(30, 185);
            label10.Name = "label10";
            label10.Size = new Size(92, 20);
            label10.TabIndex = 17;
            label10.Text = "Mã hóa đơn";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cbbSdtKH);
            groupBox3.Controls.Add(lblHoTen);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(btnThemKH);
            groupBox3.Location = new Point(11, 9);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(420, 142);
            groupBox3.TabIndex = 51;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin khách hàng";
            // 
            // cbbSdtKH
            // 
            cbbSdtKH.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbbSdtKH.FormattingEnabled = true;
            cbbSdtKH.Location = new Point(157, 27);
            cbbSdtKH.Name = "cbbSdtKH";
            cbbSdtKH.Size = new Size(198, 23);
            cbbSdtKH.TabIndex = 51;
            cbbSdtKH.TextChanged += cbbSdtKH_TextChanged;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblHoTen.ForeColor = SystemColors.HotTrack;
            lblHoTen.Location = new Point(157, 87);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(56, 20);
            lblHoTen.TabIndex = 16;
            lblHoTen.Text = "Họ tên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(75, 87);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 15;
            label5.Text = "Họ tên";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(31, 30);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 13;
            label6.Text = "Số điện thoại";
            // 
            // btnThemKH
            // 
            btnThemKH.BackColor = Color.White;
            btnThemKH.FlatAppearance.BorderSize = 0;
            btnThemKH.FlatStyle = FlatStyle.Flat;
            btnThemKH.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            btnThemKH.IconColor = Color.FromArgb(86, 122, 228);
            btnThemKH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnThemKH.IconSize = 35;
            btnThemKH.Location = new Point(361, 14);
            btnThemKH.Name = "btnThemKH";
            btnThemKH.Size = new Size(46, 46);
            btnThemKH.TabIndex = 13;
            btnThemKH.UseVisualStyleBackColor = false;
            btnThemKH.Click += btnThemKH_Click;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTongTien.ForeColor = Color.Red;
            lblTongTien.Location = new Point(177, 540);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(0, 25);
            lblTongTien.TabIndex = 50;
            lblTongTien.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = Color.FromArgb(146, 185, 229);
            btnThanhToan.FlatAppearance.BorderSize = 0;
            btnThanhToan.FlatAppearance.MouseDownBackColor = Color.FromArgb(232, 225, 197);
            btnThanhToan.FlatAppearance.MouseOverBackColor = Color.White;
            btnThanhToan.FlatStyle = FlatStyle.Flat;
            btnThanhToan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThanhToan.ForeColor = Color.FromArgb(148, 105, 215);
            btnThanhToan.IconChar = FontAwesome.Sharp.IconChar.HandHoldingUsd;
            btnThanhToan.IconColor = Color.FromArgb(148, 105, 215);
            btnThanhToan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnThanhToan.IconSize = 38;
            btnThanhToan.Location = new Point(81, 596);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(143, 55);
            btnThanhToan.TabIndex = 49;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // txtGhiChu
            // 
            txtGhiChu.BorderColor = Color.MediumSlateBlue;
            txtGhiChu.BorderFocusColor = Color.HotPink;
            txtGhiChu.BorderRadius = 10;
            txtGhiChu.BorderSize = 1;
            txtGhiChu.Location = new Point(168, 330);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Padding = new Padding(7);
            txtGhiChu.PasswordChar = false;
            txtGhiChu.PlaceholderColor = Color.DarkGray;
            txtGhiChu.PlaceholderText = "";
            txtGhiChu.Size = new Size(241, 97);
            txtGhiChu.TabIndex = 47;
            txtGhiChu.Texts = "";
            txtGhiChu.UnderlinedStyle = false;
            // 
            // rbtnCash
            // 
            rbtnCash.AutoSize = true;
            rbtnCash.BackColor = Color.White;
            rbtnCash.CheckedColor = Color.Blue;
            rbtnCash.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnCash.Location = new Point(332, 258);
            rbtnCash.MinimumSize = new Size(0, 21);
            rbtnCash.Name = "rbtnCash";
            rbtnCash.Padding = new Padding(10, 0, 0, 0);
            rbtnCash.Size = new Size(86, 21);
            rbtnCash.TabIndex = 43;
            rbtnCash.TabStop = true;
            rbtnCash.Text = "Tiền mặt";
            rbtnCash.UnCheckedColor = Color.Black;
            rbtnCash.UseVisualStyleBackColor = false;
            // 
            // rbtnTransfer
            // 
            rbtnTransfer.AutoSize = true;
            rbtnTransfer.BackColor = Color.White;
            rbtnTransfer.CheckedColor = Color.Blue;
            rbtnTransfer.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnTransfer.Location = new Point(168, 258);
            rbtnTransfer.MinimumSize = new Size(0, 21);
            rbtnTransfer.Name = "rbtnTransfer";
            rbtnTransfer.Padding = new Padding(10, 0, 0, 0);
            rbtnTransfer.Size = new Size(117, 21);
            rbtnTransfer.TabIndex = 42;
            rbtnTransfer.TabStop = true;
            rbtnTransfer.Text = "Chuyển khoản";
            rbtnTransfer.UnCheckedColor = Color.Black;
            rbtnTransfer.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(23, 258);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 41;
            label3.Text = "HT thanh toán";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(60, 340);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 36;
            label4.Text = "Ghi chú";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(30, 540);
            label11.Name = "label11";
            label11.Size = new Size(112, 25);
            label11.TabIndex = 33;
            label11.Text = "Tổng Tiền: ";
            label11.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(btnCheck);
            panel2.Controls.Add(txtGiaCuoi);
            panel2.Controls.Add(txtGiaDau);
            panel2.Controls.Add(cbbCamera);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(activeCamera);
            panel2.Controls.Add(iconButton8);
            panel2.Controls.Add(txtTimKiem);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(18, 17);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 140);
            panel2.TabIndex = 42;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Highlight;
            label8.Location = new Point(270, 23);
            label8.Name = "label8";
            label8.Size = new Size(134, 17);
            label8.TabIndex = 55;
            label8.Text = "Lọc theo khoảng giá";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(380, 71);
            label7.Name = "label7";
            label7.Size = new Size(17, 15);
            label7.TabIndex = 54;
            label7.Text = "--";
            // 
            // btnCheck
            // 
            btnCheck.BackColor = Color.MediumSlateBlue;
            btnCheck.FlatAppearance.BorderSize = 0;
            btnCheck.FlatStyle = FlatStyle.Flat;
            btnCheck.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnCheck.IconColor = Color.White;
            btnCheck.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCheck.IconSize = 25;
            btnCheck.Location = new Point(518, 63);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(40, 30);
            btnCheck.TabIndex = 53;
            btnCheck.UseVisualStyleBackColor = false;
            btnCheck.Click += btnCheck_Click;
            // 
            // txtGiaCuoi
            // 
            txtGiaCuoi.BorderColor = Color.MediumSlateBlue;
            txtGiaCuoi.BorderFocusColor = Color.HotPink;
            txtGiaCuoi.BorderRadius = 0;
            txtGiaCuoi.BorderSize = 2;
            txtGiaCuoi.Location = new Point(402, 63);
            txtGiaCuoi.Multiline = false;
            txtGiaCuoi.Name = "txtGiaCuoi";
            txtGiaCuoi.Padding = new Padding(7);
            txtGiaCuoi.PasswordChar = false;
            txtGiaCuoi.PlaceholderColor = Color.DarkGray;
            txtGiaCuoi.PlaceholderText = "";
            txtGiaCuoi.Size = new Size(100, 30);
            txtGiaCuoi.TabIndex = 52;
            txtGiaCuoi.Texts = "";
            txtGiaCuoi.UnderlinedStyle = true;
            txtGiaCuoi.KeyPress += txtGiaDau_KeyPress;
            // 
            // txtGiaDau
            // 
            txtGiaDau.BorderColor = Color.MediumSlateBlue;
            txtGiaDau.BorderFocusColor = Color.HotPink;
            txtGiaDau.BorderRadius = 0;
            txtGiaDau.BorderSize = 2;
            txtGiaDau.Location = new Point(270, 63);
            txtGiaDau.Multiline = false;
            txtGiaDau.Name = "txtGiaDau";
            txtGiaDau.Padding = new Padding(7);
            txtGiaDau.PasswordChar = false;
            txtGiaDau.PlaceholderColor = Color.DarkGray;
            txtGiaDau.PlaceholderText = "";
            txtGiaDau.Size = new Size(100, 30);
            txtGiaDau.TabIndex = 51;
            txtGiaDau.Texts = "";
            txtGiaDau.UnderlinedStyle = true;
            txtGiaDau.KeyPress += txtGiaDau_KeyPress;
            // 
            // cbbCamera
            // 
            cbbCamera.FormattingEnabled = true;
            cbbCamera.Location = new Point(661, 6);
            cbbCamera.Name = "cbbCamera";
            cbbCamera.Size = new Size(102, 23);
            cbbCamera.TabIndex = 50;
            // 
            // panel4
            // 
            panel4.Controls.Add(ptbCamera);
            panel4.Location = new Point(769, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(228, 132);
            panel4.TabIndex = 24;
            // 
            // ptbCamera
            // 
            ptbCamera.Location = new Point(3, 3);
            ptbCamera.Name = "ptbCamera";
            ptbCamera.Size = new Size(222, 126);
            ptbCamera.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbCamera.TabIndex = 45;
            ptbCamera.TabStop = false;
            // 
            // activeCamera
            // 
            activeCamera.BackColor = Color.MediumSlateBlue;
            activeCamera.BackgroundColor = Color.MediumSlateBlue;
            activeCamera.BorderColor = Color.PaleVioletRed;
            activeCamera.BorderRadius = 10;
            activeCamera.BorderSize = 0;
            activeCamera.FlatAppearance.BorderSize = 0;
            activeCamera.FlatStyle = FlatStyle.Flat;
            activeCamera.ForeColor = Color.White;
            activeCamera.Location = new Point(658, 37);
            activeCamera.Name = "activeCamera";
            activeCamera.Size = new Size(105, 36);
            activeCamera.TabIndex = 49;
            activeCamera.Text = "Bật camera";
            activeCamera.TextColor = Color.White;
            activeCamera.UseVisualStyleBackColor = false;
            activeCamera.Click += activeCamera_Click;
            // 
            // iconButton8
            // 
            iconButton8.FlatAppearance.BorderSize = 0;
            iconButton8.FlatStyle = FlatStyle.Flat;
            iconButton8.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconButton8.IconColor = Color.Black;
            iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton8.IconSize = 23;
            iconButton8.Location = new Point(12, 68);
            iconButton8.Name = "iconButton8";
            iconButton8.Size = new Size(32, 25);
            iconButton8.TabIndex = 47;
            iconButton8.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderColor = Color.MediumSlateBlue;
            txtTimKiem.BorderFocusColor = Color.HotPink;
            txtTimKiem.BorderRadius = 10;
            txtTimKiem.BorderSize = 1;
            txtTimKiem.Location = new Point(6, 64);
            txtTimKiem.Multiline = false;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Padding = new Padding(42, 7, 7, 7);
            txtTimKiem.PasswordChar = false;
            txtTimKiem.PlaceholderColor = Color.DarkGray;
            txtTimKiem.PlaceholderText = "Tìm kiếm";
            txtTimKiem.Size = new Size(197, 30);
            txtTimKiem.TabIndex = 46;
            txtTimKiem.Texts = "";
            txtTimKiem.UnderlinedStyle = false;
            txtTimKiem._TextChanged += txtTimKiem__TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(6, 23);
            label2.Name = "label2";
            label2.Size = new Size(67, 17);
            label2.TabIndex = 41;
            label2.Text = "Tìm Kiếm";
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvSanPham);
            panel3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            panel3.Location = new Point(18, 174);
            panel3.Name = "panel3";
            panel3.Size = new Size(1000, 221);
            panel3.TabIndex = 43;
            // 
            // dgvSanPham
            // 
            dgvSanPham.AllowUserToAddRows = false;
            dgvSanPham.AllowUserToResizeRows = false;
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanPham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSanPham.BackgroundColor = Color.FromArgb(214, 248, 248);
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(214, 248, 248);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvSanPham.DefaultCellStyle = dataGridViewCellStyle1;
            dgvSanPham.Location = new Point(1, 3);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersVisible = false;
            dgvSanPham.RowTemplate.Height = 25;
            dgvSanPham.Size = new Size(993, 215);
            dgvSanPham.TabIndex = 23;
            dgvSanPham.CellClick += dgvSanPham_CellClick;
            dgvSanPham.CellContentClick += dgvSanPham_CellContentClick;
            dgvSanPham.EditingControlShowing += dgvSanPham_EditingControlShowing;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvGioHang);
            groupBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(19, 401);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(451, 267);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Giỏ Hàng";
            // 
            // dgvGioHang
            // 
            dgvGioHang.AllowUserToAddRows = false;
            dgvGioHang.AllowUserToResizeRows = false;
            dgvGioHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGioHang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvGioHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGioHang.Dock = DockStyle.Fill;
            dgvGioHang.Location = new Point(3, 23);
            dgvGioHang.Name = "dgvGioHang";
            dgvGioHang.RowHeadersVisible = false;
            dgvGioHang.RowHeadersWidth = 50;
            dgvGioHang.RowTemplate.Height = 25;
            dgvGioHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGioHang.Size = new Size(445, 241);
            dgvGioHang.TabIndex = 12;
            dgvGioHang.CellClick += dgvGioHang_CellClick;
            dgvGioHang.CellContentClick += dgvGioHang_CellContentClick;
            dgvGioHang.CellMouseUp += dgvGioHang_CellMouseUp;
            // 
            // tCamera
            // 
            tCamera.Interval = 500;
            tCamera.Tick += tCamera_Tick;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { strKhuyenMai });
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(173, 26);
            // 
            // strKhuyenMai
            // 
            strKhuyenMai.Name = "strKhuyenMai";
            strKhuyenMai.Size = new Size(172, 22);
            strKhuyenMai.Text = "Chọn mã giảm giá";
            strKhuyenMai.Click += strKhuyenMai_Click;
            // 
            // printHD
            // 
            printHD.PrintPage += printHD_PrintPage;
            // 
            // printPerviewHD
            // 
            printPerviewHD.AutoScrollMargin = new Size(0, 0);
            printPerviewHD.AutoScrollMinSize = new Size(0, 0);
            printPerviewHD.ClientSize = new Size(400, 300);
            printPerviewHD.Enabled = true;
            printPerviewHD.Icon = (Icon)resources.GetObject("printPerviewHD.Icon");
            printPerviewHD.Name = "printPerviewHD";
            printPerviewHD.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(561, 401);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(451, 267);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chờ thanh toán";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 50;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(445, 241);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FrmBanHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 245, 255);
            ClientSize = new Size(1521, 690);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmBanHang";
            Text = "Bán hàng";
            FormClosing += FrmBanHang_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbCamera).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).EndInit();
            menuStrip.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label4;
        private Label label11;
        private Label label6;
        private FontAwesome.Sharp.IconButton btnThemKH;
        private CustomControl.RadioButtonCustom rbtnCash;
        private CustomControl.RadioButtonCustom rbtnTransfer;
        private Label label3;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private GroupBox groupBox2;
        private DataGridView dgvGioHang;
        private DataGridView dgvSanPham;
        private CustomControl.TextBoxCustom2_0 txtGhiChu;
        private FontAwesome.Sharp.IconButton btnThanhToan;
        private FontAwesome.Sharp.IconButton iconButton8;
        private CustomControl.TextBoxCustom2_0 txtTimKiem;
        private CustomControl.ButtonCustom activeCamera;
        private PictureBox ptbCamera;
        private Label lblTongTien;
        private Panel panel4;
        private System.Windows.Forms.Timer tCamera;
        private ComboBox cbbCamera;
        private Label label10;
        private GroupBox groupBox3;
        private Label lblHoTen;
        private Label label5;
        private ComboBox cbbSdtKH;
        private CustomControl.TextBoxCustom2_0 txtMaHD;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private ContextMenuStrip menuStrip;
        private ToolStripMenuItem strKhuyenMai;
        private ComboBox cbbGiamGia;
        private Label label1;
        private System.Drawing.Printing.PrintDocument printHD;
        private PrintPreviewDialog printPerviewHD;
        private FontAwesome.Sharp.IconButton btnCheck;
        private CustomControl.TextBoxCustom2_0 txtGiaCuoi;
        private CustomControl.TextBoxCustom2_0 txtGiaDau;
        private Label label8;
        private Label label7;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
    }
}