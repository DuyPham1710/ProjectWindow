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
    public partial class FComment : Form
    {
        public FComment()
        {
            InitializeComponent();
        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đánh giá sản phẩm thành công", "Thông báo");
            this.Close();
        }
    }
}
