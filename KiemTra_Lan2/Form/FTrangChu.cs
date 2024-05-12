using System;
using System.Collections;
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
    public partial class FTrangChu : Form
    {
        private int id;
        TraoDoiHangDF db = new TraoDoiHangDF();
        public FTrangChu(int id)
        {
            InitializeComponent();
            btnCatalog.MouseDown += btnCatalog_MouseDown;
            ContextMenuStripCatalog.LostFocus += btnCatalog_LostFocus;
            btnSort.MouseDown += btnSort_MouseDown;
            ContextMenuStripSort.LostFocus += btnSort_LostFocus;
            this.id = id;
        }
        private void FTrangChu_Load(object sender, EventArgs e)
        {
            fPanelSanPham.Controls.Clear();
            List<SanPham> DSSanPham = (from sp in db.SanPhams
                                        where sp.IDChuSP != id
                                        select sp).ToList();
            
            foreach (SanPham sp in DSSanPham)
            {
                UCSanPham ucSP = new UCSanPham(sp, id);
                ucSP.BtnClick_ChiTiet += UCChiTiet_Click;
                fPanelSanPham.Controls.Add(ucSP);
            }
        }
        private void UCChiTiet_Click(object sender, EventArgs e)
        {
            UCSanPham sp = sender as UCSanPham;
            SanPham sanPham = db.SanPhams.Where(p => p.MSP == sp.lblMaSP.Text).SingleOrDefault();
            FChiTiet fChiTiet = new FChiTiet(sanPham, id);
            fChiTiet.ShowDialog();
            FTrangChu_Load(sender, e);
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
            List<SanPham> DSSanPham = (from sp in db.SanPhams
                                       where sp.IDChuSP != id && sp.TenSP.Contains(searchText)
                                       select sp).ToList();
            foreach (SanPham sp in DSSanPham)
            {
                UCSanPham ucSP = new UCSanPham(sp, id);
                ucSP.BtnClick_ChiTiet += UCChiTiet_Click;
                fPanelSanPham.Controls.Add(ucSP);
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
            List<SanPham> DSSanPham = (from sp in db.SanPhams
                                       where sp.IDChuSP != id && sp.DanhMuc == danhMuc
                                       select sp).ToList();
            foreach (SanPham sp in DSSanPham)
            {
                UCSanPham ucSP = new UCSanPham(sp, id);
                ucSP.BtnClick_ChiTiet += UCChiTiet_Click;
                fPanelSanPham.Controls.Add(ucSP);
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
            List<SanPham> DSSanPham = db.SanPhams
                                     .Where(sp => sp.IDChuSP != id)
                                     .AsEnumerable()
                                     .OrderBy(sp => int.Parse(sp.GiaTienBayGio))
                                     .ToList();
            foreach (SanPham sp in DSSanPham)
            {
                UCSanPham uCSanPham = new UCSanPham(sp, id);
                uCSanPham.BtnClick_ChiTiet += UCChiTiet_Click;
                fPanelSanPham.Controls.Add(uCSanPham);
            }
        }

        private void giảmDầnGiáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fPanelSanPham.Controls.Clear();
            List<SanPham> DSSanPham = db.SanPhams
                                     .Where(sp => sp.IDChuSP != id)
                                     .AsEnumerable()
                                     .OrderByDescending(sp => int.Parse(sp.GiaTienBayGio))
                                     .ToList();
            foreach (SanPham sp in DSSanPham)
            {
                UCSanPham uCSanPham = new UCSanPham(sp, id);
                uCSanPham.BtnClick_ChiTiet += UCChiTiet_Click;
                fPanelSanPham.Controls.Add(uCSanPham);
            }
        }

        private void btnUuChuong_Click(object sender, EventArgs e)
        {
            fPanelSanPham.Controls.Clear();
            var tb = db.SanPhams.Average(p => p.BanDuoc);
            List<SanPham> DSSanPham = (from sp in db.SanPhams
                                       where sp.IDChuSP != id && sp.BanDuoc > tb
                                       select sp).ToList();
            foreach (SanPham sp in DSSanPham)
            {
                UCSanPham uCSanPham = new UCSanPham(sp, id);
                uCSanPham.BtnClick_ChiTiet += UCChiTiet_Click;
                fPanelSanPham.Controls.Add(uCSanPham);
            }
        }

        private void btnYeuThich_Click(object sender, EventArgs e)
        {
            List<SanPham> DanhSachSPYeuThich = (from sp in db.SanPhams 
                                                where (from yt in db.YeuThiches
                                                       where yt.IDNguoiDung == id
                                                       select yt.MSP).Contains(sp.MSP)
                                                select sp).ToList();
            fPanelSanPham.Controls.Clear();
            foreach (SanPham sp in DanhSachSPYeuThich)
            {
                UCSanPham uCSanPham = new UCSanPham(sp, id);
                uCSanPham.btnQuanTam.Image = new Bitmap(Application.StartupPath + "\\Resources\\TimDo.png");
                uCSanPham.chon = true;
                uCSanPham.BtnClick_ChiTiet += UCChiTiet_Click;
                fPanelSanPham.Controls.Add(uCSanPham);
            }
        }
    }
}
