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
            label2 = new Label();
            iconButtonClear = new FontAwesome.Sharp.IconButton();
            iconButtonSua = new FontAwesome.Sharp.IconButton();
            iconButtonThem = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            label12 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            iconButton8 = new FontAwesome.Sharp.IconButton();
            labelTimKiem = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.BackgroundColor = Color.DarkGray;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column7, Column4, Column5, Column6 });
            dgvKhachHang.GridColor = SystemColors.Highlight;
            dgvKhachHang.Location = new Point(12, 142);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersVisible = false;
            dgvKhachHang.RowTemplate.Height = 25;
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachHang.Size = new Size(910, 494);
            dgvKhachHang.TabIndex = 9;
            dgvKhachHang.CellContentClick += dgvKhachHang_CellContentClick;
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
            panel1.Controls.Add(label2);
            panel1.Controls.Add(iconButtonClear);
            panel1.Controls.Add(iconButtonSua);
            panel1.Controls.Add(iconButtonThem);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(928, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(421, 624);
            panel1.TabIndex = 10;
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
            iconButtonClear.Location = new Point(286, 533);
            iconButtonClear.Name = "iconButtonClear";
            iconButtonClear.Size = new Size(97, 43);
            iconButtonClear.TabIndex = 53;
            iconButtonClear.UseVisualStyleBackColor = false;
            // 
            // iconButtonSua
            // 
            iconButtonSua.BackColor = Color.White;
            iconButtonSua.FlatAppearance.BorderSize = 0;
            iconButtonSua.FlatStyle = FlatStyle.Flat;
            iconButtonSua.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            iconButtonSua.IconColor = Color.FromArgb(0, 0, 192);
            iconButtonSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonSua.IconSize = 40;
            iconButtonSua.Location = new Point(154, 533);
            iconButtonSua.Name = "iconButtonSua";
            iconButtonSua.Size = new Size(97, 43);
            iconButtonSua.TabIndex = 43;
            iconButtonSua.UseVisualStyleBackColor = false;
            // 
            // iconButtonThem
            // 
            iconButtonThem.BackColor = Color.White;
            iconButtonThem.FlatAppearance.BorderSize = 0;
            iconButtonThem.FlatStyle = FlatStyle.Flat;
            iconButtonThem.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            iconButtonThem.IconColor = Color.FromArgb(0, 0, 192);
            iconButtonThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonThem.IconSize = 40;
            iconButtonThem.Location = new Point(18, 533);
            iconButtonThem.Name = "iconButtonThem";
            iconButtonThem.Size = new Size(97, 43);
            iconButtonThem.TabIndex = 42;
            iconButtonThem.UseVisualStyleBackColor = false;
            iconButtonThem.Click += iconButtonThem_Click;
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
            txtMa.Load += txtMa_Load;
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
            // iconButton8
            // 
            iconButton8.FlatAppearance.BorderSize = 0;
            iconButton8.FlatStyle = FlatStyle.Flat;
            iconButton8.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconButton8.IconColor = Color.Black;
            iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton8.IconSize = 23;
            iconButton8.Location = new Point(31, 96);
            iconButton8.Name = "iconButton8";
            iconButton8.Size = new Size(32, 25);
            iconButton8.TabIndex = 53;
            iconButton8.UseVisualStyleBackColor = true;
            // 
            // labelTimKiem
            // 
            labelTimKiem.AutoSize = true;
            labelTimKiem.Location = new Point(31, 75);
            labelTimKiem.Name = "labelTimKiem";
            labelTimKiem.Size = new Size(57, 15);
            labelTimKiem.TabIndex = 54;
            labelTimKiem.Text = "TÌM KIẾM";
            // 
            // FrmKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1361, 646);
            Controls.Add(labelTimKiem);
            Controls.Add(iconButton8);
            Controls.Add(panel1);
            Controls.Add(dgvKhachHang);
            Name = "FrmKhachHang";
            Text = "FrmKhachHang";
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvKhachHang;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Panel panel1;
        private CustomControl.TextBoxCustom txtEmail;
        private Label label2;
        private FontAwesome.Sharp.IconButton iconButtonClear;
        private CustomControl.TextBoxCustom2_0 txtDiaChi;
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
        private FontAwesome.Sharp.IconButton iconButton8;
        private CustomControl.TextBoxCustom2_0 txtTimKiem;
        private Label labelTimKiem;
    }
}