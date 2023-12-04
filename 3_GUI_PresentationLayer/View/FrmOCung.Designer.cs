namespace _3_GUI_PresentationLayer.View
{
    partial class FrmOCung
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
            panel2 = new Panel();
            txtDungLuong = new CustomControl.TextBoxCustom2_0();
            rbtnSdd = new CustomControl.RadioButtonCustom();
            rbtnHdd = new CustomControl.RadioButtonCustom();
            btnLamMoi = new FontAwesome.Sharp.IconButton();
            btnSua = new FontAwesome.Sharp.IconButton();
            btnThem = new FontAwesome.Sharp.IconButton();
            txtTenOCung = new CustomControl.TextBoxCustom2_0();
            lbMa = new Label();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            dgvOCung = new DataGridView();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOCung).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtDungLuong);
            panel2.Controls.Add(rbtnSdd);
            panel2.Controls.Add(rbtnHdd);
            panel2.Controls.Add(btnLamMoi);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(txtTenOCung);
            panel2.Controls.Add(lbMa);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(286, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 237);
            panel2.TabIndex = 4;
            // 
            // txtDungLuong
            // 
            txtDungLuong.BorderColor = Color.DarkOrchid;
            txtDungLuong.BorderFocusColor = Color.HotPink;
            txtDungLuong.BorderRadius = 10;
            txtDungLuong.BorderSize = 2;
            txtDungLuong.Location = new Point(99, 142);
            txtDungLuong.Multiline = false;
            txtDungLuong.Name = "txtDungLuong";
            txtDungLuong.Padding = new Padding(7);
            txtDungLuong.PasswordChar = false;
            txtDungLuong.PlaceholderColor = Color.DarkGray;
            txtDungLuong.PlaceholderText = "";
            txtDungLuong.Size = new Size(95, 30);
            txtDungLuong.TabIndex = 21;
            txtDungLuong.Texts = "";
            txtDungLuong.UnderlinedStyle = true;
            txtDungLuong.KeyPress += txtDungLuong_KeyPress;
            // 
            // rbtnSdd
            // 
            rbtnSdd.AutoSize = true;
            rbtnSdd.CheckedColor = Color.MediumSlateBlue;
            rbtnSdd.Location = new Point(158, 107);
            rbtnSdd.MinimumSize = new Size(0, 21);
            rbtnSdd.Name = "rbtnSdd";
            rbtnSdd.Padding = new Padding(10, 0, 0, 0);
            rbtnSdd.Size = new Size(55, 21);
            rbtnSdd.TabIndex = 20;
            rbtnSdd.TabStop = true;
            rbtnSdd.Text = "SSD";
            rbtnSdd.UnCheckedColor = Color.Gray;
            rbtnSdd.UseVisualStyleBackColor = true;
            // 
            // rbtnHdd
            // 
            rbtnHdd.AutoSize = true;
            rbtnHdd.CheckedColor = Color.MediumSlateBlue;
            rbtnHdd.Location = new Point(77, 107);
            rbtnHdd.MinimumSize = new Size(0, 21);
            rbtnHdd.Name = "rbtnHdd";
            rbtnHdd.Padding = new Padding(10, 0, 0, 0);
            rbtnHdd.Size = new Size(60, 21);
            rbtnHdd.TabIndex = 20;
            rbtnHdd.TabStop = true;
            rbtnHdd.Text = "HDD";
            rbtnHdd.UnCheckedColor = Color.Gray;
            rbtnHdd.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            btnLamMoi.IconColor = Color.FromArgb(61, 39, 76);
            btnLamMoi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLamMoi.IconSize = 40;
            btnLamMoi.Location = new Point(184, 194);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(53, 37);
            btnLamMoi.TabIndex = 19;
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnSua
            // 
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.IconChar = FontAwesome.Sharp.IconChar.Pen;
            btnSua.IconColor = Color.FromArgb(61, 39, 76);
            btnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSua.IconSize = 40;
            btnSua.Location = new Point(97, 195);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(53, 37);
            btnSua.TabIndex = 18;
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnThem.IconColor = Color.FromArgb(61, 39, 76);
            btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnThem.IconSize = 40;
            btnThem.Location = new Point(7, 195);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(53, 37);
            btnThem.TabIndex = 17;
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtTenOCung
            // 
            txtTenOCung.BorderColor = Color.DarkOrchid;
            txtTenOCung.BorderFocusColor = Color.HotPink;
            txtTenOCung.BorderRadius = 10;
            txtTenOCung.BorderSize = 2;
            txtTenOCung.Location = new Point(13, 68);
            txtTenOCung.Multiline = false;
            txtTenOCung.Name = "txtTenOCung";
            txtTenOCung.Padding = new Padding(7);
            txtTenOCung.PasswordChar = false;
            txtTenOCung.PlaceholderColor = Color.DarkGray;
            txtTenOCung.PlaceholderText = "";
            txtTenOCung.Size = new Size(221, 30);
            txtTenOCung.TabIndex = 1;
            txtTenOCung.Texts = "";
            txtTenOCung.UnderlinedStyle = true;
            // 
            // lbMa
            // 
            lbMa.AutoSize = true;
            lbMa.BackColor = Color.White;
            lbMa.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbMa.Location = new Point(66, 5);
            lbMa.Name = "lbMa";
            lbMa.Size = new Size(34, 17);
            lbMa.TabIndex = 0;
            lbMa.Text = "1234";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(13, 5);
            label2.Name = "label2";
            label2.Size = new Size(27, 17);
            label2.TabIndex = 0;
            label2.Text = "Mã";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(13, 149);
            label5.Name = "label5";
            label5.Size = new Size(80, 17);
            label5.TabIndex = 0;
            label5.Text = "Dung lượng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(203, 152);
            label6.Name = "label6";
            label6.Size = new Size(25, 17);
            label6.TabIndex = 0;
            label6.Text = "GB";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(13, 111);
            label4.Name = "label4";
            label4.Size = new Size(32, 17);
            label4.TabIndex = 0;
            label4.Text = "Loại";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 33);
            label1.Name = "label1";
            label1.Size = new Size(75, 17);
            label1.TabIndex = 0;
            label1.Text = "Tên ổ cứng";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dgvOCung);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(265, 240);
            panel1.TabIndex = 3;
            // 
            // dgvOCung
            // 
            dgvOCung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOCung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOCung.Location = new Point(6, 3);
            dgvOCung.Name = "dgvOCung";
            dgvOCung.RowHeadersVisible = false;
            dgvOCung.RowTemplate.Height = 25;
            dgvOCung.Size = new Size(259, 232);
            dgvOCung.TabIndex = 0;
            dgvOCung.CellClick += dgvOCung_CellClick;
            // 
            // FrmOCung
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 259);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmOCung";
            Text = "FrmOCung";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOCung).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private CustomControl.RadioButtonCustom rbtnSdd;
        private CustomControl.RadioButtonCustom rbtnHdd;
        private FontAwesome.Sharp.IconButton btnLamMoi;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnThem;
        private CustomControl.TextBoxCustom2_0 txtTenOCung;
        private Label lbMa;
        private Label label2;
        private Label label4;
        private Label label1;
        private Panel panel1;
        private DataGridView dgvOCung;
        private CustomControl.TextBoxCustom2_0 txtDungLuong;
        private Label label5;
        private Label label6;
    }
}