using Guna.UI2.WinForms;
using ProjectWin_Demo_.UC;
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
    public partial class FInfo : Form
    {
        public FInfo()
        {
            InitializeComponent();

            btnHistory.MouseDown += btnHistory_MouseDown;
            guna2ContextMenuStrip1.LostFocus += btnHistory_LostFocus;
        }
        private void btnHistory_MouseDown(object sender, MouseEventArgs e)
        {
            Point location = btnHistory.PointToScreen(new Point(0, btnHistory.Height));
            guna2ContextMenuStrip1.Show(location);
        }

        private void btnHistory_LostFocus(object sender, EventArgs e)
        {
            guna2ContextMenuStrip1.Hide();
        }
        private void btnInfo_Click(object sender, EventArgs e)
        {
            btnInfo.ForeColor = Color.MediumSlateBlue;
            btnInfo.CustomBorderColor = Color.MediumSlateBlue;
            btnHistory.ForeColor = Color.Black;
            btnHistory.CustomBorderColor = Color.White;
            btnRevenue.ForeColor = Color.Black;
            btnRevenue.CustomBorderColor = Color.White;
            UCInfo ucInfo = new UCInfo();
            addUserControl(ucInfo);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            btnInfo.ForeColor = Color.Black;
            btnInfo.CustomBorderColor = Color.White;
            btnHistory.ForeColor = Color.MediumSlateBlue;
            btnHistory.CustomBorderColor = Color.MediumSlateBlue;
            btnRevenue.ForeColor = Color.Black;
            btnRevenue.CustomBorderColor = Color.White;
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            btnInfo.ForeColor = Color.Black;
            btnInfo.CustomBorderColor = Color.White;
            btnHistory.ForeColor = Color.Black;
            btnHistory.CustomBorderColor = Color.White;
            btnRevenue.ForeColor = Color.MediumSlateBlue;
            btnRevenue.CustomBorderColor = Color.MediumSlateBlue;
            UCRevenue ucRevenue = new UCRevenue();
            addUserControl(ucRevenue);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelChildForm.Controls.Clear();
            panelChildForm.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void FInfo_Load(object sender, EventArgs e)
        {
            UCInfo ucInfo = new UCInfo();
            addUserControl(ucInfo);
        }

        private void ItemPurchaseHistoryToolStripMenuItem(object sender, EventArgs e)
        {
            UCHistory ucHistory = new UCHistory();
            addUserControl(ucHistory);
        }

        private void ItemSalesHistoryToolStripMenuItem(object sender, EventArgs e)
        {
            UCHistory ucHistory = new UCHistory();
            addUserControl(ucHistory);
        }
    }
}
