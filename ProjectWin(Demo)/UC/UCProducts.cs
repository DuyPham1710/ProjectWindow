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
        Product sp = new Product();
        public UCProducts(Product sp)
        {
            InitializeComponent();
            this.sp = sp;
        }
        private void UCProducts_Click(object sender, EventArgs e)
        {
            FDetail fDetail = new FDetail(sp);
            fDetail.ShowDialog();
        }

        private void pctProduct_MouseHover(object sender, EventArgs e)
        {
            pctSanPham.SizeMode = PictureBoxSizeMode.StretchImage;
            this.BackColor = Color.MistyRose;
        }

        private void pctProduct_MouseLeave(object sender, EventArgs e)
        {
            pctSanPham.SizeMode = PictureBoxSizeMode.Zoom;
            this.BackColor = Color.MintCream;
        }

        private void UCProducts_Load(object sender, EventArgs e)
        {
            lblTenSP.Text = sp.TenSP;
            lblGiaSP.Text = sp.GiaHienTai + " đ";
            lblDiaChiShop.Text = sp.XuatXu;
            
        }
    }
}
