using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTra_Lan2
{
    public partial class FSPCuaToi : Form
    {
        private int id;
        TraoDoiHangDF db = new TraoDoiHangDF();
        public FSPCuaToi(int id)
        {
            InitializeComponent();

            foreach (Control control in fPanelHienThi.Controls)
            {
                control.Margin = new Padding(5); // Đặt giá trị phần đệm là 5 cho các cạnh
            }
            this.id = id;
            pTieuDeVoucher.Hide();
        }
        private void FSPCuaToi_Load(object sender, EventArgs e)
        {
            btnTongSanPham_Click(sender, e);
        }

        private void btnThemSP_Click(object sender, EventArgs e)
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

            string maSP = (from sanPham in db.SanPhams where sanPham.IDChuSP == id select sanPham.MSP).FirstOrDefault();
            List<Voucher> vouchers = (from voucher in db.Vouchers join account in db.Accounts on voucher.ID equals account.ID
                                      where voucher.ID == (from sp in db.SanPhams
                                                           where sp.MSP == maSP
                                                           select sp.IDChuSP).FirstOrDefault()
                                      select voucher).Distinct().ToList();

            foreach (Voucher voucher in vouchers)
            {
                UCVoucherCuaToi ucVoucher = new UCVoucherCuaToi(voucher, id);

                ucVoucher.BtnClick_sua += btnSuaVoucher_Click;
                ucVoucher.BtnClick_xoa += btnXoaVoucher_Click;
                fPanelHienThi.Controls.Add(ucVoucher);
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
            FSPCuaToi_Load(sender, e);
        }
        private void btnXoaVoucher_Click(object sender, EventArgs e)
        {
            UCVoucherCuaToi voucher = sender as UCVoucherCuaToi;
            DialogResult result = MessageBox.Show("Bạn chắc chắn là muốn xóa voucher này", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Voucher vc = db.Vouchers.Where(p => p.MaVoucher == voucher.lblMaVoucher.Text).SingleOrDefault();
                db.Vouchers.Remove(vc);
                db.SaveChanges();
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

            var DSSanPham = from daMua in db.DaMuas
                             join sanPham in db.SanPhams on daMua.MSP equals sanPham.MSP
                             where sanPham.IDChuSP == id && daMua.TrangThai == "Đã giao"
                             select new
                             {
                                 DaMua = daMua,
                                 SanPham = sanPham
                             };


            foreach (var sanPham in DSSanPham)
            {
                SanPham sp = sanPham.SanPham;
                int maVanChuyen = sanPham.DaMua.MaVanChuyen;

                var nguoiMua = from daMua in db.DaMuas
                           join person in db.People on daMua.ID equals person.ID
                           where daMua.MaVanChuyen == maVanChuyen
                           select person;

                sp.SoLuong = sanPham.DaMua.SoLuongDaMua;
                UCSPDaBan ucSPDaBan = new UCSPDaBan(sp, id);
                ucSPDaBan.lblNguoiMua.Text = nguoiMua.First().FullName;
                fPanelHienThi.Controls.Add(ucSPDaBan);
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

            List<SanPham> DSSanPham = (from sp in db.SanPhams where sp.IDChuSP == id select sp).ToList();
            foreach (SanPham sp in DSSanPham)
            {
                UCSPCuaToi ucSP = new UCSPCuaToi(sp);
                ucSP.BtnClick_xoa += pcbDelete_Click;
                ucSP.BtnClick_sua += pcbEdit_Click;
                fPanelHienThi.Controls.Add(ucSP);
            }
        }
        private void pcbDelete_Click(object sender, EventArgs e)
        {
            UCSPCuaToi sp = sender as UCSPCuaToi;
            DialogResult result = MessageBox.Show("Bạn chắc chắn là muốn xóa sản phẩm này", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SanPham sanPham = db.SanPhams.Where(p => p.MSP == sp.lblMaSP.Text).SingleOrDefault();
                db.SanPhams.Remove(sanPham);
                db.SaveChanges();
                MessageBox.Show("Đã xóa sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FSPCuaToi_Load(sender, e);
            }
        }

        private void pcbEdit_Click(object sender, EventArgs e)
        {
            UCSPCuaToi sp = sender as UCSPCuaToi;
            FTuyChinhSP ftuyChinh = new FTuyChinhSP(id, sp.lblMaSP.Text, "Sua");
            ftuyChinh.btnThemSP.Hide();
            ftuyChinh.btnCapNhatSP.Show();
            ftuyChinh.ShowDialog();
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
            List<SanPham> sanPham = (from sp in db.SanPhams where sp.IDChuSP == id && sp.TenSP.Contains(searchText) select sp).ToList();
            foreach (SanPham sp in sanPham)
            {
                UCSPCuaToi ucSP = new UCSPCuaToi(sp);
                ucSP.BtnClick_xoa += pcbDelete_Click;
                ucSP.BtnClick_sua += pcbEdit_Click;
                fPanelHienThi.Controls.Add(ucSP);
            }
        }
    }
}
