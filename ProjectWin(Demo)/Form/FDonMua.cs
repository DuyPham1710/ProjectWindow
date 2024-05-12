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
    public partial class FDonMua : Form
    {
        private int id;
        SanPhamDao sanPhamDao;
        List<SanPham> sanPham = new List<SanPham>();
        public FDonMua(int id)
        {
            InitializeComponent();
            this.id = id;
            sanPhamDao = new SanPhamDao(id);
        }

        private void FDonMua_Load(object sender, EventArgs e)
        {
            btnChoXacNhan_Click(sender, e);
        }
        private void btnChoXacNhan_Click(object sender, EventArgs e)
        {
            pTieuDe.Show();
            btnChoXacNhan.CustomBorderColor = Color.Gold;
            btnDangGiao.CustomBorderColor = Color.White;
            btnDaGiao.CustomBorderColor = Color.White;
            btnHuyDon.CustomBorderColor = Color.White;
            fPanelDonhang.Controls.Clear();
            List<UCSanPhamMua> uCSanPhamMuas = sanPhamDao.DSDonMua("Chờ xác nhận");
           
            foreach (UCSanPhamMua ucSP in uCSanPhamMuas)
            {
                ucSP.BtnClick_HuyDon += btnHuySPDaMua_Click;
                fPanelDonhang.Controls.Add(ucSP);
            }
        }
        private void btnHuySPDaMua_Click(object sender, EventArgs e)
        {
            UCSanPhamMua uCSanPhamMua = sender as UCSanPhamMua;
            SanPham sp = new SanPham(uCSanPhamMua.lblMaSP.Text);
            sp.MaVanChuyen = Int32.Parse(uCSanPhamMua.lblMaVanChuyen.Text);
            FLyDoHuyDon fLyDoHuy = new FLyDoHuyDon(sp, id);
            fLyDoHuy.ShowDialog();
            btnChoXacNhan_Click(sender, e);
        }

        private void btnDangGiao_Click(object sender, EventArgs e)
        {
            pTieuDe.Show();
            btnChoXacNhan.CustomBorderColor = Color.White;
            btnDangGiao.CustomBorderColor = Color.Gold;
            btnDaGiao.CustomBorderColor = Color.White;
            btnHuyDon.CustomBorderColor = Color.White;
            fPanelDonhang.Controls.Clear();
            sanPham = sanPhamDao.DanhSachDonMua("Đang giao");
            foreach (SanPham item in sanPham)
            {
                UCSanPhamMua ucSP = new UCSanPhamMua(item, id, default);
                ucSP.btnHuyDon.Hide();
                fPanelDonhang.Controls.Add(ucSP);
            }
        }

        private void btnDaGiao_Click(object sender, EventArgs e)
        {
            pTieuDe.Hide();
            btnChoXacNhan.CustomBorderColor = Color.White;
            btnDangGiao.CustomBorderColor = Color.White;
            btnDaGiao.CustomBorderColor = Color.Gold;
            btnHuyDon.CustomBorderColor = Color.White;
            fPanelDonhang.Controls.Clear();
            sanPham = sanPhamDao.DanhSachDonMua("Đã giao");
            foreach (SanPham item in sanPham)
            {
                UCSPDaMua ucSP = new UCSPDaMua(item, id);
                fPanelDonhang.Controls.Add(ucSP);
            }
        }

        private void btnHuyDon_Click(object sender, EventArgs e)
        {
            pTieuDe.Hide();
            btnChoXacNhan.CustomBorderColor = Color.White;
            btnDangGiao.CustomBorderColor = Color.White;
            btnDaGiao.CustomBorderColor = Color.White;
            btnHuyDon.CustomBorderColor = Color.Gold;
            fPanelDonhang.Controls.Clear();
            sanPham = sanPhamDao.DanhSachDonMua("Đã hủy");
            foreach (SanPham item in sanPham)
            {
                UCSPDaHuy ucSP = new UCSPDaHuy(item, id);
                fPanelDonhang.Controls.Add(ucSP);
            }
        }
    }
}
