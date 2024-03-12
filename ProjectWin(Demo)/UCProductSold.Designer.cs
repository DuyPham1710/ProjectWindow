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
            this.ucMyProduct3 = new ProjectWin_Demo_.UCMyProduct();
            this.ucMyProduct2 = new ProjectWin_Demo_.UCMyProduct();
            this.ucMyProduct1 = new ProjectWin_Demo_.UCMyProduct();
            this.SuspendLayout();
            // 
            // ucMyProduct3
            // 
            this.ucMyProduct3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ucMyProduct3.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucMyProduct3.Location = new System.Drawing.Point(0, 180);
            this.ucMyProduct3.Name = "ucMyProduct3";
            this.ucMyProduct3.Size = new System.Drawing.Size(1104, 90);
            this.ucMyProduct3.TabIndex = 2;
            // 
            // ucMyProduct2
            // 
            this.ucMyProduct2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ucMyProduct2.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucMyProduct2.Location = new System.Drawing.Point(0, 90);
            this.ucMyProduct2.Name = "ucMyProduct2";
            this.ucMyProduct2.Size = new System.Drawing.Size(1104, 90);
            this.ucMyProduct2.TabIndex = 1;
            // 
            // ucMyProduct1
            // 
            this.ucMyProduct1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ucMyProduct1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucMyProduct1.Location = new System.Drawing.Point(0, 0);
            this.ucMyProduct1.Name = "ucMyProduct1";
            this.ucMyProduct1.Size = new System.Drawing.Size(1104, 90);
            this.ucMyProduct1.TabIndex = 0;
            // 
            // UCProductSold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucMyProduct3);
            this.Controls.Add(this.ucMyProduct2);
            this.Controls.Add(this.ucMyProduct1);
            this.Name = "UCProductSold";
            this.Size = new System.Drawing.Size(1104, 579);
            this.ResumeLayout(false);

        }

        #endregion

        private UCMyProduct ucMyProduct1;
        private UCMyProduct ucMyProduct2;
        private UCMyProduct ucMyProduct3;
    }
}
