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
    public partial class FGioHang : Form
    {
        private int id;
        SanPhamDao SPDao;
        public FGioHang(int id)
        {
            InitializeComponent();
            this.id = id;
            SPDao = new SanPhamDao(id);
        }

        private void btnBuyNow_Click(object sender, EventArgs e)
        {
            //FPayment fPayment = new FPayment();
            //fPayment.ShowDialog();
        }

        private void FGioHang_Load(object sender, EventArgs e)
        {
            fPanelGioHang.Controls.Clear();
            List<UCGioHang> sanPham = SPDao.LoadGioHang<UCGioHang>();
            foreach(UCGioHang sp in sanPham)
            {
                sp.BtnClick_ChiTiet += UCGioHang_Click;
                sp.BtnClick_Xoa += pcbBin_Click;
                sp.BtnClick_Chon += cbChonSP_Click;
                fPanelGioHang.Controls.Add(sp);
            }
        }
        private void UCGioHang_Click(object sender, EventArgs e)
        {
            UCGioHang sanPham = sender as UCGioHang;
            List<SanPham> sp = SPDao.chiTietSanPham(sanPham.lblMaSP.Text);
            //SanPham sp = new SanPham(sanPham.lblMaSP.Text);
            FChiTiet fChiTiet = new FChiTiet(sp[0], id);
            fChiTiet.ShowDialog();
        }
        private void pcbBin_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn là muốn xóa sản phẩm này", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                UCGioHang sanPham = sender as UCGioHang;
                SanPham sp = new SanPham(sanPham.lblMaSP.Text);
                SPDao.Delete(sp, "GioHang");
                FGioHang_Load(sender, e);
                //MessageBox.Show("Xóa thành công", "Thông báo");
            }
        }
        private void cbChonSP_Click(object sender, EventArgs e)
        {
            UCGioHang sanPham = sender as UCGioHang;
            if (sanPham.cbChonSP.Checked)
            {
                lblTongTien.Text = (int.Parse(lblTongTien.Text) + int.Parse(sanPham.lblTongTien.Text)).ToString();
            }
            else
            {
                lblTongTien.Text = (int.Parse(lblTongTien.Text) - int.Parse(sanPham.lblTongTien.Text)).ToString();
            }
        }
    }
}
