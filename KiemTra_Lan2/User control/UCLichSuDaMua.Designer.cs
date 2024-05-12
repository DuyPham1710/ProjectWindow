namespace KiemTra_Lan2
{
    partial class UCLichSuDaMua
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
            this.fPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // fPanel
            // 
            this.fPanel.AutoScroll = true;
            this.fPanel.BackColor = System.Drawing.Color.White;
            this.fPanel.Location = new System.Drawing.Point(17, 29);
            this.fPanel.Margin = new System.Windows.Forms.Padding(2);
            this.fPanel.Name = "fPanel";
            this.fPanel.Size = new System.Drawing.Size(1146, 606);
            this.fPanel.TabIndex = 0;
            // 
            // UCLichSuDaMua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.fPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCLichSuDaMua";
            this.Size = new System.Drawing.Size(1180, 684);
            this.Load += new System.EventHandler(this.UCHistory_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fPanel;
    }
}
