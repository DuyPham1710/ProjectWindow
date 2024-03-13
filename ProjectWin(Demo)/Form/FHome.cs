using Guna.UI2.WinForms;
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
    public partial class FHome : Form
    {
        public FHome()
        {

            InitializeComponent();
            pCatalog.Hide();
            pSort.Hide();
            guna2Button2.MouseDown += btnCatalog_MouseDown;
            guna2Button2.LostFocus += btnCatalog_LostFocus;
            guna2Button3.MouseDown += btnSort_MouseDown;
            guna2Button3.LostFocus += btnSort_LostFocus;
        }
        private void btnCatalog_MouseDown(object sender, MouseEventArgs e)
        {
            pCatalog.Show();
        }

        private void btnCatalog_LostFocus(object sender, EventArgs e)
        {
            pCatalog.Hide();
        }
        private void btnSort_MouseDown(object sender, MouseEventArgs e)
        {
            pSort.Show();
        }

        private void btnSort_LostFocus(object sender, EventArgs e)
        {
            pSort.Hide();
        }




    }
}
