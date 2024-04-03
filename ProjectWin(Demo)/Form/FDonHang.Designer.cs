namespace ProjectWin_Demo_
{
    partial class FDonHang
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
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnDonMua = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnDonBan = new Guna.UI2.WinForms.Guna2GradientButton();
            this.PanelDonHang = new System.Windows.Forms.Panel();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.White;
            this.guna2CustomGradientPanel1.Controls.Add(this.btnDonMua);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnDonBan);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1450, 57);
            this.guna2CustomGradientPanel1.TabIndex = 1;
            // 
            // btnDonMua
            // 
            this.btnDonMua.CustomBorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDonMua.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnDonMua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDonMua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDonMua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDonMua.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDonMua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDonMua.FillColor = System.Drawing.Color.Transparent;
            this.btnDonMua.FillColor2 = System.Drawing.Color.Transparent;
            this.btnDonMua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonMua.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDonMua.Location = new System.Drawing.Point(37, 7);
            this.btnDonMua.Name = "btnDonMua";
            this.btnDonMua.Size = new System.Drawing.Size(180, 45);
            this.btnDonMua.TabIndex = 10;
            this.btnDonMua.Text = "Đơn mua";
            this.btnDonMua.Click += new System.EventHandler(this.btnDonMua_Click);
            // 
            // btnDonBan
            // 
            this.btnDonBan.CustomBorderColor = System.Drawing.Color.White;
            this.btnDonBan.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnDonBan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDonBan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDonBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDonBan.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDonBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDonBan.FillColor = System.Drawing.Color.Transparent;
            this.btnDonBan.FillColor2 = System.Drawing.Color.Transparent;
            this.btnDonBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonBan.ForeColor = System.Drawing.Color.Black;
            this.btnDonBan.Location = new System.Drawing.Point(223, 7);
            this.btnDonBan.Name = "btnDonBan";
            this.btnDonBan.Size = new System.Drawing.Size(190, 45);
            this.btnDonBan.TabIndex = 9;
            this.btnDonBan.Text = "Đơn bán";
            this.btnDonBan.Click += new System.EventHandler(this.btnDonBan_Click);
            // 
            // PanelDonHang
            // 
            this.PanelDonHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDonHang.Location = new System.Drawing.Point(0, 57);
            this.PanelDonHang.Name = "PanelDonHang";
            this.PanelDonHang.Size = new System.Drawing.Size(1450, 735);
            this.PanelDonHang.TabIndex = 2;
            // 
            // FDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1450, 792);
            this.Controls.Add(this.PanelDonHang);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FDonHang";
            this.Text = "FOrder";
            this.Load += new System.EventHandler(this.FDonHang_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnDonMua;
        private Guna.UI2.WinForms.Guna2GradientButton btnDonBan;
        private UC.UCDonMua ucPurchaseOrder1;
        private System.Windows.Forms.Panel PanelDonHang;
    }
}