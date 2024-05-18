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
    public partial class FDonBan : Form
    {
        private int id;
        List<SanPham> sanPham = new List<SanPham>();
        string trangThai;
        TraoDoiHangDF db = new TraoDoiHangDF();
        public FDonBan(int id)
        {
            InitializeComponent();
            this.id = id;
            pTieuDe.Hide();
        }

        private void FDonBan_Load(object sender, EventArgs e)
        {
            btnChoXacNhan_Click(sender, e);
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            UCQuyTrinhDonHang sp = sender as UCQuyTrinhDonHang;

            DaMua daMua = db.DaMuas.Find(Int32.Parse(sp.lblMaVanChuyen.Text));
            daMua.TrangThai = trangThai;
            daMua.ThoiGianHienTai = DateTime.Now;
            db.SaveChanges();
            
            if (trangThai == "Đã giao")
            {
                SanPham sanPham = db.SanPhams.Find(sp.lblMaSP.Text);
                sanPham.BanDuoc += Int32.Parse(sp.lblSoLuong.Text);
                db.SaveChanges();
            }
            FDonBan_Load(sender, e);
        }
        private void btnHuyDon_Click(object sender, EventArgs e)
        {
            UCQuyTrinhDonHang sp = sender as UCQuyTrinhDonHang;
            DaMua daMua = db.DaMuas.Where(d => d.MaVanChuyen == Int32.Parse(sp.lblMaVanChuyen.Text)).SingleOrDefault();
            db.DaMuas.Remove(daMua);
            db.SaveChanges();
            FDonBan_Load(sender, e);
        }

        public List<UCQuyTrinhDonHang> DSDonBan(string trangThai)
        {
            var DSDonBan = from sanPham in db.SanPhams
                           join daMua in db.DaMuas on sanPham.MSP equals daMua.MSP
                           join person in db.People on daMua.ID equals person.ID
                           where sanPham.IDChuSP == id && daMua.TrangThai == trangThai
                           select new
                           {
                               SanPham = sanPham,
                               DaMua = daMua
                           };

            List<UCQuyTrinhDonHang> DSSanPham = new List<UCQuyTrinhDonHang>();
            foreach (var daBan in DSDonBan)
            {
                SanPham sp = daBan.SanPham;
                UCQuyTrinhDonHang ucQuyTrinh = new UCQuyTrinhDonHang(sp, id, daBan.DaMua.MaVanChuyen);
                DSSanPham.Add(ucQuyTrinh);
            }
            return DSSanPham;
        }
        private void btnChoXacNhan_Click(object sender, EventArgs e)
        {
            pTieuDe.Hide();
            btnChoXacNhan.CustomBorderColor = Color.Gold;
            btnDangXuLy.CustomBorderColor = Color.White;
            btnDangGiao.CustomBorderColor = Color.White;
            btnDaGiao.CustomBorderColor = Color.White;
            fPanelDonhang.Controls.Clear();

            List<UCQuyTrinhDonHang> uCQuyTrinhDonHangs = DSDonBan("Chờ xác nhận");
            trangThai = "Đang xử lý";

            foreach (UCQuyTrinhDonHang ucQuyTrinh in uCQuyTrinhDonHangs)
            {
                ucQuyTrinh.ButtonClickCustom += btnXacNhan_Click;
                ucQuyTrinh.ButtonClick_HuyDonHang += btnHuyDon_Click;
                fPanelDonhang.Controls.Add(ucQuyTrinh);
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
            List<UCQuyTrinhDonHang> uCQuyTrinhDonHangs = DSDonBan("Đang xử lý");
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
            List<UCQuyTrinhDonHang> uCQuyTrinhDonHangs = DSDonBan("Đang giao");
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
            var cacSanPham = from daMua in db.DaMuas
                        join sanPham in db.SanPhams on daMua.MSP equals sanPham.MSP
                        where sanPham.IDChuSP == id && daMua.TrangThai == "Đã giao"
                        select new
                        {
                            DaMua = daMua,
                            SanPham = sanPham
                        };

            trangThai = "Đã giao";

            foreach (var sp in cacSanPham)
            {
                SanPham sanPham = sp.SanPham;
                int maVanChuyen = sp.DaMua.MaVanChuyen;

                var nguoiMua = from daMua in db.DaMuas
                               join person in db.People on daMua.ID equals person.ID
                               where daMua.MaVanChuyen == maVanChuyen
                               select person;

                sanPham.SoLuong = sp.DaMua.SoLuongDaMua;
                UCSPDaBan ucSP = new UCSPDaBan(sanPham, id);
                ucSP.lblNguoiMua.Text = nguoiMua.First().FullName;
                fPanelDonhang.Controls.Add(ucSP);
            }
        }
    }
}
