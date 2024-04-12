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
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        SanPham sp;
        private int id;
        string[] AnhCu = { };
        public UCSPDaMua(SanPham sp, int id)
        {
            InitializeComponent();
            this.sp = sp;
            this.id = id;
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
            lblTenSP.Text = sp.TenSP;
            lblGia.Text = sp.GiaHienTai + "đ";
            lblTongTien.Text = sp.GiaHienTai + "đ";
            lblSoLuongSP.Text = "1 sản phẩm";
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

        private void lblTenShop_Click(object sender, EventArgs e)
        {

        }
    }
}
