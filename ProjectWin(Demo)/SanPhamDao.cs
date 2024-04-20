using System;
using System.Collections.Generic;
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

        public List<T> LoadGioHang<T>()
        {
            string sqlStr = string.Format("SELECT SanPham.*, GioHang.SoLuong as SLGioHang FROM GioHang, SanPham WHERE GioHang.MSP = SanPham.MSP and IDNguoiMua = {0}", id);
            return dBConnection.LoadSanPham<T>(sqlStr);
        }
        public List<SanPham> chiTietSanPham(string maSP)
        {
            string sqlStr = string.Format("SELECT * FROM SanPham WHERE MSP = '{0}'", maSP);
            return dBConnection.LoadDSDonhang(sqlStr);
        }
        public List<T> LoadSanPham<T>(string toanTu)
        {
            string sqlStr = string.Format("SELECT * FROM SanPham WHERE IDchuSP {0} {1}", toanTu, id);
            return dBConnection.LoadSanPham<T>(sqlStr);
        }
        public List<T> LoadSanPhamDaBan<T>()
        {
            string sqlStr = string.Format("SELECT * FROM SanPham inner join DaMua on SanPham.MSP = DaMua.MSP WHERE IDchuSP = {0} and TrangThai = N'Đã giao'", id);
            return dBConnection.LoadSanPham<T>(sqlStr);
        }
        //public List<UCSPCuaToi> LoadSanPhamCuaToi(int id)
        //{
        //    string sqlStr = string.Format("SELECT * FROM SanPham WHERE IDchuSP = {0}", id);
        //    return dBConnection.LoadSanPhamCuaToi(sqlStr);
        //}

        public List<T> timKiem<T>(string searchText, string toanTu)
        {
            string sqlQuery = string.Format("SELECT * FROM SanPham WHERE IDchuSP {0} {1} and TenSP LIKE @searchText", toanTu, id);
            return dBConnection.timKiemSP<T>(sqlQuery, searchText);
        }

        public List<T> LocTheoDanhMuc<T>(string danhMuc)
        {
            string sqlQuery = string.Format("SELECT * FROM SanPham WHERE IDchuSP <> {0} and DanhMuc = N'{1}'", id, danhMuc);
            return dBConnection.LoadSanPham<T>(sqlQuery);
        }
        public List<T> LoadSanPhamTuongTu<T>(SanPham sp)
        {
            string sqlQuery = string.Format("SELECT * FROM SanPham WHERE IDchuSP <> {0} and DanhMuc = N'{1}' and MSP <> '{2}'", id, sp.DanhMuc, sp.MaSP);
            return dBConnection.LoadSanPham<T>(sqlQuery);
        }
        public List<UCBinhLuan> LoadDanhGia()
        {
            string query = string.Format("Select ID, FullName, Avarta, BinhLuan, SoSao from Person, DanhGia, SanPham Where Person.ID = DanhGia.IDNguoiMua and DanhGia.MSP = SanPham.MSP and IDNguoiMua = {0}", id);
            return dBConnection.LoadDanhGiaSP(query);
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
        public List<SanPham> SapXepTheoGia(string sapXep)
        {
            string sqlStr = "";
            if (sapXep == "Tang dan")
            {
                sqlStr = string.Format("SELECT * FROM SanPham WHERE IDchuSP <> {0} Order By GiaTienBayGio ASC", id);
            }
            else if (sapXep == "Giam dan")
            {
                sqlStr = string.Format("SELECT * FROM SanPham WHERE IDchuSP <> {0} Order By GiaTienBayGio DESC", id);
            }
            return dBConnection.LoadDSDonhang(sqlStr);
        }

        public void ThemGioHang(SanPham sanPham, int soLuong)
        {
            string sqlStr = string.Format("SELECT SoLuong FROM GioHang WHERE MSP = '{0}' and IDNguoiMua = {1}", sanPham.MaSP, id);
            if (dBConnection.demDB(sqlStr) == 0)
            {
                sqlStr = string.Format("INSERT INTO GioHang(IDNguoiMua, MSP, SoLuong) VALUES ({0}, '{1}', {2})",
                      id, sanPham.MaSP, soLuong);
            }
            else
            {
                sqlStr = string.Format("UPDATE GioHang SET Soluong = {0} WHERE MSP = '{1}'", soLuong + dBConnection.demDB(sqlStr), sanPham.MaSP);

            }
            dBConnection.thucThi(sqlStr);

        }

        public void Update(SanPham sanPham) 
        {
            string sqlStr = string.Format("UPDATE SanPham SET TenSP = N'{0}', DanhMuc = N'{1}', GiaTienLucMoiMua = '{2}', GiaTienBayGio = '{3}', NgayMuaSP = '{4}', SoLuong = '{5}', XuatXu = N'{6}', BaoHanh = N'{7}', TinhTrang = N'{8}', MotaTinhTrang = N'{9}', MotaSP = N'{10}', AnhLucMoiMua = N'{11}', AnhBayGio = N'{12}' WHERE MSP = '{13}'",
                           sanPham.TenSP, sanPham.DanhMuc, sanPham.GiaBanDau, sanPham.GiaHienTai, sanPham.NgayMuaSP.ToString(), sanPham.SoLuong, sanPham.XuatXu, sanPham.BaoHanh, sanPham.TinhTrang, sanPham.MoTaTinhTrang, sanPham.MotaSP, sanPham.AnhBanDau, sanPham.AnhHienTai, sanPham.MaSP);
            dBConnection.thucThi(sqlStr);
        }
        
        public void Update(SanPham sp, Decimal soLuongSP)
        {
            string sqlStr = string.Format("INSERT INTO DaMua(ID, MSP, TrangThai) VALUES ('{0}', '{1}', N'{2}')",
                       id, sp.MaSP, "Chờ xác nhận");
            dBConnection.thucThi(sqlStr);
            sqlStr = string.Format("UPDATE SanPham SET SoLuong = '{0}' WHERE MSP = '{1}'", (Decimal.Parse(sp.SoLuong) - soLuongSP).ToString(), sp.MaSP);
            dBConnection.thucThi(sqlStr);
        }

        public void Delete(SanPham sanPham, string table) 
        {
            string sqlStr = string.Format("DELETE FROM {1} WHERE MSP = '{0}'", sanPham.MaSP, table);
            dBConnection.thucThi(sqlStr);
        }

        public List<SanPham> DSDonMua(string trangThai)
        {
            string query = string.Format("SELECT * FROM DaMua inner join SanPham on DaMua.MSP = SanPham.MSP WHERE DaMua.ID = {0} and DaMua.TrangThai = N'{1}'", id, trangThai);
            return dBConnection.LoadDSDonhang(query);
        }

        public List<SanPham> DSDonBan(string trangThai)
        {
            string query = string.Format("SELECT *FROM DaMua inner join SanPham on DaMua.MSP = SanPham.MSP WHERE SanPham.IDChuSP = {0} and DaMua.TrangThai = N'{1}'", id, trangThai);
            return dBConnection.LoadDSDonhang(query);
        }

        public void XacNhanDonhang(SanPham sanPham, string trangThai)
        {
            string query = string.Format("UPDATE DaMua SET TrangThai = N'{0}' where MSP = '{1}'", trangThai, sanPham.MaSP);
            dBConnection.thucThi(query);
        }
    }
}
