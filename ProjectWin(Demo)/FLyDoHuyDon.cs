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
    public partial class FLyDoHuyDon : Form
    {
        SanPham sp;
        int id;
        SanPhamDao SPDao;
        public FLyDoHuyDon(SanPham sp, int id)
        {
            InitializeComponent();
            this.sp = sp;
            this.id = id;
            SPDao = new SanPhamDao(id);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string lyDo = "";
            foreach (Control control in Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    lyDo = radioButton.Text;
                }
            }
            SPDao.LyDoHuySP(sp, lyDo);
            this.Close();
        }
    }
}
