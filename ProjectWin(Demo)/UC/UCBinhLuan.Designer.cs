namespace ProjectWin_Demo_
{
    partial class UCBinhLuan
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
            this.txtBinhLuan = new System.Windows.Forms.RichTextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.Star = new Guna.UI2.WinForms.Guna2RatingStar();
            this.pcbAvt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAvt)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBinhLuan
            // 
            this.txtBinhLuan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBinhLuan.Enabled = false;
            this.txtBinhLuan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBinhLuan.Location = new System.Drawing.Point(74, 56);
            this.txtBinhLuan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBinhLuan.Name = "txtBinhLuan";
            this.txtBinhLuan.Size = new System.Drawing.Size(901, 80);
            this.txtBinhLuan.TabIndex = 0;
            this.txtBinhLuan.Text = "Sản phẩm tuyệt vời, chất lượng sản phẩm khỏi phải bàn";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(74, 4);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(103, 19);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Nguyen Van A";
            // 
            // Star
            // 
            this.Star.Location = new System.Drawing.Point(74, 26);
            this.Star.Name = "Star";
            this.Star.RatingColor = System.Drawing.Color.Yellow;
            this.Star.Size = new System.Drawing.Size(124, 23);
            this.Star.TabIndex = 10;
            // 
            // pcbAvt
            // 
            this.pcbAvt.Enabled = false;
            this.pcbAvt.Image = global::ProjectWin_Demo_.Properties.Resources.icons8_user_64__1_;
            this.pcbAvt.Location = new System.Drawing.Point(14, 4);
            this.pcbAvt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pcbAvt.Name = "pcbAvt";
            this.pcbAvt.Size = new System.Drawing.Size(54, 57);
            this.pcbAvt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbAvt.TabIndex = 1;
            this.pcbAvt.TabStop = false;
            // 
            // UCBinhLuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Star);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.pcbAvt);
            this.Controls.Add(this.txtBinhLuan);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCBinhLuan";
            this.Size = new System.Drawing.Size(988, 155);
            this.Load += new System.EventHandler(this.UCBinhLuan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbAvt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox txtBinhLuan;
        public System.Windows.Forms.PictureBox pcbAvt;
        public System.Windows.Forms.Label lblHoTen;
        public Guna.UI2.WinForms.Guna2RatingStar Star;
    }
}
