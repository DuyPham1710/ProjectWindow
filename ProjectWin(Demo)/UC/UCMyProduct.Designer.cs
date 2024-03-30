namespace ProjectWin_Demo_
{
    partial class UCMyProduct
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
            this.lblMaSP = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblDanhMuc = new System.Windows.Forms.Label();
            this.btnEdit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnDelete = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pctSanPham = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblMaSP.Location = new System.Drawing.Point(108, 59);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(67, 16);
            this.lblMaSP.TabIndex = 2;
            this.lblMaSP.Text = "Mã: 00198";
            this.lblMaSP.MouseLeave += new System.EventHandler(this.pcbDelete_MouseLeave);
            this.lblMaSP.MouseHover += new System.EventHandler(this.pcbDelete_MouseHover);
            // 
            // lblTenSP
            // 
            this.lblTenSP.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.Location = new System.Drawing.Point(110, 12);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(379, 44);
            this.lblTenSP.TabIndex = 3;
            this.lblTenSP.Text = "Smart Tivi 4K Sony KD-55X75K 55 inch Google TV";
            this.lblTenSP.MouseLeave += new System.EventHandler(this.pcbDelete_MouseLeave);
            this.lblTenSP.MouseHover += new System.EventHandler(this.pcbDelete_MouseHover);
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(922, 32);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(27, 20);
            this.lblSoLuong.TabIndex = 13;
            this.lblSoLuong.Text = "14";
            this.lblSoLuong.MouseLeave += new System.EventHandler(this.pcbDelete_MouseLeave);
            this.lblSoLuong.MouseHover += new System.EventHandler(this.pcbDelete_MouseHover);
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.Location = new System.Drawing.Point(1087, 32);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(99, 20);
            this.lblGia.TabIndex = 14;
            this.lblGia.Text = "10.110.000đ";
            this.lblGia.MouseLeave += new System.EventHandler(this.pcbDelete_MouseLeave);
            this.lblGia.MouseHover += new System.EventHandler(this.pcbDelete_MouseHover);
            // 
            // lblDanhMuc
            // 
            this.lblDanhMuc.AutoSize = true;
            this.lblDanhMuc.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhMuc.Location = new System.Drawing.Point(684, 32);
            this.lblDanhMuc.Name = "lblDanhMuc";
            this.lblDanhMuc.Size = new System.Drawing.Size(63, 20);
            this.lblDanhMuc.TabIndex = 16;
            this.lblDanhMuc.Text = "Điện tử";
            this.lblDanhMuc.MouseLeave += new System.EventHandler(this.pcbDelete_MouseLeave);
            this.lblDanhMuc.MouseHover += new System.EventHandler(this.pcbDelete_MouseHover);
            // 
            // btnEdit
            // 
            this.btnEdit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnEdit.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.btnEdit.Image = global::ProjectWin_Demo_.Properties.Resources.Iconoir_Team_Iconoir_Settings_48;
            this.btnEdit.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnEdit.ImageRotate = 0F;
            this.btnEdit.ImageSize = new System.Drawing.Size(32, 32);
            this.btnEdit.Location = new System.Drawing.Point(1312, 24);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.btnEdit.Size = new System.Drawing.Size(32, 32);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Click += new System.EventHandler(this.pcbEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnDelete.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.btnDelete.Image = global::ProjectWin_Demo_.Properties.Resources.trash_can_regular;
            this.btnDelete.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnDelete.ImageRotate = 0F;
            this.btnDelete.ImageSize = new System.Drawing.Size(32, 32);
            this.btnDelete.Location = new System.Drawing.Point(1362, 24);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.btnDelete.Size = new System.Drawing.Size(32, 32);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Click += new System.EventHandler(this.pcbDelete_Click);
            // 
            // pctSanPham
            // 
            this.pctSanPham.Image = global::ProjectWin_Demo_.Properties.Resources._1;
            this.pctSanPham.Location = new System.Drawing.Point(16, 3);
            this.pctSanPham.Name = "pctSanPham";
            this.pctSanPham.Size = new System.Drawing.Size(84, 84);
            this.pctSanPham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctSanPham.TabIndex = 0;
            this.pctSanPham.TabStop = false;
            this.pctSanPham.MouseLeave += new System.EventHandler(this.pcbDelete_MouseLeave);
            this.pctSanPham.MouseHover += new System.EventHandler(this.pcbDelete_MouseHover);
            // 
            // UCMyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblDanhMuc);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.lblMaSP);
            this.Controls.Add(this.pctSanPham);
            this.Name = "UCMyProduct";
            this.Size = new System.Drawing.Size(1435, 90);
            this.Load += new System.EventHandler(this.UCMyProduct_Load);
            this.MouseLeave += new System.EventHandler(this.pcbDelete_MouseLeave);
            this.MouseHover += new System.EventHandler(this.pcbDelete_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.pctSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pctSanPham;
        public System.Windows.Forms.Label lblMaSP;
        public System.Windows.Forms.Label lblTenSP;
        public System.Windows.Forms.Label lblSoLuong;
        public System.Windows.Forms.Label lblGia;
        public System.Windows.Forms.Label lblDanhMuc;
        public Guna.UI2.WinForms.Guna2ImageButton btnDelete;
        public Guna.UI2.WinForms.Guna2ImageButton btnEdit;
    }
}
