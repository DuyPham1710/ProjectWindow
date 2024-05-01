namespace ProjectWin_Demo_
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
            this.fPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fPanel.Location = new System.Drawing.Point(0, 0);
            this.fPanel.Name = "fPanel";
            this.fPanel.Size = new System.Drawing.Size(1450, 742);
            this.fPanel.TabIndex = 0;
            // 
            // UCLichSuDaMua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.fPanel);
            this.Name = "UCLichSuDaMua";
            this.Size = new System.Drawing.Size(1450, 742);
            this.Load += new System.EventHandler(this.UCHistory_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fPanel;
    }
}
