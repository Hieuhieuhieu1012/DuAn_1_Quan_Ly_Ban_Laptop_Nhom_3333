namespace _3_GUI_PresentationLayer.View
{
    partial class FrmKhuyenMai
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
            panel1 = new Panel();
            btnrdKetThuc = new CustomControl.RadioButtonCustom();
            btnTimKiemKM = new FontAwesome.Sharp.IconButton();
            txtTimKiemKM = new CustomControl.TextBoxCustom2_0();
            btnrbDang = new CustomControl.RadioButtonCustom();
            btnrdSap = new CustomControl.RadioButtonCustom();
            label2 = new Label();
            label1 = new Label();
            dgvKhuyenMai = new DataGridView();
            panel = new Panel();
            txtMucGia = new CustomControl.TextBoxCustom2_0();
            btn_Sua = new FontAwesome.Sharp.IconButton();
            lblLoai = new Label();
            cbbDong = new ComboBox();
            cbbHang = new ComboBox();
            cbbLoaiKhuyenMai = new ComboBox();
            btnClearForm = new FontAwesome.Sharp.IconButton();
            btnClear = new CustomControl.ButtonCustom();
            btnTimSp = new FontAwesome.Sharp.IconButton();
            txtTimSP = new CustomControl.TextBoxCustom2_0();
            btnAll = new CustomControl.ButtonCustom();
            btnThem = new FontAwesome.Sharp.IconButton();
            dgvSanPham = new DataGridView();
            label3 = new Label();
            dtKetThuc = new CustomControl.DateTimePickerCustom();
            dtBatDau = new CustomControl.DateTimePickerCustom();
            label10 = new Label();
            txtMa = new CustomControl.TextBoxCustom();
            txtTenCT = new CustomControl.TextBoxCustom();
            label9 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhuyenMai).BeginInit();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnrdKetThuc);
            panel1.Controls.Add(btnTimKiemKM);
            panel1.Controls.Add(txtTimKiemKM);
            panel1.Controls.Add(btnrbDang);
            panel1.Controls.Add(btnrdSap);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(960, 93);
            panel1.TabIndex = 3;
            // 
            // btnrdKetThuc
            // 
            btnrdKetThuc.AutoSize = true;
            btnrdKetThuc.CheckedColor = Color.MediumSlateBlue;
            btnrdKetThuc.Location = new Point(785, 42);
            btnrdKetThuc.MinimumSize = new Size(0, 21);
            btnrdKetThuc.Name = "btnrdKetThuc";
            btnrdKetThuc.Padding = new Padding(10, 0, 0, 0);
            btnrdKetThuc.Size = new Size(144, 21);
            btnrdKetThuc.TabIndex = 55;
            btnrdKetThuc.TabStop = true;
            btnrdKetThuc.Text = "Kết thúc khuyến mãi";
            btnrdKetThuc.UnCheckedColor = Color.Gray;
            btnrdKetThuc.UseVisualStyleBackColor = true;
            // 
            // btnTimKiemKM
            // 
            btnTimKiemKM.BackColor = Color.White;
            btnTimKiemKM.FlatAppearance.BorderSize = 0;
            btnTimKiemKM.FlatStyle = FlatStyle.Flat;
            btnTimKiemKM.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnTimKiemKM.IconColor = Color.Black;
            btnTimKiemKM.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTimKiemKM.IconSize = 23;
            btnTimKiemKM.Location = new Point(34, 38);
            btnTimKiemKM.Name = "btnTimKiemKM";
            btnTimKiemKM.Size = new Size(32, 25);
            btnTimKiemKM.TabIndex = 54;
            btnTimKiemKM.UseVisualStyleBackColor = false;
            // 
            // txtTimKiemKM
            // 
            txtTimKiemKM.BackColor = Color.White;
            txtTimKiemKM.BorderColor = Color.MediumSlateBlue;
            txtTimKiemKM.BorderFocusColor = Color.HotPink;
            txtTimKiemKM.BorderRadius = 10;
            txtTimKiemKM.BorderSize = 1;
            txtTimKiemKM.Location = new Point(28, 34);
            txtTimKiemKM.Multiline = false;
            txtTimKiemKM.Name = "txtTimKiemKM";
            txtTimKiemKM.Padding = new Padding(42, 7, 7, 7);
            txtTimKiemKM.PasswordChar = false;
            txtTimKiemKM.PlaceholderColor = Color.DarkGray;
            txtTimKiemKM.PlaceholderText = "Tìm kiếm";
            txtTimKiemKM.Size = new Size(247, 30);
            txtTimKiemKM.TabIndex = 53;
            txtTimKiemKM.Texts = "";
            txtTimKiemKM.UnderlinedStyle = false;
            // 
            // btnrbDang
            // 
            btnrbDang.AutoSize = true;
            btnrbDang.CheckedColor = Color.MediumSlateBlue;
            btnrbDang.Location = new Point(451, 43);
            btnrbDang.MinimumSize = new Size(0, 21);
            btnrbDang.Name = "btnrbDang";
            btnrbDang.Padding = new Padding(10, 0, 0, 0);
            btnrbDang.Size = new Size(128, 21);
            btnrbDang.TabIndex = 52;
            btnrbDang.TabStop = true;
            btnrbDang.Text = "Đang khuyến mại";
            btnrbDang.UnCheckedColor = Color.Gray;
            btnrbDang.UseVisualStyleBackColor = true;
            btnrbDang.CheckedChanged += btnrbDang_CheckedChanged;
            // 
            // btnrdSap
            // 
            btnrdSap.AutoSize = true;
            btnrdSap.CheckedColor = Color.MediumSlateBlue;
            btnrdSap.Location = new Point(627, 43);
            btnrdSap.MinimumSize = new Size(0, 21);
            btnrdSap.Name = "btnrdSap";
            btnrdSap.Padding = new Padding(10, 0, 0, 0);
            btnrdSap.Size = new Size(119, 21);
            btnrdSap.TabIndex = 52;
            btnrdSap.TabStop = true;
            btnrdSap.Text = "Sắp khuyến mại";
            btnrdSap.UnCheckedColor = Color.Gray;
            btnrdSap.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(453, 4);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 3;
            label2.Text = "Trạng Thái";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(23, 5);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 2;
            label1.Text = "Tìm Kiếm";
            // 
            // dgvKhuyenMai
            // 
            dgvKhuyenMai.AllowUserToAddRows = false;
            dgvKhuyenMai.AllowUserToDeleteRows = false;
            dgvKhuyenMai.AllowUserToResizeRows = false;
            dgvKhuyenMai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhuyenMai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhuyenMai.Location = new Point(3, 3);
            dgvKhuyenMai.Name = "dgvKhuyenMai";
            dgvKhuyenMai.RowHeadersVisible = false;
            dgvKhuyenMai.RowTemplate.Height = 25;
            dgvKhuyenMai.Size = new Size(957, 291);
            dgvKhuyenMai.TabIndex = 4;
            dgvKhuyenMai.CellClick += dgvKhuyenMai_CellClick;
            // 
            // panel
            // 
            panel.BackColor = Color.White;
            panel.Controls.Add(txtMucGia);
            panel.Controls.Add(btn_Sua);
            panel.Controls.Add(lblLoai);
            panel.Controls.Add(cbbDong);
            panel.Controls.Add(cbbHang);
            panel.Controls.Add(cbbLoaiKhuyenMai);
            panel.Controls.Add(btnClearForm);
            panel.Controls.Add(btnClear);
            panel.Controls.Add(btnTimSp);
            panel.Controls.Add(txtTimSP);
            panel.Controls.Add(btnAll);
            panel.Controls.Add(btnThem);
            panel.Controls.Add(dgvSanPham);
            panel.Controls.Add(label3);
            panel.Controls.Add(dtKetThuc);
            panel.Controls.Add(dtBatDau);
            panel.Controls.Add(label10);
            panel.Controls.Add(txtMa);
            panel.Controls.Add(txtTenCT);
            panel.Controls.Add(label9);
            panel.Controls.Add(label6);
            panel.Controls.Add(label7);
            panel.Controls.Add(label8);
            panel.Controls.Add(label5);
            panel.Controls.Add(label4);
            panel.Location = new Point(996, 25);
            panel.Name = "panel";
            panel.Size = new Size(490, 639);
            panel.TabIndex = 5;
            // 
            // txtMucGia
            // 
            txtMucGia.BorderColor = Color.MediumSlateBlue;
            txtMucGia.BorderFocusColor = Color.HotPink;
            txtMucGia.BorderRadius = 0;
            txtMucGia.BorderSize = 2;
            txtMucGia.Location = new Point(184, 156);
            txtMucGia.Multiline = false;
            txtMucGia.Name = "txtMucGia";
            txtMucGia.Padding = new Padding(7);
            txtMucGia.PasswordChar = false;
            txtMucGia.PlaceholderColor = Color.DarkGray;
            txtMucGia.PlaceholderText = "";
            txtMucGia.Size = new Size(131, 30);
            txtMucGia.TabIndex = 58;
            txtMucGia.Texts = "";
            txtMucGia.UnderlinedStyle = true;
            txtMucGia.KeyPress += txtMucGia_KeyPress_1;
            // 
            // btn_Sua
            // 
            btn_Sua.BackColor = Color.FromArgb(254, 197, 230);
            btn_Sua.Enabled = false;
            btn_Sua.FlatAppearance.BorderSize = 0;
            btn_Sua.FlatStyle = FlatStyle.Flat;
            btn_Sua.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            btn_Sua.IconColor = Color.Black;
            btn_Sua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Sua.IconSize = 37;
            btn_Sua.Location = new Point(200, 588);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(82, 36);
            btn_Sua.TabIndex = 57;
            btn_Sua.UseVisualStyleBackColor = false;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // lblLoai
            // 
            lblLoai.AutoSize = true;
            lblLoai.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblLoai.Location = new Point(321, 167);
            lblLoai.Name = "lblLoai";
            lblLoai.Size = new Size(35, 17);
            lblLoai.TabIndex = 56;
            lblLoai.Text = "VND";
            // 
            // cbbDong
            // 
            cbbDong.FormattingEnabled = true;
            cbbDong.Location = new Point(183, 342);
            cbbDong.Name = "cbbDong";
            cbbDong.Size = new Size(280, 23);
            cbbDong.TabIndex = 55;
            cbbDong.SelectedIndexChanged += cbbDong_SelectedIndexChanged;
            // 
            // cbbHang
            // 
            cbbHang.FormattingEnabled = true;
            cbbHang.Location = new Point(183, 300);
            cbbHang.Name = "cbbHang";
            cbbHang.Size = new Size(280, 23);
            cbbHang.TabIndex = 54;
            cbbHang.SelectedIndexChanged += cbbHang_SelectedIndexChanged;
            cbbHang.TextChanged += cbbHang_TextChanged;
            // 
            // cbbLoaiKhuyenMai
            // 
            cbbLoaiKhuyenMai.FormattingEnabled = true;
            cbbLoaiKhuyenMai.Location = new Point(183, 119);
            cbbLoaiKhuyenMai.Name = "cbbLoaiKhuyenMai";
            cbbLoaiKhuyenMai.Size = new Size(280, 23);
            cbbLoaiKhuyenMai.TabIndex = 53;
            cbbLoaiKhuyenMai.TextChanged += cbbLoaiKhuyenMai_TextChanged;
            // 
            // btnClearForm
            // 
            btnClearForm.BackColor = Color.FromArgb(254, 197, 230);
            btnClearForm.FlatAppearance.BorderSize = 0;
            btnClearForm.FlatStyle = FlatStyle.Flat;
            btnClearForm.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            btnClearForm.IconColor = Color.Black;
            btnClearForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClearForm.IconSize = 45;
            btnClearForm.Location = new Point(343, 589);
            btnClearForm.Name = "btnClearForm";
            btnClearForm.Size = new Size(91, 37);
            btnClearForm.TabIndex = 52;
            btnClearForm.UseVisualStyleBackColor = false;
            btnClearForm.Click += btnClearForm_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.MediumSlateBlue;
            btnClear.BackgroundColor = Color.MediumSlateBlue;
            btnClear.BorderColor = Color.PaleVioletRed;
            btnClear.BorderRadius = 10;
            btnClear.BorderSize = 0;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(136, 379);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(121, 32);
            btnClear.TabIndex = 23;
            btnClear.Text = "Chọn lại";
            btnClear.TextColor = Color.White;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnTimSp
            // 
            btnTimSp.BackColor = Color.White;
            btnTimSp.FlatAppearance.BorderSize = 0;
            btnTimSp.FlatStyle = FlatStyle.Flat;
            btnTimSp.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnTimSp.IconColor = Color.Black;
            btnTimSp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTimSp.IconSize = 23;
            btnTimSp.Location = new Point(283, 386);
            btnTimSp.Name = "btnTimSp";
            btnTimSp.Size = new Size(32, 25);
            btnTimSp.TabIndex = 51;
            btnTimSp.UseVisualStyleBackColor = false;
            // 
            // txtTimSP
            // 
            txtTimSP.BackColor = Color.White;
            txtTimSP.BorderColor = Color.MediumSlateBlue;
            txtTimSP.BorderFocusColor = Color.HotPink;
            txtTimSP.BorderRadius = 10;
            txtTimSP.BorderSize = 1;
            txtTimSP.Location = new Point(277, 382);
            txtTimSP.Multiline = false;
            txtTimSP.Name = "txtTimSP";
            txtTimSP.Padding = new Padding(42, 7, 7, 7);
            txtTimSP.PasswordChar = false;
            txtTimSP.PlaceholderColor = Color.DarkGray;
            txtTimSP.PlaceholderText = "Tìm kiếm";
            txtTimSP.Size = new Size(186, 30);
            txtTimSP.TabIndex = 50;
            txtTimSP.Texts = "";
            txtTimSP.UnderlinedStyle = false;
            // 
            // btnAll
            // 
            btnAll.BackColor = Color.MediumSlateBlue;
            btnAll.BackgroundColor = Color.MediumSlateBlue;
            btnAll.BorderColor = Color.PaleVioletRed;
            btnAll.BorderRadius = 10;
            btnAll.BorderSize = 0;
            btnAll.FlatAppearance.BorderSize = 0;
            btnAll.FlatStyle = FlatStyle.Flat;
            btnAll.ForeColor = Color.White;
            btnAll.Location = new Point(17, 379);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(113, 32);
            btnAll.TabIndex = 23;
            btnAll.Text = "Chọn tất cả";
            btnAll.TextColor = Color.White;
            btnAll.UseVisualStyleBackColor = false;
            btnAll.Click += btnAll_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(254, 197, 230);
            btnThem.Enabled = false;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnThem.IconColor = Color.Black;
            btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnThem.IconSize = 37;
            btnThem.Location = new Point(59, 589);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(82, 36);
            btnThem.TabIndex = 21;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // dgvSanPham
            // 
            dgvSanPham.AllowUserToAddRows = false;
            dgvSanPham.AllowUserToResizeColumns = false;
            dgvSanPham.AllowUserToResizeRows = false;
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Location = new Point(17, 423);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersVisible = false;
            dgvSanPham.RowTemplate.Height = 25;
            dgvSanPham.Size = new Size(454, 159);
            dgvSanPham.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(25, 118);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 5;
            label3.Text = "Loại Khuyến Mãi";
            // 
            // dtKetThuc
            // 
            dtKetThuc.BorderColor = Color.PaleVioletRed;
            dtKetThuc.BorderSize = 0;
            dtKetThuc.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dtKetThuc.Format = DateTimePickerFormat.Short;
            dtKetThuc.Location = new Point(183, 244);
            dtKetThuc.MinimumSize = new Size(0, 35);
            dtKetThuc.Name = "dtKetThuc";
            dtKetThuc.Size = new Size(280, 35);
            dtKetThuc.SkinColor = Color.MediumSlateBlue;
            dtKetThuc.TabIndex = 16;
            dtKetThuc.TextColor = Color.White;
            // 
            // dtBatDau
            // 
            dtBatDau.BorderColor = Color.PaleVioletRed;
            dtBatDau.BorderSize = 0;
            dtBatDau.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dtBatDau.Format = DateTimePickerFormat.Short;
            dtBatDau.Location = new Point(183, 199);
            dtBatDau.MinimumSize = new Size(0, 35);
            dtBatDau.Name = "dtBatDau";
            dtBatDau.Size = new Size(280, 35);
            dtBatDau.SkinColor = Color.MediumSlateBlue;
            dtBatDau.TabIndex = 15;
            dtBatDau.TextColor = Color.White;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.Highlight;
            label10.Location = new Point(97, 341);
            label10.Name = "label10";
            label10.Size = new Size(47, 20);
            label10.TabIndex = 14;
            label10.Text = "Dòng";
            // 
            // txtMa
            // 
            txtMa.BackColor = Color.White;
            txtMa.BorderColor = Color.MediumSlateBlue;
            txtMa.BorderFocusColor = Color.HotPink;
            txtMa.BorderSize = 2;
            txtMa.Enabled = false;
            txtMa.Location = new Point(183, 11);
            txtMa.Multiline = false;
            txtMa.Name = "txtMa";
            txtMa.Padding = new Padding(7);
            txtMa.PasswordChar = false;
            txtMa.Size = new Size(280, 30);
            txtMa.TabIndex = 12;
            txtMa.Texts = "";
            txtMa.UnderlinedStyle = true;
            // 
            // txtTenCT
            // 
            txtTenCT.BackColor = Color.White;
            txtTenCT.BorderColor = Color.MediumSlateBlue;
            txtTenCT.BorderFocusColor = Color.HotPink;
            txtTenCT.BorderSize = 2;
            txtTenCT.Location = new Point(183, 57);
            txtTenCT.Multiline = false;
            txtTenCT.Name = "txtTenCT";
            txtTenCT.Padding = new Padding(7);
            txtTenCT.PasswordChar = false;
            txtTenCT.Size = new Size(280, 30);
            txtTenCT.TabIndex = 5;
            txtTenCT.Texts = "";
            txtTenCT.UnderlinedStyle = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.Highlight;
            label9.Location = new Point(95, 299);
            label9.Name = "label9";
            label9.Size = new Size(46, 20);
            label9.TabIndex = 11;
            label9.Text = "Hãng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(311, 208);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 10;
            label6.Text = "Đến";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(75, 208);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 9;
            label7.Text = "Từ ngày";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Highlight;
            label8.Location = new Point(46, 164);
            label8.Name = "label8";
            label8.Size = new Size(104, 20);
            label8.TabIndex = 8;
            label8.Text = "Mức giảm giá";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(55, 21);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 7;
            label5.Text = "Mã giảm giá";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(9, 67);
            label4.Name = "label4";
            label4.Size = new Size(141, 20);
            label4.TabIndex = 6;
            label4.Text = "Tên CT khuyến mại";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(dgvKhuyenMai);
            panel3.Location = new Point(12, 143);
            panel3.Name = "panel3";
            panel3.Size = new Size(963, 521);
            panel3.TabIndex = 6;
            // 
            // FrmKhuyenMai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 245, 255);
            ClientSize = new Size(1521, 690);
            Controls.Add(panel3);
            Controls.Add(panel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmKhuyenMai";
            Text = "Khuyến mại";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhuyenMai).EndInit();
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private DataGridView dgvKhuyenMai;
        private Panel panel;
        private Label label3;
        private CustomControl.TextBoxCustom txtMa;
        private CustomControl.TextBoxCustom txtTenCT;
        private Label label9;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label5;
        private Label label4;
        private DataGridView dgvSanPham;
        private CustomControl.DateTimePickerCustom dtKetThuc;
        private CustomControl.DateTimePickerCustom dtBatDau;
        private Label label10;
        private FontAwesome.Sharp.IconButton btnThem;
        private CustomControl.RadioButtonCustom btnrdSap;
        private FontAwesome.Sharp.IconButton btnTimSp;
        private CustomControl.TextBoxCustom2_0 txtTimSP;
        private Panel panel3;
        private CustomControl.ButtonCustom btnClear;
        private CustomControl.ButtonCustom btnAll;
        private FontAwesome.Sharp.IconButton btnTimKiemKM;
        private CustomControl.TextBoxCustom2_0 txtTimKiemKM;
        private CustomControl.RadioButtonCustom btnrbDang;
        private FontAwesome.Sharp.IconButton btnClearForm;
        private ComboBox cbbDong;
        private ComboBox cbbHang;
        private ComboBox cbbLoaiKhuyenMai;
        private CustomControl.RadioButtonCustom btnrdKetThuc;
        private Label lblLoai;
        private FontAwesome.Sharp.IconButton btn_Sua;
        private CustomControl.TextBoxCustom2_0 txtMucGia;
    }
}