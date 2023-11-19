namespace _3_GUI_PresentationLayer.View
{
    partial class FrmLaptop
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvLaptop = new DataGridView();
            panel6 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            btnClearForm = new FontAwesome.Sharp.IconButton();
            btnDoiTT = new FontAwesome.Sharp.IconButton();
            btnSua = new FontAwesome.Sharp.IconButton();
            btnThem = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lb = new Label();
            pcbHinhAnh = new PictureBox();
            panel1 = new Panel();
            txtTimKiem = new TextBox();
            btnGiam = new FontAwesome.Sharp.IconButton();
            btnTang = new FontAwesome.Sharp.IconButton();
            label19 = new Label();
            panel4 = new Panel();
            cbbSerial = new ComboBox();
            cbbMauSac = new ComboBox();
            cbbManHinh = new ComboBox();
            cbbOCung = new ComboBox();
            cbbRam = new ComboBox();
            cbbVga = new ComboBox();
            cbbCpu = new ComboBox();
            cbbNhaCungCap = new ComboBox();
            cbbDong = new ComboBox();
            cbbHangSanXuat = new ComboBox();
            btnSerial = new FontAwesome.Sharp.IconButton();
            btnMauSac = new FontAwesome.Sharp.IconButton();
            btnManHinh = new FontAwesome.Sharp.IconButton();
            btnOCung = new FontAwesome.Sharp.IconButton();
            btnRam = new FontAwesome.Sharp.IconButton();
            btnVga = new FontAwesome.Sharp.IconButton();
            btnCpu = new FontAwesome.Sharp.IconButton();
            btnNhaCungCap = new FontAwesome.Sharp.IconButton();
            btnDongLaptop = new FontAwesome.Sharp.IconButton();
            btnHangSanXuat = new FontAwesome.Sharp.IconButton();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label9 = new Label();
            panel5 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvLaptop).BeginInit();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbHinhAnh).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // dgvLaptop
            // 
            dgvLaptop.AllowUserToAddRows = false;
            dgvLaptop.AllowUserToDeleteRows = false;
            dgvLaptop.AllowUserToResizeRows = false;
            dgvLaptop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLaptop.BackgroundColor = Color.FromArgb(214, 248, 248);
            dgvLaptop.BorderStyle = BorderStyle.None;
            dgvLaptop.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvLaptop.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(214, 248, 248);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(214, 248, 248);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLaptop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(214, 248, 248);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(241, 122, 133);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvLaptop.DefaultCellStyle = dataGridViewCellStyle2;
            dgvLaptop.Dock = DockStyle.Fill;
            dgvLaptop.EnableHeadersVisualStyles = false;
            dgvLaptop.GridColor = Color.FromArgb(145, 158, 194);
            dgvLaptop.Location = new Point(0, 0);
            dgvLaptop.Name = "dgvLaptop";
            dgvLaptop.ReadOnly = true;
            dgvLaptop.RowHeadersVisible = false;
            dgvLaptop.RowTemplate.Height = 25;
            dgvLaptop.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLaptop.Size = new Size(1078, 299);
            dgvLaptop.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(244, 245, 255);
            panel6.Controls.Add(panel3);
            panel6.Controls.Add(panel2);
            panel6.Controls.Add(panel1);
            panel6.Controls.Add(panel4);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1513, 654);
            panel6.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(dgvLaptop);
            panel3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel3.Location = new Point(12, 103);
            panel3.Name = "panel3";
            panel3.Size = new Size(1078, 299);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnClearForm);
            panel2.Controls.Add(btnDoiTT);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lb);
            panel2.Controls.Add(pcbHinhAnh);
            panel2.Location = new Point(1110, 14);
            panel2.Name = "panel2";
            panel2.Size = new Size(399, 630);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(3, 22, 73);
            label2.Location = new Point(19, 295);
            label2.Name = "label2";
            label2.Size = new Size(100, 21);
            label2.TabIndex = 20;
            label2.Text = "Trọng lượng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(3, 22, 73);
            label1.Location = new Point(227, 295);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 18;
            label1.Text = "Năm Bh";
            // 
            // btnClearForm
            // 
            btnClearForm.BackColor = Color.White;
            btnClearForm.FlatAppearance.BorderSize = 0;
            btnClearForm.FlatStyle = FlatStyle.Flat;
            btnClearForm.IconChar = FontAwesome.Sharp.IconChar.RotateBackward;
            btnClearForm.IconColor = Color.FromArgb(61, 39, 76);
            btnClearForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClearForm.IconSize = 45;
            btnClearForm.Location = new Point(313, 577);
            btnClearForm.Name = "btnClearForm";
            btnClearForm.Size = new Size(53, 37);
            btnClearForm.TabIndex = 16;
            btnClearForm.UseVisualStyleBackColor = false;
            // 
            // btnDoiTT
            // 
            btnDoiTT.BackColor = Color.White;
            btnDoiTT.FlatAppearance.BorderSize = 0;
            btnDoiTT.FlatStyle = FlatStyle.Flat;
            btnDoiTT.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            btnDoiTT.IconColor = Color.FromArgb(61, 39, 76);
            btnDoiTT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDoiTT.IconSize = 45;
            btnDoiTT.Location = new Point(224, 577);
            btnDoiTT.Name = "btnDoiTT";
            btnDoiTT.Size = new Size(53, 37);
            btnDoiTT.TabIndex = 16;
            btnDoiTT.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.White;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.IconChar = FontAwesome.Sharp.IconChar.Pen;
            btnSua.IconColor = Color.FromArgb(61, 39, 76);
            btnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSua.IconSize = 45;
            btnSua.Location = new Point(131, 577);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(53, 37);
            btnSua.TabIndex = 14;
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.White;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnThem.IconColor = Color.FromArgb(61, 39, 76);
            btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnThem.IconSize = 45;
            btnThem.Location = new Point(36, 577);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(53, 37);
            btnThem.TabIndex = 13;
            btnThem.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(3, 22, 73);
            label8.Location = new Point(19, 436);
            label8.Name = "label8";
            label8.Size = new Size(107, 21);
            label8.TabIndex = 11;
            label8.Text = "Mô tả chi tiết";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(22, 24, 63);
            label7.Location = new Point(192, 403);
            label7.Name = "label7";
            label7.Size = new Size(16, 21);
            label7.TabIndex = 10;
            label7.Text = "-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(3, 22, 73);
            label6.Location = new Point(219, 369);
            label6.Name = "label6";
            label6.Size = new Size(64, 21);
            label6.TabIndex = 9;
            label6.Text = "Giá bán";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(3, 22, 73);
            label5.Location = new Point(20, 369);
            label5.Name = "label5";
            label5.Size = new Size(73, 21);
            label5.TabIndex = 8;
            label5.Text = "Giá nhập";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(3, 22, 73);
            label4.Location = new Point(347, 403);
            label4.Name = "label4";
            label4.Size = new Size(43, 21);
            label4.TabIndex = 7;
            label4.Text = "VND";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(3, 22, 73);
            label3.Location = new Point(148, 403);
            label3.Name = "label3";
            label3.Size = new Size(43, 21);
            label3.TabIndex = 1;
            label3.Text = "VND";
            // 
            // lb
            // 
            lb.AutoSize = true;
            lb.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb.ForeColor = Color.FromArgb(3, 22, 73);
            lb.Location = new Point(19, 243);
            lb.Name = "lb";
            lb.Size = new Size(91, 21);
            lb.TabIndex = 1;
            lb.Text = "Tên Laptop";
            // 
            // pcbHinhAnh
            // 
            pcbHinhAnh.BorderStyle = BorderStyle.FixedSingle;
            pcbHinhAnh.Location = new Point(112, 24);
            pcbHinhAnh.Name = "pcbHinhAnh";
            pcbHinhAnh.Size = new Size(195, 190);
            pcbHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbHinhAnh.TabIndex = 0;
            pcbHinhAnh.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtTimKiem);
            panel1.Controls.Add(btnGiam);
            panel1.Controls.Add(btnTang);
            panel1.Controls.Add(label19);
            panel1.Location = new Point(12, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(1078, 69);
            panel1.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(16, 28);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(178, 23);
            txtTimKiem.TabIndex = 24;
            txtTimKiem.Text = "Tìm kiếm .....";
            // 
            // btnGiam
            // 
            btnGiam.FlatAppearance.BorderSize = 0;
            btnGiam.FlatStyle = FlatStyle.Flat;
            btnGiam.IconChar = FontAwesome.Sharp.IconChar.SortAmountDown;
            btnGiam.IconColor = Color.FromArgb(255, 181, 174);
            btnGiam.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGiam.Location = new Point(998, 6);
            btnGiam.Name = "btnGiam";
            btnGiam.Padding = new Padding(0, 5, 0, 0);
            btnGiam.Size = new Size(63, 55);
            btnGiam.TabIndex = 21;
            btnGiam.UseVisualStyleBackColor = true;
            // 
            // btnTang
            // 
            btnTang.FlatAppearance.BorderSize = 0;
            btnTang.FlatStyle = FlatStyle.Flat;
            btnTang.IconChar = FontAwesome.Sharp.IconChar.ArrowUpWideShort;
            btnTang.IconColor = Color.FromArgb(255, 181, 174);
            btnTang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTang.Location = new Point(929, 7);
            btnTang.Name = "btnTang";
            btnTang.Padding = new Padding(0, 5, 0, 0);
            btnTang.Size = new Size(63, 55);
            btnTang.TabIndex = 21;
            btnTang.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.FromArgb(3, 22, 73);
            label19.Location = new Point(3, 2);
            label19.Name = "label19";
            label19.Size = new Size(71, 20);
            label19.TabIndex = 17;
            label19.Text = "Tìm kiếm";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(cbbSerial);
            panel4.Controls.Add(cbbMauSac);
            panel4.Controls.Add(cbbManHinh);
            panel4.Controls.Add(cbbOCung);
            panel4.Controls.Add(cbbRam);
            panel4.Controls.Add(cbbVga);
            panel4.Controls.Add(cbbCpu);
            panel4.Controls.Add(cbbNhaCungCap);
            panel4.Controls.Add(cbbDong);
            panel4.Controls.Add(cbbHangSanXuat);
            panel4.Controls.Add(btnSerial);
            panel4.Controls.Add(btnMauSac);
            panel4.Controls.Add(btnManHinh);
            panel4.Controls.Add(btnOCung);
            panel4.Controls.Add(btnRam);
            panel4.Controls.Add(btnVga);
            panel4.Controls.Add(btnCpu);
            panel4.Controls.Add(btnNhaCungCap);
            panel4.Controls.Add(btnDongLaptop);
            panel4.Controls.Add(btnHangSanXuat);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label18);
            panel4.Controls.Add(label17);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label9);
            panel4.Location = new Point(12, 408);
            panel4.Name = "panel4";
            panel4.Size = new Size(1078, 236);
            panel4.TabIndex = 3;
            // 
            // cbbSerial
            // 
            cbbSerial.FormattingEnabled = true;
            cbbSerial.Location = new Point(915, 157);
            cbbSerial.Name = "cbbSerial";
            cbbSerial.Size = new Size(150, 23);
            cbbSerial.TabIndex = 31;
            // 
            // cbbMauSac
            // 
            cbbMauSac.FormattingEnabled = true;
            cbbMauSac.Location = new Point(699, 157);
            cbbMauSac.Name = "cbbMauSac";
            cbbMauSac.Size = new Size(150, 23);
            cbbMauSac.TabIndex = 30;
            // 
            // cbbManHinh
            // 
            cbbManHinh.FormattingEnabled = true;
            cbbManHinh.Location = new Point(456, 157);
            cbbManHinh.Name = "cbbManHinh";
            cbbManHinh.Size = new Size(150, 23);
            cbbManHinh.TabIndex = 29;
            // 
            // cbbOCung
            // 
            cbbOCung.FormattingEnabled = true;
            cbbOCung.Location = new Point(235, 157);
            cbbOCung.Name = "cbbOCung";
            cbbOCung.Size = new Size(150, 23);
            cbbOCung.TabIndex = 28;
            // 
            // cbbRam
            // 
            cbbRam.FormattingEnabled = true;
            cbbRam.Location = new Point(17, 157);
            cbbRam.Name = "cbbRam";
            cbbRam.Size = new Size(150, 23);
            cbbRam.TabIndex = 27;
            // 
            // cbbVga
            // 
            cbbVga.FormattingEnabled = true;
            cbbVga.Location = new Point(915, 40);
            cbbVga.Name = "cbbVga";
            cbbVga.Size = new Size(150, 23);
            cbbVga.TabIndex = 26;
            // 
            // cbbCpu
            // 
            cbbCpu.FormattingEnabled = true;
            cbbCpu.Location = new Point(699, 40);
            cbbCpu.Name = "cbbCpu";
            cbbCpu.Size = new Size(150, 23);
            cbbCpu.TabIndex = 25;
            // 
            // cbbNhaCungCap
            // 
            cbbNhaCungCap.FormattingEnabled = true;
            cbbNhaCungCap.Location = new Point(456, 40);
            cbbNhaCungCap.Name = "cbbNhaCungCap";
            cbbNhaCungCap.Size = new Size(150, 23);
            cbbNhaCungCap.TabIndex = 24;
            // 
            // cbbDong
            // 
            cbbDong.FormattingEnabled = true;
            cbbDong.Location = new Point(235, 40);
            cbbDong.Name = "cbbDong";
            cbbDong.Size = new Size(150, 23);
            cbbDong.TabIndex = 23;
            // 
            // cbbHangSanXuat
            // 
            cbbHangSanXuat.FormattingEnabled = true;
            cbbHangSanXuat.Location = new Point(17, 40);
            cbbHangSanXuat.Name = "cbbHangSanXuat";
            cbbHangSanXuat.Size = new Size(150, 23);
            cbbHangSanXuat.TabIndex = 22;
            // 
            // btnSerial
            // 
            btnSerial.BackColor = Color.FromArgb(86, 103, 204);
            btnSerial.FlatStyle = FlatStyle.Flat;
            btnSerial.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnSerial.IconColor = Color.Black;
            btnSerial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSerial.IconSize = 28;
            btnSerial.Location = new Point(915, 191);
            btnSerial.Name = "btnSerial";
            btnSerial.Padding = new Padding(0, 4, 0, 0);
            btnSerial.Size = new Size(150, 36);
            btnSerial.TabIndex = 20;
            btnSerial.UseVisualStyleBackColor = false;
            // 
            // btnMauSac
            // 
            btnMauSac.BackColor = Color.FromArgb(86, 103, 204);
            btnMauSac.FlatStyle = FlatStyle.Flat;
            btnMauSac.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnMauSac.IconColor = Color.Black;
            btnMauSac.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMauSac.IconSize = 28;
            btnMauSac.Location = new Point(699, 191);
            btnMauSac.Name = "btnMauSac";
            btnMauSac.Padding = new Padding(0, 4, 0, 0);
            btnMauSac.Size = new Size(150, 36);
            btnMauSac.TabIndex = 20;
            btnMauSac.UseVisualStyleBackColor = false;
            // 
            // btnManHinh
            // 
            btnManHinh.BackColor = Color.FromArgb(86, 103, 204);
            btnManHinh.FlatStyle = FlatStyle.Flat;
            btnManHinh.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnManHinh.IconColor = Color.Black;
            btnManHinh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnManHinh.IconSize = 28;
            btnManHinh.Location = new Point(456, 191);
            btnManHinh.Name = "btnManHinh";
            btnManHinh.Padding = new Padding(0, 4, 0, 0);
            btnManHinh.Size = new Size(150, 36);
            btnManHinh.TabIndex = 20;
            btnManHinh.UseVisualStyleBackColor = false;
            // 
            // btnOCung
            // 
            btnOCung.BackColor = Color.FromArgb(86, 103, 204);
            btnOCung.FlatStyle = FlatStyle.Flat;
            btnOCung.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnOCung.IconColor = Color.Black;
            btnOCung.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnOCung.IconSize = 28;
            btnOCung.Location = new Point(235, 191);
            btnOCung.Name = "btnOCung";
            btnOCung.Padding = new Padding(0, 4, 0, 0);
            btnOCung.Size = new Size(150, 36);
            btnOCung.TabIndex = 20;
            btnOCung.UseVisualStyleBackColor = false;
            // 
            // btnRam
            // 
            btnRam.BackColor = Color.FromArgb(86, 103, 204);
            btnRam.FlatStyle = FlatStyle.Flat;
            btnRam.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnRam.IconColor = Color.Black;
            btnRam.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRam.IconSize = 28;
            btnRam.Location = new Point(17, 191);
            btnRam.Name = "btnRam";
            btnRam.Padding = new Padding(0, 4, 0, 0);
            btnRam.Size = new Size(150, 36);
            btnRam.TabIndex = 20;
            btnRam.UseVisualStyleBackColor = false;
            // 
            // btnVga
            // 
            btnVga.BackColor = Color.FromArgb(86, 103, 204);
            btnVga.FlatStyle = FlatStyle.Flat;
            btnVga.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnVga.IconColor = Color.Black;
            btnVga.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVga.IconSize = 28;
            btnVga.Location = new Point(915, 73);
            btnVga.Name = "btnVga";
            btnVga.Padding = new Padding(0, 4, 0, 0);
            btnVga.Size = new Size(150, 36);
            btnVga.TabIndex = 20;
            btnVga.UseVisualStyleBackColor = false;
            btnVga.Click += btnVga_Click;
            // 
            // btnCpu
            // 
            btnCpu.BackColor = Color.FromArgb(86, 103, 204);
            btnCpu.FlatStyle = FlatStyle.Flat;
            btnCpu.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnCpu.IconColor = Color.Black;
            btnCpu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCpu.IconSize = 28;
            btnCpu.Location = new Point(699, 73);
            btnCpu.Name = "btnCpu";
            btnCpu.Padding = new Padding(0, 4, 0, 0);
            btnCpu.Size = new Size(150, 36);
            btnCpu.TabIndex = 20;
            btnCpu.UseVisualStyleBackColor = false;
            btnCpu.Click += btnCpu_Click;
            // 
            // btnNhaCungCap
            // 
            btnNhaCungCap.BackColor = Color.FromArgb(86, 103, 204);
            btnNhaCungCap.FlatStyle = FlatStyle.Flat;
            btnNhaCungCap.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnNhaCungCap.IconColor = Color.Black;
            btnNhaCungCap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNhaCungCap.IconSize = 28;
            btnNhaCungCap.Location = new Point(456, 73);
            btnNhaCungCap.Name = "btnNhaCungCap";
            btnNhaCungCap.Padding = new Padding(0, 4, 0, 0);
            btnNhaCungCap.Size = new Size(150, 36);
            btnNhaCungCap.TabIndex = 20;
            btnNhaCungCap.UseVisualStyleBackColor = false;
            btnNhaCungCap.Click += btnNhaCungCap_Click;
            // 
            // btnDongLaptop
            // 
            btnDongLaptop.BackColor = Color.FromArgb(86, 103, 204);
            btnDongLaptop.FlatStyle = FlatStyle.Flat;
            btnDongLaptop.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnDongLaptop.IconColor = Color.Black;
            btnDongLaptop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDongLaptop.IconSize = 28;
            btnDongLaptop.Location = new Point(235, 73);
            btnDongLaptop.Name = "btnDongLaptop";
            btnDongLaptop.Padding = new Padding(0, 4, 0, 0);
            btnDongLaptop.Size = new Size(150, 36);
            btnDongLaptop.TabIndex = 20;
            btnDongLaptop.UseVisualStyleBackColor = false;
            btnDongLaptop.Click += btnDongLaptop_Click;
            // 
            // btnHangSanXuat
            // 
            btnHangSanXuat.BackColor = Color.FromArgb(86, 103, 204);
            btnHangSanXuat.FlatStyle = FlatStyle.Flat;
            btnHangSanXuat.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnHangSanXuat.IconColor = Color.Black;
            btnHangSanXuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHangSanXuat.IconSize = 28;
            btnHangSanXuat.Location = new Point(17, 73);
            btnHangSanXuat.Name = "btnHangSanXuat";
            btnHangSanXuat.Padding = new Padding(0, 4, 0, 0);
            btnHangSanXuat.Size = new Size(150, 36);
            btnHangSanXuat.TabIndex = 20;
            btnHangSanXuat.UseVisualStyleBackColor = false;
            btnHangSanXuat.Click += btnHangSanXuat_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(3, 22, 73);
            label13.Location = new Point(915, 12);
            label13.Name = "label13";
            label13.Size = new Size(39, 20);
            label13.TabIndex = 17;
            label13.Text = "VGA";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(3, 22, 73);
            label12.Location = new Point(699, 12);
            label12.Name = "label12";
            label12.Size = new Size(38, 20);
            label12.TabIndex = 17;
            label12.Text = "CPU";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(3, 22, 73);
            label11.Location = new Point(456, 12);
            label11.Name = "label11";
            label11.Size = new Size(104, 20);
            label11.TabIndex = 17;
            label11.Text = "Nhà cung cấp";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(3, 22, 73);
            label10.Location = new Point(235, 12);
            label10.Name = "label10";
            label10.Size = new Size(95, 20);
            label10.TabIndex = 17;
            label10.Text = "Dòng laptop";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.FromArgb(3, 22, 73);
            label18.Location = new Point(915, 129);
            label18.Name = "label18";
            label18.Size = new Size(47, 20);
            label18.TabIndex = 17;
            label18.Text = "Serial";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.FromArgb(3, 22, 73);
            label17.Location = new Point(699, 129);
            label17.Name = "label17";
            label17.Size = new Size(65, 20);
            label17.TabIndex = 17;
            label17.Text = "Màu sắc";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.FromArgb(3, 22, 73);
            label16.Location = new Point(456, 129);
            label16.Name = "label16";
            label16.Size = new Size(75, 20);
            label16.TabIndex = 17;
            label16.Text = "Màn hình";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.FromArgb(3, 22, 73);
            label15.Location = new Point(235, 129);
            label15.Name = "label15";
            label15.Size = new Size(142, 20);
            label15.TabIndex = 17;
            label15.Text = "Dung lượng ổ cứng";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(3, 22, 73);
            label14.Location = new Point(17, 129);
            label14.Name = "label14";
            label14.Size = new Size(39, 20);
            label14.TabIndex = 17;
            label14.Text = "Ram";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(3, 22, 73);
            label9.Location = new Point(17, 12);
            label9.Name = "label9";
            label9.Size = new Size(107, 20);
            label9.TabIndex = 17;
            label9.Text = "Hãng sản xuất";
            // 
            // panel5
            // 
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1513, 654);
            panel5.TabIndex = 5;
            // 
            // FrmLaptop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1513, 654);
            Controls.Add(panel5);
            Name = "FrmLaptop";
            Text = "FrmLaptop";
            ((System.ComponentModel.ISupportInitialize)dgvLaptop).EndInit();
            panel6.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbHinhAnh).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvLaptop;
        private Panel panel6;
        private Panel panel3;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnClearForm;
        private FontAwesome.Sharp.IconButton btnDoiTT;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnThem;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lb;
        private PictureBox pcbHinhAnh;
        private Panel panel1;
        private TextBox txtTimKiem;
        private FontAwesome.Sharp.IconButton btnGiam;
        private FontAwesome.Sharp.IconButton btnTang;
        private Label label19;
        private Panel panel4;
        private ComboBox cbbSerial;
        private ComboBox cbbMauSac;
        private ComboBox cbbManHinh;
        private ComboBox cbbOCung;
        private ComboBox cbbRam;
        private ComboBox cbbVga;
        private ComboBox cbbCpu;
        private ComboBox cbbNhaCungCap;
        private ComboBox cbbDong;
        private ComboBox cbbHangSanXuat;
        private FontAwesome.Sharp.IconButton btnSerial;
        private FontAwesome.Sharp.IconButton btnMauSac;
        private FontAwesome.Sharp.IconButton btnManHinh;
        private FontAwesome.Sharp.IconButton btnOCung;
        private FontAwesome.Sharp.IconButton btnRam;
        private FontAwesome.Sharp.IconButton btnVga;
        private FontAwesome.Sharp.IconButton btnCpu;
        private FontAwesome.Sharp.IconButton btnNhaCungCap;
        private FontAwesome.Sharp.IconButton btnDongLaptop;
        private FontAwesome.Sharp.IconButton btnHangSanXuat;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label9;
        private Panel panel5;
    }
}