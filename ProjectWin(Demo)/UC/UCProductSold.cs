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
    public partial class UCProductSold : UserControl
    {
        public UCProductSold()
        {
            InitializeComponent();
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                control.Margin = new Padding(5); // Đặt giá trị phần đệm là 5 cho các cạnh
            }
        }
    }
}
