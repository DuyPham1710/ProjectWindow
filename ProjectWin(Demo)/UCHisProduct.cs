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
    public partial class UCHisProduct : UserControl
    {
        public UCHisProduct()
        {
            InitializeComponent();
        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            FComment fComment = new FComment();
            fComment.ShowDialog();
        }

        private void btnPayAgain_Click(object sender, EventArgs e)
        {
            FDetail fDetail = new FDetail();
            fDetail.ShowDialog();
        }
    }
}
