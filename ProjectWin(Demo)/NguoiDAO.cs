using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWin_Demo_
{
    internal class NguoiDAO
    {
        DBConnection dBConnection;
        private int id;
        public NguoiDAO(int id)
        {
            this.id = id;
            dBConnection = new DBConnection(id);
        }
        public MemoryStream LoadAvt()
        {
            string query = "SELECT  * FROM Person WHERE id = " + id.ToString();
            return dBConnection.LoadAvt(query);
        }
        public void themTaiKhoan(Nguoi nguoi)
        {
            string sqlStr = string.Format("INSERT INTO Person(ID, FullName, Phone, CCCD, Gender, Bith, Email, Addr) VALUES ({0}, N'{1}', '{2}', '{3}', N'{4}', '{5}', '{6}', N'{7}')",
               nguoi.ID, nguoi.FullName, nguoi.PhoneNumber, nguoi.Cccd, nguoi.Gender, nguoi.DateOfBirth.ToString(), nguoi.Email, nguoi.Address);
            dBConnection.thucThi(sqlStr);
            sqlStr = string.Format("INSERT INTO Account(ID, UserName, Pass, Position) VALUES ({0}, '{1}', '{2}', '{3}')",
                    nguoi.ID, nguoi.UserName, nguoi.Password, nguoi.Position);
            dBConnection.thucThi(sqlStr);
        }
       
        public void suaTaiKhoan()
        {

        }
        public void xoaTaiKhoan()
        {

        }
        public List<UCShop> LoadShop()
        {
            string sqlStr = string.Format("SELECT Person.*, TK.SoLuong FROM Person, (SELECT IDChuSP, COUNT(DISTINCT MSP) AS SoLuong FROM SanPham GROUP BY IDChuSP) as TK WHERE TK.IDChuSP = Person.ID and Person.ID <> {0} and TK.SoLuong > 0", id);
            return dBConnection.LoadShop(sqlStr);
        }
        public List<UCShop> UyTin(string toantu)
        {
            string sqlStr = string.Format("SELECT Person.*, TK.SoLuong FROM Person, (SELECT IDChuSP, COUNT(DISTINCT MSP) AS SoLuong, Sum(Distinct BanDuoc) AS daban FROM SanPham GROUP BY IDChuSP) as TK WHERE TK.IDChuSP = Person.ID and Person.ID <> {0} and TK.SoLuong > 0 and TK.daban {1} 5", id, toantu);
            return dBConnection.LoadShop(sqlStr);
        }
    }
}
