namespace _3_GUI_PresentationLayer.View
{
    partial class FrmHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHoaDon));
            dtpEndDate = new CustomControl.DateTimePickerCustom();
            label5 = new Label();
            dtpStartDate = new CustomControl.DateTimePickerCustom();
            label4 = new Label();
            groupBox1 = new GroupBox();
            dgv_hoaDon = new DataGridView();
            groupBox2 = new GroupBox();
            dgv_CTHD = new DataGridView();
            panel2 = new Panel();
            btnSelect = new CustomControl.ButtonCustom();
            iconButton8 = new FontAwesome.Sharp.IconButton();
            txtTimKiem = new CustomControl.TextBoxCustom2_0();
            btnInHoaDon = new FontAwesome.Sharp.IconButton();
            btnExportExcel = new PictureBox();
            printHD = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_hoaDon).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_CTHD).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnExportExcel).BeginInit();
            SuspendLayout();
            // 
            // dtpEndDate
            // 
            dtpEndDate.BorderColor = Color.PaleVioletRed;
            dtpEndDate.BorderSize = 0;
            dtpEndDate.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(496, 20);
            dtpEndDate.MinimumSize = new Size(0, 35);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(141, 35);
            dtpEndDate.SkinColor = Color.MediumSlateBlue;
            dtpEndDate.TabIndex = 8;
            dtpEndDate.TextColor = Color.White;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.MenuHighlight;
            label5.Location = new Point(453, 29);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 7;
            label5.Text = "Đến";
            // 
            // dtpStartDate
            // 
            dtpStartDate.BorderColor = Color.PaleVioletRed;
            dtpStartDate.BorderSize = 0;
            dtpStartDate.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(316, 19);
            dtpStartDate.MinimumSize = new Size(0, 35);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(131, 35);
            dtpStartDate.SkinColor = Color.MediumSlateBlue;
            dtpStartDate.TabIndex = 5;
            dtpStartDate.TextColor = Color.White;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.MenuHighlight;
            label4.Location = new Point(284, 29);
            label4.Name = "label4";
            label4.Size = new Size(26, 20);
            label4.TabIndex = 6;
            label4.Text = "Từ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgv_hoaDon);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(27, 106);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1472, 360);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hóa Đơn";
            // 
            // dgv_hoaDon
            // 
            dgv_hoaDon.AllowUserToAddRows = false;
            dgv_hoaDon.AllowUserToDeleteRows = false;
            dgv_hoaDon.AllowUserToResizeRows = false;
            dgv_hoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_hoaDon.Dock = DockStyle.Fill;
            dgv_hoaDon.Location = new Point(3, 25);
            dgv_hoaDon.Name = "dgv_hoaDon";
            dgv_hoaDon.ReadOnly = true;
            dgv_hoaDon.RowHeadersVisible = false;
            dgv_hoaDon.RowTemplate.Height = 25;
            dgv_hoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_hoaDon.Size = new Size(1466, 332);
            dgv_hoaDon.TabIndex = 0;
            dgv_hoaDon.CellClick += dgv_hoaDon_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgv_CTHD);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(24, 472);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1478, 204);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hóa Đơn Chi Tiết";
            // 
            // dgv_CTHD
            // 
            dgv_CTHD.AllowUserToAddRows = false;
            dgv_CTHD.AllowUserToDeleteRows = false;
            dgv_CTHD.AllowUserToResizeRows = false;
            dgv_CTHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_CTHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_CTHD.Dock = DockStyle.Fill;
            dgv_CTHD.Location = new Point(3, 25);
            dgv_CTHD.Name = "dgv_CTHD";
            dgv_CTHD.ReadOnly = true;
            dgv_CTHD.RowHeadersVisible = false;
            dgv_CTHD.RowTemplate.Height = 25;
            dgv_CTHD.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_CTHD.Size = new Size(1472, 176);
            dgv_CTHD.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnSelect);
            panel2.Controls.Add(iconButton8);
            panel2.Controls.Add(txtTimKiem);
            panel2.Controls.Add(dtpEndDate);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(dtpStartDate);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(30, 26);
            panel2.Name = "panel2";
            panel2.Size = new Size(1306, 74);
            panel2.TabIndex = 1;
            // 
            // btnSelect
            // 
            btnSelect.BackColor = Color.MediumSlateBlue;
            btnSelect.BackgroundColor = Color.MediumSlateBlue;
            btnSelect.BorderColor = Color.PaleVioletRed;
            btnSelect.BorderRadius = 5;
            btnSelect.BorderSize = 0;
            btnSelect.FlatAppearance.BorderSize = 0;
            btnSelect.FlatStyle = FlatStyle.Flat;
            btnSelect.ForeColor = Color.White;
            btnSelect.Image = Properties.Resources.check;
            btnSelect.Location = new Point(645, 19);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(38, 37);
            btnSelect.TabIndex = 51;
            btnSelect.TextColor = Color.White;
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;
            // 
            // iconButton8
            // 
            iconButton8.FlatAppearance.BorderSize = 0;
            iconButton8.FlatStyle = FlatStyle.Flat;
            iconButton8.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconButton8.IconColor = Color.Black;
            iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton8.IconSize = 23;
            iconButton8.Location = new Point(17, 23);
            iconButton8.Name = "iconButton8";
            iconButton8.Size = new Size(32, 25);
            iconButton8.TabIndex = 49;
            iconButton8.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderColor = Color.MediumSlateBlue;
            txtTimKiem.BorderFocusColor = Color.HotPink;
            txtTimKiem.BorderRadius = 10;
            txtTimKiem.BorderSize = 1;
            txtTimKiem.Location = new Point(11, 19);
            txtTimKiem.Multiline = false;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Padding = new Padding(42, 7, 7, 7);
            txtTimKiem.PasswordChar = false;
            txtTimKiem.PlaceholderColor = Color.DarkGray;
            txtTimKiem.PlaceholderText = "Tìm kiếm";
            txtTimKiem.Size = new Size(250, 30);
            txtTimKiem.TabIndex = 48;
            txtTimKiem.Texts = "";
            txtTimKiem.UnderlinedStyle = false;
            txtTimKiem._TextChanged += txtTimKiem__TextChanged;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.BackColor = Color.FromArgb(2, 135, 127);
            btnInHoaDon.FlatAppearance.BorderSize = 0;
            btnInHoaDon.FlatStyle = FlatStyle.Flat;
            btnInHoaDon.IconChar = FontAwesome.Sharp.IconChar.Print;
            btnInHoaDon.IconColor = Color.Black;
            btnInHoaDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInHoaDon.Location = new Point(1425, 30);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(71, 66);
            btnInHoaDon.TabIndex = 7;
            btnInHoaDon.UseVisualStyleBackColor = false;
            btnInHoaDon.Click += btnInHoaDon_Click;
            // 
            // btnExportExcel
            // 
            btnExportExcel.BackColor = Color.FromArgb(2, 135, 127);
            btnExportExcel.Image = Properties.Resources.icons8_microsoft_excel_80;
            btnExportExcel.Location = new Point(1347, 30);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(66, 66);
            btnExportExcel.SizeMode = PictureBoxSizeMode.StretchImage;
            btnExportExcel.TabIndex = 8;
            btnExportExcel.TabStop = false;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // printHD
            // 
            printHD.PrintPage += printHD_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // FrmHoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 245, 255);
            ClientSize = new Size(1521, 690);
            Controls.Add(btnExportExcel);
            Controls.Add(btnInHoaDon);
            Controls.Add(panel2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmHoaDon";
            Text = "Hóa  đơn";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_hoaDon).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_CTHD).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnExportExcel).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label4;
        private CustomControl.DateTimePickerCustom dtpEndDate;
        private Label label5;
        private CustomControl.DateTimePickerCustom dtpStartDate;
        private GroupBox groupBox1;
        private DataGridView dgv_hoaDon;
        private GroupBox groupBox2;
        private DataGridView dgv_CTHD;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton8;
        private CustomControl.TextBoxCustom2_0 txtTimKiem;
        private FontAwesome.Sharp.IconButton btnInHoaDon;
        private PictureBox btnExportExcel;
        private System.Drawing.Printing.PrintDocument printHD;
        private PrintPreviewDialog printPreviewDialog1;
        private CustomControl.ButtonCustom btnSelect;
    }
}