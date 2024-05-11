using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace ProjectWin_Demo_
{
    public partial class UCShop : UserControl
    {
        private int id;
        private int idShop;
        private string Name;
        private byte[] Avt;
        private int SoLuong;
        private string DiaChi;
        MemoryStream ms;
        public UCShop(int id, int idShop, string name, byte[] avt, int soluong, string DiaChi)
        {
            InitializeComponent();
            this.id = id;
            this.idShop = idShop;
            Name = name;
            SoLuong = soluong;
            Avt = avt;
            this.DiaChi = DiaChi;
        }

        private void UCShop_Load(object sender, EventArgs e)
        {
            ms = new MemoryStream(Avt);
            lblName.Text = Name;
            lblDiaChi.Text = DiaChi;
            pcbAvt.Image = Image.FromStream(ms);
            lblSoSanPham.Text = "Tổng: " + SoLuong.ToString() + " sản phẩm";
        }

        private void btnGheShop_Click(object sender, EventArgs e)
        {
            FChiTietShop fChiTietShop = new FChiTietShop(id, idShop);
            fChiTietShop.ShowDialog();
        }
    }
}