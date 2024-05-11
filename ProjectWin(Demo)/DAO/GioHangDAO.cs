using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWin_Demo_
{
    public class GioHangDAO
    {
        DBConnection dBConnection;
        private int id;
        public GioHangDAO(int id)
        {
            this.id = id;
            dBConnection = new DBConnection(id);
        }
        public List<UCGioHang> LoadGioHang()
        {
            string sqlStr = string.Format("SELECT SanPham.*, GioHang.SoLuong as SLGioHang FROM GioHang, SanPham WHERE GioHang.MSP = SanPham.MSP and IDNguoiMua = {0}", id);
            DataTable dt = dBConnection.LoadDuLieu(sqlStr);
            List<UCGioHang> DSGioHang = new List<UCGioHang>();
            foreach (DataRow row in dt.Rows)
            {
                SanPham sp = new SanPham(row);
                int soLuong = Int32.Parse(row["SLGioHang"].ToString());
                UCGioHang ucSP = new UCGioHang(sp, id, soLuong);
                DSGioHang.Add(ucSP);
            }
            return DSGioHang;
        }
      
        public List<UCGioHang> timKiemGioHang(string searchText)
        {
            string sqlStr = string.Format("SELECT SanPham.*, GioHang.SoLuong as SLGioHang FROM GioHang, SanPham WHERE GioHang.MSP = SanPham.MSP and IDNguoiMua = {0} and TenSP LIKE N'%{1}%'", id, searchText);
            DataTable dt = dBConnection.LoadDuLieu(sqlStr);
            List<UCGioHang> DSGioHang = new List<UCGioHang>();
            foreach (DataRow row in dt.Rows)
            {
                SanPham sp = new SanPham(row);
                int soLuong = Int32.Parse(row["SLGioHang"].ToString());
                UCGioHang ucSP = new UCGioHang(sp, id, soLuong);
                DSGioHang.Add(ucSP);
            }
            return DSGioHang;
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
        public void xoaGioHang(SanPham sanPham)
        {
            string sqlStr = string.Format("DELETE FROM GioHang WHERE MSP = '{0}'", sanPham.MaSP);
            dBConnection.thucThi(sqlStr);
        }
    }
}
