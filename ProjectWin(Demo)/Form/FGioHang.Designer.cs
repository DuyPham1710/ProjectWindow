namespace ProjectWin_Demo_
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
            this.btnBuyNow = new CustomButton.VBButton();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CBSelectAll = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ucCart1 = new ProjectWin_Demo_.UCGioHang();
            this.ucCart2 = new ProjectWin_Demo_.UCGioHang();
            this.ucCart3 = new ProjectWin_Demo_.UCGioHang();
            this.ucCart4 = new ProjectWin_Demo_.UCGioHang();
            this.ucCart5 = new ProjectWin_Demo_.UCGioHang();
            this.ucCart6 = new ProjectWin_Demo_.UCGioHang();
            this.ucCart7 = new ProjectWin_Demo_.UCGioHang();
            this.ucCart8 = new ProjectWin_Demo_.UCGioHang();
            this.ucCart9 = new ProjectWin_Demo_.UCGioHang();
            this.ucCart10 = new ProjectWin_Demo_.UCGioHang();
            this.ucCart11 = new ProjectWin_Demo_.UCGioHang();
            this.ucCart12 = new ProjectWin_Demo_.UCGioHang();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuyNow
            // 
            this.btnBuyNow.BackColor = System.Drawing.Color.Crimson;
            this.btnBuyNow.BackgroundColor = System.Drawing.Color.Crimson;
            this.btnBuyNow.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBuyNow.BorderRadius = 13;
            this.btnBuyNow.BorderSize = 0;
            this.btnBuyNow.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBuyNow.FlatAppearance.BorderSize = 0;
            this.btnBuyNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyNow.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyNow.ForeColor = System.Drawing.Color.White;
            this.btnBuyNow.Location = new System.Drawing.Point(1283, 0);
            this.btnBuyNow.Name = "btnBuyNow";
            this.btnBuyNow.Size = new System.Drawing.Size(152, 45);
            this.btnBuyNow.TabIndex = 0;
            this.btnBuyNow.Text = "Mua ngay";
            this.btnBuyNow.TextColor = System.Drawing.Color.White;
            this.btnBuyNow.UseVisualStyleBackColor = false;
            this.btnBuyNow.Click += new System.EventHandler(this.btnBuyNow_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(707, 13);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(105, 19);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Tổng số tiền:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.OldLace;
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Controls.Add(this.btnBuyNow);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 747);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1435, 45);
            this.panel3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.label2.Location = new System.Drawing.Point(629, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đơn giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.label3.Location = new System.Drawing.Point(851, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.label4.Location = new System.Drawing.Point(1101, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng số tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.label5.Location = new System.Drawing.Point(388, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phân loại";
            // 
            // CBSelectAll
            // 
            this.CBSelectAll.AutoSize = true;
            this.CBSelectAll.Location = new System.Drawing.Point(12, 9);
            this.CBSelectAll.Name = "CBSelectAll";
            this.CBSelectAll.Size = new System.Drawing.Size(18, 17);
            this.CBSelectAll.TabIndex = 5;
            this.CBSelectAll.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.label6.Location = new System.Drawing.Point(1342, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Xóa";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.CBSelectAll);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1435, 40);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ucCart1);
            this.flowLayoutPanel1.Controls.Add(this.ucCart2);
            this.flowLayoutPanel1.Controls.Add(this.ucCart3);
            this.flowLayoutPanel1.Controls.Add(this.ucCart4);
            this.flowLayoutPanel1.Controls.Add(this.ucCart5);
            this.flowLayoutPanel1.Controls.Add(this.ucCart6);
            this.flowLayoutPanel1.Controls.Add(this.ucCart7);
            this.flowLayoutPanel1.Controls.Add(this.ucCart8);
            this.flowLayoutPanel1.Controls.Add(this.ucCart9);
            this.flowLayoutPanel1.Controls.Add(this.ucCart10);
            this.flowLayoutPanel1.Controls.Add(this.ucCart11);
            this.flowLayoutPanel1.Controls.Add(this.ucCart12);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1435, 707);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // ucCart1
            // 
            this.ucCart1.Location = new System.Drawing.Point(3, 3);
            this.ucCart1.Name = "ucCart1";
            this.ucCart1.Size = new System.Drawing.Size(1435, 84);
            this.ucCart1.TabIndex = 0;
            // 
            // ucCart2
            // 
            this.ucCart2.Location = new System.Drawing.Point(3, 93);
            this.ucCart2.Name = "ucCart2";
            this.ucCart2.Size = new System.Drawing.Size(1435, 84);
            this.ucCart2.TabIndex = 1;
            // 
            // ucCart3
            // 
            this.ucCart3.Location = new System.Drawing.Point(3, 183);
            this.ucCart3.Name = "ucCart3";
            this.ucCart3.Size = new System.Drawing.Size(1435, 84);
            this.ucCart3.TabIndex = 2;
            // 
            // ucCart4
            // 
            this.ucCart4.Location = new System.Drawing.Point(3, 273);
            this.ucCart4.Name = "ucCart4";
            this.ucCart4.Size = new System.Drawing.Size(1435, 84);
            this.ucCart4.TabIndex = 3;
            // 
            // ucCart5
            // 
            this.ucCart5.Location = new System.Drawing.Point(3, 363);
            this.ucCart5.Name = "ucCart5";
            this.ucCart5.Size = new System.Drawing.Size(1435, 84);
            this.ucCart5.TabIndex = 4;
            // 
            // ucCart6
            // 
            this.ucCart6.Location = new System.Drawing.Point(3, 453);
            this.ucCart6.Name = "ucCart6";
            this.ucCart6.Size = new System.Drawing.Size(1435, 84);
            this.ucCart6.TabIndex = 5;
            // 
            // ucCart7
            // 
            this.ucCart7.Location = new System.Drawing.Point(3, 543);
            this.ucCart7.Name = "ucCart7";
            this.ucCart7.Size = new System.Drawing.Size(1435, 84);
            this.ucCart7.TabIndex = 6;
            // 
            // ucCart8
            // 
            this.ucCart8.Location = new System.Drawing.Point(3, 633);
            this.ucCart8.Name = "ucCart8";
            this.ucCart8.Size = new System.Drawing.Size(1435, 84);
            this.ucCart8.TabIndex = 7;
            // 
            // ucCart9
            // 
            this.ucCart9.Location = new System.Drawing.Point(3, 723);
            this.ucCart9.Name = "ucCart9";
            this.ucCart9.Size = new System.Drawing.Size(1435, 84);
            this.ucCart9.TabIndex = 8;
            // 
            // ucCart10
            // 
            this.ucCart10.Location = new System.Drawing.Point(3, 813);
            this.ucCart10.Name = "ucCart10";
            this.ucCart10.Size = new System.Drawing.Size(1435, 84);
            this.ucCart10.TabIndex = 9;
            // 
            // ucCart11
            // 
            this.ucCart11.Location = new System.Drawing.Point(3, 903);
            this.ucCart11.Name = "ucCart11";
            this.ucCart11.Size = new System.Drawing.Size(1435, 84);
            this.ucCart11.TabIndex = 10;
            // 
            // ucCart12
            // 
            this.ucCart12.Location = new System.Drawing.Point(3, 993);
            this.ucCart12.Name = "ucCart12";
            this.ucCart12.Size = new System.Drawing.Size(1435, 84);
            this.ucCart12.TabIndex = 11;
            // 
            // FCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1435, 792);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FCart";
            this.Text = "FCart";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotal;
        private CustomButton.VBButton btnBuyNow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox CBSelectAll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private UCGioHang ucCart1;
        private UCGioHang ucCart2;
        private UCGioHang ucCart3;
        private UCGioHang ucCart4;
        private UCGioHang ucCart5;
        private UCGioHang ucCart6;
        private UCGioHang ucCart7;
        private UCGioHang ucCart8;
        private UCGioHang ucCart9;
        private UCGioHang ucCart10;
        private UCGioHang ucCart11;
        private UCGioHang ucCart12;
    }
}