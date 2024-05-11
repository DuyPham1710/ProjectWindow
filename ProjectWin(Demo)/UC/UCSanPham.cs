using Guna.UI2.WinForms;
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
        public bool chon = false;
        public event EventHandler BtnClick_ChiTiet;
        YeuThichDAO yeuThichDAO;
        public UCSanPham(SanPham sp, int id)
        {
            InitializeComponent();
            this.sp = sp;
            this.id = id;
            yeuThichDAO = new YeuThichDAO(id);
        }
        public UCSanPham()
        {
            InitializeComponent();
        }
        private void UCProducts_Click(object sender, EventArgs e)
        {
            BtnClick_ChiTiet?.Invoke(this, e);
        }

        private void UCProducts_Load(object sender, EventArgs e)
        {
            lblMaSP.Text = sp.MaSP;
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

            // Load yêu thích
            if (yeuThichDAO.KiemTraYeuThich(sp.MaSP))
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

        private void btnQuanTam_Click(object sender, EventArgs e)
        {
          
            if (chon == false)
            {
                yeuThichDAO.ThemYeuThich(sp.MaSP);
                btnQuanTam.Image = new Bitmap(Application.StartupPath + "\\Resources\\TimDo.png");
                chon = true;
            }
            else
            {
                yeuThichDAO.XoaYeuThich(sp.MaSP);
                btnQuanTam.Image = new Bitmap(Application.StartupPath + "\\Resources\\TimTrang.png");
                chon = false;
            }

        }
        private void GunaPanel1_MouseEnter(object sender, EventArgs e)
        {
            PanelSanPham.BorderColor = Color.Gainsboro;
        }

        private void GunaPanel1_MouseLeave(object sender, EventArgs e)
        {
            PanelSanPham.BorderColor = Color.White;
        }
    }
}
