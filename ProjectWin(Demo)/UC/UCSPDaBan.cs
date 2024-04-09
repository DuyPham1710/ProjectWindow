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
    public partial class UCSPDaBan : UserControl
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        SanPham sp;
        private int id;
        string[] AnhCu = { };
        public UCSPDaBan(SanPham sp, int id)
        {
            InitializeComponent();
            this.sp = sp;
            this.id = id;
        }

        private void UCSPDaBan_Load(object sender, EventArgs e)
        {
            lblTenSP.Text = sp.TenSP;
            lblGia.Text = sp.GiaHienTai + "đ";
            lblSoLuongSP.Text = "1 sản phẩm";
            lblPhanLoai.Text = sp.DanhMuc;
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
                string query = string.Format("select UserName from DaMua inner join Account on DaMua.ID = Account.ID where DaMua.ID = {0}", id);
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    lblNguoiMua.Text = (string)rdr["UserName"];
                }
            }
            catch { }
            finally { conn.Close(); }
        }
    }
}
