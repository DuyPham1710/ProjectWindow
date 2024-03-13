using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectWin_Demo_
{
    public partial class FUser : Form
    {
        private Form activeForm = null;

        public FUser()
        {
            InitializeComponent();
            openChildForm(new FHome());
            //   btnRegister.Hide();
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.PowderBlue;
            btnMyProduct.BackColor = Color.Transparent;
            btnInfo.BackColor = Color.Transparent;
            openChildForm(new FHome());
        }

        private void pictureBoxCart_Click(object sender, EventArgs e)
        {
            openChildForm(new FCart());
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.Transparent;
            btnMyProduct.BackColor = Color.Transparent;
            btnInfo.BackColor = Color.PowderBlue;
            openChildForm(new FInfo());
        }

        private void btnMyProduct_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.Transparent;
            btnMyProduct.BackColor = Color.PowderBlue;
            btnInfo.BackColor = Color.Transparent;
            openChildForm(new FMyProduct());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void FUser_Load(object sender, EventArgs e)
        {


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
