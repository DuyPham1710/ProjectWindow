using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
