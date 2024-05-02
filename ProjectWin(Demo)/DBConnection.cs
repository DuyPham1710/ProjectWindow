using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjectWin_Demo_
{
    internal class DBConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        private int id;
        public DBConnection(int id)
        {
            this.id = id;
        }
        public MemoryStream LoadAvt(string query)
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    byte[] imageBytes = (byte[])reader["Avarta"];
                    MemoryStream ms = new MemoryStream(imageBytes);
                    return ms;
                    //pcbAvt.Image = Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return null;

        }
        public List<UCBinhLuan> LoadDanhGiaSP(string query)
        {
            List<UCBinhLuan> binhLuan = new List<UCBinhLuan>();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                { 
                    UCBinhLuan ucBinhLuan = new UCBinhLuan((int)reader["ID"], (string)reader["Fullname"], (Byte[])reader["Avarta"], (string)reader["BinhLuan"], (int)reader["SoSao"]);
                    binhLuan.Add(ucBinhLuan);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Không thể load đánh giá sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return binhLuan;
        }
        public List<T> LoadSanPham<T>(string query)
        {
            List<T> SanPham = new List<T>();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    SanPham sp = new SanPham((string)reader["MSP"], (int)reader["IDChuSP"], (string)reader["TenSP"], (string)reader["DanhMuc"], (string)reader["GiaTienLucMoiMua"],
                        (string)reader["GiaTienBayGio"], (DateTime)reader["NgayMuaSP"], (string)reader["SoLuong"], (string)reader["XuatXu"], (string)reader["BaoHanh"], (string)reader["TinhTrang"], (string)reader["MotaTinhTrang"], (string)reader["MotaSP"], (string)reader["AnhLucMoiMua"], (string)reader["AnhBayGio"]);
                    //SanPham.Add(sp);
                    if (typeof(T) == typeof(UCSanPham))
                    {
                        UCSanPham ucSP = new UCSanPham(sp, id);
                        SanPham.Add((T)(object)ucSP);
                    }     
                    else if (typeof(T) == typeof(UCSPCuaToi))
                    {
                        UCSPCuaToi ucSP = new UCSPCuaToi(sp);
                        SanPham.Add((T)(object)ucSP);
                    }
                    else if (typeof(T) == typeof(UCSPDaBan))
                    {
                        UCSPDaBan ucSP = new UCSPDaBan(sp, id);
                        SanPham.Add((T)(object)ucSP);
                    }
                    else if (typeof(T) == typeof(UCGioHang))
                    {
                        int soLuong = (int)reader["SLGioHang"];
                        UCGioHang ucSP = new UCGioHang(sp, id, soLuong);
                        SanPham.Add((T)(object)ucSP);
                    }
                }
                

            }
            catch (Exception ex) { }
            finally
            {
                conn.Close();
            }
            return SanPham;
        }
        //public List<UCSPCuaToi> LoadSanPhamCuaToi(string query)
        //{
        //    List<UCSPCuaToi> SanPham = new List<UCSPCuaToi>();
        //    try
        //    {
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand(query, conn);
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            SanPham sp = new SanPham((string)reader["MSP"], (int)reader["IDChuSP"], (string)reader["TenSP"], (string)reader["DanhMuc"], (string)reader["GiaTienLucMoiMua"],
        //                (string)reader["GiaTienBayGio"], (DateTime)reader["NgayMuaSP"], (string)reader["SoLuong"], (string)reader["XuatXu"], (string)reader["BaoHanh"], (string)reader["TinhTrang"], (string)reader["MotaTinhTrang"], (string)reader["MotaSP"], (string)reader["AnhLucMoiMua"], (string)reader["AnhBayGio"]);
        //            //SanPham.Add(sp);
        //            UCSPCuaToi ucSP = new UCSPCuaToi(sp);
        //            SanPham.Add(ucSP);
        //            //fPanelSanPham.Controls.Add(ucSP);

        //        }
        //        return SanPham;

        //    }
        //    catch (Exception ex) { }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return null;
        //}
        public List<T> timKiemSP<T>(string sqlQuery, string searchText)
        {
            List<T> SanPham = new List<T>();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    SanPham sp = new SanPham((string)reader["MSP"], (int)reader["IDChuSP"], (string)reader["TenSP"], (string)reader["DanhMuc"], (string)reader["GiaTienLucMoiMua"],
                        (string)reader["GiaTienBayGio"], (DateTime)reader["NgayMuaSP"], (string)reader["SoLuong"], (string)reader["XuatXu"], (string)reader["BaoHanh"], (string)reader["TinhTrang"], (string)reader["MotaTinhTrang"], (string)reader["MotaSP"], (string)reader["AnhLucMoiMua"], (string)reader["AnhBayGio"]);
                    //SanPham.Add(sp);

                    if (typeof(T) == typeof(UCSanPham))
                    {
                        UCSanPham ucSP = new UCSanPham(sp, id);
                        SanPham.Add((T)(object)ucSP);
                    }
                    else if (typeof(T) == typeof(UCSPCuaToi))
                    {
                        UCSPCuaToi ucSP = new UCSPCuaToi(sp);
                        SanPham.Add((T)(object)ucSP);
                    }
                    //UCSanPham ucSP = new UCSanPham(sp, id);
                    //SanPham.Add(ucSP);
                }
                
            }
            catch (Exception ex) { }
            finally { conn.Close(); }
            return SanPham;
        }
        //public List<UCSanPham> LocTheoDanhMucSP(string sqlQuery)
        //{
        //    List<UCSanPham> SanPham = new List<UCSanPham>();
        //    try
        //    {
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand(sqlQuery, conn);
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            SanPham sp = new SanPham((string)reader["MSP"], (int)reader["IDChuSP"], (string)reader["TenSP"], (string)reader["DanhMuc"], (string)reader["GiaTienLucMoiMua"],
        //                (string)reader["GiaTienBayGio"], (DateTime)reader["NgayMuaSP"], (string)reader["SoLuong"], (string)reader["XuatXu"], (string)reader["BaoHanh"], (string)reader["TinhTrang"], (string)reader["MotaTinhTrang"], (string)reader["MotaSP"], (string)reader["AnhLucMoiMua"], (string)reader["AnhBayGio"]);
        //            //SanPham.Add(sp);
        //            UCSanPham ucSP = new UCSanPham(sp, id);
        //            SanPham.Add(ucSP);
        //        }
        //        return SanPham;

        //    }
        //    catch (Exception ex) { }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return null;
        //}
        public List<SanPham> LoadDanhSachSanPham(string query)
        {
            List<SanPham> sanPham = new List<SanPham>();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    SanPham sp = new SanPham((string)reader["MSP"], (int)reader["IDChuSP"], (string)reader["TenSP"], (string)reader["DanhMuc"], (string)reader["GiaTienLucMoiMua"],
                        (string)reader["GiaTienBayGio"], (DateTime)reader["NgayMuaSP"], (string)reader["SoLuong"], (string)reader["XuatXu"], (string)reader["BaoHanh"], (string)reader["TinhTrang"], (string)reader["MotaTinhTrang"], (string)reader["MotaSP"], (string)reader["AnhLucMoiMua"], (string)reader["AnhBayGio"]);
                    sanPham.Add(sp);
                }
            }
            catch (Exception ex) { }
            finally
            {
                conn.Close();

            }
            return sanPham;
        }
        public List<SanPham> LoadDSDonhang(string query)
        {
            List<SanPham> sanPham = new List<SanPham>();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    SanPham sp = new SanPham((string)reader["MSP"], (int)reader["IDChuSP"], (string)reader["TenSP"], (string)reader["DanhMuc"], (string)reader["GiaTienLucMoiMua"],
                        (string)reader["GiaTienBayGio"], (DateTime)reader["NgayMuaSP"], (string)reader["SoLuongDaMua"], (string)reader["XuatXu"], (string)reader["BaoHanh"], (string)reader["TinhTrang"], (string)reader["MotaTinhTrang"], (string)reader["MotaSP"], (string)reader["AnhLucMoiMua"], (string)reader["AnhBayGio"]);
                    sanPham.Add(sp);
                }
            }
            catch (Exception ex) { }
            finally
            {
                conn.Close();

            }
            return sanPham;
        }

        public void thucThi(string SQL)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(SQL, conn);
                cmd = new SqlCommand(SQL, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thực thi thành công", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        public int demDB(string sql)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                int count = (int)cmd.ExecuteScalar();
                return count;
            }
            catch
            {
                return 0;
            }
            finally
            {
                conn.Close();
            }
        }
        public int soLuongSanPham(string sql)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return Convert.ToInt32(reader["SoLuong"]);
                }
                else
                {
                    return 0;
                }
               
            }
            catch
            {
                return 0;
            }
            finally
            {
                conn.Close();
            }
        }
        public List<UCShop> LoadShop(string query)
        {
            List<UCShop> shop = new List<UCShop>();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    UCShop uCShop = new UCShop((int)reader["ID"], (string)reader["FullName"], (Byte[])reader["Avarta"], (int)reader["SoLuong"]);
                    shop.Add(uCShop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể load Shop", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return shop;
        }

    }
}
