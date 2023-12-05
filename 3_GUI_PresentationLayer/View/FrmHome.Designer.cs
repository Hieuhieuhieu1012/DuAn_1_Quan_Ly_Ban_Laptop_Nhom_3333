namespace _3_GUI_PresentationLayer.View
{
    partial class FrmHome
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
            components = new System.ComponentModel.Container();
            lblClock = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblClock
            // 
            lblClock.AutoSize = true;
            lblClock.FlatStyle = FlatStyle.Flat;
            lblClock.Font = new Font("Adidas 2018 font . King sport (", 80.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblClock.ForeColor = Color.FromArgb(186, 197, 216);
            lblClock.Location = new Point(588, 204);
            lblClock.Margin = new Padding(3, 0, 0, 0);
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(77, 120);
            lblClock.TabIndex = 0;
            lblClock.Text = " ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.SSSSSS;
            pictureBox1.Location = new Point(434, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(687, 705);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // FrmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 245, 255);
            ClientSize = new Size(1537, 729);
            Controls.Add(lblClock);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmHome";
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblClock;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}