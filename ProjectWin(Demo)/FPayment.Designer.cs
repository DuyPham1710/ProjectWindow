namespace ProjectWin_Demo_
{
    partial class FPayment
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
            this.grBAddress = new System.Windows.Forms.GroupBox();
            this.txtAddress = new ProjectWin_Demo_.Funtion.RJTextBox();
            this.txtPhoneNumber = new ProjectWin_Demo_.Funtion.RJTextBox();
            this.txtName = new ProjectWin_Demo_.Funtion.RJTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ucCart1 = new ProjectWin_Demo_.UCCart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPayMethod = new System.Windows.Forms.Label();
            this.pcbPayDelivery = new System.Windows.Forms.PictureBox();
            this.pcbBank = new System.Windows.Forms.PictureBox();
            this.pcbMomo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOrder = new CustomButton.VBButton();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.grBAddress.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPayDelivery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMomo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grBAddress
            // 
            this.grBAddress.Controls.Add(this.txtAddress);
            this.grBAddress.Controls.Add(this.txtPhoneNumber);
            this.grBAddress.Controls.Add(this.txtName);
            this.grBAddress.Controls.Add(this.label9);
            this.grBAddress.Controls.Add(this.label8);
            this.grBAddress.Controls.Add(this.label6);
            this.grBAddress.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBAddress.Location = new System.Drawing.Point(12, 12);
            this.grBAddress.Name = "grBAddress";
            this.grBAddress.Size = new System.Drawing.Size(1097, 116);
            this.grBAddress.TabIndex = 7;
            this.grBAddress.TabStop = false;
            this.grBAddress.Text = "Địa chỉ nhận hàng";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddress.BorderColor = System.Drawing.Color.Lavender;
            this.txtAddress.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtAddress.BorderRadius = 11;
            this.txtAddress.BorderSize = 2;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddress.Location = new System.Drawing.Point(97, 70);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Multiline = false;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtAddress.PasswordChar = false;
            this.txtAddress.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.Size = new System.Drawing.Size(631, 35);
            this.txtAddress.TabIndex = 11;
            this.txtAddress.Texts = "9 đường 4 tổ 8 ấp 2 xã xuân hòa, Xã Xuân Hòa, Huyện Xuân Lộc, Đồng Nai";
            this.txtAddress.UnderlinedStyle = false;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtPhoneNumber.BorderColor = System.Drawing.Color.Lavender;
            this.txtPhoneNumber.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPhoneNumber.BorderRadius = 11;
            this.txtPhoneNumber.BorderSize = 2;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPhoneNumber.Location = new System.Drawing.Point(480, 27);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneNumber.Multiline = false;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPhoneNumber.PasswordChar = false;
            this.txtPhoneNumber.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPhoneNumber.PlaceholderText = "";
            this.txtPhoneNumber.Size = new System.Drawing.Size(248, 35);
            this.txtPhoneNumber.TabIndex = 10;
            this.txtPhoneNumber.Texts = "0794821201";
            this.txtPhoneNumber.UnderlinedStyle = false;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.BorderColor = System.Drawing.Color.Lavender;
            this.txtName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtName.BorderRadius = 11;
            this.txtName.BorderSize = 2;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.Location = new System.Drawing.Point(97, 27);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtName.PasswordChar = false;
            this.txtName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtName.PlaceholderText = "";
            this.txtName.Size = new System.Drawing.Size(228, 35);
            this.txtName.TabIndex = 9;
            this.txtName.Texts = "Phạm Ngọc Duy";
            this.txtName.UnderlinedStyle = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(368, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Số điện thoại: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Địa chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Họ và tên:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBox1.Controls.Add(this.ucCart1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1097, 159);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết sản phẩm";
            // 
            // ucCart1
            // 
            this.ucCart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCart1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucCart1.Location = new System.Drawing.Point(3, 63);
            this.ucCart1.Name = "ucCart1";
            this.ucCart1.Size = new System.Drawing.Size(1091, 93);
            this.ucCart1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1091, 40);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.label5.Location = new System.Drawing.Point(456, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phân loại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.label4.Location = new System.Drawing.Point(922, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng số tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.label3.Location = new System.Drawing.Point(778, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.label2.Location = new System.Drawing.Point(625, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đơn giá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(129, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Sản phẩm";
            // 
            // lblPayMethod
            // 
            this.lblPayMethod.AutoSize = true;
            this.lblPayMethod.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayMethod.Location = new System.Drawing.Point(11, 360);
            this.lblPayMethod.Name = "lblPayMethod";
            this.lblPayMethod.Size = new System.Drawing.Size(212, 23);
            this.lblPayMethod.TabIndex = 8;
            this.lblPayMethod.Text = "Phương thức thanh toán";
            // 
            // pcbPayDelivery
            // 
            this.pcbPayDelivery.Image = global::ProjectWin_Demo_.Properties.Resources.Custom_Icon_Design_Pretty_Office_11_Cash_64;
            this.pcbPayDelivery.Location = new System.Drawing.Point(606, 341);
            this.pcbPayDelivery.Name = "pcbPayDelivery";
            this.pcbPayDelivery.Size = new System.Drawing.Size(100, 50);
            this.pcbPayDelivery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbPayDelivery.TabIndex = 12;
            this.pcbPayDelivery.TabStop = false;
            this.pcbPayDelivery.Click += new System.EventHandler(this.pictureBoxPayMethod_Click);
            this.pcbPayDelivery.MouseLeave += new System.EventHandler(this.pictureBoxPayMethod_MouseLeave);
            this.pcbPayDelivery.MouseHover += new System.EventHandler(this.pictureBoxPayMethod_MouseHover);
            // 
            // pcbBank
            // 
            this.pcbBank.Image = global::ProjectWin_Demo_.Properties.Resources.Double_J_Design_Ravenna_3d_Credit_Card_64;
            this.pcbBank.Location = new System.Drawing.Point(447, 341);
            this.pcbBank.Name = "pcbBank";
            this.pcbBank.Size = new System.Drawing.Size(100, 50);
            this.pcbBank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbBank.TabIndex = 11;
            this.pcbBank.TabStop = false;
            this.pcbBank.Click += new System.EventHandler(this.pictureBoxPayMethod_Click);
            this.pcbBank.MouseLeave += new System.EventHandler(this.pictureBoxPayMethod_MouseLeave);
            this.pcbBank.MouseHover += new System.EventHandler(this.pictureBoxPayMethod_MouseHover);
            // 
            // pcbMomo
            // 
            this.pcbMomo.BackColor = System.Drawing.Color.LavenderBlush;
            this.pcbMomo.Image = global::ProjectWin_Demo_.Properties.Resources.Momo;
            this.pcbMomo.Location = new System.Drawing.Point(286, 341);
            this.pcbMomo.Name = "pcbMomo";
            this.pcbMomo.Size = new System.Drawing.Size(100, 50);
            this.pcbMomo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbMomo.TabIndex = 10;
            this.pcbMomo.TabStop = false;
            this.pcbMomo.Click += new System.EventHandler(this.pictureBoxPayMethod_Click);
            this.pcbMomo.MouseLeave += new System.EventHandler(this.pictureBoxPayMethod_MouseLeave);
            this.pcbMomo.MouseHover += new System.EventHandler(this.pictureBoxPayMethod_MouseHover);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnOrder);
            this.panel2.Controls.Add(this.lblMoney);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 416);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1116, 188);
            this.panel2.TabIndex = 13;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Crimson;
            this.btnOrder.BackgroundColor = System.Drawing.Color.Crimson;
            this.btnOrder.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOrder.BorderRadius = 13;
            this.btnOrder.BorderSize = 0;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(788, 93);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(177, 53);
            this.btnOrder.TabIndex = 11;
            this.btnOrder.Text = "Đặt hàng";
            this.btnOrder.TextColor = System.Drawing.Color.White;
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.Location = new System.Drawing.Point(784, 33);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(147, 23);
            this.lblMoney.TabIndex = 10;
            this.lblMoney.Text = "32 460 000 VND";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(627, 33);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(102, 23);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Tổng tiền: ";
            // 
            // FPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1116, 604);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pcbPayDelivery);
            this.Controls.Add(this.pcbBank);
            this.Controls.Add(this.pcbMomo);
            this.Controls.Add(this.lblPayMethod);
            this.Controls.Add(this.grBAddress);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "FPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FPayment";
            this.grBAddress.ResumeLayout(false);
            this.grBAddress.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPayDelivery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMomo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grBAddress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private UCCart ucCart1;
        private System.Windows.Forms.Label lblPayMethod;
        private System.Windows.Forms.PictureBox pcbMomo;
        private System.Windows.Forms.PictureBox pcbBank;
        private System.Windows.Forms.PictureBox pcbPayDelivery;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblMoney;
        private CustomButton.VBButton btnOrder;
        private Funtion.RJTextBox txtAddress;
        private Funtion.RJTextBox txtPhoneNumber;
        private Funtion.RJTextBox txtName;
    }
}