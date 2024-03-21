using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace ProjectWin_Demo_
{
    public partial class FHome : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        List<Product> SanPham = new List<Product>();
        private int id;
        public FHome(int id)
        {
            InitializeComponent();
            btnCatalog.MouseDown += btnCatalog_MouseDown;
            ContextMenuStripCatalog.LostFocus += btnCatalog_LostFocus;
            btnSort.MouseDown += btnSort_MouseDown;
            ContextMenuStripSort.LostFocus += btnSort_LostFocus;
            this.id = id;
        }

        private void FHome_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT * FROM SanPham WHERE IDchuSP <> {0}", id);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Product sp = new Product((string)reader["MSP"], (int)reader["IDChuSP"], (string)reader["TenSP"], (string)reader["DanhMuc"], (string)reader["GiaTienLucMoiMua"], 
                        (string)reader["GiaTienBayGio"], (DateTime)reader["NgayMuaSP"], (string)reader["SoLuong"], (string)reader["XuatXu"], (string)reader["BaoHanh"], (string)reader["TinhTrang"], (string)reader["MotaTinhTrang"], (string)reader["MotaSP"], (string)reader["AnhLucMoiMua"], (string)reader["AnhBayGio"]);
                    SanPham.Add(sp);
                    UCProducts ucSP = new UCProducts(sp);
                    fPanelSanPham.Controls.Add(ucSP);
                }

            }
            catch (Exception ex) { }
        }

        private void btnSort_MouseDown(object sender, MouseEventArgs e)
        {
            Point location = btnSort.PointToScreen(new Point(0, btnSort.Height));
            ContextMenuStripSort.Show(location);
        }

        private void btnSort_LostFocus(object sender, EventArgs e)
        {
            ContextMenuStripSort.Hide();
        }
        private void btnCatalog_MouseDown(object sender, MouseEventArgs e)
        {
            Point location = btnCatalog.PointToScreen(new Point(0, btnCatalog.Height));
            ContextMenuStripCatalog.Show(location);
        }

        private void btnCatalog_LostFocus(object sender, EventArgs e)
        {
            ContextMenuStripCatalog.Hide();
        }

       
    }
}
