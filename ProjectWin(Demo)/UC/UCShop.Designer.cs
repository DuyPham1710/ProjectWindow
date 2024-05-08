namespace ProjectWin_Demo_
{
    partial class UCShop
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
            this.components = new System.ComponentModel.Container();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.btnGheShop = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblSoSanPham = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pcbAvt = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAvt)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(127, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(224, 23);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Điện máy xanh";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(148, 48);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(67, 13);
            this.lblDiaChi.TabIndex = 3;
            this.lblDiaChi.Text = "Hồ Chí Minh";
            // 
            // btnGheShop
            // 
            this.btnGheShop.BorderColor = System.Drawing.Color.White;
            this.btnGheShop.BorderRadius = 10;
            this.btnGheShop.BorderThickness = 1;
            this.btnGheShop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGheShop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGheShop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGheShop.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGheShop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGheShop.FillColor = System.Drawing.Color.Transparent;
            this.btnGheShop.FillColor2 = System.Drawing.Color.Transparent;
            this.btnGheShop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGheShop.ForeColor = System.Drawing.Color.DarkGray;
            this.btnGheShop.Location = new System.Drawing.Point(704, 18);
            this.btnGheShop.Name = "btnGheShop";
            this.btnGheShop.Size = new System.Drawing.Size(119, 36);
            this.btnGheShop.TabIndex = 4;
            this.btnGheShop.Text = "Ghé shop >>";
            this.btnGheShop.Click += new System.EventHandler(this.btnGheShop_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 9;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lblSoSanPham
            // 
            this.lblSoSanPham.AutoSize = true;
            this.lblSoSanPham.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoSanPham.Location = new System.Drawing.Point(409, 30);
            this.lblSoSanPham.Name = "lblSoSanPham";
            this.lblSoSanPham.Size = new System.Drawing.Size(127, 19);
            this.lblSoSanPham.TabIndex = 5;
            this.lblSoSanPham.Text = "Tổng: 5 Sản phẩm";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::ProjectWin_Demo_.Properties.Resources.Ionic_Ionicons_Location_outline_48;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(124, 43);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(20, 20);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            // 
            // pcbAvt
            // 
            this.pcbAvt.Image = global::ProjectWin_Demo_.Properties.Resources.z5217272932631_72c73dc409773a73013edce5ca74c052;
            this.pcbAvt.ImageRotate = 0F;
            this.pcbAvt.Location = new System.Drawing.Point(30, 7);
            this.pcbAvt.Name = "pcbAvt";
            this.pcbAvt.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pcbAvt.Size = new System.Drawing.Size(64, 64);
            this.pcbAvt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbAvt.TabIndex = 0;
            this.pcbAvt.TabStop = false;
            // 
            // UCShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.lblSoSanPham);
            this.Controls.Add(this.btnGheShop);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pcbAvt);
            this.Name = "UCShop";
            this.Size = new System.Drawing.Size(850, 80);
            this.Load += new System.EventHandler(this.UCShop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAvt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox pcbAvt;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label lblDiaChi;
        private Guna.UI2.WinForms.Guna2GradientButton btnGheShop;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lblSoSanPham;
    }
}