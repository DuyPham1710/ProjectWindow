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
    public partial class FAdmin : Form
    {
        public FAdmin()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void btnApproved_Click(object sender, EventArgs e)
        {
            btnApproved.BackColor = Color.PowderBlue;
            btnWaitProduct.BackColor = Color.Transparent;
            btnInfo.BackColor = Color.Transparent;
          //  openChildForm(new FInfo());
        }

        private void btnWaitProduct_Click(object sender, EventArgs e)
        {
            btnApproved.BackColor = Color.Transparent;
            btnWaitProduct.BackColor = Color.PowderBlue;
            btnInfo.BackColor = Color.Transparent;
         //   openChildForm(new FMyProduct());
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            btnApproved.BackColor = Color.Transparent;
            btnWaitProduct.BackColor = Color.Transparent;
            btnInfo.BackColor = Color.PowderBlue;
          //  openChildForm(new FInfo());
        }
    }
}
