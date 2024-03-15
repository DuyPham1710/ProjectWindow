namespace ProjectWin_Demo_
{
    partial class FInfo
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
            this.ItemPurchaseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemSalesHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.guna2ContextMenuStrip1.SuspendLayout();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1440, 50);
            this.panel1.TabIndex = 0;
            // 
            // btnInfo
            // 
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
            this.btnInfo.Location = new System.Drawing.Point(14, 4);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(198, 45);
            this.btnInfo.TabIndex = 10;
            this.btnInfo.Text = "Thông tin cá nhân";
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnRevenue
            // 
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
            this.btnRevenue.Location = new System.Drawing.Point(415, 4);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Size = new System.Drawing.Size(190, 45);
            this.btnRevenue.TabIndex = 11;
            this.btnRevenue.Text = "Doanh thu";
            this.btnRevenue.Click += new System.EventHandler(this.btnRevenue_Click);
            // 
            // btnHistory
            // 
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
            this.btnHistory.Location = new System.Drawing.Point(219, 4);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(190, 45);
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
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(307, 64);
            // 
            // ItemPurchaseHistory
            // 
            this.ItemPurchaseHistory.BackColor = System.Drawing.Color.White;
            this.ItemPurchaseHistory.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemPurchaseHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ItemPurchaseHistory.Image = global::ProjectWin_Demo_.Properties.Resources.Done;
            this.ItemPurchaseHistory.Name = "ItemPurchaseHistory";
            this.ItemPurchaseHistory.Size = new System.Drawing.Size(306, 30);
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
            this.ItemSalesHistory.Size = new System.Drawing.Size(306, 30);
            this.ItemSalesHistory.Text = "       Lịch sử bán hàng";
            this.ItemSalesHistory.Click += new System.EventHandler(this.ItemSalesHistoryToolStripMenuItem);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.White;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 50);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1440, 742);
            this.panelChildForm.TabIndex = 1;
            // 
            // FInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 792);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FInfo";
            this.Text = "FInfo";
            this.Load += new System.EventHandler(this.FInfo_Load);
            this.panel1.ResumeLayout(false);
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelChildForm;
        private Guna.UI2.WinForms.Guna2GradientButton btnInfo;
        private Guna.UI2.WinForms.Guna2GradientButton btnHistory;
        private Guna.UI2.WinForms.Guna2GradientButton btnRevenue;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ItemPurchaseHistory;
        private System.Windows.Forms.ToolStripMenuItem ItemSalesHistory;
    }
}