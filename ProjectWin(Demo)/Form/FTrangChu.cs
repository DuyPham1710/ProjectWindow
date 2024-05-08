using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace ProjectWin_Demo_
{
    public partial class FTrangChu : Form
    {
        private int id;
        SanPhamDao SPDao;
        public FTrangChu(int id)
        {
            InitializeComponent();
            btnCatalog.MouseDown += btnCatalog_MouseDown;
            ContextMenuStripCatalog.LostFocus += btnCatalog_LostFocus;
            btnSort.MouseDown += btnSort_MouseDown;
            ContextMenuStripSort.LostFocus += btnSort_LostFocus;
            this.id = id;
            SPDao = new SanPhamDao(id);
        }
        private void FTrangChu_Load(object sender, EventArgs e)
        {
            fPanelSanPham.Controls.Clear();
            List<UCSanPham> sanPham = SPDao.LoadSanPham<UCSanPham>("<>");
            foreach (UCSanPham sp in sanPham)
            {
                fPanelSanPham.Controls.Add(sp);
            }
        }

        private void btnSort_MouseDown(object sender, MouseEventArgs e)
        {
            Point location = btnSort.PointToScreen(new Point(0, btnSort.Height));
            ContextMenuStripSort.Show(location);
        }

        private void btnSort_LostFocus(object sender, EventArgs e)
        {
            ContextMenuStripSort.Hide();
        }
        private void btnCatalog_MouseDown(object sender, MouseEventArgs e)
        {
            Point location = btnCatalog.PointToScreen(new Point(0, btnCatalog.Height));
            ContextMenuStripCatalog.Show(location);
        }

        private void btnCatalog_LostFocus(object sender, EventArgs e)
        {
            ContextMenuStripCatalog.Hide();
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                FTrangChu_Load(sender, e);
            }
            else
            {
                timKiemVaHienThi(txtTimKiem.Text);
            }
        }
        private void timKiemVaHienThi(string searchText)
        {
            fPanelSanPham.Controls.Clear();
            List<UCSanPham> sanPham = SPDao.timKiem<UCSanPham>(searchText, "<>");
            foreach (UCSanPham sp in sanPham)
            {
                fPanelSanPham.Controls.Add(sp);
            }
        }

        private void điệnTửToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocTheoDanhMucSP("Điện tử");
        }

        private void giaDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocTheoDanhMucSP("Gia dụng");
        }

        private void họcTậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocTheoDanhMucSP("Học tập");
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LocTheoDanhMucSP("Thời trang");
        }
        private void LocTheoDanhMucSP(string danhMuc)
        {
            fPanelSanPham.Controls.Clear();
            List<UCSanPham> sanPham = SPDao.LocTheoDanhMuc(danhMuc);
            foreach (UCSanPham sp in sanPham)
            {
                fPanelSanPham.Controls.Add(sp);
            }
        }

        private void btnTatCaSP_Click(object sender, EventArgs e)
        {
            FTrangChu_Load(sender, e);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            LocTheoDanhMucSP("Thể thao & Du lịch");
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            LocTheoDanhMucSP("Giày dép");
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            LocTheoDanhMucSP("Sắc đẹp");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            LocTheoDanhMucSP("Sức khỏe");
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            LocTheoDanhMucSP("Sách");
        }

        private void tăngDầnGiáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fPanelSanPham.Controls.Clear();
            List<UCSanPham> cacSanPham = SPDao.SapXepTheoGia("Tang dan");
            foreach (UCSanPham uCSanPham in cacSanPham)
            {
                //UCSanPham uCSanPham = new UCSanPham(sp, id);
                fPanelSanPham.Controls.Add(uCSanPham);
            }
        }

        private void giảmDầnGiáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fPanelSanPham.Controls.Clear();
            List<UCSanPham> cacSanPham = SPDao.SapXepTheoGia("Giam dan");
            foreach (UCSanPham uCSanPham in cacSanPham)
            {
                //UCSanPham uCSanPham = new UCSanPham(sp, id);
                fPanelSanPham.Controls.Add(uCSanPham);
            }
        }

        private void btnUuChuong_Click(object sender, EventArgs e)
        {
            fPanelSanPham.Controls.Clear();
            List<UCSanPham> sanPham = SPDao.SanPhamUaChuong();
            foreach (UCSanPham sp in sanPham)
            {
                fPanelSanPham.Controls.Add(sp);
            }
        }
    }
}
