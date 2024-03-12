using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWin_Demo_
{
    public partial class UCProducts : UserControl
    {
        public UCProducts()
        {
            InitializeComponent();
        }
        private void UCProducts_Click(object sender, EventArgs e)
        {
            FDetail fDetail = new FDetail();
            fDetail.ShowDialog();
        }

        private void pctProduct_MouseHover(object sender, EventArgs e)
        {
            pctProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            this.BackColor = Color.MistyRose;
        }

        private void pctProduct_MouseLeave(object sender, EventArgs e)
        {
            pctProduct.SizeMode = PictureBoxSizeMode.Zoom;
            this.BackColor = Color.LightGray;
        }
    }
}
