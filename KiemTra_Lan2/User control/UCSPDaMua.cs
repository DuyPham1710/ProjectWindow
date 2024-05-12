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
    public partial class UCSPDaMua : UserControl
    {
        SanPham sp;
        private int id;
        string[] AnhCu = { };
        int maVanChuyen;
        TraoDoiHangDF db = new TraoDoiHangDF();
        public UCSPDaMua(SanPham sp, int id, int maVanChuyen)
        {
            InitializeComponent();
            this.sp = sp;
            this.id = id;
            this.maVanChuyen = maVanChuyen;
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
            lblMaVanChuyen.Text = "Mã vận chuyển: " + maVanChuyen.ToString();
            lblTenSP.Text = sp.TenSP;
            lblGia.Text = sp.GiaTienBayGio + "đ";
            lblTongTien.Text = sp.GiaTienBayGio + "đ";
            lblSoLuongSP.Text = sp.SoLuong;
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
    }
}
