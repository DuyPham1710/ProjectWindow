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
    public partial class FDonMua : Form
    {
        private int id;
        List<SanPham> sanPham = new List<SanPham>();
        TraoDoiHangDF db = new TraoDoiHangDF();
        public FDonMua(int id)
        {
            InitializeComponent();
            this.id = id;
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

            var DSDonMua = from sanPham in db.SanPhams
                        join daMua in db.DaMuas on sanPham.MSP equals daMua.MSP
                        join person in db.People on daMua.ID equals person.ID
                        where daMua.ID == id && daMua.TrangThai == "Chờ xác nhận"
                        select new
                        {
                            SanPham = sanPham,
                            DaMua = daMua
                        };
       
            foreach (var donMua in DSDonMua)
            {
                SanPham sp = donMua.SanPham;
                sp.SoLuong = donMua.DaMua.SoLuongDaMua;
                sp.GiaTienBayGio = donMua.DaMua.Gia.ToString();
                UCSanPhamMua ucSP = new UCSanPhamMua(sp, id, donMua.DaMua.MaVanChuyen);
                ucSP.BtnClick_HuyDon += btnHuySPDaMua_Click;
                fPanelDonhang.Controls.Add(ucSP);
            }
        }
        private void btnHuySPDaMua_Click(object sender, EventArgs e)
        {
            UCSanPhamMua uCSanPhamMua = sender as UCSanPhamMua;

            SanPham sp = new SanPham();
            sp.MSP = uCSanPhamMua.lblMaSP.Text;
            FLyDoHuyDon fLyDoHuy = new FLyDoHuyDon(sp, id, Int32.Parse(uCSanPhamMua.lblMaVanChuyen.Text));

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

            var DSDonMua = from sanPham in db.SanPhams
                            join daMua in db.DaMuas on sanPham.MSP equals daMua.MSP
                            where daMua.ID == id && daMua.TrangThai == "Đang giao"
                            select new
                            {
                                SanPham = sanPham,
                                DaMua = daMua
                            };

            foreach (var donMua in DSDonMua)
            {
                SanPham sp = donMua.SanPham;
                sp.SoLuong = donMua.DaMua.SoLuongDaMua;
                sp.GiaTienBayGio = donMua.DaMua.Gia.ToString();
                UCSanPhamMua ucSP = new UCSanPhamMua(sp, id, default);
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

            var DSDonMua = from sanPham in db.SanPhams
                           join daMua in db.DaMuas on sanPham.MSP equals daMua.MSP
                           where daMua.ID == id && daMua.TrangThai == "Đã giao"
                           select new
                           {
                               SanPham = sanPham,
                               DaMua = daMua
                           };

            foreach (var donMua in DSDonMua)
            {
                SanPham sp = donMua.SanPham;
                sp.SoLuong = donMua.DaMua.SoLuongDaMua;
                sp.GiaTienBayGio = donMua.DaMua.Gia.ToString();
                UCSPDaMua ucSP = new UCSPDaMua(sp, id, donMua.DaMua.MaVanChuyen);
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

            var DSDonMua = from sanPham in db.SanPhams
                           join daMua in db.DaMuas on sanPham.MSP equals daMua.MSP
                           where daMua.ID == id && daMua.TrangThai == "Đã hủy"
                           select new
                           {
                               SanPham = sanPham,
                               DaMua = daMua
                           };

            foreach (var donMua in DSDonMua)
            {
                SanPham sp = donMua.SanPham;
                sp.SoLuong = donMua.DaMua.SoLuongDaMua;
                sp.GiaTienBayGio = donMua.DaMua.Gia.ToString();
                UCSPDaHuy ucSP = new UCSPDaHuy(sp, id, donMua.DaMua.MaVanChuyen);
                fPanelDonhang.Controls.Add(ucSP);
            }
         
        }
    }
}
