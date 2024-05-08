using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWin_Demo_
{
    public class Voucher
    {
        private int iD, giaTri, soLuong;
        private string maVoucher, moTa;
        private DateTime hSD;

        public int ID { get => iD; set => iD = value; }
        public int GiaTri { get => giaTri; set => giaTri = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string MaVoucher { get => maVoucher; set => maVoucher = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public DateTime HSD { get => hSD; set => hSD = value; }

        public Voucher(int ID, int GiaTri, int SoLuong, string MaVoucher, string MoTa, DateTime HSD)
        {
            this.ID = ID;
            this.GiaTri = GiaTri;
            this.SoLuong = SoLuong;
            this.MaVoucher = MaVoucher;
            this.MoTa = MoTa;
            this.HSD = HSD;
        }
        public Voucher(DataRow duLieu)
        {
            this.ID = Int32.Parse(duLieu["ID"].ToString());
            this.GiaTri = Int32.Parse(duLieu["GiaTri"].ToString());
            this.SoLuong = Int32.Parse(duLieu["SoLuongVoucher"].ToString());
            this.MaVoucher = duLieu["MaVoucher"].ToString();
            this.MoTa = duLieu["Mota"].ToString();
            this.HSD = DateTime.Parse(duLieu["HSD"].ToString());
        }
    }
}
