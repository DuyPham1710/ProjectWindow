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

namespace ProjectWin_Demo_.UC
{
    public partial class UCQuyTrinhDonHang : UserControl
    {
        SanPham sp;
        int id;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public event EventHandler ButtonClickCustom;
        public event EventHandler ButtonClick_HuyDonHang;
        string[] AnhCu = { };
        int MaVanChuyen;
        DaMuaDAO daMuaDAO;
        public UCQuyTrinhDonHang(SanPham sp, int id, int MaVanChuyen)
        {
            InitializeComponent();
            this.id = id;
            this.sp = sp;
            this.MaVanChuyen = MaVanChuyen;
            daMuaDAO = new DaMuaDAO(id);
        }

        private void UCProcessSales_Load(object sender, EventArgs e)
        {
            List<string> thongTin = daMuaDAO.LoadThongTinQuyTrinh(MaVanChuyen);

            lblNguoiMua.Text = thongTin[0];
            lblMaVanChuyen.Text = MaVanChuyen.ToString();
            lblSoLuong.Text = thongTin[1];
            lblTenSP.Text = sp.TenSP;
            lblGia.Text = sp.GiaHienTai + "đ";
            lblTongTien.Text = sp.GiaHienTai + "đ";
            lblMaSP.Text = sp.MaSP;
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
