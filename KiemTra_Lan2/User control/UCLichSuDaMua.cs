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
    public partial class UCLichSuDaMua : UserControl
    {
        private int id;
        TraoDoiHangDF db = new TraoDoiHangDF();
        public UCLichSuDaMua(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void UCHistory_Load(object sender, EventArgs e)
        {
            fPanel.Controls.Clear();
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
                fPanel.Controls.Add(ucSP);
            }
        }
    }
}
