namespace _3_GUI_PresentationLayer.View
{
    partial class FrmMain
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
            panelMenu = new Panel();
            btnDangXuat = new FontAwesome.Sharp.IconButton();
            btnThongKe = new FontAwesome.Sharp.IconButton();
            btnKhuyenMai = new FontAwesome.Sharp.IconButton();
            btnKhachHang = new FontAwesome.Sharp.IconButton();
            btnNhanVien = new FontAwesome.Sharp.IconButton();
            btnHoaDon = new FontAwesome.Sharp.IconButton();
            btnBanHang = new FontAwesome.Sharp.IconButton();
            btnSanPham = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            panel1 = new Panel();
            lblTen = new Label();
            lblMa = new Label();
            label2 = new Label();
            label1 = new Label();
            pictrueBoxCustom1 = new CustomControl.PictrueBoxCustom();
            panelTitleBar = new Panel();
            btnMinimize = new FontAwesome.Sharp.IconButton();
            btnExit = new FontAwesome.Sharp.IconButton();
            lblTitleChildFrm = new Label();
            iconCurrentChildFrm = new FontAwesome.Sharp.IconPictureBox();
            panelShadow = new Panel();
            panelDesktop = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictrueBoxCustom1).BeginInit();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildFrm).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(31, 32, 69);
            panelMenu.Controls.Add(btnDangXuat);
            panelMenu.Controls.Add(btnThongKe);
            panelMenu.Controls.Add(btnKhuyenMai);
            panelMenu.Controls.Add(btnKhachHang);
            panelMenu.Controls.Add(btnNhanVien);
            panelMenu.Controls.Add(btnHoaDon);
            panelMenu.Controls.Add(btnBanHang);
            panelMenu.Controls.Add(btnSanPham);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(247, 811);
            panelMenu.TabIndex = 0;
           // panelMenu.Paint += panelMenu_Paint;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Dock = DockStyle.Top;
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnDangXuat.ForeColor = Color.Gainsboro;
            btnDangXuat.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            btnDangXuat.IconColor = Color.Gainsboro;
            btnDangXuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDangXuat.ImageAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.Location = new Point(0, 712);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Padding = new Padding(22, 0, 0, 0);
            btnDangXuat.Size = new Size(247, 70);
            btnDangXuat.TabIndex = 8;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.TextAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.Dock = DockStyle.Top;
            btnThongKe.FlatAppearance.BorderSize = 0;
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnThongKe.ForeColor = Color.Gainsboro;
            btnThongKe.IconChar = FontAwesome.Sharp.IconChar.LineChart;
            btnThongKe.IconColor = Color.Gainsboro;
            btnThongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnThongKe.ImageAlign = ContentAlignment.MiddleLeft;
            btnThongKe.Location = new Point(0, 642);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Padding = new Padding(22, 0, 0, 0);
            btnThongKe.Size = new Size(247, 70);
            btnThongKe.TabIndex = 7;
            btnThongKe.Text = "Thống kê";
            btnThongKe.TextAlign = ContentAlignment.MiddleLeft;
            btnThongKe.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // btnKhuyenMai
            // 
            btnKhuyenMai.Dock = DockStyle.Top;
            btnKhuyenMai.FlatAppearance.BorderSize = 0;
            btnKhuyenMai.FlatStyle = FlatStyle.Flat;
            btnKhuyenMai.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnKhuyenMai.ForeColor = Color.Gainsboro;
            btnKhuyenMai.IconChar = FontAwesome.Sharp.IconChar.Salesforce;
            btnKhuyenMai.IconColor = Color.Gainsboro;
            btnKhuyenMai.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnKhuyenMai.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhuyenMai.Location = new Point(0, 572);
            btnKhuyenMai.Name = "btnKhuyenMai";
            btnKhuyenMai.Padding = new Padding(22, 0, 0, 0);
            btnKhuyenMai.Size = new Size(247, 70);
            btnKhuyenMai.TabIndex = 6;
            btnKhuyenMai.Text = "Khuyến mại";
            btnKhuyenMai.TextAlign = ContentAlignment.MiddleLeft;
            btnKhuyenMai.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKhuyenMai.UseVisualStyleBackColor = true;
            btnKhuyenMai.Click += btnKhuyenMai_Click;
            // 
            // btnKhachHang
            // 
            btnKhachHang.Dock = DockStyle.Top;
            btnKhachHang.FlatAppearance.BorderSize = 0;
            btnKhachHang.FlatStyle = FlatStyle.Flat;
            btnKhachHang.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnKhachHang.ForeColor = Color.Gainsboro;
            btnKhachHang.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            btnKhachHang.IconColor = Color.Gainsboro;
            btnKhachHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnKhachHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhachHang.Location = new Point(0, 502);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Padding = new Padding(22, 0, 0, 0);
            btnKhachHang.Size = new Size(247, 70);
            btnKhachHang.TabIndex = 5;
            btnKhachHang.Text = "Khách hàng";
            btnKhachHang.TextAlign = ContentAlignment.MiddleLeft;
            btnKhachHang.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKhachHang.UseVisualStyleBackColor = true;
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.Dock = DockStyle.Top;
            btnNhanVien.FlatAppearance.BorderSize = 0;
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnNhanVien.ForeColor = Color.Gainsboro;
            btnNhanVien.IconChar = FontAwesome.Sharp.IconChar.Person;
            btnNhanVien.IconColor = Color.Gainsboro;
            btnNhanVien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNhanVien.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhanVien.Location = new Point(0, 432);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Padding = new Padding(22, 0, 0, 0);
            btnNhanVien.Size = new Size(247, 70);
            btnNhanVien.TabIndex = 4;
            btnNhanVien.Text = "Nhân viên";
            btnNhanVien.TextAlign = ContentAlignment.MiddleLeft;
            btnNhanVien.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNhanVien.UseVisualStyleBackColor = true;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // btnHoaDon
            // 
            btnHoaDon.Dock = DockStyle.Top;
            btnHoaDon.FlatAppearance.BorderSize = 0;
            btnHoaDon.FlatStyle = FlatStyle.Flat;
            btnHoaDon.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnHoaDon.ForeColor = Color.Gainsboro;
            btnHoaDon.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            btnHoaDon.IconColor = Color.Gainsboro;
            btnHoaDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btnHoaDon.Location = new Point(0, 362);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Padding = new Padding(22, 0, 0, 0);
            btnHoaDon.Size = new Size(247, 70);
            btnHoaDon.TabIndex = 3;
            btnHoaDon.Text = "Hóa đơn";
            btnHoaDon.TextAlign = ContentAlignment.MiddleLeft;
            btnHoaDon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHoaDon.UseVisualStyleBackColor = true;
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // btnBanHang
            // 
            btnBanHang.Dock = DockStyle.Top;
            btnBanHang.FlatAppearance.BorderSize = 0;
            btnBanHang.FlatStyle = FlatStyle.Flat;
            btnBanHang.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnBanHang.ForeColor = Color.Gainsboro;
            btnBanHang.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            btnBanHang.IconColor = Color.Gainsboro;
            btnBanHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBanHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnBanHang.Location = new Point(0, 292);
            btnBanHang.Name = "btnBanHang";
            btnBanHang.Padding = new Padding(22, 0, 0, 0);
            btnBanHang.Size = new Size(247, 70);
            btnBanHang.TabIndex = 2;
            btnBanHang.Text = "Bán hàng";
            btnBanHang.TextAlign = ContentAlignment.MiddleLeft;
            btnBanHang.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBanHang.UseVisualStyleBackColor = true;
            btnBanHang.Click += btnBanHang_Click;
            // 
            // btnSanPham
            // 
            btnSanPham.Dock = DockStyle.Top;
            btnSanPham.FlatAppearance.BorderSize = 0;
            btnSanPham.FlatStyle = FlatStyle.Flat;
            btnSanPham.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnSanPham.ForeColor = Color.Gainsboro;
            btnSanPham.IconChar = FontAwesome.Sharp.IconChar.Tag;
            btnSanPham.IconColor = Color.Gainsboro;
            btnSanPham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSanPham.ImageAlign = ContentAlignment.MiddleLeft;
            btnSanPham.Location = new Point(0, 222);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Padding = new Padding(22, 0, 0, 0);
            btnSanPham.Size = new Size(247, 70);
            btnSanPham.TabIndex = 1;
            btnSanPham.Text = "Sản phẩm";
            btnSanPham.TextAlign = ContentAlignment.MiddleLeft;
            btnSanPham.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSanPham.UseVisualStyleBackColor = true;
            btnSanPham.Click += btnSanPham_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(31, 32, 69);
            panelLogo.Controls.Add(panel1);
            panelLogo.Controls.Add(pictrueBoxCustom1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(247, 222);
            panelLogo.TabIndex = 0;
            //panelLogo.Paint += panelLogo_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTen);
            panel1.Controls.Add(lblMa);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(247, 222);
            panel1.TabIndex = 1;
            //panel1.Paint += panel1_Paint;
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTen.ForeColor = Color.Gainsboro;
            lblTen.Location = new Point(105, 40);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(33, 20);
            lblTen.TabIndex = 3;
            lblTen.Text = "Tên";
            //lblTen.Click += lblTen_Click;
            // 
            // lblMa
            // 
            lblMa.AutoSize = true;
            lblMa.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMa.ForeColor = Color.Gainsboro;
            lblMa.Location = new Point(105, 6);
            lblMa.Name = "lblMa";
            lblMa.Size = new Size(31, 20);
            lblMa.TabIndex = 2;
            lblMa.Text = "Mã";
            //lblMa.Click += lblMa_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(42, 42);
            label2.Name = "label2";
            label2.Size = new Size(50, 17);
            label2.TabIndex = 1;
            label2.Text = "Họ tên:";
           // label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(89, 17);
            label1.TabIndex = 0;
            label1.Text = "Mã nhân viên:";
            //label1.Click += label1_Click;
            // 
            // pictrueBoxCustom1
            // 
            pictrueBoxCustom1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            pictrueBoxCustom1.BorderColor = Color.RoyalBlue;
            pictrueBoxCustom1.BorderColor2 = Color.HotPink;
            pictrueBoxCustom1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            pictrueBoxCustom1.BorderSize = 2;
            pictrueBoxCustom1.GradientAngle = 50F;
            pictrueBoxCustom1.Image = Properties.Resources.SSSSSSAAAAAA;
            pictrueBoxCustom1.Location = new Point(53, 10);
            pictrueBoxCustom1.Name = "pictrueBoxCustom1";
            pictrueBoxCustom1.Size = new Size(133, 133);
            pictrueBoxCustom1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictrueBoxCustom1.TabIndex = 0;
            pictrueBoxCustom1.TabStop = false;
            pictrueBoxCustom1.Click += pictrueBoxCustom1_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(26, 27, 61);
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Controls.Add(btnExit);
            panelTitleBar.Controls.Add(lblTitleChildFrm);
            panelTitleBar.Controls.Add(iconCurrentChildFrm);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(247, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1537, 73);
            panelTitleBar.TabIndex = 1;
            //panelTitleBar.Paint += panelTitleBar_Paint;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.FromArgb(26, 27, 61);
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            btnMinimize.IconColor = Color.FromArgb(0, 192, 192);
            btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimize.IconSize = 27;
            btnMinimize.Location = new Point(1470, 5);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(31, 26);
            btnMinimize.TabIndex = 2;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(26, 27, 61);
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            btnExit.IconColor = Color.FromArgb(0, 192, 192);
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExit.IconSize = 27;
            btnExit.Location = new Point(1496, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(31, 26);
            btnExit.TabIndex = 2;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblTitleChildFrm
            // 
            lblTitleChildFrm.AutoSize = true;
            lblTitleChildFrm.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleChildFrm.ForeColor = Color.Gainsboro;
            lblTitleChildFrm.Location = new Point(113, 16);
            lblTitleChildFrm.Name = "lblTitleChildFrm";
            lblTitleChildFrm.Size = new Size(121, 50);
            lblTitleChildFrm.TabIndex = 1;
            lblTitleChildFrm.Text = "Home";
            //lblTitleChildFrm.Click += lblTitleChildFrm_Click;
            // 
            // iconCurrentChildFrm
            // 
            iconCurrentChildFrm.BackColor = Color.FromArgb(26, 25, 62);
            iconCurrentChildFrm.ForeColor = Color.MediumPurple;
            iconCurrentChildFrm.IconChar = FontAwesome.Sharp.IconChar.House;
            iconCurrentChildFrm.IconColor = Color.MediumPurple;
            iconCurrentChildFrm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildFrm.IconSize = 52;
            iconCurrentChildFrm.Location = new Point(31, 14);
            iconCurrentChildFrm.Name = "iconCurrentChildFrm";
            iconCurrentChildFrm.Size = new Size(60, 52);
            iconCurrentChildFrm.TabIndex = 0;
            iconCurrentChildFrm.TabStop = false;
            //iconCurrentChildFrm.Click += iconCurrentChildFrm_Click;
            // 
            // panelShadow
            // 
            panelShadow.BackColor = Color.FromArgb(26, 24, 58);
            panelShadow.Dock = DockStyle.Top;
            panelShadow.Location = new Point(247, 73);
            panelShadow.Name = "panelShadow";
            panelShadow.Size = new Size(1537, 9);
            panelShadow.TabIndex = 2;
            //panelShadow.Paint += panelShadow_Paint;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.FromArgb(26, 29, 65);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(247, 82);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1537, 729);
            panelDesktop.TabIndex = 3;
           // panelDesktop.Paint += panelDesktop_Paint;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1784, 811);
            Controls.Add(panelDesktop);
            Controls.Add(panelShadow);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMain";
            Text = "Form2";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictrueBoxCustom1).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildFrm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnDangXuat;
        private FontAwesome.Sharp.IconButton btnThongKe;
        private FontAwesome.Sharp.IconButton btnKhuyenMai;
        private FontAwesome.Sharp.IconButton btnKhachHang;
        private FontAwesome.Sharp.IconButton btnNhanVien;
        private FontAwesome.Sharp.IconButton btnHoaDon;
        private FontAwesome.Sharp.IconButton btnBanHang;
        private FontAwesome.Sharp.IconButton btnSanPham;
        private Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildFrm;
        private Label lblTitleChildFrm;
        private Panel panelShadow;
        private Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnExit;
        private Panel panel1;
        private Label lblTen;
        private Label lblMa;
        private Label label2;
        private Label label1;
        private CustomControl.PictrueBoxCustom pictrueBoxCustom1;
    }
}