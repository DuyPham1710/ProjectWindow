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
    public partial class UCSanPhamMua : UserControl
    {
        SanPham sp;
        int id;
        string[] AnhCu = { };
        public event EventHandler BtnClick_HuyDon;
        public UCSanPhamMua(SanPham sp, int id)
        {
            InitializeComponent();
            this.sp = sp;
            this.id = id;
        }

        private void btnHuyDon_Click(object sender, EventArgs e)
        {
            BtnClick_HuyDon?.Invoke(this, e);
            //FLyDoHuyDon fLyDoHuy = new FLyDoHuyDon(sp, id);
            //fLyDoHuy.ShowDialog();
        }

        private void UCSanPhamMua_Load(object sender, EventArgs e)
        {
            lblTenSP.Text = sp.TenSP;
            lblMaSP.Text = sp.MaSP;
            lblSoLuong.Text = sp.SoLuong;
            lblGia.Text = sp.GiaHienTai;
            lblDanhMuc.Text = sp.DanhMuc;
            if (sp.AnhHienTai != "")
                AnhCu = sp.AnhHienTai.Split(',');
            if (AnhCu.Length > 0)
            {
                Bitmap bitmap = new Bitmap(Application.StartupPath + "\\AnhSanPham\\" + sp.MaSP + "\\" + AnhCu[0]);
                pctSanPham.Image = bitmap;
            }
            else
                pctSanPham.Image = null;
        }
        private void pcbDelete_MouseHover(object sender, EventArgs e)
        {
            pctSanPham.SizeMode = PictureBoxSizeMode.StretchImage;
            this.BackColor = Color.LightCyan;
        }

        private void pcbDelete_MouseLeave(object sender, EventArgs e)
        {
            pctSanPham.SizeMode = PictureBoxSizeMode.Zoom;
            this.BackColor = Color.WhiteSmoke;
        }
    }
}
