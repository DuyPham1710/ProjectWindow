using ProjectWin_Demo_.UC;
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
    
    public partial class FSPCuaToi : Form
    {
        private int id;
        SanPhamDao SPDao;
        public FSPCuaToi(int id)
        {
            InitializeComponent();

            foreach (Control control in fPanelHienThi.Controls)
            {
                control.Margin = new Padding(5);
            }
            this.id = id;
            SPDao = new SanPhamDao(id);
            pTieuDeVoucher.Hide();
        }
        private void FSPCuaToi_Load(object sender, EventArgs e)
        {
            btnTongSanPham_Click(sender, e);
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            FTuyChinhSP addProduct = new FTuyChinhSP(id, "", "Them");
            addProduct.ShowDialog();
            btnTongSanPham_Click(sender, e);
        }
        private void btnVoucher_Click(object sender, EventArgs e)
        {
            btnTongSP.CustomBorderColor = Color.White;
            btnTongSP.ForeColor = Color.Black;
            btnVoucher.CustomBorderColor = Color.MediumSlateBlue;
            btnVoucher.ForeColor = Color.MediumSlateBlue;
            btnSPDaBan.CustomBorderColor = Color.White;
            btnSPDaBan.ForeColor = Color.Black;
            txtTimKiem.PlaceholderText = "Mã Voucher";

            pTieuDeVoucher.Show();
            pTieuDeSP.Hide();
            fPanelHienThi.Controls.Clear();
            VoucherDAO voucherDAO = new VoucherDAO(id);
            string maSP = SPDao.LayMaSP();
            List<UCVoucherCuaToi> vouchers = voucherDAO.LoadVoucher<UCVoucherCuaToi>(maSP);
            foreach (UCVoucherCuaToi voucher in vouchers)
            {
                voucher.BtnClick_sua += btnSuaVoucher_Click;
                voucher.BtnClick_xoa += btnXoaVoucher_Click;
                fPanelHienThi.Controls.Add(voucher);
            }
        }
        private void btnThemVoucher_Click(object sender, EventArgs e)
        {
            FTuyChinhVoucher fThemVoucher = new FTuyChinhVoucher(id, "", "Them");
            fThemVoucher.ShowDialog();
            
            btnVoucher_Click(sender, e);
        }
        private void btnSuaVoucher_Click(object sender, EventArgs e)
        {
            UCVoucherCuaToi voucher = sender as UCVoucherCuaToi;
            FTuyChinhVoucher fThemVoucher = new FTuyChinhVoucher(id, voucher.lblMaVoucher.Text, "Sua");
            fThemVoucher.ShowDialog();
            btnVoucher_Click(sender, e);
        }

        private void btnXoaVoucher_Click(object sender, EventArgs e)
        {
            VoucherDAO voucherDAO = new VoucherDAO(id);
            UCVoucherCuaToi voucher = sender as UCVoucherCuaToi;
            DialogResult result = MessageBox.Show("Bạn chắc chắn là muốn xóa voucher này", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                voucherDAO.xoaVoucher(voucher.lblMaVoucher.Text);
                btnVoucher_Click(sender, e);
            }
        }
        private void btnSPBanDuoc_Click(object sender, EventArgs e)
        {
            btnTongSP.CustomBorderColor = Color.White;
            btnTongSP.ForeColor = Color.Black;
            btnVoucher.CustomBorderColor = Color.White;
            btnVoucher.ForeColor = Color.Black;
            btnSPDaBan.CustomBorderColor = Color.MediumSlateBlue;
            btnSPDaBan.ForeColor = Color.MediumSlateBlue;
            txtTimKiem.PlaceholderText = "Tìm kiếm sản phẩm";

            pTieuDeVoucher.Hide();
            pTieuDeSP.Show();
            lblTuyChon.Text = "Người mua";
            fPanelHienThi.Controls.Clear();
            List<SanPham> sanPham = SPDao.DSDaBan("Đã giao");
            NguoiDAO nguoiDAO = new NguoiDAO(id);
            List<Nguoi> DSNguoiMua = nguoiDAO.LoadThongTinNguoiMua(sanPham);
            int i = 0;
            foreach (SanPham sp in sanPham)
            {
                UCSPDaBan ucSPDaBan = new UCSPDaBan(sp, id);
                ucSPDaBan.lblNguoiMua.Text = DSNguoiMua[i].HoTen;
                fPanelHienThi.Controls.Add(ucSPDaBan);
                i++;
            }
        }
        private void btnTongSanPham_Click(object sender, EventArgs e)
        {
            pTieuDeVoucher.Hide();
            pTieuDeSP.Show();

            lblTuyChon.Text = "Tùy chọn";
            btnTongSP.CustomBorderColor = Color.MediumSlateBlue;
            btnTongSP.ForeColor = Color.MediumSlateBlue;
            btnVoucher.CustomBorderColor = Color.White;
            btnVoucher.ForeColor = Color.Black;
            btnSPDaBan.CustomBorderColor = Color.White;
            btnSPDaBan.ForeColor = Color.Black;
            txtTimKiem.PlaceholderText = "Tìm kiếm sản phẩm";

            fPanelHienThi.Controls.Clear();
            List<UCSPCuaToi> sanPham = SPDao.LoadSanPham<UCSPCuaToi>("=");
            foreach (UCSPCuaToi sp in sanPham)
            {
                sp.BtnClick_delete += pcbDelete_Click;
                sp.BtnClick_edit += pcbEdit_Click;
                fPanelHienThi.Controls.Add(sp);
            }
        }
    
        private void pcbDelete_Click(object sender, EventArgs e)
        {
            UCSPCuaToi sp = sender as UCSPCuaToi;
            DialogResult result = MessageBox.Show("Bạn chắc chắn là muốn xóa sản phẩm này", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SanPham sanPham = new SanPham(sp.lblMaSP.Text);
                SPDao.xoaSP(sanPham);
                MessageBox.Show("Đã xóa sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FSPCuaToi_Load(sender, e);          
            }
        }

        private void pcbEdit_Click(object sender, EventArgs e)
        {
            UCSPCuaToi sp = sender as UCSPCuaToi;
            FTuyChinhSP fedit = new FTuyChinhSP(id, sp.lblMaSP.Text, "Sua");
            fedit.btnAddProduct.Hide();
            fedit.btnUpdateProduct.Show();
            fedit.ShowDialog();
            FSPCuaToi_Load(sender, e);
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                FSPCuaToi_Load(sender, e);
            }
            else
            {
                timKiemVaHienThi(txtTimKiem.Text);
            }          
        }
        private void timKiemVaHienThi(string searchText)
        {
            fPanelHienThi.Controls.Clear();
            List<UCSPCuaToi> sanPham = SPDao.timKiem<UCSPCuaToi>(searchText, "=");
            foreach (UCSPCuaToi sp in sanPham)
            {
                sp.BtnClick_delete += pcbDelete_Click;
                sp.BtnClick_edit += pcbEdit_Click;
                fPanelHienThi.Controls.Add(sp);
            }
        }
    }
}
