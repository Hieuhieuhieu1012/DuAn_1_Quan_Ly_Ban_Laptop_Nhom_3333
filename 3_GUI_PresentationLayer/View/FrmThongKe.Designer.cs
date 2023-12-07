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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend16 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title11 = new System.Windows.Forms.DataVisualization.Charting.Title();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea17 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend17 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title12 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea18 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend18 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            btnTimKiemKM = new FontAwesome.Sharp.IconButton();
            dtpEndDate = new CustomControl.DateTimePickerCustom();
            dtpStartDate = new CustomControl.DateTimePickerCustom();
            label1 = new Label();
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
            panel_Top5 = new Panel();
            Chart_Top5 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
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
            panel_Top5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Chart_Top5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(btnTimKiemKM);
            panel1.Controls.Add(dtpEndDate);
            panel1.Controls.Add(dtpStartDate);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-40, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1126, 72);
            panel1.TabIndex = 0;
            // 
            // btnTimKiemKM
            // 
            btnTimKiemKM.BackColor = Color.MediumSlateBlue;
            btnTimKiemKM.FlatAppearance.BorderSize = 0;
            btnTimKiemKM.FlatStyle = FlatStyle.Flat;
            btnTimKiemKM.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimKiemKM.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnTimKiemKM.IconColor = Color.White;
            btnTimKiemKM.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTimKiemKM.IconSize = 23;
            btnTimKiemKM.Location = new Point(909, 21);
            btnTimKiemKM.Name = "btnTimKiemKM";
            btnTimKiemKM.Size = new Size(90, 34);
            btnTimKiemKM.TabIndex = 55;
            btnTimKiemKM.UseVisualStyleBackColor = false;
            btnTimKiemKM.Click += btnTimKiemKM_Click;
            // 
            // dtpEndDate
            // 
            dtpEndDate.BorderColor = Color.PaleVioletRed;
            dtpEndDate.BorderSize = 0;
            dtpEndDate.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dtpEndDate.Location = new Point(524, 20);
            dtpEndDate.MinimumSize = new Size(0, 35);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(320, 35);
            dtpEndDate.SkinColor = Color.MediumSlateBlue;
            dtpEndDate.TabIndex = 6;
            dtpEndDate.TextColor = Color.White;
            // 
            // dtpStartDate
            // 
            dtpStartDate.BorderColor = Color.PaleVioletRed;
            dtpStartDate.BorderSize = 0;
            dtpStartDate.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dtpStartDate.Location = new Point(99, 20);
            dtpStartDate.MinimumSize = new Size(0, 35);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(326, 35);
            dtpStartDate.SkinColor = Color.MediumSlateBlue;
            dtpStartDate.TabIndex = 5;
            dtpStartDate.TextColor = Color.White;
            dtpStartDate.Value = new DateTime(2023, 6, 17, 21, 32, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(451, 21);
            label1.Name = "label1";
            label1.Size = new Size(37, 30);
            label1.TabIndex = 3;
            label1.Text = "---";
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
            lblNumHoaDons.Size = new Size(37, 30);
            lblNumHoaDons.TabIndex = 1;
            lblNumHoaDons.Text = "94";
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
            lblTotalDoanhThu.Size = new Size(203, 30);
            lblTotalDoanhThu.TabIndex = 1;
            lblTotalDoanhThu.Text = "1.627.910.000 VND";
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
            chartArea16.AxisX.IsMarginVisible = false;
            chartArea16.AxisX.LineColor = Color.FromArgb(255, 192, 192);
            chartArea16.AxisX.MajorGrid.LineColor = Color.FromArgb(255, 192, 192);
            chartArea16.AxisX.MajorGrid.LineWidth = 0;
            chartArea16.AxisX.MajorTickMark.Size = 3F;
            chartArea16.AxisY.LineWidth = 0;
            chartArea16.AxisY.MajorGrid.LineColor = Color.FromArgb(255, 192, 192);
            chartArea16.AxisY.MajorTickMark.LineColor = Color.FromArgb(255, 192, 192);
            chartArea16.AxisY.MajorTickMark.LineWidth = 0;
            chartArea16.Name = "ChartArea1";
            chartDoanhThu.ChartAreas.Add(chartArea16);
            chartDoanhThu.Dock = DockStyle.Fill;
            legend16.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend16.Name = "Legend1";
            chartDoanhThu.Legends.Add(legend16);
            chartDoanhThu.Location = new Point(0, 0);
            chartDoanhThu.Name = "chartDoanhThu";
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series16.IsXValueIndexed = true;
            series16.Legend = "Legend1";
            series16.Name = "Số lượng máy bán ra";
            chartDoanhThu.Series.Add(series16);
            chartDoanhThu.Size = new Size(1069, 248);
            chartDoanhThu.TabIndex = 4;
            chartDoanhThu.Text = "Doanh Thu";
            title11.Alignment = ContentAlignment.TopLeft;
            title11.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            title11.Name = "Title1";
            title11.Text = "Biểu đồ doanh thu";
            chartDoanhThu.Titles.Add(title11);
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
            lblNumProducts.Size = new Size(36, 20);
            lblNumProducts.TabIndex = 2;
            lblNumProducts.Text = "130";
            // 
            // lblNumNhaCungCaps
            // 
            lblNumNhaCungCaps.AutoSize = true;
            lblNumNhaCungCaps.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumNhaCungCaps.ForeColor = Color.FromArgb(2, 76, 94);
            lblNumNhaCungCaps.Location = new Point(75, 113);
            lblNumNhaCungCaps.Name = "lblNumNhaCungCaps";
            lblNumNhaCungCaps.Size = new Size(27, 20);
            lblNumNhaCungCaps.TabIndex = 2;
            lblNumNhaCungCaps.Text = "13";
            // 
            // lblNumCustomers
            // 
            lblNumCustomers.AutoSize = true;
            lblNumCustomers.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumCustomers.ForeColor = Color.FromArgb(2, 76, 94);
            lblNumCustomers.Location = new Point(75, 58);
            lblNumCustomers.Name = "lblNumCustomers";
            lblNumCustomers.Size = new Size(36, 20);
            lblNumCustomers.TabIndex = 2;
            lblNumCustomers.Text = "184";
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
            label7.Size = new Size(176, 21);
            label7.TabIndex = 0;
            label7.Text = "Số lượng nhà cung cấp";
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
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(214, 248, 248);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(214, 248, 248);
            dataGridViewCellStyle11.SelectionForeColor = Color.Black;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgvUnderStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(214, 248, 248);
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(240, 101, 88);
            dataGridViewCellStyle12.SelectionForeColor = Color.White;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dgvUnderStock.DefaultCellStyle = dataGridViewCellStyle12;
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
            // panel_Top5
            // 
            panel_Top5.BackColor = Color.White;
            panel_Top5.Controls.Add(Chart_Top5);
            panel_Top5.Location = new Point(1113, 12);
            panel_Top5.Name = "panel_Top5";
            panel_Top5.Size = new Size(383, 657);
            panel_Top5.TabIndex = 3;
            // 
            // Chart_Top5
            // 
            chartArea17.Name = "ChartArea1";
            Chart_Top5.ChartAreas.Add(chartArea17);
            legend17.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            legend17.HeaderSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            legend17.IsTextAutoFit = false;
            legend17.Name = "Legend1";
            legend17.Position.Auto = false;
            legend17.Position.Height = 15.4408188F;
            legend17.Position.Width = 65.03957F;
            legend17.Position.X = 5F;
            legend17.Position.Y = 84.55918F;
            legend17.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide;
            legend17.Title = "Chú thích";
            Chart_Top5.Legends.Add(legend17);
            Chart_Top5.Location = new Point(3, 3);
            Chart_Top5.Name = "Chart_Top5";
            Chart_Top5.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            Chart_Top5.PaletteCustomColors = new Color[]
    {
    Color.FromArgb(192, 255, 192)
    };
            Chart_Top5.RightToLeft = RightToLeft.No;
            series17.BackSecondaryColor = Color.FromArgb(255, 224, 192);
            series17.BorderColor = SystemColors.ControlDark;
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series17.Color = Color.White;
            series17.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            series17.IsValueShownAsLabel = true;
            series17.IsXValueIndexed = true;
            series17.LabelBackColor = Color.Transparent;
            series17.LabelBorderColor = Color.Transparent;
            series17.Legend = "Legend1";
            series17.Name = "charttop5";
            series17.ShadowColor = SystemColors.ActiveCaptionText;
            series17.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            Chart_Top5.Series.Add(series17);
            Chart_Top5.Size = new Size(380, 654);
            Chart_Top5.SuppressExceptions = true;
            Chart_Top5.TabIndex = 4;
            Chart_Top5.Text = "Top 5 Laptop bán chạy";
            title12.BorderWidth = 5;
            title12.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            title12.ForeColor = Color.IndianRed;
            title12.Name = "Title1";
            title12.ShadowColor = Color.Black;
            title12.Text = "Top 5 LapTop bán chạy ";
            Chart_Top5.Titles.Add(title12);
            // 
            // chart2
            // 
            chartArea18.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea18);
            legend18.Name = "Legend1";
            chart2.Legends.Add(legend18);
            chart2.Location = new Point(1498, 141);
            chart2.Name = "chart2";
            series18.ChartArea = "ChartArea1";
            series18.Legend = "Legend1";
            series18.Name = "Series1";
            chart2.Series.Add(series18);
            chart2.Size = new Size(300, 300);
            chart2.TabIndex = 4;
            chart2.Text = "chart2";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.Location = new Point(0, 0);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(32, 32);
            iconPictureBox1.TabIndex = 56;
            iconPictureBox1.TabStop = false;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(0, 0);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(75, 23);
            iconButton1.TabIndex = 5;
            iconButton1.Text = "iconButton1";
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(8, 8);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(75, 23);
            iconButton2.TabIndex = 6;
            iconButton2.Text = "iconButton2";
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // FrmThongKe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 245, 255);
            ClientSize = new Size(1521, 690);
            Controls.Add(iconButton2);
            Controls.Add(iconButton1);
            Controls.Add(chart2);
            Controls.Add(panel_Top5);
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
            panel_Top5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Chart_Top5).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
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
        private Panel panel_Top5;
        private Label lblNumProducts;
        private Label lblNumNhaCungCaps;
        private Label lblNumCustomers;
        private Label label8;
        private Label label7;
        private Label label12;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private DataGridView dgvUnderStock;
        private Label lblNumHoaDons;
        private Label lblTotalDoanhThu;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Top5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private CustomControl.DateTimePickerCustom dtpEndDate;
        private CustomControl.DateTimePickerCustom dtpStartDate;
        private FontAwesome.Sharp.IconButton btnTimKiemKM;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}