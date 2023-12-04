﻿namespace _3_GUI_PresentationLayer.View
{
    partial class FrmHangLaptop
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
            dgvHang = new DataGridView();
            panel2 = new Panel();
            btnLamMoi = new FontAwesome.Sharp.IconButton();
            btnSua = new FontAwesome.Sharp.IconButton();
            btnThem = new FontAwesome.Sharp.IconButton();
            txtTen = new CustomControl.TextBoxCustom2_0();
            lbMa = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHang).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dgvHang);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(265, 238);
            panel1.TabIndex = 0;
            // 
            // dgvHang
            // 
            dgvHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHang.Location = new Point(6, 3);
            dgvHang.Name = "dgvHang";
            dgvHang.RowHeadersVisible = false;
            dgvHang.RowTemplate.Height = 25;
            dgvHang.Size = new Size(259, 232);
            dgvHang.TabIndex = 0;
            dgvHang.CellClick += dgvHang_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnLamMoi);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(txtTen);
            panel2.Controls.Add(lbMa);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(294, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(244, 235);
            panel2.TabIndex = 1;
            // 
            // btnLamMoi
            // 
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            btnLamMoi.IconColor = Color.FromArgb(61, 39, 76);
            btnLamMoi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLamMoi.IconSize = 45;
            btnLamMoi.Location = new Point(171, 177);
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
            btnSua.Location = new Point(82, 177);
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
            btnThem.Location = new Point(7, 177);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(53, 37);
            btnThem.TabIndex = 17;
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtTen
            // 
            txtTen.BorderColor = Color.MediumSlateBlue;
            txtTen.BorderFocusColor = Color.HotPink;
            txtTen.BorderRadius = 10;
            txtTen.BorderSize = 1;
            txtTen.Location = new Point(13, 113);
            txtTen.Multiline = false;
            txtTen.Name = "txtTen";
            txtTen.Padding = new Padding(7);
            txtTen.PasswordChar = false;
            txtTen.PlaceholderColor = Color.DarkGray;
            txtTen.PlaceholderText = "";
            txtTen.Size = new Size(200, 30);
            txtTen.TabIndex = 1;
            txtTen.Texts = "";
            txtTen.UnderlinedStyle = false;
            // 
            // lbMa
            // 
            lbMa.AutoSize = true;
            lbMa.BackColor = Color.White;
            lbMa.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbMa.Location = new Point(66, 35);
            lbMa.Name = "lbMa";
            lbMa.Size = new Size(40, 20);
            lbMa.TabIndex = 0;
            lbMa.Text = "1234";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(13, 35);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 90);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên hãng";
            // 
            // FrmHangLaptop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 245, 255);
            ClientSize = new Size(550, 262);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmHangLaptop";
            Text = "FrmHangLaptop";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHang).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvHang;
        private Panel panel2;
        private CustomControl.TextBoxCustom2_0 txtTen;
        private Label lbMa;
        private Label label2;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnThem;
        private FontAwesome.Sharp.IconButton btnLamMoi;
    }
}