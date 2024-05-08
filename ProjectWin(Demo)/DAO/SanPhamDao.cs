﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWin_Demo_
{
    internal class SanPhamDao
    {
        DBConnection dBConnection;
        private int id;
        public SanPhamDao(int id)
        {
            this.id = id;
            dBConnection = new DBConnection(id);
        }

        public string LayMaSP()
        {
            string sqlStr = string.Format("SELECT MSP FROM SanPham WHERE IDchuSP = {0}", id);
            DataTable dt = dBConnection.LoadDuLieu(sqlStr);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            return dt.Rows[0]["MSP"].ToString();
        }
        //public string LayMaSP()
        //{
        //    string sqlStr = string.Format("SELECT MSP FROM SanPham WHERE IDchuSP = {0}", id);
        //    return dBConnection.LayMaSP(sqlStr);
        //}
        public List<SanPham> chiTietSanPham(string maSP)
        {
            string sqlStr = string.Format("SELECT * FROM SanPham WHERE MSP = '{0}'", maSP);
            DataTable dt = dBConnection.LoadDuLieu(sqlStr);
            List<SanPham> cacSanPham = new List<SanPham>();
            foreach (DataRow row in dt.Rows)
            {
                SanPham sp = new SanPham(row);
                cacSanPham.Add(sp);
            }
            return cacSanPham;
        }
        public List<T> LoadSanPham<T>(string toanTu)
        {
            string sqlStr = string.Format("SELECT * FROM SanPham WHERE IDchuSP {0} {1}", toanTu, id);
            //return dBConnection.LoadSanPham<T>(sqlStr);
            DataTable dt = dBConnection.LoadDuLieu(sqlStr);
            List<T> DSSanPham = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                SanPham sp = new SanPham(row);
                
                if (typeof(T) == typeof(UCSanPham))
                {
                    UCSanPham ucSP = new UCSanPham(sp, id);
                    DSSanPham.Add((T)(object)ucSP);
                }
                else if (typeof(T) == typeof(UCSPCuaToi))
                {
                    UCSPCuaToi ucSP = new UCSPCuaToi(sp);
                    DSSanPham.Add((T)(object)ucSP);
                }
                //else if (typeof(T) == typeof(UCSPDaBan))
                //{
                //    UCSPDaBan ucSP = new UCSPDaBan(sp, id);
                //    DSSanPham.Add((T)(object)ucSP);
                //}
                //else if (typeof(T) == typeof(UCGioHang))
                //{
                //    //int soLuong = (int)reader["SLGioHang"];
                //    int soLuong = Int32.Parse(dt.Rows[0]["SLGioHang"].ToString());
                //    UCGioHang ucSP = new UCGioHang(sp, id, soLuong);
                //    DSSanPham.Add((T)(object)ucSP);
                //}
            }
            return DSSanPham;

        }
        public List<UCSPDaBan> LoadSanPhamDaBan()
        {
            string sqlStr = string.Format("SELECT * FROM SanPham inner join DaMua on SanPham.MSP = DaMua.MSP WHERE IDchuSP = {0} and TrangThai = N'Đã giao'", id);
            DataTable dt = dBConnection.LoadDuLieu(sqlStr);
            List<UCSPDaBan> DSSanPham = new List<UCSPDaBan>();
            foreach (DataRow row in dt.Rows)
            {
                SanPham sp = new SanPham(row);
                UCSPDaBan ucSP = new UCSPDaBan(sp, id);
                DSSanPham.Add(ucSP);
            }
            return DSSanPham;
            //return dBConnection.LoadSanPham<T>(sqlStr);
        }
        //public List<T> LoadSanPhamDaBan<T>()
        //{
        //    string sqlStr = string.Format("SELECT * FROM SanPham inner join DaMua on SanPham.MSP = DaMua.MSP WHERE IDchuSP = {0} and TrangThai = N'Đã giao'", id);
        //    DataTable dt = dBConnection.LoadSanPham(sqlStr);
        //    foreach (DataRow row in dt.Rows) { 
        //    }
        //    //return dBConnection.LoadSanPham<T>(sqlStr);
        //}

        public List<T> timKiem<T>(string searchText, string toanTu)
        {
            string sqlQuery = string.Format("SELECT * FROM SanPham WHERE IDchuSP {0} {1} and TenSP LIKE N'%{2}%'", toanTu, id, searchText);
            DataTable dt = dBConnection.LoadDuLieu(sqlQuery);
            List<T> DSSanPham = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                SanPham sp = new SanPham(row);
                if (typeof(T) == typeof(UCSanPham))
                {
                    UCSanPham ucSP = new UCSanPham(sp, id);
                    DSSanPham.Add((T)(object)ucSP);
                }
                else if (typeof(T) == typeof(UCSPCuaToi))
                {
                    UCSPCuaToi ucSP = new UCSPCuaToi(sp);
                    DSSanPham.Add((T)(object)ucSP);
                }
            }
            return DSSanPham;
        }
        //public List<T> timKiemGioHang<T>(string searchText)
        //{
        //    string sqlStr = string.Format("SELECT SanPham.*, GioHang.SoLuong as SLGioHang FROM GioHang, SanPham WHERE GioHang.MSP = SanPham.MSP and IDNguoiMua = {0} and TenSP LIKE @searchText", id);
        //    return dBConnection.timKiemSP<T>(sqlStr, searchText);
        //}
        public List<UCSanPham> LocTheoDanhMuc(string danhMuc)
        {
            string sqlStr = string.Format("SELECT * FROM SanPham WHERE IDchuSP <> {0} and DanhMuc = N'{1}'", id, danhMuc);
            DataTable dt = dBConnection.LoadDuLieu(sqlStr);
            List<UCSanPham> DSSanPham = new List<UCSanPham>();
            foreach (DataRow row in dt.Rows)
            {
                SanPham sp = new SanPham(row);
                UCSanPham ucSP = new UCSanPham(sp, id);
                DSSanPham.Add(ucSP);
            }
            return DSSanPham;
           // return dBConnection.LoadSanPham(sqlQuery);
        }
        //public List<T> LocTheoDanhMuc<T>(string danhMuc)
        //{
        //    string sqlQuery = string.Format("SELECT * FROM SanPham WHERE IDchuSP <> {0} and DanhMuc = N'{1}'", id, danhMuc);
        //    return dBConnection.LoadSanPham<T>(sqlQuery);
        //}
        public List<UCSanPham> LoadSanPhamTuongTu(SanPham sp)
        {
            string sqlStr = string.Format("SELECT * FROM SanPham WHERE IDchuSP <> {0} and DanhMuc = N'{1}' and MSP <> '{2}'", id, sp.DanhMuc, sp.MaSP);
            DataTable dt = dBConnection.LoadDuLieu(sqlStr);
            List<UCSanPham> DSSanPham = new List<UCSanPham>();
            foreach (DataRow row in dt.Rows)
            {
                SanPham sanPham = new SanPham(row);
                UCSanPham ucSP = new UCSanPham(sp, id);
                DSSanPham.Add(ucSP);
            }
            return DSSanPham;
        }
        //public List<T> LoadSanPhamTuongTu<T>(SanPham sp)
        //{
        //    string sqlQuery = string.Format("SELECT * FROM SanPham WHERE IDchuSP <> {0} and DanhMuc = N'{1}' and MSP <> '{2}'", id, sp.DanhMuc, sp.MaSP);
        //    return dBConnection.LoadSanPham<T>(sqlQuery);
        //}
        public List<UCBinhLuan> LoadDanhGia()
        {
            string query = string.Format("Select ID, FullName, Avarta, BinhLuan, SoSao from Person, DanhGia, SanPham Where Person.ID = DanhGia.IDNguoiMua and DanhGia.MSP = SanPham.MSP and IDNguoiMua = {0}", id);
            DataTable dt = dBConnection.LoadDuLieu(query);
            List<UCBinhLuan> DSDanhGia = new List<UCBinhLuan>();
            foreach (DataRow row in dt.Rows)
            {
                UCBinhLuan ucBinhLuan = new UCBinhLuan((int)row["ID"], (string)row["Fullname"], (byte[])row["Avarta"], (string)row["BinhLuan"], (int)row["SoSao"]);
                DSDanhGia.Add(ucBinhLuan);
            }
            return DSDanhGia;
        }
        public void Add(SanPham sanPham)
        {
            string sqlStr = string.Format("INSERT INTO SanPham(MSP, IDChuSP, TenSP, DanhMuc, GiaTienLucMoiMua, GiaTienBayGio, NgayMuaSP, SoLuong, XuatXu, BaoHanh, TinhTrang, MotaTinhTrang, MotaSP, AnhLucMoiMua, AnhBayGio) VALUES ('{0}', '{1}', N'{2}', N'{3}', '{4}', '{5}', '{6}', '{7}', N'{8}', N'{9}', N'{10}', N'{11}', N'{12}', N'{13}', N'{14}')",
                        sanPham.MaSP, sanPham.IDChuSP, sanPham.TenSP, sanPham.DanhMuc, sanPham.GiaBanDau, sanPham.GiaHienTai, sanPham.NgayMuaSP.ToString(), sanPham.SoLuong, sanPham.XuatXu, sanPham.BaoHanh, sanPham.TinhTrang, sanPham.MoTaTinhTrang, sanPham.MotaSP, sanPham.AnhBanDau, sanPham.AnhHienTai);
            dBConnection.thucThi(sqlStr);
        }
        public void DanhGia(SanPham sp, string binhLuan, int soSao)
        {
            string query = string.Format("INSERT INTO DanhGia(IDNguoiMua, MSP, BinhLuan, SoSao) VALUES ({0}, '{1}', N'{2}', {3})", id, sp.MaSP, binhLuan, soSao);
            dBConnection.thucThi(query);

        }
        public List<UCSanPham> SapXepTheoGia(string sapXep)
        {
            string sqlStr = "";
            if (sapXep == "Tang dan")
            {
                sqlStr = string.Format("SELECT * FROM SanPham WHERE IDchuSP <> {0} Order By CAST (GiaTienBayGio AS INT) ASC", id);
            }
            else if (sapXep == "Giam dan")
            {
                sqlStr = string.Format("SELECT * FROM SanPham WHERE IDchuSP <> {0} Order By CAST (GiaTienBayGio AS INT) DESC", id);
            }
            DataTable dt = dBConnection.LoadDuLieu(sqlStr);
            List<UCSanPham> DSSanPham = new List<UCSanPham>();
            foreach (DataRow row in dt.Rows)
            {
                SanPham sp = new SanPham(row);
                UCSanPham ucSP = new UCSanPham(sp, id);
                DSSanPham.Add(ucSP);
            }
            return DSSanPham;
        }
        //public List<SanPham> SapXepTheoGia(string sapXep)
        //{
        //    string sqlStr = "";
        //    if (sapXep == "Tang dan")
        //    {
        //        sqlStr = string.Format("SELECT * FROM SanPham WHERE IDchuSP <> {0} Order By GiaTienBayGio ASC", id);
        //    }
        //    else if (sapXep == "Giam dan")
        //    {
        //        sqlStr = string.Format("SELECT * FROM SanPham WHERE IDchuSP <> {0} Order By GiaTienBayGio DESC", id);
        //    }
        //    return dBConnection.LoadDanhSachSanPham(sqlStr);
        //}

        //public void ThemGioHang(SanPham sanPham, int soLuong)
        //{
        //    string sqlStr = string.Format("SELECT SoLuong FROM GioHang WHERE MSP = '{0}' and IDNguoiMua = {1}", sanPham.MaSP, id);
        //    if (dBConnection.demDB(sqlStr) == 0)
        //    {
        //        sqlStr = string.Format("INSERT INTO GioHang(IDNguoiMua, MSP, SoLuong) VALUES ({0}, '{1}', {2})",
        //              id, sanPham.MaSP, soLuong);
        //    }
        //    else
        //    {
        //        sqlStr = string.Format("UPDATE GioHang SET Soluong = {0} WHERE MSP = '{1}'", soLuong + dBConnection.demDB(sqlStr), sanPham.MaSP);

        //    }
        //    dBConnection.thucThi(sqlStr);

        //}

        public void Update(SanPham sanPham) 
        {
            string sqlStr = string.Format("UPDATE SanPham SET TenSP = N'{0}', DanhMuc = N'{1}', GiaTienLucMoiMua = '{2}', GiaTienBayGio = '{3}', NgayMuaSP = '{4}', SoLuong = '{5}', XuatXu = N'{6}', BaoHanh = N'{7}', TinhTrang = N'{8}', MotaTinhTrang = N'{9}', MotaSP = N'{10}', AnhLucMoiMua = N'{11}', AnhBayGio = N'{12}' WHERE MSP = '{13}'",
                           sanPham.TenSP, sanPham.DanhMuc, sanPham.GiaBanDau, sanPham.GiaHienTai, sanPham.NgayMuaSP.ToString(), sanPham.SoLuong, sanPham.XuatXu, sanPham.BaoHanh, sanPham.TinhTrang, sanPham.MoTaTinhTrang, sanPham.MotaSP, sanPham.AnhBanDau, sanPham.AnhHienTai, sanPham.MaSP);
            dBConnection.thucThi(sqlStr);
        }
        
        //public void Update(SanPham sp, Decimal soLuongSP)
        //{
        //    string sqlStr = string.Format("INSERT INTO DaMua(ID, MSP, TrangThai, SoLuongDaMua) VALUES ({0}, '{1}', N'{2}', {3})",
        //               id, sp.MaSP, "Chờ xác nhận", soLuongSP);
        //    dBConnection.thucThi(sqlStr);
        //    sqlStr = string.Format("UPDATE SanPham SET SoLuong = '{0}' WHERE MSP = '{1}'", (Decimal.Parse(sp.SoLuong) - soLuongSP).ToString(), sp.MaSP);
        //    dBConnection.thucThi(sqlStr);
        //}
        public void DatHang(SanPham sp, string maVoucher)
        {
            string sqlStr = string.Format("INSERT INTO DaMua(ID, MSP, TrangThai, SoLuongDaMua, MaVoucher) VALUES ({0}, '{1}', N'{2}', {3}, '{4}')",
                       id, sp.MaSP, "Chờ xác nhận", sp.SoLuong, maVoucher);
            dBConnection.thucThi(sqlStr);
            sqlStr = string.Format("Select SoLuong from SanPham where MSP = '{0}'", sp.MaSP);
            int soLuongBanDau = dBConnection.soLuongSanPham(sqlStr);
            sqlStr = string.Format("UPDATE SanPham SET SoLuong = '{0}' WHERE MSP = '{1}'", (soLuongBanDau - Decimal.Parse(sp.SoLuong)).ToString(), sp.MaSP);
            dBConnection.thucThi(sqlStr);
            VoucherDAO voucherDao = new VoucherDAO(id);
            voucherDao.capNhatVoucher(maVoucher);
        }

        public void xoaSP(SanPham sanPham) 
        {
            string sqlStr = string.Format("DELETE FROM SanPham WHERE MSP = '{0}'", sanPham.MaSP);
            dBConnection.thucThi(sqlStr);
        }
        public List<SanPham> DSDonMua(string trangThai)
        {
            string query = string.Format("SELECT * FROM DaMua inner join SanPham on DaMua.MSP = SanPham.MSP WHERE DaMua.ID = {0} and DaMua.TrangThai = N'{1}'", id, trangThai);
            DataTable dt = dBConnection.LoadDuLieu(query);
            List<SanPham> DSSanPham = new List<SanPham>();
            foreach (DataRow row in dt.Rows)
            {
                SanPham sp = new SanPham(row);
                sp.SoLuong = row["SoLuongDaMua"].ToString();
                DSSanPham.Add(sp);
            }
            return DSSanPham;
        }

        public List<SanPham> DSDonBan(string trangThai)
        {
            string query = string.Format("SELECT * FROM DaMua inner join SanPham on DaMua.MSP = SanPham.MSP WHERE SanPham.IDChuSP = {0} and DaMua.TrangThai = N'{1}'", id, trangThai);
            DataTable dt = dBConnection.LoadDuLieu(query);
            List<SanPham> DSSanPham = new List<SanPham>();
            foreach (DataRow row in dt.Rows)
            {
                SanPham sp = new SanPham(row);

                DSSanPham.Add(sp);
            }
            return DSSanPham;
        }
        //public List<SanPham> DSDonMua(string trangThai)
        //{
        //    string query = string.Format("SELECT * FROM DaMua inner join SanPham on DaMua.MSP = SanPham.MSP WHERE DaMua.ID = {0} and DaMua.TrangThai = N'{1}'", id, trangThai);
        //    return dBConnection.LoadDSDonhang(query);
        //}

        //public List<SanPham> DSDonBan(string trangThai)
        //{
        //    string query = string.Format("SELECT * FROM DaMua inner join SanPham on DaMua.MSP = SanPham.MSP WHERE SanPham.IDChuSP = {0} and DaMua.TrangThai = N'{1}'", id, trangThai);
        //    return dBConnection.LoadDSDonhang(query);
        //}

        public void XacNhanDonhang(SanPham sanPham, string trangThai)
        {
            string query = string.Format("UPDATE DaMua SET TrangThai = N'{0}' where MSP = '{1}'", trangThai, sanPham.MaSP);
            dBConnection.thucThi(query);
            if (trangThai == "Đã giao")
            {
                query = string.Format("UPDATE SanPham SET BanDuoc = (BanDuoc + 1) where MSP = '{1}'", trangThai, sanPham.MaSP);
                dBConnection.thucThi(query);
            }
        }
        public void LyDoHuySP(SanPham sp, string lyDo)
        {
            string sqlStr = string.Format("INSERT INTO SanPhamHuy(ID, MSP, LyDoHuy, ThoiGianHuy) VALUES ({0}, '{1}', N'{2}', '{3}')",
                       id, sp.MaSP, lyDo, DateTime.Now);
            dBConnection.thucThi(sqlStr);
            XacNhanDonhang(sp, "Đã hủy");
        }
        public List<UCSanPham> SanPhamUaChuong()
        {
            string sqlStr = string.Format("SELECT AVG(BanDuoc) FROM SanPham");
            int tb = dBConnection.demDB(sqlStr);
            sqlStr = string.Format("SELECT * FROM SanPham WHERE IDchuSP <> {0} and BanDuoc > {1} ", id, tb);
            DataTable dt = dBConnection.LoadDuLieu(sqlStr);
            List<UCSanPham> DSSanPham = new List<UCSanPham>();
            foreach (DataRow row in dt.Rows)
            {
                SanPham sp = new SanPham(row);
                UCSanPham ucSP = new UCSanPham(sp, id);
                DSSanPham.Add(ucSP);
            }
            return DSSanPham;
        }
        //public List<T> SanPhamUaChuong<T>()
        //{
        //    string sqlStr = string.Format("SELECT AVG(BanDuoc) FROM SanPham");
        //    int tb = dBConnection.demDB(sqlStr);
        //    sqlStr = string.Format("SELECT * FROM SanPham WHERE IDchuSP <> {0} and BanDuoc > {1} ", id, tb);
        //    return dBConnection.LoadSanPham<T>(sqlStr);
        //}

        //public void DiaChiNhanHang(string hoTen, string sdt, string DiaChiNhanHang)
        //{
        //    string sqlStr = string.Format("INSERT INTO DiaChiGiaoHang(IDNguoiMua, MSP, HoTen, soDT, DiaChiNhanHang) VALUES ({0}, N'{1}', '{2}', N'{3}'", id, hoTen, sdt, DiaChiNhanHang);
        //    dBConnection.thucThi(sqlStr);
        //}
    }
}
