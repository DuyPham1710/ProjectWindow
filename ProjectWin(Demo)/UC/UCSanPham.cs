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
    public partial class UCSanPham : UserControl
    {
        SanPham sp;
        int id;
        internal object btnXacNhan;
        string[] AnhCu = { };
        private bool chon = false;
        public UCSanPham(SanPham sp, int id)
        {
            InitializeComponent();
            this.sp = sp;
            this.id = id;
        }
        public UCSanPham() 
        {
            InitializeComponent();
        }
        private void UCProducts_Click(object sender, EventArgs e)
        {
            FChiTiet fChiTiet = new FChiTiet(sp, id);
            fChiTiet.ShowDialog();
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
            lblGiaSP.Text = sp.GiaHienTai + "đ";
            lblGiaBanDau.Text = sp.GiaBanDau + "đ";
            lblGiaBanDau.Font = new Font(lblGiaBanDau.Font, FontStyle.Strikeout);
            lblDiaChiShop.Text = sp.XuatXu;
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

        private void btnQuanTam_Click(object sender, EventArgs e)
        {
            if (chon == false)
            {
                btnQuanTam.Image = new Bitmap(Application.StartupPath + "\\Resources\\TimDo.png");
                chon = true;
            }
            else
            {
                btnQuanTam.Image = new Bitmap(Application.StartupPath + "\\Resources\\TimTrang.png");
                chon = false;
            }
           
        }
    }
}
