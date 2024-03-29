﻿namespace ProjectWin_Demo_.UC
{
    partial class UCPurchaseOrder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefund = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnDelivered = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnProcess = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnDelivery = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnWaitAccept = new Guna.UI2.WinForms.Guna2GradientButton();
            this.fPanelSanPham = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnRefund);
            this.panel1.Controls.Add(this.btnDelivered);
            this.panel1.Controls.Add(this.btnProcess);
            this.panel1.Controls.Add(this.btnDelivery);
            this.panel1.Controls.Add(this.btnWaitAccept);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1450, 60);
            this.panel1.TabIndex = 1;
            // 
            // btnRefund
            // 
            this.btnRefund.CustomBorderColor = System.Drawing.Color.White;
            this.btnRefund.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnRefund.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefund.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefund.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefund.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefund.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefund.FillColor = System.Drawing.Color.Transparent;
            this.btnRefund.FillColor2 = System.Drawing.Color.Transparent;
            this.btnRefund.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefund.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRefund.Location = new System.Drawing.Point(992, 9);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.Size = new System.Drawing.Size(217, 45);
            this.btnRefund.TabIndex = 15;
            this.btnRefund.Text = "Hoàn tiền/Hủy đơn";
            this.btnRefund.Click += new System.EventHandler(this.btnRefund_Click);
            // 
            // btnDelivered
            // 
            this.btnDelivered.CustomBorderColor = System.Drawing.Color.White;
            this.btnDelivered.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnDelivered.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelivered.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelivered.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelivered.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelivered.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelivered.FillColor = System.Drawing.Color.Transparent;
            this.btnDelivered.FillColor2 = System.Drawing.Color.Transparent;
            this.btnDelivered.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelivered.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelivered.Location = new System.Drawing.Point(757, 9);
            this.btnDelivered.Name = "btnDelivered";
            this.btnDelivered.Size = new System.Drawing.Size(198, 45);
            this.btnDelivered.TabIndex = 14;
            this.btnDelivered.Text = "Đã giao";
            this.btnDelivered.Click += new System.EventHandler(this.btnDelivered_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.CustomBorderColor = System.Drawing.Color.White;
            this.btnProcess.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnProcess.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProcess.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProcess.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProcess.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProcess.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProcess.FillColor = System.Drawing.Color.Transparent;
            this.btnProcess.FillColor2 = System.Drawing.Color.Transparent;
            this.btnProcess.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnProcess.Location = new System.Drawing.Point(297, 9);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(198, 45);
            this.btnProcess.TabIndex = 13;
            this.btnProcess.Text = "Đang xử lý";
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnDelivery
            // 
            this.btnDelivery.CustomBorderColor = System.Drawing.Color.White;
            this.btnDelivery.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnDelivery.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelivery.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelivery.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelivery.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelivery.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelivery.FillColor = System.Drawing.Color.Transparent;
            this.btnDelivery.FillColor2 = System.Drawing.Color.Transparent;
            this.btnDelivery.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelivery.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelivery.Location = new System.Drawing.Point(519, 9);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(198, 45);
            this.btnDelivery.TabIndex = 12;
            this.btnDelivery.Text = "Đang giao";
            this.btnDelivery.Click += new System.EventHandler(this.btnDelivery_Click);
            // 
            // btnWaitAccept
            // 
            this.btnWaitAccept.CustomBorderColor = System.Drawing.Color.Gold;
            this.btnWaitAccept.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnWaitAccept.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnWaitAccept.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnWaitAccept.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnWaitAccept.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnWaitAccept.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnWaitAccept.FillColor = System.Drawing.Color.Transparent;
            this.btnWaitAccept.FillColor2 = System.Drawing.Color.Transparent;
            this.btnWaitAccept.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWaitAccept.ForeColor = System.Drawing.Color.Black;
            this.btnWaitAccept.Location = new System.Drawing.Point(65, 9);
            this.btnWaitAccept.Name = "btnWaitAccept";
            this.btnWaitAccept.Size = new System.Drawing.Size(198, 45);
            this.btnWaitAccept.TabIndex = 11;
            this.btnWaitAccept.Text = "Chờ xác nhận";
            this.btnWaitAccept.Click += new System.EventHandler(this.btnWaitAccept_Click);
            // 
            // fPanelSanPham
            // 
            this.fPanelSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fPanelSanPham.Location = new System.Drawing.Point(0, 60);
            this.fPanelSanPham.Name = "fPanelSanPham";
            this.fPanelSanPham.Size = new System.Drawing.Size(1450, 682);
            this.fPanelSanPham.TabIndex = 2;
            // 
            // UCPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.fPanelSanPham);
            this.Controls.Add(this.panel1);
            this.Name = "UCPurchaseOrder";
            this.Size = new System.Drawing.Size(1450, 742);
            this.Load += new System.EventHandler(this.UCPurchaseOrder_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnRefund;
        private Guna.UI2.WinForms.Guna2GradientButton btnDelivered;
        private Guna.UI2.WinForms.Guna2GradientButton btnProcess;
        private Guna.UI2.WinForms.Guna2GradientButton btnDelivery;
        private Guna.UI2.WinForms.Guna2GradientButton btnWaitAccept;
        private System.Windows.Forms.FlowLayoutPanel fPanelSanPham;
    }
}
