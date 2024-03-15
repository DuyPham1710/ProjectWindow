namespace ProjectWin_Demo_
{
    partial class FOrder
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
            this.btnPurchaseOrder = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSaleOrder = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucPurchaseOrder1 = new ProjectWin_Demo_.UC.UCPurchaseOrder();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.White;
            this.guna2CustomGradientPanel1.Controls.Add(this.btnPurchaseOrder);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnSaleOrder);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1450, 57);
            this.guna2CustomGradientPanel1.TabIndex = 1;
            // 
            // btnPurchaseOrder
            // 
            this.btnPurchaseOrder.CustomBorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPurchaseOrder.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnPurchaseOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPurchaseOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPurchaseOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPurchaseOrder.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPurchaseOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPurchaseOrder.FillColor = System.Drawing.Color.Transparent;
            this.btnPurchaseOrder.FillColor2 = System.Drawing.Color.Transparent;
            this.btnPurchaseOrder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchaseOrder.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPurchaseOrder.Location = new System.Drawing.Point(37, 7);
            this.btnPurchaseOrder.Name = "btnPurchaseOrder";
            this.btnPurchaseOrder.Size = new System.Drawing.Size(180, 45);
            this.btnPurchaseOrder.TabIndex = 10;
            this.btnPurchaseOrder.Text = "Đơn mua";
            this.btnPurchaseOrder.Click += new System.EventHandler(this.btnPurchaseOrder_Click);
            // 
            // btnSaleOrder
            // 
            this.btnSaleOrder.CustomBorderColor = System.Drawing.Color.White;
            this.btnSaleOrder.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnSaleOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaleOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaleOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaleOrder.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaleOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaleOrder.FillColor = System.Drawing.Color.Transparent;
            this.btnSaleOrder.FillColor2 = System.Drawing.Color.Transparent;
            this.btnSaleOrder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaleOrder.ForeColor = System.Drawing.Color.Black;
            this.btnSaleOrder.Location = new System.Drawing.Point(223, 7);
            this.btnSaleOrder.Name = "btnSaleOrder";
            this.btnSaleOrder.Size = new System.Drawing.Size(190, 45);
            this.btnSaleOrder.TabIndex = 9;
            this.btnSaleOrder.Text = "Đơn bán";
            this.btnSaleOrder.Click += new System.EventHandler(this.btnSaleOrder_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucPurchaseOrder1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1450, 735);
            this.panel1.TabIndex = 2;
            // 
            // ucPurchaseOrder1
            // 
            this.ucPurchaseOrder1.BackColor = System.Drawing.Color.GhostWhite;
            this.ucPurchaseOrder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPurchaseOrder1.Location = new System.Drawing.Point(0, 0);
            this.ucPurchaseOrder1.Name = "ucPurchaseOrder1";
            this.ucPurchaseOrder1.Size = new System.Drawing.Size(1450, 735);
            this.ucPurchaseOrder1.TabIndex = 0;
            // 
            // FOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1450, 792);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FOrder";
            this.Text = "FOrder";
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnPurchaseOrder;
        private Guna.UI2.WinForms.Guna2GradientButton btnSaleOrder;
        private System.Windows.Forms.Panel panel1;
        private UC.UCPurchaseOrder ucPurchaseOrder1;
    }
}