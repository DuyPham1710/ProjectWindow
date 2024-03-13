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
        }
        private void btnInfo_Click(object sender, EventArgs e)
        {
            btnInfo.ForeColor = Color.DarkCyan;
            btnHistory.ForeColor = Color.Black;
            btnRevenue.ForeColor = Color.Black;
            UCInfo ucInfo = new UCInfo();
            addUserControl(ucInfo);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            btnInfo.ForeColor = Color.Black;
            btnHistory.ForeColor = Color.DarkCyan;
            btnRevenue.ForeColor = Color.Black;
            UCHistory ucHistory = new UCHistory();
            addUserControl(ucHistory);
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            btnInfo.ForeColor = Color.Black;
            btnHistory.ForeColor = Color.Black;
            btnRevenue.ForeColor = Color.DarkCyan;
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
    }
}
