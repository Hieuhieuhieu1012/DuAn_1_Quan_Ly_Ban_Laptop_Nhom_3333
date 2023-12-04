namespace _3_GUI_PresentationLayer.View
{
    partial class FrmRam
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
            dgvRam = new DataGridView();
            panel2 = new Panel();
            txtDungLuong = new CustomControl.TextBoxCustom2_0();
            label3 = new Label();
            lbMa = new Label();
            btnLamMoi = new FontAwesome.Sharp.IconButton();
            btnSua = new FontAwesome.Sharp.IconButton();
            btnThem = new FontAwesome.Sharp.IconButton();
            txtTenRam = new CustomControl.TextBoxCustom2_0();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRam).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvRam
            // 
            dgvRam.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRam.Location = new Point(12, 12);
            dgvRam.Name = "dgvRam";
            dgvRam.RowHeadersVisible = false;
            dgvRam.RowTemplate.Height = 25;
            dgvRam.Size = new Size(265, 232);
            dgvRam.TabIndex = 8;
            dgvRam.CellClick += dgvRam_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtDungLuong);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lbMa);
            panel2.Controls.Add(btnLamMoi);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(txtTenRam);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(292, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(244, 232);
            panel2.TabIndex = 9;
            // 
            // txtDungLuong
            // 
            txtDungLuong.BorderColor = Color.MediumSlateBlue;
            txtDungLuong.BorderFocusColor = Color.HotPink;
            txtDungLuong.BorderRadius = 10;
            txtDungLuong.BorderSize = 1;
            txtDungLuong.Location = new Point(13, 139);
            txtDungLuong.Multiline = false;
            txtDungLuong.Name = "txtDungLuong";
            txtDungLuong.Padding = new Padding(7);
            txtDungLuong.PasswordChar = false;
            txtDungLuong.PlaceholderColor = Color.DarkGray;
            txtDungLuong.PlaceholderText = "";
            txtDungLuong.Size = new Size(180, 30);
            txtDungLuong.TabIndex = 22;
            txtDungLuong.Texts = "";
            txtDungLuong.UnderlinedStyle = false;
            txtDungLuong.KeyPress += txtDungLuong_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(13, 115);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 21;
            label3.Text = "Dung lượng";
            // 
            // lbMa
            // 
            lbMa.AutoSize = true;
            lbMa.BackColor = Color.White;
            lbMa.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbMa.Location = new Point(55, 13);
            lbMa.Name = "lbMa";
            lbMa.Size = new Size(40, 20);
            lbMa.TabIndex = 20;
            lbMa.Text = "1234";
            // 
            // btnLamMoi
            // 
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            btnLamMoi.IconColor = Color.FromArgb(61, 39, 76);
            btnLamMoi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLamMoi.IconSize = 45;
            btnLamMoi.Location = new Point(171, 184);
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
            btnSua.IconSize = 45;
            btnSua.Location = new Point(87, 184);
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
            btnThem.IconSize = 45;
            btnThem.Location = new Point(7, 184);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(53, 37);
            btnThem.TabIndex = 17;
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtTenRam
            // 
            txtTenRam.BorderColor = Color.MediumSlateBlue;
            txtTenRam.BorderFocusColor = Color.HotPink;
            txtTenRam.BorderRadius = 10;
            txtTenRam.BorderSize = 1;
            txtTenRam.Location = new Point(13, 77);
            txtTenRam.Multiline = false;
            txtTenRam.Name = "txtTenRam";
            txtTenRam.Padding = new Padding(7);
            txtTenRam.PasswordChar = false;
            txtTenRam.PlaceholderColor = Color.DarkGray;
            txtTenRam.PlaceholderText = "";
            txtTenRam.Size = new Size(211, 30);
            txtTenRam.TabIndex = 1;
            txtTenRam.Texts = "";
            txtTenRam.UnderlinedStyle = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(13, 13);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 50);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên ram";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(199, 147);
            label6.Name = "label6";
            label6.Size = new Size(25, 17);
            label6.TabIndex = 23;
            label6.Text = "GB";
            // 
            // FrmRam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 252);
            Controls.Add(dgvRam);
            Controls.Add(panel2);
            Name = "FrmRam";
            Text = "FrmRam";
            ((System.ComponentModel.ISupportInitialize)dgvRam).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvRam;
        private Panel panel2;
        private Label lbMa;
        private FontAwesome.Sharp.IconButton btnLamMoi;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnThem;
        private CustomControl.TextBoxCustom2_0 txtTenRam;
        private Label label2;
        private Label label1;
        private CustomControl.TextBoxCustom2_0 txtDungLuong;
        private Label label3;
        private Label label6;
    }
}