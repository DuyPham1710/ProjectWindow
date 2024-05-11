namespace ProjectWin_Demo_
{
    partial class FKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDSKhachHang = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnKHHayMua = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gvDanhSach = new System.Windows.Forms.DataGridView();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnKHDaHuy = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDSKhachHang
            // 
            this.btnDSKhachHang.Animated = true;
            this.btnDSKhachHang.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDSKhachHang.BorderRadius = 7;
            this.btnDSKhachHang.CustomBorderColor = System.Drawing.Color.DarkTurquoise;
            this.btnDSKhachHang.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnDSKhachHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDSKhachHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDSKhachHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDSKhachHang.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDSKhachHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDSKhachHang.FillColor = System.Drawing.Color.White;
            this.btnDSKhachHang.FillColor2 = System.Drawing.Color.White;
            this.btnDSKhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSKhachHang.ForeColor = System.Drawing.Color.Black;
            this.btnDSKhachHang.Location = new System.Drawing.Point(66, 13);
            this.btnDSKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.btnDSKhachHang.Name = "btnDSKhachHang";
            this.btnDSKhachHang.Size = new System.Drawing.Size(192, 51);
            this.btnDSKhachHang.TabIndex = 23;
            this.btnDSKhachHang.Text = "Danh sách khách hàng";
            this.btnDSKhachHang.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnKHHayMua
            // 
            this.btnKHHayMua.Animated = true;
            this.btnKHHayMua.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnKHHayMua.BorderRadius = 7;
            this.btnKHHayMua.CustomBorderColor = System.Drawing.Color.White;
            this.btnKHHayMua.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnKHHayMua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKHHayMua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKHHayMua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKHHayMua.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKHHayMua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKHHayMua.FillColor = System.Drawing.Color.White;
            this.btnKHHayMua.FillColor2 = System.Drawing.Color.White;
            this.btnKHHayMua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKHHayMua.ForeColor = System.Drawing.Color.Black;
            this.btnKHHayMua.Location = new System.Drawing.Point(254, 13);
            this.btnKHHayMua.Margin = new System.Windows.Forms.Padding(2);
            this.btnKHHayMua.Name = "btnKHHayMua";
            this.btnKHHayMua.Size = new System.Drawing.Size(192, 51);
            this.btnKHHayMua.TabIndex = 24;
            this.btnKHHayMua.Text = "Khách hàng hay mua";
            this.btnKHHayMua.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.gvDanhSach);
            this.panel1.Location = new System.Drawing.Point(36, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1107, 626);
            this.panel1.TabIndex = 26;
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.gvDanhSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvDanhSach.BackgroundColor = System.Drawing.Color.White;
            this.gvDanhSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvDanhSach.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.gvDanhSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDanhSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvDanhSach.ColumnHeadersHeight = 27;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvDanhSach.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvDanhSach.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gvDanhSach.EnableHeadersVisualStyles = false;
            this.gvDanhSach.GridColor = System.Drawing.Color.RosyBrown;
            this.gvDanhSach.Location = new System.Drawing.Point(0, 0);
            this.gvDanhSach.Margin = new System.Windows.Forms.Padding(2);
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.ReadOnly = true;
            this.gvDanhSach.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDanhSach.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gvDanhSach.RowHeadersWidth = 51;
            this.gvDanhSach.RowTemplate.Height = 28;
            this.gvDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDanhSach.Size = new System.Drawing.Size(1107, 626);
            this.gvDanhSach.TabIndex = 27;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.panel1;
            // 
            // btnKHDaHuy
            // 
            this.btnKHDaHuy.Animated = true;
            this.btnKHDaHuy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnKHDaHuy.BorderRadius = 7;
            this.btnKHDaHuy.CustomBorderColor = System.Drawing.Color.White;
            this.btnKHDaHuy.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnKHDaHuy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKHDaHuy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKHDaHuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKHDaHuy.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKHDaHuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKHDaHuy.FillColor = System.Drawing.Color.White;
            this.btnKHDaHuy.FillColor2 = System.Drawing.Color.White;
            this.btnKHDaHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKHDaHuy.ForeColor = System.Drawing.Color.Black;
            this.btnKHDaHuy.Location = new System.Drawing.Point(446, 13);
            this.btnKHDaHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnKHDaHuy.Name = "btnKHDaHuy";
            this.btnKHDaHuy.Size = new System.Drawing.Size(192, 51);
            this.btnKHDaHuy.TabIndex = 27;
            this.btnKHDaHuy.Text = "Khách hàng đã hủy";
            this.btnKHDaHuy.Click += new System.EventHandler(this.btnKHDaHuy_Click);
            // 
            // FKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1180, 725);
            this.Controls.Add(this.btnKHDaHuy);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnKHHayMua);
            this.Controls.Add(this.btnDSKhachHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FKhachHang";
            this.Text = "FKhachHang";
            this.Load += new System.EventHandler(this.FKhachHang_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnDSKhachHang;
        private Guna.UI2.WinForms.Guna2GradientButton btnKHHayMua;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gvDanhSach;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientButton btnKHDaHuy;
    }
}