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
using System.Windows.Forms;

namespace ProjectWin_Demo_
{
    public partial class FAddProduct : Form
    {
        private bool isDragging;
        private Point lastCursor;
        private Point lastForm;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        private string ma;
        private int id;
        private string thaoTac;
        public FAddProduct(int id, string ma, string thaoTac)
        {
            InitializeComponent();
            btnUpdateProduct.Hide();
            this.ma = ma;
            this.id = id;
            this.thaoTac = thaoTac;
        }
        private void FAddProduct_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (thaoTac == "Them")
                {
                    string sqlStr = "SELECT count(*) FROM SanPham";

                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    txtMaSP.Texts = "SP0" + ((int)cmd.ExecuteScalar() + 1).ToString();
                }
                else
                {
                    string sqlStr = string.Format("SELECT * FROM SanPham WHERE MSP = '{0}'", ma);
                    SqlCommand cmd = new SqlCommand( sqlStr, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Product sp = new Product((string)reader["MSP"], (int)reader["IDChuSP"], (string)reader["TenSP"], (string)reader["DanhMuc"], (string)reader["GiaTienLucMoiMua"],
                        (string)reader["GiaTienBayGio"], (DateTime)reader["NgayMuaSP"], (string)reader["SoLuong"], (string)reader["XuatXu"], (string)reader["BaoHanh"], (string)reader["TinhTrang"], (string)reader["MotaTinhTrang"], (string)reader["MotaSP"], (byte[])reader["AnhLucMoiMua"], (byte[])reader["AnhBayGio"]);
                        txtMaSP.Texts = sp.MaSP;
                        cbBoxSoLuong.Value = Int32.Parse(sp.SoLuong);
                        txtTenSP.Texts = sp.TenSP;
                        cbBoxDanhMuc.SelectedItem = sp.DanhMuc;
                        txtGiaBanDau.Texts = sp.GiaBanDau;
                        txtGiaHienTai.Texts = sp.GiaHienTai;
                        txtXuatXu.Texts = sp.XuatXu;
                        cbBoxBaoHanh.SelectedItem = sp.BaoHanh;
                        DtpNgayMua.Value = sp.NgayMuaSP;
                        rtbMoTaSP.Text = sp.MotaSP;
                        txtTinhTrang.Texts = sp.TinhTrang;
                        rtbMoTaTinhTrang.Text = sp.MoTaTinhTrang;
                    }
                    
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
          
           
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm sản phẩm này không", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    string sqlStr = "SELECT count(*) FROM SanPham";

                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    Product product = new Product(txtMaSP.Texts, id, txtTenSP.Texts, cbBoxDanhMuc.Text, txtGiaBanDau.Texts, txtGiaHienTai.Texts,
                        DtpNgayMua.Value, cbBoxSoLuong.Value.ToString(), txtXuatXu.Texts, cbBoxBaoHanh.Text, txtTinhTrang.Texts, rtbMoTaTinhTrang.Text, rtbMoTaSP.Text, null, null);

                    sqlStr = string.Format("INSERT INTO SanPham(MSP, IDChuSP, TenSP, DanhMuc, GiaTienLucMoiMua, GiaTienBayGio, NgayMuaSP, SoLuong, XuatXu, BaoHanh, TinhTrang, MotaTinhTrang, MotaSP, AnhLucMoiMua, AnhBayGio) VALUES ('{0}', '{1}', N'{2}', N'{3}', '{4}', '{5}', '{6}', '{7}', N'{8}', N'{9}', N'{10}', N'{11}', N'{12}', '{13}', '{14}')",
                        product.MaSP, product.IDChuSP, product.TenSP, product.DanhMuc, product.GiaBanDau, product.GiaHienTai, product.NgayMuaSP.ToString(), product.SoLuong, product.XuatXu, product.BaoHanh, product.TinhTrang, product.MoTaTinhTrang, product.MotaSP, product.AnhBanDau, product.AnhHienTai);

                    cmd = new SqlCommand(sqlStr, conn);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Thêm sản phẩm thành công", "Thông báo");
                        this.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm sản phảm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
            
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn cập nhật sản phẩm này không", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
             
                try
                {

                    conn.Open();
                    Product product = new Product(txtMaSP.Texts, id, txtTenSP.Texts, cbBoxDanhMuc.Text, txtGiaBanDau.Texts, txtGiaHienTai.Texts,
                   DtpNgayMua.Value, cbBoxSoLuong.Value.ToString(), txtXuatXu.Texts, cbBoxBaoHanh.Text, txtTinhTrang.Texts, rtbMoTaTinhTrang.Text, rtbMoTaSP.Text, null, null);

                    string sqlStr = string.Format("UPDATE SanPham SET TenSP = N'{0}', DanhMuc = N'{1}', GiaTienLucMoiMua = '{2}', GiaTienBayGio = '{3}', NgayMuaSP = '{4}', SoLuong = '{5}', XuatXu = N'{6}', BaoHanh = N'{7}', TinhTrang = N'{8}', MotaTinhTrang = N'{9}', MotaSP = N'{10}', AnhLucMoiMua = '{11}', AnhBayGio = '{12}' WHERE MSP = '{13}'",
                        product.TenSP, product.DanhMuc, product.GiaBanDau, product.GiaHienTai, product.NgayMuaSP.ToString(), product.SoLuong, product.XuatXu, product.BaoHanh, product.TinhTrang, product.MoTaTinhTrang, product.MotaSP, product.AnhBanDau, product.AnhHienTai, product.MaSP);
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Cập nhật sản phẩm thành công", "Thông báo");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật sản phảm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
                
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void pToolBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentCursor = Cursor.Position;
                this.Location = new Point(lastForm.X + (currentCursor.X - lastCursor.X), lastForm.Y + (currentCursor.Y - lastCursor.Y));
            }
        }

        private void pToolBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastForm = this.Location;
            }
        }

        private void pToolBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            while (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    pctProduct.Image = Image.FromFile(openFileDialog1.FileName);
                    break;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể chọn ảnh này !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

      
    }
}
