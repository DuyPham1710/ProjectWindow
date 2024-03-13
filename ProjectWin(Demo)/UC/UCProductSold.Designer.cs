namespace ProjectWin_Demo_
{
    partial class UCProductSold
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
            this.ucMyProduct1 = new ProjectWin_Demo_.UCMyProduct();
            this.ucMyProduct2 = new ProjectWin_Demo_.UCMyProduct();
            this.ucMyProduct3 = new ProjectWin_Demo_.UCMyProduct();
            this.ucMyProduct4 = new ProjectWin_Demo_.UCMyProduct();
            this.ucMyProduct5 = new ProjectWin_Demo_.UCMyProduct();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucMyProduct1
            // 
            this.ucMyProduct1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ucMyProduct1.Location = new System.Drawing.Point(3, 439);
            this.ucMyProduct1.Name = "ucMyProduct1";
            this.ucMyProduct1.Padding = new System.Windows.Forms.Padding(15);
            this.ucMyProduct1.Size = new System.Drawing.Size(1200, 103);
            this.ucMyProduct1.TabIndex = 0;
            // 
            // ucMyProduct2
            // 
            this.ucMyProduct2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ucMyProduct2.Location = new System.Drawing.Point(3, 3);
            this.ucMyProduct2.Name = "ucMyProduct2";
            this.ucMyProduct2.Padding = new System.Windows.Forms.Padding(15);
            this.ucMyProduct2.Size = new System.Drawing.Size(1200, 103);
            this.ucMyProduct2.TabIndex = 1;
            // 
            // ucMyProduct3
            // 
            this.ucMyProduct3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ucMyProduct3.Location = new System.Drawing.Point(3, 330);
            this.ucMyProduct3.Name = "ucMyProduct3";
            this.ucMyProduct3.Padding = new System.Windows.Forms.Padding(15);
            this.ucMyProduct3.Size = new System.Drawing.Size(1200, 103);
            this.ucMyProduct3.TabIndex = 2;
            // 
            // ucMyProduct4
            // 
            this.ucMyProduct4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ucMyProduct4.Location = new System.Drawing.Point(3, 221);
            this.ucMyProduct4.Name = "ucMyProduct4";
            this.ucMyProduct4.Padding = new System.Windows.Forms.Padding(15);
            this.ucMyProduct4.Size = new System.Drawing.Size(1200, 103);
            this.ucMyProduct4.TabIndex = 3;
            // 
            // ucMyProduct5
            // 
            this.ucMyProduct5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ucMyProduct5.Location = new System.Drawing.Point(3, 112);
            this.ucMyProduct5.Name = "ucMyProduct5";
            this.ucMyProduct5.Padding = new System.Windows.Forms.Padding(15);
            this.ucMyProduct5.Size = new System.Drawing.Size(1200, 103);
            this.ucMyProduct5.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.GhostWhite;
            this.flowLayoutPanel1.Controls.Add(this.ucMyProduct2);
            this.flowLayoutPanel1.Controls.Add(this.ucMyProduct5);
            this.flowLayoutPanel1.Controls.Add(this.ucMyProduct4);
            this.flowLayoutPanel1.Controls.Add(this.ucMyProduct3);
            this.flowLayoutPanel1.Controls.Add(this.ucMyProduct1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1200, 651);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // UCProductSold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "UCProductSold";
            this.Size = new System.Drawing.Size(1200, 651);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UCMyProduct ucMyProduct1;
        private UCMyProduct ucMyProduct2;
        private UCMyProduct ucMyProduct3;
        private UCMyProduct ucMyProduct4;
        private UCMyProduct ucMyProduct5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
