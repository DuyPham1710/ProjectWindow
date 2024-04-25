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
    public partial class FShop : Form
    {
        NguoiDAO nguoiDAO;
        public FShop()
        {
            InitializeComponent();
            btnLoc.MouseDown += btnLoc_MouseDown;
            ContextMenuStripLoc.LostFocus += btnLoc_LostFocus;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {

        }

        private void btnLoc_LostFocus(object sender, EventArgs e)
        {
            ContextMenuStripLoc.Hide();
        }
        private void btnLoc_MouseDown(object sender, MouseEventArgs e)
        {
            Point location = btnLoc.PointToScreen(new Point(0, btnLoc.Height));
            ContextMenuStripLoc.Show(location);
        }

        private void shopUyTínToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocShop(">");
        }

        private void shopÍtUyTínToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocShop("<");
        }
        private void LocShop(string toanTu)
        {
            fPanelShop.Controls.Clear();
            List<UCShop> shop = nguoiDAO.LocTheoDoUyTin(toanTu);
            foreach (var s in shop)
            {
                fPanelShop.Controls.Add(s);
            }
        }

        private void btnAllShop_Click(object sender, EventArgs e)
        {
            LocShop("<");
        }
    }
}
