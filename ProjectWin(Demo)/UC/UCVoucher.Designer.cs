namespace ProjectWin_Demo_
{
    partial class UCVoucher
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCVoucher));
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoChon = new Guna.UI2.WinForms.Guna2RadioButton();
            this.lblHSD = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaVoucher = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnApDung = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnApDung);
            this.panel1.Controls.Add(this.rdoChon);
            this.panel1.Controls.Add(this.lblHSD);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblMaVoucher);
            this.panel1.Controls.Add(this.lblSoLuong);
            this.panel1.Controls.Add(this.lblMoTa);
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 118);
            this.panel1.TabIndex = 0;
            // 
            // rdoChon
            // 
            this.rdoChon.AutoSize = true;
            this.rdoChon.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoChon.CheckedState.BorderThickness = 0;
            this.rdoChon.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoChon.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoChon.CheckedState.InnerOffset = -4;
            this.rdoChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoChon.Location = new System.Drawing.Point(441, 52);
            this.rdoChon.Margin = new System.Windows.Forms.Padding(2);
            this.rdoChon.Name = "rdoChon";
            this.rdoChon.Size = new System.Drawing.Size(14, 13);
            this.rdoChon.TabIndex = 38;
            this.rdoChon.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoChon.UncheckedState.BorderThickness = 2;
            this.rdoChon.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoChon.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // lblHSD
            // 
            this.lblHSD.AutoSize = true;
            this.lblHSD.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHSD.ForeColor = System.Drawing.Color.Silver;
            this.lblHSD.Location = new System.Drawing.Point(171, 80);
            this.lblHSD.Name = "lblHSD";
            this.lblHSD.Size = new System.Drawing.Size(56, 21);
            this.lblHSD.TabIndex = 6;
            this.lblHSD.Text = "HSD: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // lblMaVoucher
            // 
            this.lblMaVoucher.AutoSize = true;
            this.lblMaVoucher.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaVoucher.ForeColor = System.Drawing.Color.Silver;
            this.lblMaVoucher.Location = new System.Drawing.Point(171, 44);
            this.lblMaVoucher.Name = "lblMaVoucher";
            this.lblMaVoucher.Size = new System.Drawing.Size(38, 21);
            this.lblMaVoucher.TabIndex = 3;
            this.lblMaVoucher.Text = "Mã:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(459, 5);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(28, 21);
            this.lblSoLuong.TabIndex = 2;
            this.lblSoLuong.Text = "x5";
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoTa.Location = new System.Drawing.Point(171, 8);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(138, 21);
            this.lblMoTa.TabIndex = 1;
            this.lblMoTa.Text = "Giảm tối đa 100k";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(5, 5);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(154, 108);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnApDung
            // 
            this.btnApDung.BorderRadius = 10;
            this.btnApDung.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnApDung.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnApDung.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnApDung.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnApDung.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnApDung.FillColor = System.Drawing.Color.Tomato;
            this.btnApDung.FillColor2 = System.Drawing.Color.DarkOrange;
            this.btnApDung.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApDung.ForeColor = System.Drawing.Color.White;
            this.btnApDung.Location = new System.Drawing.Point(354, 44);
            this.btnApDung.Margin = new System.Windows.Forms.Padding(2);
            this.btnApDung.Name = "btnApDung";
            this.btnApDung.Size = new System.Drawing.Size(119, 37);
            this.btnApDung.TabIndex = 39;
            this.btnApDung.Text = "Áp dụng";
            this.btnApDung.Click += new System.EventHandler(this.btnApDung_Click);
            // 
            // UCVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.panel1);
            this.Name = "UCVoucher";
            this.Size = new System.Drawing.Size(496, 124);
            this.Load += new System.EventHandler(this.UCVoucher_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel panel1;
        public Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        public System.Windows.Forms.Label lblMoTa;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblMaVoucher;
        public System.Windows.Forms.Label lblSoLuong;
        public System.Windows.Forms.Label lblHSD;
        public Guna.UI2.WinForms.Guna2RadioButton rdoChon;
        private Guna.UI2.WinForms.Guna2GradientButton btnApDung;
    }
}
