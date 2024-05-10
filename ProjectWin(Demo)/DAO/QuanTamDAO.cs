using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWin_Demo_
{
    public class QuanTamDAO
    {
        private int id;
        private DBConnection dBConnection;
        public QuanTamDAO(int id)
        {
            this.id = id;
            dBConnection = new DBConnection(id);
        }
        public void TheoDoiShop(int IDS)
        {
            string sqlStr = string.Format("INSERT INTO QuanTam(IDNguoiMua, IDShop) VALUES ({0}, {1})",
                id, IDS);
            dBConnection.thucThi(sqlStr);
        }
        public void BoTheoDoiShop(int IDS)
        {
            string sqlStr = string.Format("Delete from QuanTam where IDNguoiMua = {0} and IDShop = {1}",
                id, IDS);
            dBConnection.thucThi(sqlStr);
        }
        public bool KiemTraTheoDoi(int IDS)
        {
            string sqlStr = string.Format("select *from QuanTam where IDNguoiMua = {0} and IDShop = {1}", id, IDS);
            DataTable tmp = dBConnection.LoadDuLieu(sqlStr);
            if (tmp.Rows.Count == 0)
            {
                return false;
            }
            return true;
        }
    }
}
