using System;
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
    public partial class FGioHang : Form
    {
        private int id;
        List<UCGioHang> gioHang = new List<UCGioHang>();
        TraoDoiHangDF db = new TraoDoiHangDF(); 
        public FGioHang(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        private void FGioHang_Load(object sender, EventArgs e)
        {
            fPanelGioHang.Controls.Clear();
            //List<UCGioHang> sanPham = ghDAO.LoadGioHang();

            var DSGgioHang = from gh in db.GioHangs
                        join sanPham in db.SanPhams on gh.MSP equals sanPham.MSP
                        where gh.IDNguoiMua == id
                        select new
                        {
                            SanPham = sanPham,
                            SLGioHang = gh.SoLuong
                        };
            //gioHang = sanPham;
            foreach (var item in DSGgioHang)
            {
                SanPham sp = item.SanPham;
                UCGioHang ucGh = new UCGioHang(sp, id, Int32.Parse(item.SLGioHang.ToString()));
                gioHang.Add(ucGh);
                ucGh.BtnClick_ChiTiet += UCGioHang_Click;
                ucGh.BtnClick_Xoa += pcbBin_Click;
                ucGh.BtnClick_Chon += cbChonSP_Click;
                fPanelGioHang.Controls.Add(ucGh);
            }
        }
        private void btnMuaHang_Click(object sender, EventArgs e)
        {
            if (lblTongTien.Text == "0")
            {
                MessageBox.Show("Bạn vẫn chưa chọn sản phẩm nào để mua", "Thông báo");
            }
            else
            {
                List<SanPham> danhSachsanPham = new List<SanPham>();
                foreach (UCGioHang gh in gioHang)
                {
                    if (gh.cbChonSP.Checked)
                    {
                        SanPham sp = (from sanPham in db.SanPhams
                                      where sanPham.MSP == gh.lblMaSP.Text
                                      select sanPham).SingleOrDefault();
                        sp.SoLuong = gh.nudSoLuong.Value.ToString();
                        sp.GiaTienBayGio = (Int32.Parse(sp.GiaTienBayGio) * gh.nudSoLuong.Value).ToString();
                        danhSachsanPham.Add(sp);
                    }
                }
                FThanhToan fThanhToan = new FThanhToan(danhSachsanPham, id);
                fThanhToan.ShowDialog();
            }
        }


        private void UCGioHang_Click(object sender, EventArgs e)
        {
            UCGioHang gh = sender as UCGioHang;
            List<SanPham> sp = (from sanPham in db.SanPhams
                          where sanPham.MSP == gh.lblMaSP.Text
                          select sanPham).ToList();
            //List<SanPham> sp = SPDao.chiTietSanPham(sanPham.lblMaSP.Text);
            FChiTiet fChiTiet = new FChiTiet(sp[0], id);
            fChiTiet.ShowDialog();
        }
        private void pcbBin_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn là muốn xóa sản phẩm này", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                UCGioHang ucGioHang = sender as UCGioHang;
                var maSP = ucGioHang.lblMaSP.Text;
                GioHang gh = db.GioHangs.Where(p => p.MSP == maSP).SingleOrDefault();
                db.GioHangs.Remove(gh);
                db.SaveChanges();
                FGioHang_Load(sender, e);
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbChonSP_Click(object sender, EventArgs e)
        {
            UCGioHang sanPham = sender as UCGioHang;
            if (sanPham.cbChonSP.Checked)
            {
                lblTongTien.Text = (int.Parse(lblTongTien.Text) + int.Parse(sanPham.lblTongTien.Text)).ToString();
                sanPham.panelGioHanh.BackColor = Color.LightCyan;
            }
            else
            {
                lblTongTien.Text = (int.Parse(lblTongTien.Text) - int.Parse(sanPham.lblTongTien.Text)).ToString();
                sanPham.panelGioHanh.BackColor = Color.White;
            }

        }
        private void cbChonTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (cbChonTatCa.Checked)
            {
                foreach (UCGioHang gh in gioHang)
                {
                    gh.cbChonSP.Checked = true;
                    gh.panelGioHanh.BackColor = Color.LightCyan;
                    lblTongTien.Text = (int.Parse(lblTongTien.Text) + int.Parse(gh.lblTongTien.Text)).ToString();
                }

            }
            else
            {
                foreach (UCGioHang gh in gioHang)
                {
                    gh.cbChonSP.Checked = false;
                    gh.panelGioHanh.BackColor = Color.White;
                }
                lblTongTien.Text = "0";
            }
        }
        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                FGioHang_Load(sender, e);
            }
            else
            {
                timKiemVaHienThi(txtTimKiem.Text);
            }
        }
        private void timKiemVaHienThi(string searchText)
        {
            fPanelGioHang.Controls.Clear();
            //List<UCGioHang> sanPham = ghDAO.timKiemGioHang(searchText);
            var DSTimKiem = (from gioHang in db.GioHangs
                        join sanPham in db.SanPhams on gioHang.MSP equals sanPham.MSP
                        where gioHang.IDNguoiMua == id && sanPham.TenSP.Contains(searchText)
                        select new
                        {
                            SanPham = sanPham,
                            SLGioHang = gioHang.SoLuong
                        });

            foreach (var item in DSTimKiem)
            {
                SanPham sp = item.SanPham;
                UCGioHang ucGh = new UCGioHang(sp, id, Int32.Parse(item.SLGioHang.ToString()));
                ucGh.BtnClick_ChiTiet += UCGioHang_Click;
                ucGh.BtnClick_Xoa += pcbBin_Click;
                ucGh.BtnClick_Chon += cbChonSP_Click;
                fPanelGioHang.Controls.Add(ucGh);
            }
        }
    }
}
