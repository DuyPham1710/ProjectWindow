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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnThongKe = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnChiTiet = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gvDanhSach = new System.Windows.Forms.DataGridView();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThongKe
            // 
            this.btnThongKe.CustomBorderColor = System.Drawing.Color.DarkTurquoise;
            this.btnThongKe.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnThongKe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThongKe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongKe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongKe.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongKe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThongKe.FillColor = System.Drawing.Color.Transparent;
            this.btnThongKe.FillColor2 = System.Drawing.Color.Transparent;
            this.btnThongKe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.Black;
            this.btnThongKe.Location = new System.Drawing.Point(91, 12);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(2);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(192, 51);
            this.btnThongKe.TabIndex = 23;
            this.btnThongKe.Text = "Danh sách khách hàng";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.CustomBorderColor = System.Drawing.Color.White;
            this.btnChiTiet.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnChiTiet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChiTiet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChiTiet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChiTiet.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChiTiet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChiTiet.FillColor = System.Drawing.Color.Transparent;
            this.btnChiTiet.FillColor2 = System.Drawing.Color.Transparent;
            this.btnChiTiet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTiet.ForeColor = System.Drawing.Color.Black;
            this.btnChiTiet.Location = new System.Drawing.Point(287, 12);
            this.btnChiTiet.Margin = new System.Windows.Forms.Padding(2);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(192, 51);
            this.btnChiTiet.TabIndex = 24;
            this.btnChiTiet.Text = "Khách hàng hay mua";
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.gvDanhSach);
            this.panel1.Location = new System.Drawing.Point(54, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 626);
            this.panel1.TabIndex = 26;
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.gvDanhSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.gvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvDanhSach.BackgroundColor = System.Drawing.Color.White;
            this.gvDanhSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvDanhSach.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.gvDanhSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDanhSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.gvDanhSach.ColumnHeadersHeight = 27;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvDanhSach.DefaultCellStyle = dataGridViewCellStyle19;
            this.gvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvDanhSach.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gvDanhSach.EnableHeadersVisualStyles = false;
            this.gvDanhSach.GridColor = System.Drawing.Color.RosyBrown;
            this.gvDanhSach.Location = new System.Drawing.Point(0, 0);
            this.gvDanhSach.Margin = new System.Windows.Forms.Padding(2);
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDanhSach.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.gvDanhSach.RowHeadersWidth = 51;
            this.gvDanhSach.RowTemplate.Height = 28;
            this.gvDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDanhSach.Size = new System.Drawing.Size(1078, 626);
            this.gvDanhSach.TabIndex = 27;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.panel1;
            // 
            // FKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1180, 725);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.btnThongKe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FKhachHang";
            this.Text = "FKhachHang";
            this.Load += new System.EventHandler(this.FKhachHang_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnThongKe;
        private Guna.UI2.WinForms.Guna2GradientButton btnChiTiet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gvDanhSach;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}