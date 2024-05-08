using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWin_Demo_
{
    public class YeuThichDAO
    {
        private int id;
        DBConnection dBConnection;
        public YeuThichDAO(int id)
        {
            this.id = id;
            dBConnection = new DBConnection(id);
        }
        public void ThemYeuThich(string maSP)
        {
            string query = string.Format("insert into YeuThich(IDNguoiDung, MSP) values({0}, '{1}')", id, maSP);
            dBConnection.thucThi(query);
        }
        public void XoaYeuThich(string maSP)
        {
            string query = string.Format("delete from YeuThich where IDNguoiDung = {0} and MSP = '{1}'", id, maSP);
            dBConnection.thucThi(query);
        }
        public List<UCSanPham> LoadSanPhamYeuThich()
        {
            string query = string.Format("select * from SanPham where MSP in (select MSP from YeuThich where IDNguoiDung = {0})", id);
            DataTable dt = dBConnection.LoadDuLieu(query);
            List<UCSanPham> DSSanPham = new List<UCSanPham>();
            foreach (DataRow dr in dt.Rows)
            {
                SanPham sp = new SanPham(dr);
                UCSanPham uc = new UCSanPham(sp, id);
                DSSanPham.Add(uc);
            }
            return DSSanPham;
        }
        public bool KiemTraYeuThich(string maSP)
        {
            string query = string.Format("select * from YeuThich where IDNguoiDung = {0} and MSP = '{1}'", id, maSP);
            DataTable dt = dBConnection.LoadDuLieu(query);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
    }
}
