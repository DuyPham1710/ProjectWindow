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
    public partial class FShop : Form
    {
        private int id;
        TraoDoiHangDF db = new TraoDoiHangDF();
        public FShop(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void FShop_Load(object sender, EventArgs e)
        {
            btnTatCaShop.CustomBorderColor = Color.DarkTurquoise;
            btnUyTin.CustomBorderColor = Color.White;
            btnItUyTin.CustomBorderColor = Color.White;
            btnShopTheoDoi.CustomBorderColor = Color.White;

            fPanelShop.Controls.Clear();

            var subQuery = from sanPham in db.SanPhams
                           group sanPham by sanPham.IDChuSP into g
                           select new
                           {
                               IDChuSP = g.Key,
                               SoLuong = g.Select(sp => sp.MSP).Distinct().Count()
                           };

            var shop = from person in db.People
                        join tk in subQuery on person.ID equals tk.IDChuSP
                        where person.ID != id && tk.SoLuong > 0
                        select new
                        {
                            Person = person,
                            SoLuong = tk.SoLuong
                        };

            foreach (var s in shop)
            {
                UCShop ucShop = new UCShop(id, s.Person.ID, s.Person.FullName, s.Person.Avarta, s.SoLuong, s.Person.Addr);

                fPanelShop.Controls.Add(ucShop);
            }
        }
        private void btnUyTin_Click(object sender, EventArgs e)
        {
            btnTatCaShop.CustomBorderColor = Color.White;
            btnUyTin.CustomBorderColor = Color.DarkTurquoise;
            btnItUyTin.CustomBorderColor = Color.White;
            btnShopTheoDoi.CustomBorderColor = Color.White;

            fPanelShop.Controls.Clear();
            var avgRatings = from account in db.Accounts
                             join person in db.People on account.ID equals person.ID
                             join sanPham in db.SanPhams on person.ID equals sanPham.IDChuSP
                             join danhGia in db.DanhGias on sanPham.MSP equals danhGia.MSP
                             group danhGia by account.ID into g
                             select new
                             {
                                 ID = g.Key,
                                 TBSao = g.Average(x => x.SoSao)
                             };
            var uniqueProducts = from sanPham in db.SanPhams
                                 group sanPham by sanPham.IDChuSP into g
                                 select new
                                 {
                                     IDChuSP = g.Key,
                                     SoLuong = g.Select(sp => sp.MSP).Distinct().Count()
                                 };
            var shop = from s in avgRatings
                        join person in db.People on s.ID equals person.ID
                        join tk in uniqueProducts on person.ID equals tk.IDChuSP
                        where person.ID != id && tk.SoLuong > 0 && s.TBSao > 3
                        select new
                        {
                            Person = person,
                            SoLuong = tk.SoLuong,
                            TBSao = s.TBSao
                        };

            foreach (var s in shop)
            {
                UCShop ucShop = new UCShop(id, s.Person.ID, s.Person.FullName, s.Person.Avarta, s.SoLuong, s.Person.Addr);

                fPanelShop.Controls.Add(ucShop);
            }
        }
        private void btnItUyTin_Click(object sender, EventArgs e)
        {
            btnTatCaShop.CustomBorderColor = Color.White;
            btnUyTin.CustomBorderColor = Color.White;
            btnItUyTin.CustomBorderColor = Color.DarkTurquoise;
            btnShopTheoDoi.CustomBorderColor = Color.White;

            fPanelShop.Controls.Clear();
            var avgRatings = from account in db.Accounts
                             join person in db.People on account.ID equals person.ID
                             join sanPham in db.SanPhams on person.ID equals sanPham.IDChuSP
                             join danhGia in db.DanhGias on sanPham.MSP equals danhGia.MSP
                             group danhGia by account.ID into g
                             select new
                             {
                                 ID = g.Key,
                                 TBSao = g.Average(x => x.SoSao)
                             };
            var uniqueProducts = from sanPham in db.SanPhams
                                 group sanPham by sanPham.IDChuSP into g
                                 select new
                                 {
                                     IDChuSP = g.Key,
                                     SoLuong = g.Select(sp => sp.MSP).Distinct().Count()
                                 };
            var shop = from s in avgRatings
                        join person in db.People on s.ID equals person.ID
                        join tk in uniqueProducts on person.ID equals tk.IDChuSP
                        where person.ID != id && tk.SoLuong > 0 && s.TBSao < 3
                        select new
                        {
                            Person = person,
                            SoLuong = tk.SoLuong,
                            TBSao = s.TBSao
                        };

            foreach (var s in shop)
            {
                UCShop ucShop = new UCShop(id, s.Person.ID, s.Person.FullName, s.Person.Avarta, s.SoLuong, s.Person.Addr);

                fPanelShop.Controls.Add(ucShop);
            }
        }

        private void btnAllShop_Click(object sender, EventArgs e)
        {
            FShop_Load(sender, e);
        }

        private void btnShopTheoDoi_Click(object sender, EventArgs e)
        {
            btnTatCaShop.CustomBorderColor = Color.White;
            btnUyTin.CustomBorderColor = Color.White;
            btnItUyTin.CustomBorderColor = Color.White;
            btnShopTheoDoi.CustomBorderColor = Color.DarkTurquoise;

            fPanelShop.Controls.Clear();
            //List<UCShop> shop = nguoiDao.TheoDoi();
            //foreach (UCShop s in shop)
            //{
            //    fPanelShop.Controls.Add(s);
            //}
        }
    }
}
