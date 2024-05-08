﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWin_Demo_
{
    public class SanPham
    {
        private int iDChuSP;
        private string maSP, tenSP, danhMuc, giaBanDau, giaHienTai, soLuong, xuatXu, baoHanh, tinhTrang, moTaTinhTrang, motaSP, anhBanDau, anhHienTai; 
        private DateTime ngayMuaSP;
        private int maVanChuyen;
        public int IDChuSP { get => iDChuSP; set => iDChuSP = value; }
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
        public DateTime NgayMuaSP { get => ngayMuaSP; set => ngayMuaSP = value; }
        public string AnhBanDau { get => anhBanDau; set => anhBanDau = value; }
        public string AnhHienTai { get => anhHienTai; set => anhHienTai = value; }
        public int MaVanChuyen { get => maVanChuyen; set => maVanChuyen = value; }

        public SanPham(string MaSP)
        {
            this.MaSP = MaSP;
        }
        public SanPham(int MaVanChuyen)
        {
            this.MaVanChuyen = MaVanChuyen;
        }
        public SanPham(string MaSP, int IDChuSP, string TenSP, string DanhMuc, string GiaBanDau, string GiaHienTai, DateTime NgayMuaSP,
            string SoLuong, string XuatXu, string BaoHanh, string TinhTrang, string MoTaTinhTrang, string MotaSP, string AnhBanDau, 
            string AnhHienTai)
        {
            this.MaSP = MaSP;
            this.IDChuSP = IDChuSP;
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
        public SanPham(DataRow duLieu)
        {
            this.MaSP = duLieu["MSP"].ToString(); 
            this.IDChuSP = Int32.Parse(duLieu["IDChuSP"].ToString()); 
            this.TenSP = duLieu["TenSP"].ToString(); 
            this.DanhMuc = duLieu["DanhMuc"].ToString(); 
            this.GiaBanDau = duLieu["GiaTienLucMoiMua"].ToString(); 
            this.GiaHienTai = duLieu["GiaTienBayGio"].ToString();
            this.SoLuong = duLieu["SoLuong"].ToString(); 
            this.XuatXu = duLieu["XuatXu"].ToString(); 
            this.BaoHanh = duLieu["BaoHanh"].ToString(); 
            this.TinhTrang = duLieu["TinhTrang"].ToString(); 
            this.MoTaTinhTrang = duLieu["MotaTinhTrang"].ToString(); 
            this.MotaSP = duLieu["MotaSP"].ToString(); 
            this.AnhBanDau = duLieu["AnhLucMoiMua"].ToString(); 
            this.AnhHienTai = duLieu["AnhBayGio"].ToString(); 
            this.NgayMuaSP = DateTime.Parse(duLieu["NgayMuaSP"].ToString()); 
        }
    }
}
