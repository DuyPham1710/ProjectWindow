using ProjectWin_Demo_.UC;
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
    public partial class UCHistory : UserControl
    {
        private int id;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        List<Product> sanPham = new List<Product>();
        public UCHistory(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void UCHistory_Load(object sender, EventArgs e)
        {
            fPanel.Controls.Clear();
            sanPham = ThucThi();
            foreach (Product item in sanPham)
            {
                UCHisProduct ucSP = new UCHisProduct(item, id);
                fPanel.Controls.Add(ucSP);
            }
        }
        private List<Product> ThucThi()
        {
            List<Product> products = new List<Product>();
            try
            {
                conn.Open();
                string query = string.Format("SELECT *FROM DaMua inner join SanPham on DaMua.MSP = SanPham.MSP WHERE DaMua.ID = {0} and DaMua.TrangThai = N'{1}'", id, "Đã giao");
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Product sp = new Product((string)reader["MSP"], (int)reader["IDChuSP"], (string)reader["TenSP"], (string)reader["DanhMuc"], (string)reader["GiaTienLucMoiMua"],
                        (string)reader["GiaTienBayGio"], (DateTime)reader["NgayMuaSP"], (string)reader["SoLuong"], (string)reader["XuatXu"], (string)reader["BaoHanh"], (string)reader["TinhTrang"], (string)reader["MotaTinhTrang"], (string)reader["MotaSP"], (string)reader["AnhLucMoiMua"], (string)reader["AnhBayGio"]);
                    products.Add(sp);
                }

            }
            catch (Exception ex) { }
            finally
            {
                conn.Close();

            }
            return products;
        }
    }
}
