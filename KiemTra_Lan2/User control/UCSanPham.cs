using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTra_Lan2
{
    public partial class UCSanPham : UserControl
    {
        SanPham sp;
        int id;
        internal object btnXacNhan;
        string[] AnhCu = { };
        public bool chon = false;
        public event EventHandler BtnClick_ChiTiet;

        TraoDoiHangDF db = new TraoDoiHangDF();
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
            BtnClick_ChiTiet?.Invoke(this, e);
        }

        private void UCProducts_Load(object sender, EventArgs e)
        {
            lblMaSP.Text = sp.MSP;
            lblTenSP.Text = sp.TenSP;
            lblGiaSP.Text = sp.GiaTienBayGio + "đ";
            lblGiaBanDau.Text = sp.GiaTienLucMoiMua + "đ";
            lblGiaBanDau.Font = new Font(lblGiaBanDau.Font, FontStyle.Strikeout);
            lblDiaChiShop.Text = sp.XuatXu;
            if (sp.AnhBayGio != "")
                AnhCu = sp.AnhBayGio.Split(',');
            if (AnhCu.Length > 0)
            {
                Bitmap bitmap = new Bitmap(Application.StartupPath + "\\AnhSanPham\\" + sp.MSP + "\\" + AnhCu[0]);
                pctSanPham.Image = bitmap;
            }
            else
                pctSanPham.Image = null;

            // Load yêu thích
            var kiemTraYeuThich = from q in db.YeuThiches
                                  where q.IDNguoiDung == id && q.MSP == sp.MSP
                                  select q;
            if (kiemTraYeuThich.Count() > 0)
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
                YeuThich yeuThich = new YeuThich 
                {
                    IDNguoiDung = id,
                    MSP = sp.MSP
                };
                db.YeuThiches.Add(yeuThich);
                db.SaveChanges();
                btnQuanTam.Image = new Bitmap(Application.StartupPath + "\\Resources\\TimDo.png");
                chon = true;
            }
            else
            {
                YeuThich xoaYeuThich = db.YeuThiches.Where(p => p.MSP == sp.MSP && p.IDNguoiDung == id).SingleOrDefault();
                db.YeuThiches.Remove(xoaYeuThich);
                db.SaveChanges();
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
