using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWin_Demo_
{
    public class VoucherDAO
    {
        DBConnection dBConnection;
        private int id;
        public VoucherDAO(int id)
        {
            this.id = id;
            dBConnection = new DBConnection(id);
        }
        public List<T> LoadVoucher<T>(string maSP)
        {
            string sqlStr = string.Format("select distinct Q.* from (select Voucher.* from Voucher, Account where Voucher.ID = Account.ID) Q where Q.ID = (select IDChuSP from SanPham where MSP = '{0}')", maSP);
            DataTable dt = dBConnection.LoadDuLieu(sqlStr);
            List<T> Vouchers = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                Voucher voucher = new Voucher(row);

                if (typeof(T) == typeof(UCVoucher))
                {
                    UCVoucher ucVoucher = new UCVoucher(voucher, id);
                    Vouchers.Add((T)(object)ucVoucher);
                }
                else if (typeof(T) == typeof(UCVoucherCuaToi))
                {
                    UCVoucherCuaToi ucVoucher = new UCVoucherCuaToi(voucher, id);
                    Vouchers.Add((T)(object)ucVoucher);
                }

                if (typeof(T) == typeof(Voucher))
                {
                    Vouchers.Add((T)(object)voucher);
                    return Vouchers;
                }
            }
            return Vouchers;
        }
      
        public bool KiemTraVoucher(string maVoucher)
        {
            string sqlStr = string.Format("SELECT * FROM Voucher WHERE MaVoucher = '{0}'", maVoucher);
            DataTable dt = dBConnection.LoadDuLieu(sqlStr);
            if (dt.Rows.Count == 0)
                return false;
            return true;
        }
        public void capNhatVoucher(string MaVoucher)
        {
            if (MaVoucher != "")
            {
                string sqlStr = string.Format("UPDATE Voucher SET SoLuongVoucher = (SoLuongVoucher - 1) WHERE MaVoucher = '{0}'", MaVoucher);
                dBConnection.thucThi(sqlStr);

            }
          
        }
        public void ThemVoucher(Voucher voucher)
        {
            string sqlStr = string.Format("INSERT INTO Voucher(ID, MaVoucher, Mota, GiaTri, HSD, SoLuongVoucher) VALUES ({0}, '{1}', N'{2}', {3}, '{4}', {5})",
                                 id, voucher.MaVoucher, voucher.MoTa, voucher.GiaTri, voucher.HSD, voucher.SoLuong);
            dBConnection.thucThi(sqlStr);
        }
        public void suaVoucher(Voucher voucher, string maVoucherCu)
        {
            string sqlStr = string.Format("UPDATE Voucher SET MaVoucher = '{0}', Mota = N'{1}', GiaTri = {2}, HSD = '{3}', SoLuongVoucher = {4} WHERE ID = {5} and MaVoucher = '{6}'", voucher.MaVoucher, voucher.MoTa, voucher.GiaTri, voucher.HSD.ToString(), voucher.SoLuong, id, maVoucherCu);
            dBConnection.thucThi(sqlStr);
        }
        public void xoaVoucher(string MaVoucher)
        {
            string sqlStr = string.Format("DELETE FROM Voucher WHERE MaVoucher = '{0}'", MaVoucher);
            dBConnection.thucThi(sqlStr);
        }
      
        public Voucher LayVoucher(string maVoucher)
        {
            string sqlStr = string.Format("SELECT * FROM Voucher WHERE MaVoucher = '{0}'", maVoucher);
            DataTable dt = dBConnection.LoadDuLieu(sqlStr);
            if (dt.Rows.Count == 0)
                return null;
            Voucher voucher = new Voucher(dt.Rows[0]);
            return voucher;
        }
    }
}
