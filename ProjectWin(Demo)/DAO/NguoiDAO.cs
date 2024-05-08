using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWin_Demo_
{
    internal class NguoiDAO
    {
        DBConnection dBConnection;
        private int id;
        
        public NguoiDAO() 
        {
            dBConnection = new DBConnection();
        }
        public NguoiDAO(int id)
        {
            this.id = id;
            dBConnection = new DBConnection(id);
        }
        public MemoryStream LoadAvt()
        {
            string query = "SELECT * FROM Person WHERE id = " + id.ToString();
            DataTable dt = dBConnection.LoadAvt(query);
            if (dt.Rows.Count > 0)
            {
                object avarta = dt.Rows[0]["Avarta"];
                byte[] avartaBytes = avarta != DBNull.Value ? (byte[])avarta : null;
                //byte[] img = (byte[])dt.Rows[0]["Avarta"];
                MemoryStream ms = new MemoryStream(avartaBytes);
                return ms;
            }
            else
            {
                return null;
            }
            //return dBConnection.LoadAvt(query);
        }
        public Nguoi LoadThongTinCaNhan()
        {
            string query = "SELECT * FROM Person,Account WHERE Person.ID = Account.ID and Account.ID = " + id.ToString();
            DataTable dt = dBConnection.LoadDuLieu(query);
            if (dt.Rows.Count > 0)
            {
                Nguoi nguoiDung = new Nguoi(dt);
                return nguoiDung;
            }
            return null;
        }
        //public Nguoi LoadThongTinCaNhan()
        //{
        //    string query = "SELECT *FROM Person,Account WHERE Person.ID = Account.ID and Account.ID = " + id.ToString();
        //    DataTable dt = dBConnection.LoadThongTinCaNhan(query);
        //    if (dt.Rows.Count > 0)
        //    {
        //        Nguoi nguoiDung = new Nguoi(dt);
        //        return nguoiDung;
        //    }
        //    return null;
        //    //return dBConnection.LoadThongTinCaNhan(query);
        //}

        public void themTaiKhoan(Nguoi nguoi)
        {
            string sqlStr = string.Format("INSERT INTO Person(ID, FullName, Phone, CCCD, Gender, Bith, Email, Addr) VALUES ({0}, N'{1}', '{2}', '{3}', N'{4}', '{5}', '{6}', N'{7}')",
               nguoi.ID, nguoi.FullName, nguoi.PhoneNumber, nguoi.Cccd, nguoi.Gender, nguoi.DateOfBirth.ToString(), nguoi.Email, nguoi.Address);
            dBConnection.thucThi(sqlStr);
            sqlStr = string.Format("INSERT INTO Account(ID, UserName, Pass, Position) VALUES ({0}, '{1}', '{2}', '{3}')",
                    nguoi.ID, nguoi.UserName, nguoi.Password, nguoi.Position);
            dBConnection.thucThi(sqlStr);
        }
        public Dictionary<int, string> DangNhap(string userName, string passWord)
        {
            string query = string.Format("SELECT ID, Position FROM Account WHERE UserName = '{0}' and Pass = '{1}'", userName, passWord);
            DataTable dt = dBConnection.LoadDuLieu(query);

            if (dt.Rows.Count > 0)
            {
                Dictionary<int, string> thongTin = new Dictionary<int, string>();
                thongTin[Int32.Parse(dt.Rows[0]["ID"].ToString())] = dt.Rows[0]["Position"].ToString();
                return thongTin;
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Thông báo");
                return null;
            }
            //return dBConnection.DangNhap(query);
        }
        // sửa chổ này nha
        public int TaoID()
        {
            string idStr = "SELECT count(*) FROM Person";
            return dBConnection.demDB(idStr) + 1;
        }
        public void DangKy(Nguoi nguoiDung)
        {
            string sqlStr = string.Format("INSERT INTO Person(ID, FullName, Phone, CCCD, Gender, Bith, Email, Addr) VALUES ({0}, N'{1}', '{2}', '{3}', N'{4}', '{5}', '{6}', N'{7}')",
            nguoiDung.ID, nguoiDung.FullName, nguoiDung.PhoneNumber, nguoiDung.Cccd, nguoiDung.Gender, nguoiDung.DateOfBirth.ToString(), nguoiDung.Email, nguoiDung.Address);
            dBConnection.thucThi(sqlStr);

            sqlStr = string.Format("INSERT INTO Account(ID, UserName, Pass, Position) VALUES ({0}, '{1}', '{2}', '{3}')",
                nguoiDung.ID, nguoiDung.UserName, nguoiDung.Password, nguoiDung.Position);
            dBConnection.thucThi(sqlStr);
        }
       
        public void suaTaiKhoan(Nguoi nguoiDung)
        {
            string sqlStr = string.Format("UPDATE Person SET FullName = N'{0}', Phone = '{1}', CCCD = '{2}', Gender = N'{3}', Bith = '{4}', Email = '{5}', Avarta = 0x{6}, Addr = N'{7}' WHERE ID = {8}", 
                nguoiDung.FullName, nguoiDung.PhoneNumber, nguoiDung.Cccd, nguoiDung.Gender, nguoiDung.DateOfBirth, nguoiDung.Email, nguoiDung.Avt.Length, nguoiDung.Address, nguoiDung.ID);
            dBConnection.thucThi(sqlStr);
        }
        public void xoaTaiKhoan()
        {

        }
        public List<UCShop> LoadShop()
        {
            string sqlStr = string.Format("SELECT Person.*, TK.SoLuong FROM Person, (SELECT IDChuSP, COUNT(DISTINCT MSP) AS SoLuong FROM SanPham GROUP BY IDChuSP) as TK WHERE TK.IDChuSP = Person.ID and Person.ID <> {0} and TK.SoLuong > 0", id); 
            DataTable dt = dBConnection.LoadDuLieu(sqlStr);
            List<UCShop> ucShops = new List<UCShop>();
            foreach (DataRow row in dt.Rows)
            {
                UCShop ucShop = new UCShop(id, Int32.Parse(row["ID"].ToString()), row["FullName"].ToString(), (byte[])row["Avarta"], Int32.Parse(row["SoLuong"].ToString()));
                ucShops.Add(ucShop);
            }
            return ucShops;
        }
        public List<UCShop> UyTin(string toantu)
        {
            string sqlStr = string.Format("SELECT Person.*, TK.SoLuong,S.TBSao FROM (select Account.ID, AVG(DanhGia.SoSao) as TBSao from Account, Person, SanPham, DanhGia Where Account.ID = Person.ID and Person.ID = SanPham.IDChuSP and SanPham.MSP = DanhGia.MSP Group by Account.ID) as S,Person, (SELECT IDChuSP, COUNT(DISTINCT MSP) AS SoLuong FROM SanPham GROUP BY IDChuSP) as TK WHERE TK.IDChuSP = Person.ID and S.ID=Person.ID and Person.ID <> {0} and TK.SoLuong > 0 and TBSao {1} 3", id, toantu); 
            DataTable dt = dBConnection.LoadDuLieu(sqlStr);
            List<UCShop> ucShops = new List<UCShop>();
            foreach (DataRow row in dt.Rows)
            {
                UCShop ucShop = new UCShop(id, Int32.Parse(row["ID"].ToString()), row["FullName"].ToString(), (byte[])row["Avarta"], Int32.Parse(row["SoLuong"].ToString()));
                ucShops.Add(ucShop);
            }
            return ucShops;
        }
        //public List<UCShop> LoadShop()
        //{
        //    string sqlStr = string.Format("SELECT Person.*, TK.SoLuong FROM Person, (SELECT IDChuSP, COUNT(DISTINCT MSP) AS SoLuong FROM SanPham GROUP BY IDChuSP) as TK WHERE TK.IDChuSP = Person.ID and Person.ID <> {0} and TK.SoLuong > 0", id);
        //    return dBConnection.LoadShop(sqlStr);
        //}
        //public List<UCShop> UyTin(string toantu)
        //{
        //    string sqlStr = string.Format("SELECT Person.*, TK.SoLuong FROM Person, (SELECT IDChuSP, COUNT(DISTINCT MSP) AS SoLuong, Sum(Distinct BanDuoc) AS daban FROM SanPham GROUP BY IDChuSP) as TK WHERE TK.IDChuSP = Person.ID and Person.ID <> {0} and TK.SoLuong > 0 and TK.daban {1} 5", id, toantu);
        //    return dBConnection.LoadShop(sqlStr);
        //}
    }
}
