using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWin_Demo_
{
    public partial class UCGioHang : UserControl
    {
        private int id;
        private SanPham sp;
        public event EventHandler BtnClick_ChiTiet;
        public event EventHandler BtnClick_Xoa;
        public event EventHandler BtnClick_Chon;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        string[] AnhCu = { };
        SanPhamDao SPDao;
        private int soLuong;
        public UCGioHang(SanPham sp, int id, int soLuong)
        {
            InitializeComponent();
            this.id = id;
            this.sp = sp;
            this.soLuong = soLuong;
            SPDao = new SanPhamDao(id);
        }
        private void UCGioHang_Load(object sender, EventArgs e)
        {
            lblTenSP.Text = sp.TenSP;
            lblMaSP.Text = sp.MaSP;
            nudSoLuong.Value = soLuong;
            lblGia.Text = sp.GiaHienTai;
            lblDanhMuc.Text = sp.DanhMuc;
            lblTongTien.Text = (nudSoLuong.Value * Decimal.Parse(sp.GiaHienTai)).ToString();
            if (sp.AnhHienTai != "")
                AnhCu = sp.AnhHienTai.Split(',');
            if (AnhCu.Length > 0)
            {
                Bitmap bitmap = new Bitmap(Application.StartupPath + "\\AnhSanPham\\" + sp.MaSP + "\\" + AnhCu[0]);
                pctSanPham.Image = bitmap;
            }
            else
                pctSanPham.Image = null;
        }
        private void pcbBin_Click(object sender, EventArgs e)
        {
            BtnClick_Xoa?.Invoke(this, e);
            //DialogResult result = MessageBox.Show("Bạn chắc chắn là muốn xóa sản phẩm này", "Xác nhận xóa", MessageBoxButtons.YesNo);
            //if (result == DialogResult.Yes)
            //{
            //    UCGioHang sanPham = sender as UCGioHang;
            //    SanPham sp = new SanPham(sanPham.lblMaSP.Text);
            //    SPDao.Delete(sp, "GioHang");
            //    //MessageBox.Show("Xóa thành công", "Thông báo");
            //}
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            BtnClick_ChiTiet?.Invoke(this, e);
        }

        private void cbChonSP_Click(object sender, EventArgs e)
        {
            BtnClick_Chon?.Invoke(this, e);
        }
    }
}
