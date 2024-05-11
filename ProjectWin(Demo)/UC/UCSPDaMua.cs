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
    public partial class UCSPDaMua : UserControl
    {
        SanPham sp;
        private int id;
        string[] AnhCu = { };
        NguoiDAO nguoiDao;
        public UCSPDaMua(SanPham sp, int id)
        {
            InitializeComponent();
            this.sp = sp;
            this.id = id;
            nguoiDao = new NguoiDAO(id);
        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            FDanhGia fComment = new FDanhGia(id, sp);
            fComment.ShowDialog();
        }

        private void btnPayAgain_Click(object sender, EventArgs e)
        {
            FChiTiet fDetail = new FChiTiet(sp, id);
            fDetail.ShowDialog();
        }

        private void UCHisProduct_Load(object sender, EventArgs e)
        {
            lblMaVanChuyen.Text = "Mã vận chuyển: " + sp.MaVanChuyen.ToString();
            lblTenSP.Text = sp.TenSP;
            lblGia.Text = sp.GiaHienTai + "đ";
            lblTongTien.Text = sp.GiaHienTai + "đ";
            lblSoLuongSP.Text = sp.SoLuong;
            if (sp.AnhHienTai != "")
                AnhCu = sp.AnhHienTai.Split(',');
            if (AnhCu.Length > 0)
            {
                Bitmap bitmap = new Bitmap(Application.StartupPath + "\\AnhSanPham\\" + sp.MaSP + "\\" + AnhCu[0]);
                pctSanPham.Image = bitmap;
            }
            else
                pctSanPham.Image = null;
            lblTenShop.Text = nguoiDao.LoadTenShop(sp.MaSP);
        }
    }
}
