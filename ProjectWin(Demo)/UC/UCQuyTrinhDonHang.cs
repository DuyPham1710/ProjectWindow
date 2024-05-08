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
        string[] AnhCu = { };
        int MaVanChuyen;
        public UCQuyTrinhDonHang(SanPham sp, int id, int MaVanChuyen)
        {
            InitializeComponent();
            this.id = id;
            this.sp = sp;
            this.MaVanChuyen = MaVanChuyen;
        }

        private void UCProcessSales_Load(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format("Select * from Person,DaMua where Person.ID = DaMua.ID and DaMua.MSP = '{0}'", sp.MaSP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblNguoiMua.Text = reader["FullName"].ToString();
                    lblMaVanChuyen.Text = MaVanChuyen.ToString();
                    lblSoLuong.Text = reader["SoLuongDaMua"].ToString();
                }
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }            
            lblTenSP.Text = sp.TenSP;
            lblGia.Text = sp.GiaHienTai + "đ";
            //lblSoLuong.Text = "1 sản phẩm";
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
            //try
            //{
            //    string query = string.Format("UPDATE DaMua SET TrangThai = N'{0}' where MSP = '{1}'", trangThai, sp.MaSP);
            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand(query, conn);

            //    if (cmd.ExecuteNonQuery() > 0)
            //    {
            //        MessageBox.Show("Xác nhận thành công", "Thông báo");
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Xác nhận thất bại", "Thông báo");
            //}
            //finally
            //{
            //    conn.Close();
            //}

        }

        private void btnHuyDon_Click(object sender, EventArgs e)
        {

        }
    }
}
