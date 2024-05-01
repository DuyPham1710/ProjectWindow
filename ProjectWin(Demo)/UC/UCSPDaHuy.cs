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
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        SanPhamDao sanPhamDao;
        private int id;
        private SanPham sp;
        string[] AnhCu = { };
        public UCSPDaHuy(SanPham sp, int id)
        {
            InitializeComponent();
            this.id = id;
            this.sp = sp;
            sanPhamDao = new SanPhamDao(id);
           
        }

        private void UCSPDaHuy_Load(object sender, EventArgs e)
        {
            lblTenSP.Text = sp.TenSP;
            lblPhanLoai.Text = sp.DanhMuc;
            lblGiaBanDau.Text = sp.GiaBanDau;
            lblGiaBanDau.Font = new Font(lblGiaBanDau.Font, FontStyle.Strikeout);
            lblDonGia.Text = sp.GiaHienTai + "đ";

            lblThanhTien.Text = (Int32.Parse(sp.GiaHienTai) * Int32.Parse(sp.SoLuong)).ToString() + "đ";
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
            try
            {
                conn.Open();
                string query = string.Format("select UserName from Account, SanPham where Account.ID = SanPham.IDChuSP and MSP = '{0}'", sp.MaSP);
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    lblTenShop.Text = (string)rdr["UserName"];
                }
            }
            catch { }
            finally { conn.Close(); }
        }
        private void btnMuaLai_Click(object sender, EventArgs e)
        {

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
