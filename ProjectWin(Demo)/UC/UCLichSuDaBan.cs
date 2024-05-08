using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWin_Demo_
{
    public partial class UCLichSuDaBan : UserControl
    {
        private int id;
        SanPhamDao SPDao;
        public UCLichSuDaBan(int id)
        {
            InitializeComponent();
            this.id = id;
            SPDao = new SanPhamDao(id);
        }

        private void UCLichSuDaBan_Load(object sender, EventArgs e)
        {
            fPanel.Controls.Clear();
            List<SanPham> sanPham = SPDao.DSDaBan("Đã giao");

            NguoiDAO nguoiDAO = new NguoiDAO(id);
            List<Nguoi> DSNguoiMua = nguoiDAO.LoadThongTinNguoiMua();
            int i = 0;
            foreach (SanPham sp in sanPham)
            {
                UCSPDaBan ucSP = new UCSPDaBan(sp, id);
                ucSP.lblNguoiMua.Text = DSNguoiMua[i].FullName;
                fPanel.Controls.Add(ucSP);
                i++;
            }
        }
    }
}
