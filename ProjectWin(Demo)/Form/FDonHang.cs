using ProjectWin_Demo_.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWin_Demo_
{
    public partial class FDonHang : Form
    {
        private int id;
        public FDonHang(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void FDonHang_Load(object sender, EventArgs e)
        {
            btnDonMua_Click(sender, e);
        }

        private void btnDonMua_Click(object sender, EventArgs e)
        {
            btnDonMua.CustomBorderColor = Color.MediumSlateBlue;
            btnDonMua.ForeColor = Color.MediumSlateBlue;
            btnDonBan.CustomBorderColor = Color.White;
            btnDonBan.ForeColor = Color.Black;
            UCDonMua ucDonMua = new UCDonMua(id);
            addUserControl(ucDonMua);
        }

        private void btnDonBan_Click(object sender, EventArgs e)
        {
            btnDonMua.CustomBorderColor = Color.White;
            btnDonMua.ForeColor = Color.Black;
            btnDonBan.CustomBorderColor = Color.MediumSlateBlue;
            btnDonBan.ForeColor = Color.MediumSlateBlue;
            UCDonBan ucDonBan = new UCDonBan(id);
            addUserControl(ucDonBan);
        }
       
        private void addUserControl(UserControl userControl)
        {
            PanelDonHang.Controls.Clear();
            PanelDonHang.Controls.Add(userControl);
            userControl.BringToFront();
            userControl.Dock = DockStyle.Fill;
        }
    }
}
