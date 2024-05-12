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

            // load thông tin người mua
            List<Person> DSNguoiMua = (from daMua in db.DaMuas
                                       join person in db.People on daMua.ID equals person.ID
                                       select person).Distinct().ToList();
            int i = 0;
            foreach (var sp in cacSanPham)
            {
                SanPham sanPham = sp.SanPham;
                sanPham.SoLuong = sp.DaMua.SoLuongDaMua;
                UCSPDaBan ucSP = new UCSPDaBan(sanPham, id);
                ucSP.lblNguoiMua.Text = DSNguoiMua[i].FullName;
                fPanel.Controls.Add(ucSP);
                i++;
            }
        }
    }
}
