using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWin_Demo_
{
    internal class SanPhamDao
    {
        public void Add(SanPham sanPham)
        {
            string sqlStr = string.Format("INSERT INTO SanPham(MSP, IDChuSP, TenSP, DanhMuc, GiaTienLucMoiMua, GiaTienBayGio, NgayMuaSP, SoLuong, XuatXu, BaoHanh, TinhTrang, MotaTinhTrang, MotaSP, AnhLucMoiMua, AnhBayGio) VALUES ('{0}', '{1}', N'{2}', N'{3}', '{4}', '{5}', '{6}', '{7}', N'{8}', N'{9}', N'{10}', N'{11}', N'{12}', N'{13}', N'{14}')",
                        sanPham.MaSP, sanPham.IDChuSP, sanPham.TenSP, sanPham.DanhMuc, sanPham.GiaBanDau, sanPham.GiaHienTai, sanPham.NgayMuaSP.ToString(), sanPham.SoLuong, sanPham.XuatXu, sanPham.BaoHanh, sanPham.TinhTrang, sanPham.MoTaTinhTrang, sanPham.MotaSP, sanPham.AnhBanDau, sanPham.AnhHienTai);
            DBConnection.thucThi(sqlStr);
        }
        public void Update(SanPham sanPham) 
        {
            string sqlStr = string.Format("UPDATE SanPham SET TenSP = N'{0}', DanhMuc = N'{1}', GiaTienLucMoiMua = '{2}', GiaTienBayGio = '{3}', NgayMuaSP = '{4}', SoLuong = '{5}', XuatXu = N'{6}', BaoHanh = N'{7}', TinhTrang = N'{8}', MotaTinhTrang = N'{9}', MotaSP = N'{10}', AnhLucMoiMua = N'{11}', AnhBayGio = N'{12}' WHERE MSP = '{13}'",
                           sanPham.TenSP, sanPham.DanhMuc, sanPham.GiaBanDau, sanPham.GiaHienTai, sanPham.NgayMuaSP.ToString(), sanPham.SoLuong, sanPham.XuatXu, sanPham.BaoHanh, sanPham.TinhTrang, sanPham.MoTaTinhTrang, sanPham.MotaSP, sanPham.AnhBanDau, sanPham.AnhHienTai, sanPham.MaSP);
            DBConnection.thucThi(sqlStr);
        }
        public void Delete(SanPham sanPham) 
        {
            string sqlStr = string.Format("DELETE FROM SanPham WHERE MSP = '{0}'", sanPham.MaSP);
            DBConnection.thucThi(sqlStr);
        }
    }
}
