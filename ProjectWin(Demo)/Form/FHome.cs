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
            btnCatalog.MouseDown += btnCatalog_MouseDown;
            ContextMenuStripCatalog.LostFocus += btnCatalog_LostFocus;
            btnSort.MouseDown += btnSort_MouseDown;
            ContextMenuStripSort.LostFocus += btnSort_LostFocus;
        }

        private void btnSort_MouseDown(object sender, MouseEventArgs e)
        {
            Point location = btnSort.PointToScreen(new Point(0, btnSort.Height));
            ContextMenuStripSort.Show(location);
        }

        private void btnSort_LostFocus(object sender, EventArgs e)
        {
            ContextMenuStripSort.Hide();
        }
        private void btnCatalog_MouseDown(object sender, MouseEventArgs e)
        {
            Point location = btnCatalog.PointToScreen(new Point(0, btnCatalog.Height));
            ContextMenuStripCatalog.Show(location);
        }

        private void btnCatalog_LostFocus(object sender, EventArgs e)
        {
            ContextMenuStripCatalog.Hide();
        }
    }
}
