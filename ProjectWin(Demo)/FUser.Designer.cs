namespace ProjectWin_Demo_
{
    partial class FUser
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
            this.rjTextBox1 = new ProjectWin_Demo_.Funtion.RJTextBox();
            this.btnFind = new CustomButton.VBButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCart = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnLogOut = new CustomButton.VBButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnInfo = new CustomButton.VBButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnMyProduct = new CustomButton.VBButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnHome = new CustomButton.VBButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCart)).BeginInit();
            this.panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.rjTextBox1);
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBoxCart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1286, 58);
            this.panel1.TabIndex = 0;
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox1.BorderRadius = 15;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox1.Location = new System.Drawing.Point(239, 6);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.PlaceholderText = "";
            this.rjTextBox1.Size = new System.Drawing.Size(555, 40);
            this.rjTextBox1.TabIndex = 7;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Transparent;
            this.btnFind.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnFind.BorderColor = System.Drawing.Color.Lavender;
            this.btnFind.BorderRadius = 15;
            this.btnFind.BorderSize = 2;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.Black;
            this.btnFind.Image = global::ProjectWin_Demo_.Properties.Resources.Elegantthemes_Beautiful_Flat_One_Color_Magnifying_glass_24;
            this.btnFind.Location = new System.Drawing.Point(814, 6);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(177, 40);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "    Tìm kiếm";
            this.btnFind.TextColor = System.Drawing.Color.Black;
            this.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFind.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectWin_Demo_.Properties.Resources.facebook_messenger;
            this.pictureBox1.Location = new System.Drawing.Point(1215, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxCart
            // 
            this.pictureBoxCart.Image = global::ProjectWin_Demo_.Properties.Resources.cart_shopping_solid;
            this.pictureBoxCart.Location = new System.Drawing.Point(1158, 6);
            this.pictureBoxCart.Name = "pictureBoxCart";
            this.pictureBoxCart.Size = new System.Drawing.Size(37, 42);
            this.pictureBoxCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCart.TabIndex = 2;
            this.pictureBoxCart.TabStop = false;
            this.pictureBoxCart.Click += new System.EventHandler(this.pictureBoxCart_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(175, 58);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1111, 686);
            this.panelChildForm.TabIndex = 2;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.LightCyan;
            this.panel13.Controls.Add(this.btnLogOut);
            this.panel13.Controls.Add(this.panel6);
            this.panel13.Controls.Add(this.btnInfo);
            this.panel13.Controls.Add(this.panel5);
            this.panel13.Controls.Add(this.btnMyProduct);
            this.panel13.Controls.Add(this.panel4);
            this.panel13.Controls.Add(this.btnHome);
            this.panel13.Controls.Add(this.panel3);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel13.Location = new System.Drawing.Point(0, 58);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(175, 686);
            this.panel13.TabIndex = 3;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnLogOut.BorderColor = System.Drawing.Color.SlateGray;
            this.btnLogOut.BorderRadius = 0;
            this.btnLogOut.BorderSize = 0;
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.Image = global::ProjectWin_Demo_.Properties.Resources.logout;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(0, 270);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(175, 70);
            this.btnLogOut.TabIndex = 16;
            this.btnLogOut.Tag = "";
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.TextColor = System.Drawing.Color.Black;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 255);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(175, 15);
            this.panel6.TabIndex = 15;
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnInfo.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnInfo.BorderColor = System.Drawing.Color.SlateGray;
            this.btnInfo.BorderRadius = 0;
            this.btnInfo.BorderSize = 0;
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.Black;
            this.btnInfo.Image = global::ProjectWin_Demo_.Properties.Resources.Icons8_Windows_8_Users_Name_48;
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnInfo.Location = new System.Drawing.Point(0, 185);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(175, 70);
            this.btnInfo.TabIndex = 10;
            this.btnInfo.Text = "Thông tin\r\ncá nhân";
            this.btnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInfo.TextColor = System.Drawing.Color.Black;
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 170);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(175, 15);
            this.panel5.TabIndex = 14;
            // 
            // btnMyProduct
            // 
            this.btnMyProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnMyProduct.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnMyProduct.BorderColor = System.Drawing.Color.SlateGray;
            this.btnMyProduct.BorderRadius = 0;
            this.btnMyProduct.BorderSize = 0;
            this.btnMyProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMyProduct.FlatAppearance.BorderSize = 0;
            this.btnMyProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyProduct.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyProduct.ForeColor = System.Drawing.Color.Black;
            this.btnMyProduct.Image = global::ProjectWin_Demo_.Properties.Resources.icons8_product_50;
            this.btnMyProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyProduct.Location = new System.Drawing.Point(0, 100);
            this.btnMyProduct.Name = "btnMyProduct";
            this.btnMyProduct.Size = new System.Drawing.Size(175, 70);
            this.btnMyProduct.TabIndex = 7;
            this.btnMyProduct.Text = "Sản phẩm\r\ncủa tôi";
            this.btnMyProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMyProduct.TextColor = System.Drawing.Color.Black;
            this.btnMyProduct.UseVisualStyleBackColor = false;
            this.btnMyProduct.Click += new System.EventHandler(this.btnMyProduct_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 85);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(175, 15);
            this.panel4.TabIndex = 13;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.PowderBlue;
            this.btnHome.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHome.BorderColor = System.Drawing.Color.SlateGray;
            this.btnHome.BorderRadius = 0;
            this.btnHome.BorderSize = 0;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Image = global::ProjectWin_Demo_.Properties.Resources.Custom_Icon_Design_Mono_General_3_Home_48;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 15);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(175, 70);
            this.btnHome.TabIndex = 8;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.TextColor = System.Drawing.Color.Black;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(175, 15);
            this.panel3.TabIndex = 12;
            // 
            // FUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1286, 744);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FUser";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCart)).EndInit();
            this.panel13.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxCart;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomButton.VBButton btnFind;
        private Funtion.RJTextBox rjTextBox1;
        private System.Windows.Forms.Panel panel13;
        private CustomButton.VBButton btnInfo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private CustomButton.VBButton btnHome;
        private System.Windows.Forms.Panel panel3;
        private CustomButton.VBButton btnLogOut;
        private System.Windows.Forms.Panel panel6;
        public CustomButton.VBButton btnMyProduct;
    }
}