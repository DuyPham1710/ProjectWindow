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
    public partial class UCLichSuDaBan : UserControl
    {
        private int id;
        TraoDoiHangDF db = new TraoDoiHangDF();
        public UCLichSuDaBan(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void UCLichSuDaBan_Load(object sender, EventArgs e)
        {
            fPanel.Controls.Clear();
            var cacSanPham = from daMua in db.DaMuas
                             join sanPham in db.SanPhams on daMua.MSP equals sanPham.MSP
                             where sanPham.IDChuSP == id && daMua.TrangThai == "Đã giao"
                             select new
                             {
                                 DaMua = daMua,
                                 SanPham = sanPham
                             };

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
                fPanel.Controls.Add(ucSP);
            }
        }
    }
}
