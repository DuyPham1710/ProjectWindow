using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProjectWin_Demo_
{
    public class DaMuaDAO
    {
        private int id;
        private DBConnection dBConnection;
        public DaMuaDAO(int id)
        {
            this.id = id;
            dBConnection = new DBConnection(id);
        }
        public List<string> LoadThongTinQuyTrinh(int maVanChuyen)
        {
            string query = string.Format("Select * from Person,DaMua where Person.ID = DaMua.ID and DaMua.MaVanChuyen = {0}", maVanChuyen);
            DataTable dt = dBConnection.LoadDuLieu(query);
            List<string> thongTin = new List<string>();
            thongTin.Add(dt.Rows[0]["FullName"].ToString());
            thongTin.Add(dt.Rows[0]["SoLuongDaMua"].ToString());
            return thongTin;
        }
        public void HuyDonHang(int maVanChuyen)
        {
            string query = string.Format("delete from DaMua where MaVanChuyen = {0}", maVanChuyen);
            dBConnection.thucThi(query);
        }
        public DataTable LoadDoanhThu(string thang, string nam)
        {
            string loc = "";
            if (thang != "")
            {
                loc = " and " + loc + "DATEPART(month, DaMua.ThoiGianHienTai) = " + thang;
            }
            if (nam != "" && int.TryParse(nam, out int nguyen))
            {
                loc = loc + " and " + "DATEPART(year, DaMua.ThoiGianHienTai) = " + nam;
            }
            string sql = string.Format("select sum(CAST(DaMua.SoLuongDaMua  as int)) as TongSoLuong, sum(DaMua.Gia) as TongTien from SanPham, DaMua, Person Where SanPham.MSP = DaMua.MSP  and DaMua.ID = Person.ID and SanPham.IDChuSP = {0} and DaMua.TrangThai = N'Đã giao' {1} group by SanPham.IDChuSP", id, loc);
            DataTable dt = dBConnection.LoadDuLieu(sql);
            return dt;
        }
        public DataTable LoadBieuDoDoanhThu(string nam)
        {
            string sql = string.Format("select MONTH(DaMua.ThoiGianHienTai) AS [Tháng], SUM(DaMua.Gia) AS [Doanh thu] from SanPham, DaMua Where SanPham.MSP = DaMua.MSP and SanPham.IDChuSP = {0} and DaMua.TrangThai = N'Đã giao' and YEAR(DaMua.ThoiGianHienTai) = {1} GROUP BY MONTH(DaMua.ThoiGianHienTai)", id, nam);
            return dBConnection.LoadDuLieu(sql);

        }
        public DataTable LoadChiTietDoanhThu(string thang, string nam)
        {
            string loc = "";
            if (thang != "")
            {
                loc = " and " + loc + "DATEPART(month, DaMua.ThoiGianHienTai) = " + thang;
            }
            if (nam != "" && int.TryParse(nam, out int nguyen))
            {
                loc = loc + " and " + "DATEPART(year, DaMua.ThoiGianHienTai) = " + nam;
            }
            string sql = string.Format("select SanPham.MSP, TenSP, SoLuongDaMua, FullName, ThoiGianDat, ThoiGianHienTai, Addr, Gia from SanPham, DaMua, Person Where SanPham.MSP = DaMua.MSP and DaMua.ID = Person.ID and SanPham.IDChuSP = {0} and DaMua.TrangThai = N'Đã giao' {1}", id, loc);
            return dBConnection.LoadDuLieu(sql);
        }
    }
}
