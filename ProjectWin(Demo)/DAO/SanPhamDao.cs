using ProjectWin_Demo_.UC;
using System;
using System.Collections;
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
        private int id, idShop;
        public SanPhamDao(int id)
        {
            this.id = id;
            dBConnection = new DBConnection(id);
        }
        public SanPhamDao(int id, int idShop)
        {
            this.idShop = idShop;
            this.id = id;
            dBConnection = new DBConnection(id);
        }
        public int TaoMaSP()
        {
            int maSP = 1;
            string sqlStr = "SELECT count(MSP) FROM SanPham";
            int soLuongSP = dBConnection.demDB(sqlStr);
            if (soLuongSP != 0)
            {
                string tam = timMaSPMax();
                maSP = int.Parse(tam.ToString().Substring(2)) + 1;
            }
            return maSP;
        }
        public string timMaSPMax()
        {
            string sqlStr = "SELECT max(MSP) as MaSPMAX FROM SanPham";
            DataTable dt = dBConnection.LoadDuLieu(sqlStr);
            return dt.Rows[0]["MaSPMAX"].ToString();
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
            }
            return DSSanPham;

        }
        public List<UCSanPham> LoadSanPhamCuaShop(string toanTu)
        {
            string sqlStr = string.Format("SELECT * FROM SanPham WHERE IDchuSP {0} {1}", toanTu, idShop);
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
        public List<UCSPDaBan> LoadSanPhamDaBan()
        {
            string sqlStr = string.Format("SELECT * FROM SanPham inner join DaMua on SanPham.MSP = DaMua.MSP WHERE IDchuSP = {0} and TrangThai = N'Đã giao'", id);
            DataTable dt = dBConnection.LoadDuLieu(sqlStr);
            List<UCSPDaBan> DSSanPham = new List<UCSPDaBan>();
            foreach (DataRow row in dt.Rows)
            {
                SanPham sp = new SanPham(row);
                sp.SoLuong = row["SoLuongDaMua"].ToString();
                UCSPDaBan ucSP = new UCSPDaBan(sp, id);
                DSSanPham.Add(ucSP);
            }
            return DSSanPham;
        }
      
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
        public SanPham LoadDanhSachSanPham(string maSP, decimal SoLuongDaChon)
        {
            string query = string.Format("Select * from SanPham WHERE MSP = '{0}'", maSP);
            DataTable dt = dBConnection.LoadDuLieu(query);
            SanPham sp = new SanPham(dt.Rows[0]);
            sp.SoLuong = SoLuongDaChon.ToString();
            sp.GiaHienTai = (Int32.Parse(sp.GiaHienTai) * SoLuongDaChon).ToString();
            return sp;
        }
        public SanPham LoadSanPhamChinhSua(string maSP)
        {
            string query = string.Format("Select * from SanPham WHERE MSP = '{0}'", maSP);
            DataTable dt = dBConnection.LoadDuLieu(query);
            SanPham sp = new SanPham(dt.Rows[0]);
            return sp;
        }
       
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
        }
    
        public List<UCSanPham> LoadSanPhamTuongTu(SanPham sp)
        {
            string sqlStr = string.Format("SELECT * FROM SanPham WHERE IDchuSP <> {0} and DanhMuc = N'{1}' and MSP <> '{2}'", id, sp.DanhMuc, sp.MaSP);
            DataTable dt = dBConnection.LoadDuLieu(sqlStr);
            List<UCSanPham> DSSanPham = new List<UCSanPham>();
            foreach (DataRow row in dt.Rows)
            {
                SanPham sanPham = new SanPham(row);
                UCSanPham ucSP = new UCSanPham(sanPham, id);
                DSSanPham.Add(ucSP);
            }
            return DSSanPham;
        }
      
        public List<UCBinhLuan> LoadDanhGia(string maSP)
        {
            string query = string.Format("Select ID, FullName, Avarta, BinhLuan, SoSao from Person, DanhGia, SanPham Where Person.ID = DanhGia.IDNguoiMua and DanhGia.MSP = SanPham.MSP and SanPham.MSP = '{0}'", maSP);
            DataTable dt = dBConnection.LoadDuLieu(query);
            List<UCBinhLuan> DSDanhGia = new List<UCBinhLuan>();
            foreach (DataRow row in dt.Rows)
            {
                object avarta = row["Avarta"];
                byte[] Avt = avarta != DBNull.Value ? (byte[])avarta : null;
                UCBinhLuan ucBinhLuan = new UCBinhLuan((int)row["ID"], (string)row["Fullname"], Avt, (string)row["BinhLuan"], (int)row["SoSao"]);
                DSDanhGia.Add(ucBinhLuan);
            }
            return DSDanhGia;
        }
        public void ThemSanPham(SanPham sanPham)
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

        public void SuaSanPham(SanPham sanPham) 
        {
            string sqlStr = string.Format("UPDATE SanPham SET TenSP = N'{0}', DanhMuc = N'{1}', GiaTienLucMoiMua = '{2}', GiaTienBayGio = '{3}', NgayMuaSP = '{4}', SoLuong = '{5}', XuatXu = N'{6}', BaoHanh = N'{7}', TinhTrang = N'{8}', MotaTinhTrang = N'{9}', MotaSP = N'{10}', AnhLucMoiMua = N'{11}', AnhBayGio = N'{12}' WHERE MSP = '{13}'",
                           sanPham.TenSP, sanPham.DanhMuc, sanPham.GiaBanDau, sanPham.GiaHienTai, sanPham.NgayMuaSP.ToString(), sanPham.SoLuong, sanPham.XuatXu, sanPham.BaoHanh, sanPham.TinhTrang, sanPham.MoTaTinhTrang, sanPham.MotaSP, sanPham.AnhBanDau, sanPham.AnhHienTai, sanPham.MaSP);
            dBConnection.thucThi(sqlStr);
        }
           
        public void DatHang(SanPham sp, string maVoucher)
        {
            string sqlStr = string.Format("INSERT DaMua(ID, MSP, TrangThai, SoLuongDaMua, MaVoucher, Gia, ThoiGianHienTai, ThoiGianDat) VALUES ({0}, '{1}', N'{2}', {3}, '{4}', {5}, '{6}', '{7}')",
                       id, sp.MaSP, "Chờ xác nhận", sp.SoLuong, maVoucher, Int32.Parse(sp.GiaHienTai), DateTime.Now, DateTime.Now);
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
        public List<SanPham> DanhSachDonMua(string trangThai)
        {
            string query = string.Format("SELECT * FROM DaMua inner join SanPham on DaMua.MSP = SanPham.MSP WHERE DaMua.ID = {0} and DaMua.TrangThai = N'{1}'", id, trangThai);
            DataTable dt = dBConnection.LoadDuLieu(query);
            List<SanPham> DSSanPham = new List<SanPham>();
            foreach (DataRow row in dt.Rows)
            {
                SanPham sp = new SanPham(row);
                sp.SoLuong = row["SoLuongDaMua"].ToString();
                sp.GiaHienTai = row["Gia"].ToString();
                sp.MaVanChuyen = Int32.Parse(row["MaVanChuyen"].ToString());
                DSSanPham.Add(sp);
            }
            return DSSanPham;
        }
        public List<UCSanPhamMua> DSDonMua(string trangThai)
        {
            string query = string.Format("Select * from SanPham, Person, DaMua where Person.ID = DaMua.ID and SanPham.MSP = DaMua.MSP and DaMua.ID = {0} and DaMua.TrangThai = N'{1}'", id, trangThai);

            DataTable dt = dBConnection.LoadDuLieu(query);
            List<UCSanPhamMua> DSSanPham = new List<UCSanPhamMua>();
            foreach (DataRow row in dt.Rows)
            {
                SanPham sp = new SanPham(row);
                sp.SoLuong = row["SoLuongDaMua"].ToString();
                sp.GiaHienTai = row["Gia"].ToString();
                UCSanPhamMua ucSP = new UCSanPhamMua(sp, id, Int32.Parse(row["MaVanChuyen"].ToString()));
                DSSanPham.Add(ucSP);
            }
            return DSSanPham;
        }
        public List<UCQuyTrinhDonHang> DSDonBan(string trangThai)
        {
            string query = string.Format("Select * from SanPham, Person, DaMua where Person.ID = DaMua.ID and SanPham.MSP = DaMua.MSP and SanPham.IDChuSP = {0} and  DaMua.TrangThai = N'{1}'", id, trangThai);

            DataTable dt = dBConnection.LoadDuLieu(query);
            List<UCQuyTrinhDonHang> DSSanPham = new List<UCQuyTrinhDonHang>();
            foreach (DataRow row in dt.Rows)
            {
                SanPham sp = new SanPham(row);
                UCQuyTrinhDonHang ucQuyTrinh = new UCQuyTrinhDonHang(sp, id, Int32.Parse(row["MaVanChuyen"].ToString()));
                DSSanPham.Add(ucQuyTrinh);
            }
            return DSSanPham;
        }
        public List<SanPham> DSDaBan(string trangThai)
        {
            string query = string.Format("SELECT * FROM DaMua inner join SanPham on DaMua.MSP = SanPham.MSP WHERE SanPham.IDChuSP = {0} and DaMua.TrangThai = N'{1}'", id, trangThai);
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
       
        public void XacNhanDonhang(SanPham sanPham, string trangThai, int soLuongDaMua)
        {
            if (trangThai != "Đã hủy")
            {
                string query = string.Format("UPDATE DaMua SET TrangThai = N'{0}', ThoiGianHienTai = '{1}' where MaVanChuyen = '{2}'", trangThai, DateTime.Now, sanPham.MaVanChuyen);
                dBConnection.thucThi(query);

                if (trangThai == "Đã giao")
                {
                    query = string.Format("UPDATE SanPham SET BanDuoc = (BanDuoc + {0}) where MSP = '{1}'", soLuongDaMua, sanPham.MaSP);
                    dBConnection.thucThi(query);
                }
            }
            else if (trangThai == "Đã hủy")
            {
                string query = string.Format("UPDATE DaMua SET TrangThai = N'{0}', ThoiGianHienTai = '{1}' where MaVanChuyen = '{2}'", trangThai, DateTime.Now, sanPham.MaVanChuyen);
                dBConnection.thucThi(query);
                query = string.Format("UPDATE SanPham SET SoLuong = (SoLuong + {0}) where MSP = '{1}'", soLuongDaMua, sanPham.MaSP);
                dBConnection.thucThi(query);
            }

        }
        public void LyDoHuySP(SanPham sp, string lyDo)
        {
            string sqlStr = string.Format("INSERT INTO SanPhamHuy(ID, MSP, LyDoHuy, ThoiGianHuy) VALUES ({0}, '{1}', N'{2}', '{3}')",
                       id, sp.MaSP, lyDo, DateTime.Now);
            dBConnection.thucThi(sqlStr);
            sqlStr = string.Format("Select SoLuongDaMua from DaMua where MaVanChuyen = {0}", sp.MaVanChuyen);
            DataTable dt = dBConnection.LoadDuLieu(sqlStr);

            int soLuongDaMua = Int32.Parse(dt.Rows[0]["SoLuongDaMua"].ToString());
         
            XacNhanDonhang(sp, "Đã hủy", soLuongDaMua);
        }
        public List<UCSanPham> SanPhamUaChuong()
        {
            string sqlStr = string.Format("SELECT Sum(BanDuoc)/(count(MSP)) FROM SanPham");
            int tb = dBConnection.demDB(sqlStr);
            sqlStr = string.Format("SELECT * FROM SanPham WHERE IDchuSP <> {0} and ( BanDuoc > {1} or SoLuong = '0') ", id, tb);
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
    }
}
