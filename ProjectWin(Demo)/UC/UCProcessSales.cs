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
    public partial class UCProcessSales : UserControl
    {
        Product sp;
        int id;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public UCProcessSales(Product sp, int id)
        {
            InitializeComponent();
        }

        private void UCProcessSales_Load(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format("Select FullName from Person,DaMua where Person.ID = DaMua.ID and DaMua.MSP = '{0}'", sp.MaSP);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblNguoiMua.Text = reader[0].ToString();
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
            lblGia.Text = sp.GiaHienTai + " đ";
            lblSoLuong.Text = "1 sản phẩm";
            lblTongTien.Text = sp.GiaHienTai + " đ";
            lblMaSP.Text = sp.MaSP;
        }
    }
}
