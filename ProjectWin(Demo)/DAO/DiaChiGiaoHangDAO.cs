using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWin_Demo_
{
    public class DiaChiGiaoHangDAO
    {
        DBConnection dBConnection;
        private int id;
        public DiaChiGiaoHangDAO(int id)
        {
            this.id = id;
            dBConnection = new DBConnection(id);
        }
        public void DiaChiNhanHang(string hoTen, string cacMaSP, string sdt, string DiaChiNhanHang)
        {
            string sqlStr = string.Format("INSERT INTO DiaChiGiaoHang(IDNguoiMua, MSP, HoTen, soDT, DiaChiNhanHang, ThoiGianThayDoi) VALUES ({0}, '{1}', N'{2}', '{3}', N'{4}', '{5}')", id, cacMaSP, hoTen, sdt, DiaChiNhanHang, DateTime.Now.ToString());
            dBConnection.thucThi(sqlStr);
        }
        public List<string> LoadDiaChiMoi()
        {
            string sqlStr = string.Format("select max(MaDiaChi) as max from DiaChiGiaoHang where IDNguoiMua = {0}", id);
            DataTable dt = dBConnection.LoadDuLieu(sqlStr);
            int max = Int32.Parse(dt.Rows[0]["max"].ToString());
           
            sqlStr = string.Format("select * from DiaChiGiaoHang where MaDiaChi = {0}", max);
            List<string> DiaChiMoi = new List<string>();
            dt = dBConnection.LoadDuLieu(sqlStr);
            DiaChiMoi.Add(dt.Rows[0]["HoTen"].ToString());
            DiaChiMoi.Add(dt.Rows[0]["soDT"].ToString());
            DiaChiMoi.Add(dt.Rows[0]["DiaChiNhanHang"].ToString());
            return DiaChiMoi;
        }
    }
}
