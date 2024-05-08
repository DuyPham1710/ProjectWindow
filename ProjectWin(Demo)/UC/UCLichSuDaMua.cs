using ProjectWin_Demo_.UC;
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
    public partial class UCLichSuDaMua : UserControl
    {
        private int id;
        SanPhamDao SPDao;
        public UCLichSuDaMua(int id)
        {
            InitializeComponent();
            this.id = id;
            SPDao = new SanPhamDao(id);
        }

        private void UCHistory_Load(object sender, EventArgs e)
        {
            fPanel.Controls.Clear();
            List<SanPham> sanPham = SPDao.DanhSachDonMua("Đã giao");
            foreach (SanPham item in sanPham)
            {
                UCSPDaMua ucSP = new UCSPDaMua(item, id);
                fPanel.Controls.Add(ucSP);
            }
        }
    }
}
