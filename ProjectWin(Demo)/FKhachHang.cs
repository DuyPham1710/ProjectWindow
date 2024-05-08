using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWin_Demo_
{
    public partial class FKhachHang : Form
    {
        private int id;
        NguoiDAO nguoiDAO;
        public FKhachHang(int id)
        {
            InitializeComponent();
            this.id = id;
            nguoiDAO = new NguoiDAO(id);
        }
        private void FKhachHang_Load(object sender, EventArgs e)
        {
            btnThongKe_Click(sender, e);
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            gvDanhSach.DataSource =  nguoiDAO.ThongTinKhachHang();
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
            gvDanhSach.DataSource = nguoiDAO.LoadKhachhang();
            gvDanhSach.Columns[0].HeaderText = "ID";
            gvDanhSach.Columns[1].HeaderText = "Tên khách hàng";
            gvDanhSach.Columns[2].HeaderText = "Số điện thoại";
            gvDanhSach.Columns[3].HeaderText = "Giới tính";
            gvDanhSach.Columns[4].HeaderText = "Email";
            gvDanhSach.Columns[5].HeaderText = "Địa chỉ";
            gvDanhSach.Columns[6].HeaderText = "Số lần mua hàng";
            //gvDanhSach.Columns[7].HeaderText = "Tổng tiền";
        }

       
    }
}
