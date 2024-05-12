using ProjectWin_Demo_.UC;
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
    public partial class FDonBan : Form
    {
        private int id;
        List<SanPham> sanPham = new List<SanPham>();
        string trangThai;
        SanPhamDao sanPhamDao;
        DaMuaDAO daMuaDAO;
        public FDonBan(int id)
        {
            InitializeComponent();
            this.id = id;
            sanPhamDao = new SanPhamDao(id);
            daMuaDAO = new DaMuaDAO(id);
            pTieuDe.Hide();
        }

        private void FDonBan_Load(object sender, EventArgs e)
        {
            btnChoXacNhan_Click(sender, e);
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            UCQuyTrinhDonHang sp = sender as UCQuyTrinhDonHang;
            SanPham sanPham = new SanPham(Int32.Parse(sp.lblMaVanChuyen.Text));
            sanPham.MaSP = sp.lblMaSP.Text;
            sanPhamDao.XacNhanDonhang(sanPham, trangThai, Int32.Parse(sp.lblSoLuong.Text));
            FDonBan_Load(sender, e);
        }
        private void btnHuyDon_Click(object sender, EventArgs e)
        {
            UCQuyTrinhDonHang sp = sender as UCQuyTrinhDonHang;
            daMuaDAO.HuyDonHang(Int32.Parse(sp.lblMaVanChuyen.Text));
            FDonBan_Load(sender, e);
        }
        private void btnChoXacNhan_Click(object sender, EventArgs e)
        {
            pTieuDe.Hide();
            btnChoXacNhan.CustomBorderColor = Color.Gold;
            btnDangXuLy.CustomBorderColor = Color.White;
            btnDangGiao.CustomBorderColor = Color.White;
            btnDaGiao.CustomBorderColor = Color.White;
            fPanelDonhang.Controls.Clear();
            List<UCQuyTrinhDonHang> uCQuyTrinhDonHangs = sanPhamDao.DSDonBan("Chờ xác nhận");
            trangThai = "Đang xử lý";
            foreach (UCQuyTrinhDonHang ucSP in uCQuyTrinhDonHangs)
            {
                ucSP.ButtonClickCustom += btnXacNhan_Click;
                ucSP.ButtonClick_HuyDonHang += btnHuyDon_Click;
                fPanelDonhang.Controls.Add(ucSP);
            }
           
        }

        private void btnDangXuLy_Click(object sender, EventArgs e)
        {
            pTieuDe.Hide();
            btnChoXacNhan.CustomBorderColor = Color.White;
            btnDangXuLy.CustomBorderColor = Color.Gold;
            btnDangGiao.CustomBorderColor = Color.White;
            btnDaGiao.CustomBorderColor = Color.White;

            fPanelDonhang.Controls.Clear();
            List<UCQuyTrinhDonHang> uCQuyTrinhDonHangs = sanPhamDao.DSDonBan("Đang xử lý");
            trangThai = "Đang giao";
            foreach (UCQuyTrinhDonHang ucSP in uCQuyTrinhDonHangs)
            {
                ucSP.ButtonClickCustom += btnXacNhan_Click;
                ucSP.ButtonClick_HuyDonHang += btnHuyDon_Click;
                fPanelDonhang.Controls.Add(ucSP);
            }
        }

        private void btnDangGiao_Click(object sender, EventArgs e)
        {
            pTieuDe.Hide();
            btnChoXacNhan.CustomBorderColor = Color.White;
            btnDangXuLy.CustomBorderColor = Color.White;
            btnDangGiao.CustomBorderColor = Color.Gold;
            btnDaGiao.CustomBorderColor = Color.White;

            fPanelDonhang.Controls.Clear();
            List<UCQuyTrinhDonHang> uCQuyTrinhDonHangs = sanPhamDao.DSDonBan("Đang giao");
            trangThai = "Đã giao";
            foreach (UCQuyTrinhDonHang ucSP in uCQuyTrinhDonHangs)
            {
                ucSP.ButtonClickCustom += btnXacNhan_Click;
                ucSP.btnHuyDon.Hide();
                fPanelDonhang.Controls.Add(ucSP);
            }
        }

        private void btnDaGiao_Click(object sender, EventArgs e)
        {
            pTieuDe.Show();
            btnChoXacNhan.CustomBorderColor = Color.White;
            btnDangXuLy.CustomBorderColor = Color.White;
            btnDangGiao.CustomBorderColor = Color.White;
            btnDaGiao.CustomBorderColor = Color.Gold;

            fPanelDonhang.Controls.Clear();
            sanPham = sanPhamDao.DSDaBan("Đã giao");
            trangThai = "Đã giao";
            NguoiDAO nguoiDAO = new NguoiDAO(id);
            List<Nguoi> DSNguoiMua = nguoiDAO.LoadThongTinNguoiMua();
            int i = 0;
            foreach (SanPham sp in sanPham)
            {
                UCSPDaBan ucSP = new UCSPDaBan(sp, id);
                ucSP.lblNguoiMua.Text = DSNguoiMua[i].HoTen;
                fPanelDonhang.Controls.Add(ucSP);
                i++;
            }
        }
    }
}
