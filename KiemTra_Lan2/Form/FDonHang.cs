using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTra_Lan2
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
            openChildForm(new FDonMua(id));
        }

        private void btnDonBan_Click(object sender, EventArgs e)
        {
            btnDonMua.CustomBorderColor = Color.White;
            btnDonMua.ForeColor = Color.Black;
            btnDonBan.CustomBorderColor = Color.MediumSlateBlue;
            btnDonBan.ForeColor = Color.MediumSlateBlue;
            openChildForm(new FDonBan(id));
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelDonHang.Controls.Add(childForm);
            PanelDonHang.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
