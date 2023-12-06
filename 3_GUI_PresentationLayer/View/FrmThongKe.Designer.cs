namespace _3_GUI_PresentationLayer.View
{
    partial class FrmThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            panel1 = new Panel();
            label1 = new Label();
            dtpStartDate = new CustomControl.DateTimePickerCustom();
            dtpEndDate = new CustomControl.DateTimePickerCustom();
            btnOk = new CustomControl.ButtonCustom();
            btnCustom = new CustomControl.ButtonCustom();
            btnToday = new CustomControl.ButtonCustom();
            btnLast7Days = new CustomControl.ButtonCustom();
            btnThisMonth = new CustomControl.ButtonCustom();
            panel2 = new Panel();
            pictureBox5 = new PictureBox();
            lblNumHoaDons = new Label();
            label2 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            pictureBox4 = new PictureBox();
            lblTotalDoanhThu = new Label();
            label4 = new Label();
            panel5 = new Panel();
            chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel6 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lblNumProducts = new Label();
            lblNumNhaCungCaps = new Label();
            lblNumCustomers = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            panel7 = new Panel();
            dgvUnderStock = new DataGridView();
            label12 = new Label();
            panel8 = new Panel();
            chartTop5 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDoanhThu).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUnderStock).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartTop5).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dtpStartDate);
            panel1.Controls.Add(dtpEndDate);
            panel1.Controls.Add(btnOk);
            panel1.Controls.Add(btnCustom);
            panel1.Controls.Add(btnToday);
            panel1.Controls.Add(btnLast7Days);
            panel1.Controls.Add(btnThisMonth);
            panel1.Location = new Point(20, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1476, 72);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(192, 32);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 3;
            label1.Text = "---";
            // 
            // dtpStartDate
            // 
            dtpStartDate.BorderColor = Color.PaleVioletRed;
            dtpStartDate.BorderSize = 0;
            dtpStartDate.Enabled = false;
            dtpStartDate.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(49, 21);
            dtpStartDate.MinimumSize = new Size(0, 35);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(131, 35);
            dtpStartDate.SkinColor = Color.MediumSlateBlue;
            dtpStartDate.TabIndex = 2;
            dtpStartDate.TabStop = false;
            dtpStartDate.TextColor = Color.White;
            // 
            // dtpEndDate
            // 
            dtpEndDate.BorderColor = Color.PaleVioletRed;
            dtpEndDate.BorderSize = 0;
            dtpEndDate.Enabled = false;
            dtpEndDate.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(220, 20);
            dtpEndDate.MinimumSize = new Size(0, 35);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(135, 35);
            dtpEndDate.SkinColor = Color.MediumSlateBlue;
            dtpEndDate.TabIndex = 1;
            dtpEndDate.TextColor = Color.White;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.MediumSlateBlue;
            btnOk.BackgroundColor = Color.MediumSlateBlue;
            btnOk.BorderColor = Color.PaleVioletRed;
            btnOk.BorderRadius = 10;
            btnOk.BorderSize = 0;
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.ForeColor = Color.White;
            btnOk.Image = Properties.Resources.check;
            btnOk.Location = new Point(404, 17);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(41, 40);
            btnOk.TabIndex = 0;
            btnOk.TextColor = Color.White;
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Visible = false;
            btnOk.Click += btnOk_Click;
            // 
            // btnCustom
            // 
            btnCustom.BackColor = Color.MediumSlateBlue;
            btnCustom.BackgroundColor = Color.MediumSlateBlue;
            btnCustom.BorderColor = Color.PaleVioletRed;
            btnCustom.BorderRadius = 10;
            btnCustom.BorderSize = 0;
            btnCustom.FlatAppearance.BorderSize = 0;
            btnCustom.FlatStyle = FlatStyle.Flat;
            btnCustom.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCustom.ForeColor = Color.White;
            btnCustom.Location = new Point(455, 17);
            btnCustom.Name = "btnCustom";
            btnCustom.Size = new Size(195, 40);
            btnCustom.TabIndex = 0;
            btnCustom.Text = "Tùy chọn";
            btnCustom.TextColor = Color.White;
            btnCustom.UseVisualStyleBackColor = false;
            btnCustom.Click += btnCustom_Click;
            // 
            // btnToday
            // 
            btnToday.BackColor = Color.MediumSlateBlue;
            btnToday.BackgroundColor = Color.MediumSlateBlue;
            btnToday.BorderColor = Color.PaleVioletRed;
            btnToday.BorderRadius = 10;
            btnToday.BorderSize = 0;
            btnToday.FlatAppearance.BorderSize = 0;
            btnToday.FlatStyle = FlatStyle.Flat;
            btnToday.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnToday.ForeColor = Color.White;
            btnToday.Location = new Point(705, 16);
            btnToday.Name = "btnToday";
            btnToday.Size = new Size(195, 40);
            btnToday.TabIndex = 0;
            btnToday.Text = "Hôm nay";
            btnToday.TextColor = Color.White;
            btnToday.UseVisualStyleBackColor = false;
            btnToday.Click += btnToday_Click;
            // 
            // btnLast7Days
            // 
            btnLast7Days.BackColor = Color.MediumSlateBlue;
            btnLast7Days.BackgroundColor = Color.MediumSlateBlue;
            btnLast7Days.BorderColor = Color.PaleVioletRed;
            btnLast7Days.BorderRadius = 10;
            btnLast7Days.BorderSize = 0;
            btnLast7Days.FlatAppearance.BorderSize = 0;
            btnLast7Days.FlatAppearance.MouseOverBackColor = Color.SlateBlue;
            btnLast7Days.FlatStyle = FlatStyle.Flat;
            btnLast7Days.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLast7Days.ForeColor = Color.White;
            btnLast7Days.Location = new Point(951, 15);
            btnLast7Days.Name = "btnLast7Days";
            btnLast7Days.Size = new Size(195, 40);
            btnLast7Days.TabIndex = 0;
            btnLast7Days.Text = "7 ngày gần nhất";
            btnLast7Days.TextColor = Color.White;
            btnLast7Days.UseVisualStyleBackColor = false;
            btnLast7Days.Click += btnLast7Days_Click;
            // 
            // btnThisMonth
            // 
            btnThisMonth.BackColor = Color.MediumSlateBlue;
            btnThisMonth.BackgroundColor = Color.MediumSlateBlue;
            btnThisMonth.BorderColor = Color.PaleVioletRed;
            btnThisMonth.BorderRadius = 10;
            btnThisMonth.BorderSize = 0;
            btnThisMonth.FlatAppearance.BorderSize = 0;
            btnThisMonth.FlatStyle = FlatStyle.Flat;
            btnThisMonth.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThisMonth.ForeColor = Color.White;
            btnThisMonth.Location = new Point(1184, 16);
            btnThisMonth.Name = "btnThisMonth";
            btnThisMonth.Size = new Size(201, 40);
            btnThisMonth.TabIndex = 0;
            btnThisMonth.Text = "Tháng này";
            btnThisMonth.TextColor = Color.White;
            btnThisMonth.UseVisualStyleBackColor = false;
            btnThisMonth.Click += btnThisMonth_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(lblNumHoaDons);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(20, 97);
            panel2.Name = "panel2";
            panel2.Size = new Size(476, 72);
            panel2.TabIndex = 1;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.invoice;
            pictureBox5.Location = new Point(5, 5);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(60, 60);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 3;
            pictureBox5.TabStop = false;
            // 
            // lblNumHoaDons
            // 
            lblNumHoaDons.AutoSize = true;
            lblNumHoaDons.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumHoaDons.ForeColor = Color.FromArgb(2, 76, 94);
            lblNumHoaDons.Location = new Point(132, 29);
            lblNumHoaDons.Name = "lblNumHoaDons";
            lblNumHoaDons.Size = new Size(126, 30);
            lblNumHoaDons.TabIndex = 1;
            lblNumHoaDons.Text = "Số hóa đơn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(145, 158, 194);
            label2.Location = new Point(83, 0);
            label2.Name = "label2";
            label2.Size = new Size(110, 25);
            label2.TabIndex = 0;
            label2.Text = "Số hóa đơn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(145, 158, 194);
            label3.Location = new Point(75, 33);
            label3.Name = "label3";
            label3.Size = new Size(115, 21);
            label3.TabIndex = 0;
            label3.Text = "Số khách hàng";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(lblTotalDoanhThu);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(539, 97);
            panel3.Name = "panel3";
            panel3.Size = new Size(547, 72);
            panel3.TabIndex = 2;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.revenue;
            pictureBox4.Location = new Point(5, 6);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(60, 60);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // lblTotalDoanhThu
            // 
            lblTotalDoanhThu.AutoSize = true;
            lblTotalDoanhThu.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalDoanhThu.ForeColor = Color.FromArgb(2, 76, 94);
            lblTotalDoanhThu.Location = new Point(124, 29);
            lblTotalDoanhThu.Name = "lblTotalDoanhThu";
            lblTotalDoanhThu.Size = new Size(173, 30);
            lblTotalDoanhThu.TabIndex = 1;
            lblTotalDoanhThu.Text = "Tổng doanh thu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(145, 158, 194);
            label4.Location = new Point(88, 0);
            label4.Name = "label4";
            label4.Size = new Size(148, 25);
            label4.TabIndex = 0;
            label4.Text = "Tổng doanh thu";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(chartDoanhThu);
            panel5.Location = new Point(20, 186);
            panel5.Name = "panel5";
            panel5.Size = new Size(1069, 248);
            panel5.TabIndex = 2;
            // 
            // chartDoanhThu
            // 
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LineColor = Color.FromArgb(255, 192, 192);
            chartArea1.AxisX.MajorGrid.LineColor = Color.FromArgb(255, 192, 192);
            chartArea1.AxisX.MajorGrid.LineWidth = 0;
            chartArea1.AxisX.MajorTickMark.Size = 3F;
            chartArea1.AxisY.LineWidth = 0;
            chartArea1.AxisY.MajorGrid.LineColor = Color.FromArgb(255, 192, 192);
            chartArea1.AxisY.MajorTickMark.LineColor = Color.FromArgb(255, 192, 192);
            chartArea1.AxisY.MajorTickMark.LineWidth = 0;
            chartArea1.Name = "ChartArea1";
            chartDoanhThu.ChartAreas.Add(chartArea1);
            chartDoanhThu.Dock = DockStyle.Fill;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            chartDoanhThu.Legends.Add(legend1);
            chartDoanhThu.Location = new Point(0, 0);
            chartDoanhThu.Name = "chartDoanhThu";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series1.BackSecondaryColor = Color.FromArgb(107, 83, 255);
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Color = Color.FromArgb(241, 88, 127);
            series1.Legend = "Legend1";
            series1.MarkerColor = Color.FromArgb(255, 128, 255);
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Series1";
            chartDoanhThu.Series.Add(series1);
            chartDoanhThu.Size = new Size(1069, 248);
            chartDoanhThu.TabIndex = 4;
            chartDoanhThu.Text = "chart1";
            title1.Alignment = ContentAlignment.TopLeft;
            title1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            title1.Name = "Title1";
            title1.Text = "Biểu đồ doanh thu";
            chartDoanhThu.Titles.Add(title1);
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(pictureBox3);
            panel6.Controls.Add(pictureBox2);
            panel6.Controls.Add(pictureBox1);
            panel6.Controls.Add(lblNumProducts);
            panel6.Controls.Add(lblNumNhaCungCaps);
            panel6.Controls.Add(lblNumCustomers);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(label7);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(label6);
            panel6.Location = new Point(20, 452);
            panel6.Name = "panel6";
            panel6.Size = new Size(273, 217);
            panel6.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.product;
            pictureBox3.Location = new Point(5, 155);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 48);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.supplier;
            pictureBox2.Location = new Point(5, 92);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.customer;
            pictureBox1.Location = new Point(5, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblNumProducts
            // 
            lblNumProducts.AutoSize = true;
            lblNumProducts.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumProducts.ForeColor = Color.FromArgb(2, 76, 94);
            lblNumProducts.Location = new Point(75, 180);
            lblNumProducts.Name = "lblNumProducts";
            lblNumProducts.Size = new Size(45, 20);
            lblNumProducts.TabIndex = 2;
            lblNumProducts.Text = "1000";
            // 
            // lblNumNhaCungCaps
            // 
            lblNumNhaCungCaps.AutoSize = true;
            lblNumNhaCungCaps.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumNhaCungCaps.ForeColor = Color.FromArgb(2, 76, 94);
            lblNumNhaCungCaps.Location = new Point(75, 113);
            lblNumNhaCungCaps.Name = "lblNumNhaCungCaps";
            lblNumNhaCungCaps.Size = new Size(45, 20);
            lblNumNhaCungCaps.TabIndex = 2;
            lblNumNhaCungCaps.Text = "1000";
            // 
            // lblNumCustomers
            // 
            lblNumCustomers.AutoSize = true;
            lblNumCustomers.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumCustomers.ForeColor = Color.FromArgb(2, 76, 94);
            lblNumCustomers.Location = new Point(75, 58);
            lblNumCustomers.Name = "lblNumCustomers";
            lblNumCustomers.Size = new Size(45, 20);
            lblNumCustomers.TabIndex = 2;
            lblNumCustomers.Text = "1000";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(145, 158, 194);
            label8.Location = new Point(70, 155);
            label8.Name = "label8";
            label8.Size = new Size(157, 21);
            label8.TabIndex = 0;
            label8.Text = "Số Laptop đang bán";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(145, 158, 194);
            label7.Location = new Point(75, 92);
            label7.Name = "label7";
            label7.Size = new Size(129, 21);
            label7.TabIndex = 0;
            label7.Text = "Số nhà cung cấp";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(2, 76, 94);
            label6.Location = new Point(18, 0);
            label6.Name = "label6";
            label6.Size = new Size(144, 25);
            label6.TabIndex = 1;
            label6.Text = "Thông tin thêm";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(214, 248, 248);
            panel7.Controls.Add(dgvUnderStock);
            panel7.Controls.Add(label12);
            panel7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel7.Location = new Point(321, 455);
            panel7.Name = "panel7";
            panel7.Size = new Size(768, 214);
            panel7.TabIndex = 3;
            // 
            // dgvUnderStock
            // 
            dgvUnderStock.AllowUserToAddRows = false;
            dgvUnderStock.AllowUserToResizeRows = false;
            dgvUnderStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUnderStock.BackgroundColor = Color.FromArgb(214, 248, 248);
            dgvUnderStock.BorderStyle = BorderStyle.None;
            dgvUnderStock.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUnderStock.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(214, 248, 248);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(214, 248, 248);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUnderStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(214, 248, 248);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(240, 101, 88);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUnderStock.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUnderStock.EnableHeadersVisualStyles = false;
            dgvUnderStock.GridColor = Color.FromArgb(145, 158, 194);
            dgvUnderStock.Location = new Point(17, 30);
            dgvUnderStock.Name = "dgvUnderStock";
            dgvUnderStock.RowHeadersVisible = false;
            dgvUnderStock.RowTemplate.Height = 35;
            dgvUnderStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUnderStock.Size = new Size(737, 173);
            dgvUnderStock.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(2, 76, 94);
            label12.Location = new Point(17, -3);
            label12.Name = "label12";
            label12.Size = new Size(212, 25);
            label12.TabIndex = 3;
            label12.Text = "Sản phẩm sắp hết hàng";
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(chartTop5);
            panel8.Location = new Point(1113, 97);
            panel8.Name = "panel8";
            panel8.Size = new Size(383, 572);
            panel8.TabIndex = 3;
            // 
            // chartTop5
            // 
            chartArea2.Name = "ChartArea1";
            chartTop5.ChartAreas.Add(chartArea2);
            chartTop5.Dock = DockStyle.Fill;
            legend2.BorderColor = Color.White;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            legend2.TitleFont = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            chartTop5.Legends.Add(legend2);
            chartTop5.Location = new Point(0, 0);
            chartTop5.Name = "chartTop5";
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series2.BackSecondaryColor = Color.FromArgb(255, 128, 255);
            series2.BorderColor = Color.White;
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartTop5.Series.Add(series2);
            chartTop5.Size = new Size(383, 572);
            chartTop5.TabIndex = 5;
            chartTop5.Text = "chart2";
            title2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            title2.Name = "Title1";
            title2.Text = "Top 5 lapotp bán chạy";
            chartTop5.Titles.Add(title2);
            // 
            // FrmThongKe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 245, 255);
            ClientSize = new Size(1521, 690);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmThongKe";
            Text = "Thống kê";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartDoanhThu).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUnderStock).EndInit();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartTop5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private CustomControl.DateTimePickerCustom dtpStartDate;
        private CustomControl.DateTimePickerCustom dtpEndDate;
        private CustomControl.ButtonCustom btnOk;
        private CustomControl.ButtonCustom btnCustom;
        private CustomControl.ButtonCustom btnToday;
        private CustomControl.ButtonCustom btnLast7Days;
        private CustomControl.ButtonCustom btnThisMonth;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Panel panel3;
        private Label label4;
        private Panel panel5;
        private Panel panel6;
        private Label label6;
        private Panel panel7;
        private Panel panel8;
        private Label lblNumProducts;
        private Label lblNumNhaCungCaps;
        private Label lblNumCustomers;
        private Label label8;
        private Label label7;
        private Label label12;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTop5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private DataGridView dgvUnderStock;
        private Label lblNumHoaDons;
        private Label lblTotalDoanhThu;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
    }
}