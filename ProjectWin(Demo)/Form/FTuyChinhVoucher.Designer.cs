namespace ProjectWin_Demo_
{
    partial class FTuyChinhVoucher
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
            this.components = new System.ComponentModel.Container();
            this.btnTroLai = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnThem = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.DtpHSD = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.nudSoLuong = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtMaVoucher = new ProjectWin_Demo_.Funtion.RJTextBox();
            this.txtGiaTri = new ProjectWin_Demo_.Funtion.RJTextBox();
            this.txtMota = new ProjectWin_Demo_.Funtion.RJTextBox();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTroLai
            // 
            this.btnTroLai.BorderRadius = 10;
            this.btnTroLai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTroLai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTroLai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTroLai.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTroLai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTroLai.FillColor = System.Drawing.Color.Snow;
            this.btnTroLai.FillColor2 = System.Drawing.Color.Snow;
            this.btnTroLai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroLai.ForeColor = System.Drawing.Color.Black;
            this.btnTroLai.Location = new System.Drawing.Point(202, 382);
            this.btnTroLai.Margin = new System.Windows.Forms.Padding(2);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(125, 46);
            this.btnTroLai.TabIndex = 41;
            this.btnTroLai.Text = "Trở lại";
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.Animated = true;
            this.btnThem.BorderRadius = 10;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.FillColor = System.Drawing.Color.Tomato;
            this.btnThem.FillColor2 = System.Drawing.Color.DarkOrange;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(346, 382);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(125, 46);
            this.btnThem.TabIndex = 40;
            this.btnThem.Text = "Thêm Voucher";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(27, 25);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(140, 24);
            this.lblTieuDe.TabIndex = 41;
            this.lblTieuDe.Text = "Thêm Voucher";
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.Color.Transparent;
            this.groupBox10.Controls.Add(this.DtpHSD);
            this.groupBox10.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.groupBox10.Location = new System.Drawing.Point(29, 286);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox10.Size = new System.Drawing.Size(309, 57);
            this.groupBox10.TabIndex = 39;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Hạn sử dụng";
            // 
            // DtpHSD
            // 
            this.DtpHSD.Animated = true;
            this.DtpHSD.BackColor = System.Drawing.SystemColors.Window;
            this.DtpHSD.BorderColor = System.Drawing.Color.Gray;
            this.DtpHSD.BorderRadius = 10;
            this.DtpHSD.BorderThickness = 1;
            this.DtpHSD.Checked = true;
            this.DtpHSD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtpHSD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DtpHSD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DtpHSD.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DtpHSD.Location = new System.Drawing.Point(2, 19);
            this.DtpHSD.Margin = new System.Windows.Forms.Padding(2);
            this.DtpHSD.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtpHSD.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DtpHSD.Name = "DtpHSD";
            this.DtpHSD.Size = new System.Drawing.Size(305, 36);
            this.DtpHSD.TabIndex = 0;
            this.DtpHSD.Value = new System.DateTime(2024, 3, 14, 0, 30, 40, 833);
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.Transparent;
            this.groupBox9.Controls.Add(this.txtGiaTri);
            this.groupBox9.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.groupBox9.Location = new System.Drawing.Point(29, 214);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox9.Size = new System.Drawing.Size(309, 51);
            this.groupBox9.TabIndex = 38;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Giá trị";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtMota);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(29, 145);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(309, 51);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mô tả Voucher";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.txtMaVoucher);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(29, 68);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(309, 51);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mã Voucher";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.nudSoLuong);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(377, 68);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(96, 51);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Số lượng";
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.BackColor = System.Drawing.Color.Transparent;
            this.nudSoLuong.BorderColor = System.Drawing.Color.Gray;
            this.nudSoLuong.BorderRadius = 10;
            this.nudSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudSoLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudSoLuong.Location = new System.Drawing.Point(2, 19);
            this.nudSoLuong.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(92, 30);
            this.nudSoLuong.TabIndex = 0;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 17;
            this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.DimGray;
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 17;
            this.guna2Elipse1.TargetControl = this;
            // 
            // txtMaVoucher
            // 
            this.txtMaVoucher.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaVoucher.BorderColor = System.Drawing.Color.Gray;
            this.txtMaVoucher.BorderFocusColor = System.Drawing.Color.DarkCyan;
            this.txtMaVoucher.BorderRadius = 10;
            this.txtMaVoucher.BorderSize = 1;
            this.txtMaVoucher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaVoucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaVoucher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaVoucher.Location = new System.Drawing.Point(2, 19);
            this.txtMaVoucher.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaVoucher.Multiline = false;
            this.txtMaVoucher.Name = "txtMaVoucher";
            this.txtMaVoucher.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtMaVoucher.PasswordChar = false;
            this.txtMaVoucher.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaVoucher.PlaceholderText = "";
            this.txtMaVoucher.Size = new System.Drawing.Size(305, 29);
            this.txtMaVoucher.TabIndex = 2;
            this.txtMaVoucher.Texts = "";
            this.txtMaVoucher.UnderlinedStyle = false;
            // 
            // txtGiaTri
            // 
            this.txtGiaTri.BackColor = System.Drawing.SystemColors.Window;
            this.txtGiaTri.BorderColor = System.Drawing.Color.Gray;
            this.txtGiaTri.BorderFocusColor = System.Drawing.Color.DarkCyan;
            this.txtGiaTri.BorderRadius = 10;
            this.txtGiaTri.BorderSize = 1;
            this.txtGiaTri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGiaTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaTri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGiaTri.Location = new System.Drawing.Point(2, 19);
            this.txtGiaTri.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaTri.Multiline = false;
            this.txtGiaTri.Name = "txtGiaTri";
            this.txtGiaTri.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtGiaTri.PasswordChar = false;
            this.txtGiaTri.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtGiaTri.PlaceholderText = "";
            this.txtGiaTri.Size = new System.Drawing.Size(305, 29);
            this.txtGiaTri.TabIndex = 1;
            this.txtGiaTri.Texts = "";
            this.txtGiaTri.UnderlinedStyle = false;
            // 
            // txtMota
            // 
            this.txtMota.BackColor = System.Drawing.SystemColors.Window;
            this.txtMota.BorderColor = System.Drawing.Color.Gray;
            this.txtMota.BorderFocusColor = System.Drawing.Color.DarkCyan;
            this.txtMota.BorderRadius = 10;
            this.txtMota.BorderSize = 1;
            this.txtMota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMota.Location = new System.Drawing.Point(2, 19);
            this.txtMota.Margin = new System.Windows.Forms.Padding(4);
            this.txtMota.Multiline = false;
            this.txtMota.Name = "txtMota";
            this.txtMota.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtMota.PasswordChar = false;
            this.txtMota.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMota.PlaceholderText = "";
            this.txtMota.Size = new System.Drawing.Size(305, 29);
            this.txtMota.TabIndex = 1;
            this.txtMota.Texts = "";
            this.txtMota.UnderlinedStyle = false;
            // 
            // FTuyChinhVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(503, 464);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FTuyChinhVoucher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FThemVoucher";
            this.Load += new System.EventHandler(this.FThemVoucher_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseUp);
            this.groupBox10.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox10;
        private Guna.UI2.WinForms.Guna2DateTimePicker DtpHSD;
        private System.Windows.Forms.GroupBox groupBox9;
        private Funtion.RJTextBox txtGiaTri;
        private System.Windows.Forms.GroupBox groupBox2;
        private Funtion.RJTextBox txtMota;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudSoLuong;
        private System.Windows.Forms.Label lblTieuDe;
        private Guna.UI2.WinForms.Guna2GradientButton btnTroLai;
        private Guna.UI2.WinForms.Guna2GradientButton btnThem;
        private Funtion.RJTextBox txtMaVoucher;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}