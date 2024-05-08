namespace ProjectWin_Demo_
{
    partial class FThongTin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInfo = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnRevenue = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnHistory = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.panelTieuDe = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTenNguoiMua = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.ItemPurchaseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemSalesHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.panelTieuDe.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.btnInfo);
            this.panel1.Controls.Add(this.btnRevenue);
            this.panel1.Controls.Add(this.btnHistory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1180, 41);
            this.panel1.TabIndex = 0;
            // 
            // btnInfo
            // 
            this.btnInfo.Animated = true;
            this.btnInfo.CustomBorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnInfo.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInfo.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInfo.FillColor = System.Drawing.Color.Transparent;
            this.btnInfo.FillColor2 = System.Drawing.Color.Transparent;
            this.btnInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnInfo.Location = new System.Drawing.Point(10, 3);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(148, 37);
            this.btnInfo.TabIndex = 10;
            this.btnInfo.Text = "Thông tin cá nhân";
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnRevenue
            // 
            this.btnRevenue.Animated = true;
            this.btnRevenue.CustomBorderColor = System.Drawing.Color.White;
            this.btnRevenue.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnRevenue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRevenue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRevenue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRevenue.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRevenue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRevenue.FillColor = System.Drawing.Color.Transparent;
            this.btnRevenue.FillColor2 = System.Drawing.Color.Transparent;
            this.btnRevenue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevenue.ForeColor = System.Drawing.Color.Black;
            this.btnRevenue.Location = new System.Drawing.Point(311, 3);
            this.btnRevenue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Size = new System.Drawing.Size(142, 37);
            this.btnRevenue.TabIndex = 11;
            this.btnRevenue.Text = "Doanh thu";
            this.btnRevenue.Click += new System.EventHandler(this.btnRevenue_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Animated = true;
            this.btnHistory.ContextMenuStrip = this.guna2ContextMenuStrip1;
            this.btnHistory.CustomBorderColor = System.Drawing.Color.White;
            this.btnHistory.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnHistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHistory.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHistory.FillColor = System.Drawing.Color.Transparent;
            this.btnHistory.FillColor2 = System.Drawing.Color.Transparent;
            this.btnHistory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.Color.Black;
            this.btnHistory.Location = new System.Drawing.Point(164, 3);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(142, 37);
            this.btnHistory.TabIndex = 9;
            this.btnHistory.Text = "Lịch sử giao dịch";
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemPurchaseHistory,
            this.ItemSalesHistory});
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(262, 56);
            // 
            // panelTieuDe
            // 
            this.panelTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.panelTieuDe.Controls.Add(this.panel7);
            this.panelTieuDe.Controls.Add(this.panel6);
            this.panelTieuDe.Controls.Add(this.panel5);
            this.panelTieuDe.Controls.Add(this.panel4);
            this.panelTieuDe.Controls.Add(this.lblTenNguoiMua);
            this.panelTieuDe.Controls.Add(this.label5);
            this.panelTieuDe.Controls.Add(this.label4);
            this.panelTieuDe.Controls.Add(this.label3);
            this.panelTieuDe.Controls.Add(this.label2);
            this.panelTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTieuDe.Location = new System.Drawing.Point(0, 41);
            this.panelTieuDe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTieuDe.Name = "panelTieuDe";
            this.panelTieuDe.Size = new System.Drawing.Size(1180, 37);
            this.panelTieuDe.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(919, 5);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1, 28);
            this.panel7.TabIndex = 13;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(795, 5);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1, 28);
            this.panel6.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(608, 5);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 28);
            this.panel5.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(472, 5);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 28);
            this.panel4.TabIndex = 12;
            // 
            // lblTenNguoiMua
            // 
            this.lblTenNguoiMua.AutoSize = true;
            this.lblTenNguoiMua.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNguoiMua.Location = new System.Drawing.Point(984, 11);
            this.lblTenNguoiMua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenNguoiMua.Name = "lblTenNguoiMua";
            this.lblTenNguoiMua.Size = new System.Drawing.Size(74, 17);
            this.lblTenNguoiMua.TabIndex = 11;
            this.lblTenNguoiMua.Text = "Người mua";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(838, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(674, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(516, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Phân loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên sản phẩm";
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.White;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 78);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1180, 647);
            this.panelChildForm.TabIndex = 9;
            // 
            // ItemPurchaseHistory
            // 
            this.ItemPurchaseHistory.BackColor = System.Drawing.Color.White;
            this.ItemPurchaseHistory.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemPurchaseHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ItemPurchaseHistory.Image = global::ProjectWin_Demo_.Properties.Resources.Done;
            this.ItemPurchaseHistory.Name = "ItemPurchaseHistory";
            this.ItemPurchaseHistory.Size = new System.Drawing.Size(261, 26);
            this.ItemPurchaseHistory.Text = "       Lịch sử mua hàng";
            this.ItemPurchaseHistory.Click += new System.EventHandler(this.ItemPurchaseHistoryToolStripMenuItem);
            // 
            // ItemSalesHistory
            // 
            this.ItemSalesHistory.BackColor = System.Drawing.Color.White;
            this.ItemSalesHistory.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.ItemSalesHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ItemSalesHistory.Image = global::ProjectWin_Demo_.Properties.Resources.tinhTrang;
            this.ItemSalesHistory.Name = "ItemSalesHistory";
            this.ItemSalesHistory.Size = new System.Drawing.Size(261, 26);
            this.ItemSalesHistory.Text = "       Lịch sử bán hàng";
            this.ItemSalesHistory.Click += new System.EventHandler(this.ItemSalesHistoryToolStripMenuItem);
            // 
            // FThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 725);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelTieuDe);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FThongTin";
            this.Text = "FInfo";
            this.Load += new System.EventHandler(this.FInfo_Load);
            this.panel1.ResumeLayout(false);
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.panelTieuDe.ResumeLayout(false);
            this.panelTieuDe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnInfo;
        private Guna.UI2.WinForms.Guna2GradientButton btnHistory;
        private Guna.UI2.WinForms.Guna2GradientButton btnRevenue;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ItemPurchaseHistory;
        private System.Windows.Forms.ToolStripMenuItem ItemSalesHistory;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelTieuDe;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTenNguoiMua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelChildForm;
    }
}