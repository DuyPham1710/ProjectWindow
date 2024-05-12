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

namespace KiemTra_Lan2
{
    public partial class UCQuyTrinhDonHang : UserControl
    {
        SanPham sp;
        int id;
        public event EventHandler ButtonClickCustom;
        public event EventHandler ButtonClick_HuyDonHang;
        string[] AnhCu = { };
        int MaVanChuyen;
        TraoDoiHangDF db = new TraoDoiHangDF();
        public UCQuyTrinhDonHang(SanPham sp, int id, int MaVanChuyen)
        {
            InitializeComponent();
            this.id = id;
            this.sp = sp;
            this.MaVanChuyen = MaVanChuyen;
        }

        private void UCProcessSales_Load(object sender, EventArgs e)
        {
            //List<string> thongTin = daMuaDAO.LoadThongTinQuyTrinh(MaVanChuyen);
            var thongTin = from person in db.People
                        join daMua in db.DaMuas on person.ID equals daMua.ID
                        where daMua.MaVanChuyen == MaVanChuyen
                        select new
                        {
                            person.FullName,
                            daMua.SoLuongDaMua
                        };

            lblNguoiMua.Text = thongTin.First().FullName;
            lblMaVanChuyen.Text = MaVanChuyen.ToString();
            lblSoLuong.Text = thongTin.First().SoLuongDaMua;
            lblTenSP.Text = sp.TenSP;
            lblGia.Text = sp.GiaTienBayGio + "đ";
            lblTongTien.Text = sp.GiaTienBayGio + "đ";
            lblMaSP.Text = sp.MSP;
            if (sp.AnhBayGio != "")
                AnhCu = sp.AnhBayGio.Split(',');
            if (AnhCu.Length > 0)
            {
                Bitmap bitmap = new Bitmap(Application.StartupPath + "\\AnhSanPham\\" + sp.MSP + "\\" + AnhCu[0]);
                pctSanPham.Image = bitmap;
            }
            else
                pctSanPham.Image = null;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            ButtonClickCustom?.Invoke(this, e);
        }

        private void btnHuyDon_Click(object sender, EventArgs e)
        {
            ButtonClick_HuyDonHang?.Invoke(this, e);
        }
    }
}
