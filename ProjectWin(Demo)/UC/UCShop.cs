using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System;

namespace ProjectWin_Demo_
{
    public partial class UCShop : UserControl
    {
        private int iD;
        private string Name;
        private byte[] Avt;
        private int SoLuong;
        MemoryStream ms;
        public UCShop(int id, string name, byte[] avt, int soluong)
        {
            InitializeComponent();
            this.iD = id;
            lblName.Text = name;
            ms = new MemoryStream(avt);
            pcbAvt.Image = Image.FromStream(ms);
            lblSoSanPham.Text = "Tổng: " + soluong.ToString() + " sản phẩm";
        }

        private void UCShop_Load(object sender, EventArgs e)
        {

        }

        private void btnGheShop_Click(object sender, EventArgs e)
        {
            FChiTietShop fChiTietShop = new FChiTietShop();
            fChiTietShop.ShowDialog();
        }
    }
}