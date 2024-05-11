using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWin_Demo_
{
    public partial class UCSPDaHuy : UserControl
    {
        private int id;
        private SanPham sp;
        string[] AnhCu = { };
        NguoiDAO nguoiDAO;
        public UCSPDaHuy(SanPham sp, int id)
        {
            InitializeComponent();
            this.id = id;
            this.sp = sp;
            nguoiDAO = new NguoiDAO(id);

        }

        private void UCSPDaHuy_Load(object sender, EventArgs e)
        {
            lblMaSP.Text = "Mã sản phẩm: " + sp.MaSP;
            lblMaVanChuyen.Text = "Mã vận chuyển: " + sp.MaVanChuyen.ToString();
            lblTenSP.Text = sp.TenSP;
            lblPhanLoai.Text = "Phân loại hàng:" + sp.DanhMuc;
            lblGiaBanDau.Text = sp.GiaBanDau;
            lblGiaBanDau.Font = new Font(lblGiaBanDau.Font, FontStyle.Strikeout);
            lblDonGia.Text = sp.GiaHienTai + "đ";
            lblThanhTien.Text = sp.GiaHienTai + "đ";
            lblSoLuong.Text = "x" + sp.SoLuong;
            if (sp.AnhHienTai != "")
                AnhCu = sp.AnhHienTai.Split(',');
            if (AnhCu.Length > 0)
            {
                Bitmap bitmap = new Bitmap(Application.StartupPath + "\\AnhSanPham\\" + sp.MaSP + "\\" + AnhCu[0]);
                pctSanPham.Image = bitmap;
            }
            else
                pctSanPham.Image = null;
            
            lblTenShop.Text = nguoiDAO.LoadTenShop(sp.MaSP);
        }
        private void btnMuaLai_Click(object sender, EventArgs e)
        {
            DaMuaDAO daMuaDao = new DaMuaDAO(id);
            SanPham sanPham = daMuaDao.MuaLai(sp.MaVanChuyen);
            FChiTiet fChiTiet = new FChiTiet(sanPham, id);
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
