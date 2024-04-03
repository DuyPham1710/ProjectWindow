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
    public partial class UCDoanhThu : UserControl
    {
        public UCDoanhThu()
        {
            InitializeComponent();
            dataGridView2.Show();
            chart1.Show();
            dataGridView1.Hide();
        }

        private void cbxMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void btnStatistical_Click(object sender, EventArgs e)
        {
            btnStatistical.CustomBorderColor = Color.DarkTurquoise;
            btnDetail.CustomBorderColor = Color.White;
            dataGridView2.Show();
            chart1.Show();
            dataGridView1.Hide();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            btnStatistical.CustomBorderColor = Color.White;
            btnDetail.CustomBorderColor = Color.DarkTurquoise;
            dataGridView2.Hide();
            chart1.Hide();
            dataGridView1.Show();
        }

     
    }
}
