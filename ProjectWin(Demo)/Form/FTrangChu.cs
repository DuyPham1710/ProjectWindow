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
    public partial class FTrangChu : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        List<SanPham> SanPham = new List<SanPham>();
        private int id;
        public FTrangChu(int id)
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
            fPanelSanPham.Controls.Clear();
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT * FROM SanPham WHERE IDchuSP <> {0}", id);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    SanPham sp = new SanPham((string)reader["MSP"], (int)reader["IDChuSP"], (string)reader["TenSP"], (string)reader["DanhMuc"], (string)reader["GiaTienLucMoiMua"], 
                        (string)reader["GiaTienBayGio"], (DateTime)reader["NgayMuaSP"], (string)reader["SoLuong"], (string)reader["XuatXu"], (string)reader["BaoHanh"], (string)reader["TinhTrang"], (string)reader["MotaTinhTrang"], (string)reader["MotaSP"], (string)reader["AnhLucMoiMua"], (string)reader["AnhBayGio"]);
                    SanPham.Add(sp);
                    UCSanPham ucSP = new UCSanPham(sp, id);
                    fPanelSanPham.Controls.Add(ucSP);

                }

            }
            catch (Exception ex) { }
            finally
            {
                conn.Close();
            }
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

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                FHome_Load(sender, e);
            }
            else
            {
                SearchAndDisplay(txtTimKiem.Text);
            }
        }
        private void SearchAndDisplay(string searchText)
        {
            try
            {
                conn.Open();

                string sqlQuery = "SELECT * FROM SanPham WHERE TenSP LIKE @searchText";
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                SqlDataReader reader = cmd.ExecuteReader();
                fPanelSanPham.Controls.Clear();

                while (reader.Read())
                {
                    SanPham sp = new SanPham((string)reader["MSP"], (int)reader["IDChuSP"], (string)reader["TenSP"], (string)reader["DanhMuc"], (string)reader["GiaTienLucMoiMua"],
                        (string)reader["GiaTienBayGio"], (DateTime)reader["NgayMuaSP"], (string)reader["SoLuong"], (string)reader["XuatXu"], (string)reader["BaoHanh"], (string)reader["TinhTrang"], (string)reader["MotaTinhTrang"], (string)reader["MotaSP"], (string)reader["AnhLucMoiMua"], (string)reader["AnhBayGio"]);
                    SanPham.Add(sp);
                    UCSanPham ucSP = new UCSanPham(sp, id);
                    fPanelSanPham.Controls.Add(ucSP);
                }
            }
            catch (Exception ex) { }
            finally { conn.Close(); }

        }

        private void điệnTửToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocTheoDanhMucSP("Điện tử");
        }

        private void giaDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocTheoDanhMucSP("Gia dụng");
        }

        private void họcTậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocTheoDanhMucSP("Học tập");
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LocTheoDanhMucSP("Thời trang");
        }
        private void LocTheoDanhMucSP(string danhMuc)
        {
            fPanelSanPham.Controls.Clear();
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT * FROM SanPham WHERE IDchuSP <> {0} and DanhMuc = N'{1}'", id, danhMuc);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    SanPham sp = new SanPham((string)reader["MSP"], (int)reader["IDChuSP"], (string)reader["TenSP"], (string)reader["DanhMuc"], (string)reader["GiaTienLucMoiMua"],
                        (string)reader["GiaTienBayGio"], (DateTime)reader["NgayMuaSP"], (string)reader["SoLuong"], (string)reader["XuatXu"], (string)reader["BaoHanh"], (string)reader["TinhTrang"], (string)reader["MotaTinhTrang"], (string)reader["MotaSP"], (string)reader["AnhLucMoiMua"], (string)reader["AnhBayGio"]);
                    SanPham.Add(sp);
                    UCSanPham ucSP = new UCSanPham(sp, id);
                    fPanelSanPham.Controls.Add(ucSP);

                }

            }
            catch (Exception ex) { }
            finally
            {
                conn.Close();
            }
        }

        private void btnAllProduct_Click(object sender, EventArgs e)
        {
            FHome_Load(sender, e);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            LocTheoDanhMucSP("Thể thao & Du lịch");
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            LocTheoDanhMucSP("Giày dép");
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            LocTheoDanhMucSP("Sắc đẹp");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            LocTheoDanhMucSP("Sức khỏe");
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            LocTheoDanhMucSP("Sách");
        }
    }
}
