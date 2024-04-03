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
    
    public partial class FMyProduct : Form
    {
        private int id;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        //Product sp ;
        public FMyProduct(int id)
        {
            InitializeComponent();

            foreach (Control control in fPanelHienThi.Controls)
            {
                control.Margin = new Padding(5); // Đặt giá trị phần đệm là 5 cho các cạnh
            }
            this.id = id;
            
        }
        private void FMyProduct_Load(object sender, EventArgs e)
        {
            fPanelHienThi.Controls.Clear();
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT * FROM SanPham WHERE IDchuSP = {0}", id);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Product sp = new Product((string)reader["MSP"], (int)reader["IDChuSP"], (string)reader["TenSP"], (string)reader["DanhMuc"], (string)reader["GiaTienLucMoiMua"],
                        (string)reader["GiaTienBayGio"], (DateTime)reader["NgayMuaSP"], (string)reader["SoLuong"], (string)reader["XuatXu"], (string)reader["BaoHanh"], (string)reader["TinhTrang"], (string)reader["MotaTinhTrang"], (string)reader["MotaSP"], (string)reader["AnhLucMoiMua"], (string)reader["AnhBayGio"]);
                    UCMyProduct uCMyProduct = new UCMyProduct(sp);
                    uCMyProduct.BtnClick_delete += pcbDelete_Click;
                    uCMyProduct.BtnClick_edit += pcbEdit_Click;
                    fPanelHienThi.Controls.Add(uCMyProduct);

                }
            }
            catch { }
            finally { conn.Close(); }
          
            
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            FAddProduct addProduct = new FAddProduct(id, "", "Them");
            addProduct.ShowDialog();
            FMyProduct_Load(sender, e);
        }

        private void btnProductSold_Click(object sender, EventArgs e)
        {
            btnTotalProduct.CustomBorderColor = Color.White;
            btnTotalProduct.ForeColor = Color.Black;
            btnProductSold.CustomBorderColor = Color.MediumSlateBlue;
            btnProductSold.ForeColor = Color.MediumSlateBlue;
            //UCHistory uCHistory = new UCHistory();
            //addUserControl(uCHistory);
        }
        private void addUserControl(UserControl userControl)
        {
            fPanelHienThi.Controls.Clear();
            fPanelHienThi.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnTotalProduct_Click(object sender, EventArgs e)
        {
            btnTotalProduct.CustomBorderColor = Color.MediumSlateBlue;
            btnTotalProduct.ForeColor = Color.MediumSlateBlue;
            btnProductSold.CustomBorderColor = Color.White;
            btnProductSold.ForeColor = Color.Black;
            FMyProduct_Load(sender, e );
        }

        private void pcbDelete_Click(object sender, EventArgs e)
        {
            UCMyProduct sp = sender as UCMyProduct;
            DialogResult result = MessageBox.Show("Bạn chắc chắn là muốn xóa sản phẩm này", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // thực hiện xóa 

                string SQL = string.Format("DELETE FROM SanPham WHERE MSP = '{0}'", sp.lblMaSP.Text);
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(SQL, conn);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Xóa Sản phẩm thành công", "Thông báo");
                        FMyProduct_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa sản phẩm này", "Thông báo");

                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void pcbEdit_Click(object sender, EventArgs e)
        {
            UCMyProduct sp = sender as UCMyProduct;
            //MessageBox.Show(sp.lblMaSP.Text);
            FAddProduct fedit = new FAddProduct(id, sp.lblMaSP.Text, "Sua");
            fedit.btnAddProduct.Hide();
            fedit.btnUpdateProduct.Show();
            fedit.ShowDialog();
            FMyProduct_Load(sender, e);
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                FMyProduct_Load(sender, e);
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
                fPanelHienThi.Controls.Clear();

                while (reader.Read())
                {
                    Product sp = new Product((string)reader["MSP"], (int)reader["IDChuSP"], (string)reader["TenSP"], (string)reader["DanhMuc"], (string)reader["GiaTienLucMoiMua"],
                        (string)reader["GiaTienBayGio"], (DateTime)reader["NgayMuaSP"], (string)reader["SoLuong"], (string)reader["XuatXu"], (string)reader["BaoHanh"], (string)reader["TinhTrang"], (string)reader["MotaTinhTrang"], (string)reader["MotaSP"], (string)reader["AnhLucMoiMua"], (string)reader["AnhBayGio"]);
                    //SanPham.Add(sp);
                    UCMyProduct ucSP = new UCMyProduct(sp);
                    fPanelHienThi.Controls.Add(ucSP);
                }
            }
            catch (Exception ex) { }
            finally { conn.Close(); }

        }
    }
}
