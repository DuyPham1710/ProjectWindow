using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTra_Lan2
{
    public partial class FKhachHang : Form
    {
        private int id;
        TraoDoiHangDF db = new TraoDoiHangDF();
        public FKhachHang(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        private void FKhachHang_Load(object sender, EventArgs e)
        {
            btnThongKe_Click(sender, e);
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            btnDSKhachHang.CustomBorderColor = Color.DarkTurquoise;
            btnKHHayMua.CustomBorderColor = Color.White;
            btnKHDaHuy.CustomBorderColor = Color.White;

            var query = from person in db.People
                        join daMua in db.DaMuas on person.ID equals daMua.ID
                        join sanPham in db.SanPhams on daMua.MSP equals sanPham.MSP
                        where sanPham.IDChuSP == id
                        select new
                        {
                            sanPham.MSP,
                            sanPham.TenSP,
                            person.FullName,
                            person.Phone,
                            person.Email,
                            daMua.SoLuongDaMua,
                            daMua.Gia,
                            person.Addr,
                            daMua.TrangThai
                        };

            gvDanhSach.DataSource = query.ToList();
            gvDanhSach.Columns[0].HeaderText = "Mã sản phẩm";
            gvDanhSach.Columns[1].HeaderText = "Tên sản phẩm";
            gvDanhSach.Columns[2].HeaderText = "Tên khách hàng";
            gvDanhSach.Columns[3].HeaderText = "Số điện thoại";
            gvDanhSach.Columns[4].HeaderText = "Email";
            gvDanhSach.Columns[5].HeaderText = "Số lượng đã mua";
            gvDanhSach.Columns[6].HeaderText = "Tổng số tiền";
            gvDanhSach.Columns[7].HeaderText = "Địa chỉ nhận hàng";
            gvDanhSach.Columns[8].HeaderText = "Trạng thái";
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            btnDSKhachHang.CustomBorderColor = Color.White;
            btnKHHayMua.CustomBorderColor = Color.DarkTurquoise;
            btnKHDaHuy.CustomBorderColor = Color.White;

            var query = from person in db.People
                        join daMua in db.DaMuas on person.ID equals daMua.ID into daMuaGroup
                        where daMuaGroup.Any(d => d.TrangThai == "Đã giao")
                        select new
                        {
                            person.ID,
                            person.FullName,
                            person.Phone,
                            person.Gender,
                            person.Email,
                            person.Addr,
                            SoLuotMua = daMuaGroup.Count(d => d.TrangThai == "Đã giao")
                        };

            gvDanhSach.DataSource = query.ToList();
            gvDanhSach.Columns[0].HeaderText = "ID";
            gvDanhSach.Columns[1].HeaderText = "Tên khách hàng";
            gvDanhSach.Columns[2].HeaderText = "Số điện thoại";
            gvDanhSach.Columns[3].HeaderText = "Giới tính";
            gvDanhSach.Columns[4].HeaderText = "Email";
            gvDanhSach.Columns[5].HeaderText = "Địa chỉ";
            gvDanhSach.Columns[6].HeaderText = "Số lần mua hàng";
        }

        private void btnKHDaHuy_Click(object sender, EventArgs e)
        {
            btnDSKhachHang.CustomBorderColor = Color.White;
            btnKHHayMua.CustomBorderColor = Color.White;
            btnKHDaHuy.CustomBorderColor = Color.DarkTurquoise;

            var query = from sanPham in db.SanPhams
                        join person in db.People on sanPham.IDChuSP equals person.ID
                        join sanPhamHuy in db.SanPhamHuys on sanPham.MSP equals sanPhamHuy.MSP
                        where sanPham.IDChuSP == id
                        select new
                        {
                            sanPhamHuy.MSP,
                            person.FullName,
                            sanPham.TenSP,
                            sanPhamHuy.LyDoHuy,
                            sanPhamHuy.ThoiGianHuy
                        };

            gvDanhSach.DataSource = query.ToList();
            gvDanhSach.Columns[0].HeaderText = "Mã sản phẩm";
            gvDanhSach.Columns[1].HeaderText = "Tên khách hàng";
            gvDanhSach.Columns[2].HeaderText = "Tên sản phẩm";
            gvDanhSach.Columns[3].HeaderText = "Lý do hủy đơn";
            gvDanhSach.Columns[4].HeaderText = "Thời gian hủy";

        }
    }
}
