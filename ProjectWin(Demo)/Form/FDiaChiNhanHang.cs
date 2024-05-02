using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWin_Demo_
{
    public partial class FDiaChiNhanHang : Form
    {
        SanPhamDao SPDao;
        private int id;
        public FDiaChiNhanHang(int id)
        {
            InitializeComponent();
            this.id = id;
            SPDao = new SanPhamDao(id);
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            SPDao.DiaChiNhanHang(txtHoTen.Text, txtSoDT.Text, txtDiaChiNhanHang.Text);
        }
    }
}
