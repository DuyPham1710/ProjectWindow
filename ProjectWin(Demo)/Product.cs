using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWin_Demo_
{
    internal class Product
    {
        private string maSP, tenSP, danhMuc, giaBanDau, giaHienTai, soLuong, xuatXu, baoHanh, tinhTrang, moTaTinhTrang, motaSP, anhBanDau, anhHienTai; 
        private DateTime ngayMuaSP;

        public string MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public string DanhMuc { get => danhMuc; set => danhMuc = value; }
        public string GiaBanDau { get => giaBanDau; set => giaBanDau = value; }
        public string GiaHienTai { get => giaHienTai; set => giaHienTai = value; }
        public string SoLuong { get => soLuong; set => soLuong = value; }
        public string XuatXu { get => xuatXu; set => xuatXu = value; }
        public string BaoHanh { get => baoHanh; set => baoHanh = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public string MoTaTinhTrang { get => moTaTinhTrang; set => moTaTinhTrang = value; }
        public string MotaSP { get => motaSP; set => motaSP = value; }
        public string AnhBanDau { get => anhBanDau; set => anhBanDau = value; }
        public string AnhHienTai { get => anhHienTai; set => anhHienTai = value; }
        public DateTime NgayMuaSP { get => ngayMuaSP; set => ngayMuaSP = value; }

        public Product(string MaSP, string TenSP, string DanhMuc, string GiaBanDau, string GiaHienTai, 
            string SoLuong, string XuatXu, string BaoHanh, string TinhTrang, string MoTaTinhTrang, string MotaSP, string AnhBanDau, 
            string AnhHienTai, DateTime NgayMuaSP)
        {
            this.MaSP = MaSP;
            this.TenSP = TenSP;
            this.DanhMuc = DanhMuc;
            this.GiaBanDau = GiaBanDau;
            this.GiaHienTai = GiaHienTai;
            this.SoLuong = SoLuong;
            this.XuatXu = XuatXu;
            this.BaoHanh = BaoHanh;
            this.TinhTrang = TinhTrang;
            this.MoTaTinhTrang = MoTaTinhTrang;
            this.MotaSP = MotaSP;
            this.AnhBanDau = AnhBanDau;
            this.AnhHienTai = AnhHienTai;
            this.NgayMuaSP = NgayMuaSP;
        }
    }
}
