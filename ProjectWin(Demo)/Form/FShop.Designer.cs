namespace ProjectWin_Demo_
{
    partial class FShop
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
            this.fPanelShop = new System.Windows.Forms.FlowLayoutPanel();
            this.btnShopTheoDoi = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnTatCaShop = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnUyTin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnItUyTin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fPanelShop
            // 
            this.fPanelShop.AutoScroll = true;
            this.fPanelShop.BackColor = System.Drawing.Color.White;
            this.fPanelShop.Location = new System.Drawing.Point(232, 89);
            this.fPanelShop.Name = "fPanelShop";
            this.fPanelShop.Size = new System.Drawing.Size(887, 624);
            this.fPanelShop.TabIndex = 1;
            // 
            // btnShopTheoDoi
            // 
            this.btnShopTheoDoi.Animated = true;
            this.btnShopTheoDoi.BackColor = System.Drawing.Color.Transparent;
            this.btnShopTheoDoi.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.btnShopTheoDoi.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnShopTheoDoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShopTheoDoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShopTheoDoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShopTheoDoi.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShopTheoDoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShopTheoDoi.FillColor = System.Drawing.Color.Transparent;
            this.btnShopTheoDoi.FillColor2 = System.Drawing.Color.Transparent;
            this.btnShopTheoDoi.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnShopTheoDoi.ForeColor = System.Drawing.Color.Black;
            this.btnShopTheoDoi.Location = new System.Drawing.Point(16, 66);
            this.btnShopTheoDoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnShopTheoDoi.Name = "btnShopTheoDoi";
            this.btnShopTheoDoi.Size = new System.Drawing.Size(135, 31);
            this.btnShopTheoDoi.TabIndex = 14;
            this.btnShopTheoDoi.Text = "Đang theo dõi";
            this.btnShopTheoDoi.Click += new System.EventHandler(this.btnShopTheoDoi_Click);
            // 
            // btnTatCaShop
            // 
            this.btnTatCaShop.Animated = true;
            this.btnTatCaShop.BackColor = System.Drawing.Color.Transparent;
            this.btnTatCaShop.CustomBorderColor = System.Drawing.Color.MediumTurquoise;
            this.btnTatCaShop.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnTatCaShop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTatCaShop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTatCaShop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTatCaShop.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTatCaShop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTatCaShop.FillColor = System.Drawing.Color.Transparent;
            this.btnTatCaShop.FillColor2 = System.Drawing.Color.Transparent;
            this.btnTatCaShop.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnTatCaShop.ForeColor = System.Drawing.Color.Black;
            this.btnTatCaShop.Location = new System.Drawing.Point(17, 7);
            this.btnTatCaShop.Margin = new System.Windows.Forms.Padding(2);
            this.btnTatCaShop.Name = "btnTatCaShop";
            this.btnTatCaShop.Size = new System.Drawing.Size(135, 31);
            this.btnTatCaShop.TabIndex = 17;
            this.btnTatCaShop.Text = "Tất cả shop";
            this.btnTatCaShop.Click += new System.EventHandler(this.btnAllShop_Click);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 20;
            this.guna2CustomGradientPanel1.Controls.Add(this.btnUyTin);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnItUyTin);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnTatCaShop);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnShopTheoDoi);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(9, 89);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(166, 624);
            this.guna2CustomGradientPanel1.TabIndex = 28;
            // 
            // btnUyTin
            // 
            this.btnUyTin.Animated = true;
            this.btnUyTin.BackColor = System.Drawing.Color.Transparent;
            this.btnUyTin.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.btnUyTin.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnUyTin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUyTin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUyTin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUyTin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUyTin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUyTin.FillColor = System.Drawing.Color.Transparent;
            this.btnUyTin.FillColor2 = System.Drawing.Color.Transparent;
            this.btnUyTin.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnUyTin.ForeColor = System.Drawing.Color.Black;
            this.btnUyTin.Location = new System.Drawing.Point(16, 120);
            this.btnUyTin.Margin = new System.Windows.Forms.Padding(2);
            this.btnUyTin.Name = "btnUyTin";
            this.btnUyTin.Size = new System.Drawing.Size(135, 31);
            this.btnUyTin.TabIndex = 19;
            this.btnUyTin.Text = "Uy Tín";
            this.btnUyTin.Click += new System.EventHandler(this.btnUyTin_Click);
            // 
            // btnItUyTin
            // 
            this.btnItUyTin.Animated = true;
            this.btnItUyTin.BackColor = System.Drawing.Color.Transparent;
            this.btnItUyTin.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.btnItUyTin.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnItUyTin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnItUyTin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnItUyTin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnItUyTin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnItUyTin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnItUyTin.FillColor = System.Drawing.Color.Transparent;
            this.btnItUyTin.FillColor2 = System.Drawing.Color.Transparent;
            this.btnItUyTin.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnItUyTin.ForeColor = System.Drawing.Color.Black;
            this.btnItUyTin.Location = new System.Drawing.Point(16, 175);
            this.btnItUyTin.Margin = new System.Windows.Forms.Padding(2);
            this.btnItUyTin.Name = "btnItUyTin";
            this.btnItUyTin.Size = new System.Drawing.Size(135, 31);
            this.btnItUyTin.TabIndex = 18;
            this.btnItUyTin.Text = "Ít uy tín";
            this.btnItUyTin.Click += new System.EventHandler(this.btnItUyTin_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderRadius = 10;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.IconRight = global::ProjectWin_Demo_.Properties.Resources.magnifying_glass_solid;
            this.txtTimKiem.IconRightOffset = new System.Drawing.Point(10, 0);
            this.txtTimKiem.IconRightSize = new System.Drawing.Size(30, 30);
            this.txtTimKiem.Location = new System.Drawing.Point(309, 21);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "Tìm kiếm Shop";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(440, 39);
            this.txtTimKiem.TabIndex = 29;
            this.txtTimKiem.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // FShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1180, 727);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.fPanelShop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FShop";
            this.Text = "FHome";
            this.Load += new System.EventHandler(this.FShop_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel fPanelShop;
        private Guna.UI2.WinForms.Guna2GradientButton btnShopTheoDoi;
        private Guna.UI2.WinForms.Guna2GradientButton btnTatCaShop;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;

        private Guna.UI2.WinForms.Guna2GradientButton btnUyTin;
        private Guna.UI2.WinForms.Guna2GradientButton btnItUyTin;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
    }
}