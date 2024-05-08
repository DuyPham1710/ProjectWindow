﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TheArtOfDevHtmlRenderer.Adapters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjectWin_Demo_
{
    internal class DBConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        private int id;

        public DBConnection() { }
        public DBConnection(int id)
        {
            this.id = id;
        }
        public DataTable LoadAvt(string query)
        {
            try
            {
                conn.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                Adapter.Fill(dt);
                return dt;
                //SqlCommand command = new SqlCommand(query, conn);
                //SqlDataReader reader = command.ExecuteReader();
                //while (reader.Read())
                //{
                //    byte[] imageBytes = (byte[])reader["Avarta"];
                //    MemoryStream ms = new MemoryStream(imageBytes);
                //    return ms;
                //}
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
            return null;

        }
        public DataTable LoadDuLieu(string query)
        {
            try
            {
                conn.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                Adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không load được dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
            finally
            {
                conn.Close();
            }
            return null;
        }
        //public DataTable LoadThongTinCaNhan(string query)
        //{
        //    try
        //    {
        //        conn.Open();
        //        SqlDataAdapter Adapter = new SqlDataAdapter(query, conn);
        //        DataTable dt = new DataTable();
        //        Adapter.Fill(dt);
        //        return dt;
        //        //SqlCommand command = new SqlCommand(query, conn);
        //        //SqlDataReader reader = command.ExecuteReader();
        //        //if (reader.Read())
        //        //{
        //        //    object avarta = reader["Avarta"];
        //        //    byte[] avartaBytes = avarta != DBNull.Value ? (byte[])avarta : null;

        //        //    Nguoi nguoiDung = new Nguoi((int)reader["ID"], (string)reader["FullName"], (string)reader["Email"], (string)reader["Phone"], (string)reader["CCCD"],
        //        //        (string)reader["Gender"], (string)reader["Addr"], (string)reader["UserName"], (string)reader["Pass"], (DateTime)reader["Bith"], avartaBytes);
        //        //    return nguoiDung;
        //        //}
        //        //else
        //        //{
        //        //    return null;
        //        //}
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Không load được thông tin", "Thông báo");
        //        return null;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}
        //public Nguoi LoadThongTinCaNhan(string query)
        //{
        //    try
        //    {
        //        conn.Open();
        //        SqlCommand command = new SqlCommand(query, conn);
        //        SqlDataReader reader = command.ExecuteReader();
        //        if (reader.Read())
        //        {
        //            object avarta = reader["Avarta"];
        //            byte[] avartaBytes = avarta != DBNull.Value ? (byte[])avarta : null;

        //            Nguoi nguoiDung = new Nguoi((int)reader["ID"], (string)reader["FullName"], (string)reader["Email"], (string)reader["Phone"], (string)reader["CCCD"], 
        //                (string)reader["Gender"], (string)reader["Addr"], (string)reader["UserName"], (string)reader["Pass"], (DateTime)reader["Bith"], avartaBytes);
        //            return nguoiDung;
        //            //if (reader["Avarta"] != DBNull.Value)
        //            //{
        //            //    byte[] imageBytes = (byte[])reader["Avarta"];
        //            //    MemoryStream ms = new MemoryStream(imageBytes);
        //            //    pictureBoxUser.Image = Image.FromStream(ms);

        //            //}
        //            //txtName.Text = (string)reader["FullName"];
        //            //txtPhoneNumber.Text = (string)reader["Phone"];
        //            //txtEmail.Text = (string)reader["Email"];
        //            //txtCCCD.Text = (string)reader["CCCD"];
        //            //txtUserName.Text = (string)reader["UserName"];
        //            //txtPass.Text = (string)reader["Pass"];
        //            //cbAddress.SelectedItem = (string)reader["Addr"];
        //            //dtpNgaySinh.Value = (DateTime)reader["Bith"];
        //            //string gioiTinh = (string)reader["Gender"];
        //            //if (gioiTinh == "Nam")
        //            //{
        //            //    rdoNam.Checked = true;
        //            //}
        //            //else if (gioiTinh == "Nữ")
        //            //{
        //            //    rdoNu.Checked = true;
        //            //}
        //            //else
        //            //{
        //            //    rdoLGBT.Checked = true;
        //            //}

        //        }
        //        else
        //        {
        //            return null;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Không load được thông tin", "Thông báo");
        //        return null;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}

        //public List<UCBinhLuan> LoadDanhGiaSP(string query)
        //{
        //    List<UCBinhLuan> binhLuan = new List<UCBinhLuan>();
        //    try
        //    {
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand(query, conn);
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        while (reader.Read())
        //        { 
        //            UCBinhLuan ucBinhLuan = new UCBinhLuan((int)reader["ID"], (string)reader["Fullname"], (Byte[])reader["Avarta"], (string)reader["BinhLuan"], (int)reader["SoSao"]);
        //            binhLuan.Add(ucBinhLuan);
        //        }
        //    }
        //    catch (Exception ex) 
        //    {
        //        MessageBox.Show("Không thể load đánh giá sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return binhLuan;
        //}
        //public DataTable LoadSanPham(string query)
        //{
        //    //List<T> SanPham = new List<T>();
        //    try
        //    {
        //        conn.Open();
        //        SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
        //        DataTable dt = new DataTable();
        //        adapter.Fill(dt);
        //        return dt;
        //        //SqlCommand cmd = new SqlCommand(query, conn);
        //        //SqlDataReader reader = cmd.ExecuteReader();
        //        //while (reader.Read())
        //        //{
        //        //    SanPham sp = new SanPham((string)reader["MSP"], (int)reader["IDChuSP"], (string)reader["TenSP"], (string)reader["DanhMuc"], (string)reader["GiaTienLucMoiMua"],
        //        //        (string)reader["GiaTienBayGio"], (DateTime)reader["NgayMuaSP"], (string)reader["SoLuong"], (string)reader["XuatXu"], (string)reader["BaoHanh"], (string)reader["TinhTrang"], (string)reader["MotaTinhTrang"], (string)reader["MotaSP"], (string)reader["AnhLucMoiMua"], (string)reader["AnhBayGio"]);
        //        //    //SanPham.Add(sp);
        //        //    if (typeof(T) == typeof(UCSanPham))
        //        //    {
        //        //        UCSanPham ucSP = new UCSanPham(sp, id);
        //        //        SanPham.Add((T)(object)ucSP);
        //        //    }
        //        //    else if (typeof(T) == typeof(UCSPCuaToi))
        //        //    {
        //        //        UCSPCuaToi ucSP = new UCSPCuaToi(sp);
        //        //        SanPham.Add((T)(object)ucSP);
        //        //    }
        //        //    else if (typeof(T) == typeof(UCSPDaBan))
        //        //    {
        //        //        UCSPDaBan ucSP = new UCSPDaBan(sp, id);
        //        //        SanPham.Add((T)(object)ucSP);
        //        //    }
        //        //    else if (typeof(T) == typeof(UCGioHang))
        //        //    {
        //        //        int soLuong = (int)reader["SLGioHang"];
        //        //        UCGioHang ucSP = new UCGioHang(sp, id, soLuong);
        //        //        SanPham.Add((T)(object)ucSP);
        //        //    }
        //        //}


        //    }
        //    catch (Exception ex) { }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return null;
        //}
        //public List<T> LoadSanPham<T>(string query)
        //{
        //    List<T> SanPham = new List<T>();
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
        //            if (typeof(T) == typeof(UCSanPham))
        //            {
        //                UCSanPham ucSP = new UCSanPham(sp, id);
        //                SanPham.Add((T)(object)ucSP);
        //            }
        //            else if (typeof(T) == typeof(UCSPCuaToi))
        //            {
        //                UCSPCuaToi ucSP = new UCSPCuaToi(sp);
        //                SanPham.Add((T)(object)ucSP);
        //            }
        //            else if (typeof(T) == typeof(UCSPDaBan))
        //            {
        //                UCSPDaBan ucSP = new UCSPDaBan(sp, id);
        //                SanPham.Add((T)(object)ucSP);
        //            }
        //            else if (typeof(T) == typeof(UCGioHang))
        //            {
        //                int soLuong = (int)reader["SLGioHang"];
        //                UCGioHang ucSP = new UCGioHang(sp, id, soLuong);
        //                SanPham.Add((T)(object)ucSP);
        //            }
        //        }


        //    }
        //    catch (Exception ex) { }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return SanPham;
        //}
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
        //public DataTable timKiemSP(string sqlQuery)
        //{
        //    try
        //    {
        //        conn.Open();
        //        SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, conn);
        //        DataTable dt = new DataTable();
        //        adapter.Fill(dt);
        //        return dt;
        //        //SqlCommand cmd = new SqlCommand(sqlQuery, conn);
        //        //cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

        //        //SqlDataReader reader = cmd.ExecuteReader();

        //        //while (reader.Read())
        //        //{
        //        //    SanPham sp = new SanPham((string)reader["MSP"], (int)reader["IDChuSP"], (string)reader["TenSP"], (string)reader["DanhMuc"], (string)reader["GiaTienLucMoiMua"],
        //        //        (string)reader["GiaTienBayGio"], (DateTime)reader["NgayMuaSP"], (string)reader["SoLuong"], (string)reader["XuatXu"], (string)reader["BaoHanh"], (string)reader["TinhTrang"], (string)reader["MotaTinhTrang"], (string)reader["MotaSP"], (string)reader["AnhLucMoiMua"], (string)reader["AnhBayGio"]);
        //        //    //SanPham.Add(sp);

        //        //    if (typeof(T) == typeof(UCSanPham))
        //        //    {
        //        //        UCSanPham ucSP = new UCSanPham(sp, id);
        //        //        SanPham.Add((T)(object)ucSP);
        //        //    }
        //        //    else if (typeof(T) == typeof(UCSPCuaToi))
        //        //    {
        //        //        UCSPCuaToi ucSP = new UCSPCuaToi(sp);
        //        //        SanPham.Add((T)(object)ucSP);
        //        //    }
        //        //    else if (typeof(T) == typeof(UCGioHang))
        //        //    {
        //        //        int soLuong = (int)reader["SLGioHang"];
        //        //        UCGioHang ucSP = new UCGioHang(sp, id, soLuong);
        //        //        SanPham.Add((T)(object)ucSP);
        //        //    }
        //            //UCSanPham ucSP = new UCSanPham(sp, id);
        //            //SanPham.Add(ucSP);
        //       // }

        //    }
        //    catch (Exception ex) { }
        //    finally { conn.Close(); }
        //    return null;
        //}
        //public DataTable LoadVoucher(string sqlStr)
        //{
        //    try
        //    {
        //        conn.Open();
        //        SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
        //        DataTable dt = new DataTable();
        //        adapter.Fill(dt);
        //        return dt;
        //        //SqlCommand cmd = new SqlCommand(sqlStr, conn);
        //        //SqlDataReader reader = cmd.ExecuteReader();
        //        //while (reader.Read())
        //        //{
        //        //    Voucher voucher = new Voucher((int)reader["ID"], (int)reader["GiaTri"], (int)reader["SoLuongVoucher"], (string)reader["MaVoucher"], (string)reader["Mota"], (DateTime)reader["HSD"]);
        //        //    if (typeof(T) == typeof(UCVoucher))
        //        //    {
        //        //        UCVoucher ucVoucher = new UCVoucher(voucher, id);
        //        //        Vouchers.Add((T)(object)ucVoucher);
        //        //    }
        //        //    else if (typeof(T) == typeof(UCVoucherCuaToi))
        //        //    {
        //        //        UCVoucherCuaToi ucVoucher = new UCVoucherCuaToi(voucher, id);
        //        //        Vouchers.Add((T)(object)ucVoucher);
        //        //    }

        //        //    if (typeof(T) == typeof(Voucher))
        //        //    {
        //        //        Vouchers.Add((T)(object)voucher);
        //        //        return Vouchers;
        //        //    }
        //        //}
        //        //return Vouchers;
        //    }
        //    catch (Exception ex) { }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return null;
        //}
        //public List<T> timKiemSP<T>(string sqlQuery, string searchText)
        //{
        //    List<T> SanPham = new List<T>();
        //    try
        //    {
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand(sqlQuery, conn);
        //        cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

        //        SqlDataReader reader = cmd.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            SanPham sp = new SanPham((string)reader["MSP"], (int)reader["IDChuSP"], (string)reader["TenSP"], (string)reader["DanhMuc"], (string)reader["GiaTienLucMoiMua"],
        //                (string)reader["GiaTienBayGio"], (DateTime)reader["NgayMuaSP"], (string)reader["SoLuong"], (string)reader["XuatXu"], (string)reader["BaoHanh"], (string)reader["TinhTrang"], (string)reader["MotaTinhTrang"], (string)reader["MotaSP"], (string)reader["AnhLucMoiMua"], (string)reader["AnhBayGio"]);
        //            //SanPham.Add(sp);

        //            if (typeof(T) == typeof(UCSanPham))
        //            {
        //                UCSanPham ucSP = new UCSanPham(sp, id);
        //                SanPham.Add((T)(object)ucSP);
        //            }
        //            else if (typeof(T) == typeof(UCSPCuaToi))
        //            {
        //                UCSPCuaToi ucSP = new UCSPCuaToi(sp);
        //                SanPham.Add((T)(object)ucSP);
        //            }
        //            else if (typeof(T) == typeof(UCGioHang))
        //            {
        //                int soLuong = (int)reader["SLGioHang"];
        //                UCGioHang ucSP = new UCGioHang(sp, id, soLuong);
        //                SanPham.Add((T)(object)ucSP);
        //            }
        //            //UCSanPham ucSP = new UCSanPham(sp, id);
        //            //SanPham.Add(ucSP);
        //        }

        //    }
        //    catch (Exception ex) { }
        //    finally { conn.Close(); }
        //    return SanPham;
        //}
        //public List<T> LoadVoucher<T>(string sqlStr)
        //{
        //    List<T> Vouchers = new List<T>();
        //    try
        //    {
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand(sqlStr, conn);
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            Voucher voucher = new Voucher((int)reader["ID"], (int)reader["GiaTri"], (int)reader["SoLuongVoucher"], (string)reader["MaVoucher"], (string)reader["Mota"], (DateTime)reader["HSD"]);
        //            if (typeof(T) == typeof(UCVoucher))
        //            {
        //                UCVoucher ucVoucher = new UCVoucher(voucher, id);
        //                Vouchers.Add((T)(object)ucVoucher);
        //            }
        //            else if (typeof(T) == typeof(UCVoucherCuaToi))
        //            {
        //                UCVoucherCuaToi ucVoucher = new UCVoucherCuaToi(voucher, id);
        //                Vouchers.Add((T)(object)ucVoucher);
        //            }

        //            if (typeof(T) == typeof(Voucher))
        //            {
        //                Vouchers.Add((T)(object)voucher);
        //                return Vouchers;
        //            }
        //        }
        //        return Vouchers;
        //    }
        //    catch (Exception ex) { }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return null;
        //}
        //public DataTable LoadDanhSachSanPham(string query)
        //{
        //    try
        //    {
        //        conn.Open();
        //        SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
        //        DataTable dt = new DataTable();
        //        adapter.Fill(dt);
        //        return dt;
        //        //SqlCommand cmd = new SqlCommand(query, conn);
        //        //SqlDataReader reader = cmd.ExecuteReader();
        //        //while (reader.Read())
        //        //{
        //        //    SanPham sp = new SanPham((string)reader["MSP"], (int)reader["IDChuSP"], (string)reader["TenSP"], (string)reader["DanhMuc"], (string)reader["GiaTienLucMoiMua"],
        //        //        (string)reader["GiaTienBayGio"], (DateTime)reader["NgayMuaSP"], (string)reader["SoLuong"], (string)reader["XuatXu"], (string)reader["BaoHanh"], (string)reader["TinhTrang"], (string)reader["MotaTinhTrang"], (string)reader["MotaSP"], (string)reader["AnhLucMoiMua"], (string)reader["AnhBayGio"]);
        //        //    sanPham.Add(sp);
        //        //}
        //    }
        //    catch (Exception ex) { }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return null;
        //}
        //public List<SanPham> LoadDanhSachSanPham(string query)
        //{
        //    List<SanPham> sanPham = new List<SanPham>();
        //    try
        //    {
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand(query, conn);
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            SanPham sp = new SanPham((string)reader["MSP"], (int)reader["IDChuSP"], (string)reader["TenSP"], (string)reader["DanhMuc"], (string)reader["GiaTienLucMoiMua"],
        //                (string)reader["GiaTienBayGio"], (DateTime)reader["NgayMuaSP"], (string)reader["SoLuong"], (string)reader["XuatXu"], (string)reader["BaoHanh"], (string)reader["TinhTrang"], (string)reader["MotaTinhTrang"], (string)reader["MotaSP"], (string)reader["AnhLucMoiMua"], (string)reader["AnhBayGio"]);
        //            sanPham.Add(sp);
        //        }
        //    }
        //    catch (Exception ex) { }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return sanPham;
        //}
        //public List<SanPham> LoadDSDonhang(string query)
        //{
        //    List<SanPham> sanPham = new List<SanPham>();
        //    try
        //    {
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand(query, conn);
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            SanPham sp = new SanPham((string)reader["MSP"], (int)reader["IDChuSP"], (string)reader["TenSP"], (string)reader["DanhMuc"], (string)reader["GiaTienLucMoiMua"],
        //                (string)reader["GiaTienBayGio"], (DateTime)reader["NgayMuaSP"], (string)reader["SoLuongDaMua"], (string)reader["XuatXu"], (string)reader["BaoHanh"], (string)reader["TinhTrang"], (string)reader["MotaTinhTrang"], (string)reader["MotaSP"], (string)reader["AnhLucMoiMua"], (string)reader["AnhBayGio"]);
        //            sanPham.Add(sp);
        //        }
        //    }
        //    catch (Exception ex) { }
        //    finally
        //    {
        //        conn.Close();

        //    }
        //    return sanPham;
        //}
        //public DataTable DangNhap(string query)
        //{
        //    //Dictionary<int, string> thongTin = new Dictionary<int, string>();
        //    try
        //    {
        //        conn.Open();
        //        SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
        //        DataTable dt = new DataTable();
        //        adapter.Fill(dt);
        //        return dt;
        //        //SqlCommand cmd = new SqlCommand(query, conn);
        //        //SqlDataReader reader = cmd.ExecuteReader();
        //        //if (reader.Read())
        //        //{
        //        //    thongTin[reader.GetInt32(0)] = reader.GetString(1);
        //        //    return thongTin;
        //        //}
        //        //else
        //        //{
        //        //    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Thông báo");
        //        //    return null;
        //        //}
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Thông báo");
        //        return null;
        //    }
        //    finally { conn.Close(); }
        //}
        //public Dictionary<int, string> DangNhap(string query)
        //{
        //    Dictionary<int, string> thongTin = new Dictionary<int, string>();
        //    try
        //    {
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand(query, conn);
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        if (reader.Read())
        //        {
        //            thongTin[reader.GetInt32(0)] = reader.GetString(1);
        //            return thongTin;
        //        }
        //        else
        //        {
        //            MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Thông báo");
        //            return null;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Thông báo");
        //        return null;
        //    }
        //    finally { conn.Close(); }
        //}
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
                int soDong = (int)cmd.ExecuteScalar();
                return soDong;
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
        //public DataTable LayMaSP(string sql)
        //{
        //    try
        //    {
        //        conn.Open();
        //        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
        //        DataTable dt = new DataTable();
        //        adapter.Fill(dt);
        //        return dt;
        //        //SqlCommand cmd = new SqlCommand(sql, conn);
        //        //string count = (string)cmd.ExecuteScalar();
        //        //return count;
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return null;
        //}
        //public string LayMaSP(string sql)
        //{
        //    try
        //    {
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand(sql, conn);
        //        string count = (string)cmd.ExecuteScalar();
        //        return count;
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}
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
        //public List<UCShop> LoadShop(string query)
        //{
        //    List<UCShop> shop = new List<UCShop>();
        //    try
        //    {
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand(query, conn);
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            UCShop uCShop = new UCShop((int)reader["ID"], (string)reader["FullName"], (Byte[])reader["Avarta"], (int)reader["SoLuong"]);
        //            shop.Add(uCShop);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Không thể load Shop", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return shop;
        //}
        public int giaVoucher(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return (int)reader["GiaTri"];
                }
            }
            catch (Exception ex) 
            {
                return 0;
            }
            finally
            {
                conn.Close();
            }
            return 0;
        }

        public Voucher LayVoucher(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Voucher voucher = new Voucher((int)reader["ID"], (int)reader["GiaTri"], (int)reader["SoLuongVoucher"], (string)reader["MaVoucher"], (string)reader["Mota"], (DateTime)reader["HSD"]);
                    return voucher;
                }
            }
            catch (Exception ex) { }
            finally
            {
                conn.Close();
            }
            return null;
        }
    }
}
