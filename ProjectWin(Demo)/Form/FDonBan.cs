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
        public FDonBan(int id)
        {
            InitializeComponent();
            this.id = id;
            sanPhamDao = new SanPhamDao(id);
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
            sanPhamDao.XacNhanDonhang(sanPham, trangThai, Int32.Parse(sp.lblSoLuong.Text));
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
            //sanPham = sanPhamDao.DSDonBan("Chờ xác nhận");
            trangThai = "Đang xử lý";
            foreach (UCQuyTrinhDonHang ucSP in uCQuyTrinhDonHangs)
            {
                ucSP.ButtonClickCustom += btnXacNhan_Click;
                fPanelDonhang.Controls.Add(ucSP);
            }
            //foreach (SanPham item in sanPham)
            //{
            //    UCQuyTrinhDonHang ucSP = new UCQuyTrinhDonHang(item, id);
            //    ucSP.ButtonClickCustom += btnXacNhan_Click;
            //    fPanelDonhang.Controls.Add(ucSP);
            //}
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
            foreach (SanPham item in sanPham)
            {
                UCSPDaBan ucSP = new UCSPDaBan(item, id);
                fPanelDonhang.Controls.Add(ucSP);
            }
        }
    }
}
