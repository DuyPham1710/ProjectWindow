﻿namespace ProjectWin_Demo_
{
    partial class FGioHang
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
            this.lblTongTien = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMuaHang = new CustomButton.VBButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbChonTatCa = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fPanelGioHang = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(1029, 14);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(18, 19);
            this.lblTongTien.TabIndex = 1;
            this.lblTongTien.Text = "0";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.OldLace;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lblTongTien);
            this.panel3.Controls.Add(this.btnMuaHang);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 839);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1573, 53);
            this.panel3.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(893, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tổng số tiền:";
            // 
            // btnMuaHang
            // 
            this.btnMuaHang.BackColor = System.Drawing.Color.Crimson;
            this.btnMuaHang.BackgroundColor = System.Drawing.Color.Crimson;
            this.btnMuaHang.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMuaHang.BorderRadius = 13;
            this.btnMuaHang.BorderSize = 0;
            this.btnMuaHang.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMuaHang.FlatAppearance.BorderSize = 0;
            this.btnMuaHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMuaHang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuaHang.ForeColor = System.Drawing.Color.White;
            this.btnMuaHang.Location = new System.Drawing.Point(1421, 0);
            this.btnMuaHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMuaHang.Name = "btnMuaHang";
            this.btnMuaHang.Size = new System.Drawing.Size(152, 53);
            this.btnMuaHang.TabIndex = 0;
            this.btnMuaHang.Text = "Mua ngay";
            this.btnMuaHang.TextColor = System.Drawing.Color.White;
            this.btnMuaHang.UseVisualStyleBackColor = false;
            this.btnMuaHang.Click += new System.EventHandler(this.btnMuaHang_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(704, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đơn giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(964, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1189, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng số tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(413, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phân loại";
            // 
            // cbChonTatCa
            // 
            this.cbChonTatCa.AutoSize = true;
            this.cbChonTatCa.Location = new System.Drawing.Point(15, 11);
            this.cbChonTatCa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbChonTatCa.Name = "cbChonTatCa";
            this.cbChonTatCa.Size = new System.Drawing.Size(18, 17);
            this.cbChonTatCa.TabIndex = 5;
            this.cbChonTatCa.UseVisualStyleBackColor = true;
            this.cbChonTatCa.CheckedChanged += new System.EventHandler(this.cbChonTatCa_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1467, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Xóa";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbChonTatCa);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1573, 56);
            this.panel1.TabIndex = 0;
            // 
            // fPanelGioHang
            // 
            this.fPanelGioHang.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fPanelGioHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fPanelGioHang.Location = new System.Drawing.Point(0, 54);
            this.fPanelGioHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fPanelGioHang.Name = "fPanelGioHang";
            this.fPanelGioHang.Size = new System.Drawing.Size(1573, 785);
            this.fPanelGioHang.TabIndex = 6;
            // 
            // FGioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1573, 892);
            this.Controls.Add(this.fPanelGioHang);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FGioHang";
            this.Text = "FCart";
            this.Load += new System.EventHandler(this.FGioHang_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTongTien;
        private CustomButton.VBButton btnMuaHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbChonTatCa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel fPanelGioHang;
        private System.Windows.Forms.Label label7;
    }
}