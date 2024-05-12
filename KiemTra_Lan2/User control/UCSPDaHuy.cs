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
    public partial class UCSPDaHuy : UserControl
    {
        private int id;
        private SanPham sp;
        string[] AnhCu = { };
        private int maVanChuyen;
        TraoDoiHangDF db = new TraoDoiHangDF();
        public UCSPDaHuy(SanPham sp, int id, int maVanChuyen)
        {
            InitializeComponent();
            this.id = id;
            this.sp = sp;
            this.maVanChuyen = maVanChuyen;

        }

        private void UCSPDaHuy_Load(object sender, EventArgs e)
        {
            lblMaSP.Text = "Mã sản phẩm: " + sp.MSP;
            lblMaVanChuyen.Text = "Mã vận chuyển: " + maVanChuyen.ToString();
            lblTenSP.Text = sp.TenSP;
            lblPhanLoai.Text = "Phân loại hàng:" + sp.DanhMuc;
            lblGiaBanDau.Text = sp.GiaTienLucMoiMua;
            lblGiaBanDau.Font = new Font(lblGiaBanDau.Font, FontStyle.Strikeout);
            lblDonGia.Text = sp.GiaTienBayGio + "đ";
            lblThanhTien.Text = sp.GiaTienBayGio + "đ";
            lblSoLuong.Text = "x" + sp.SoLuong;
            if (sp.AnhBayGio != "")
                AnhCu = sp.AnhBayGio.Split(',');
            if (AnhCu.Length > 0)
            {
                Bitmap bitmap = new Bitmap(Application.StartupPath + "\\AnhSanPham\\" + sp.MSP + "\\" + AnhCu[0]);
                pctSanPham.Image = bitmap;
            }
            else
                pctSanPham.Image = null;

            string tenShop = (from person in db.People
                              join sanPham in db.SanPhams on person.ID equals sanPham.IDChuSP
                              where sanPham.MSP == sp.MSP
                              select person.FullName).FirstOrDefault();
            lblTenShop.Text = tenShop;
        }
        private void btnMuaLai_Click(object sender, EventArgs e)
        {
            SanPham sp = (from sanPham in db.SanPhams
                        join daMua in db.DaMuas on sanPham.MSP equals daMua.MSP
                        where daMua.MaVanChuyen == maVanChuyen && daMua.TrangThai == "Đã hủy"
                        select sanPham).FirstOrDefault();
            FChiTiet fChiTiet = new FChiTiet(sp, id);
            fChiTiet.ShowDialog();
        }
        private void pcbDelete_MouseHover(object sender, EventArgs e)
        {
            pctSanPham.SizeMode = PictureBoxSizeMode.StretchImage;
            ShadowPanel.FillColor = Color.LightCyan;
            this.BackColor = Color.LightCyan;
        }

        private void pcbDelete_MouseLeave(object sender, EventArgs e)
        {
            pctSanPham.SizeMode = PictureBoxSizeMode.Zoom;
            ShadowPanel.FillColor = Color.White;
            this.BackColor = Color.White;
        }
    }
}
