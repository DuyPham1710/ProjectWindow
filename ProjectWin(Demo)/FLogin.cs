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
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form SignUp = new FSignUp();
            SignUp.ShowDialog();
          //  this.Show();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (radiobtnUser.Checked)
            {
                this.Hide();
                Form form = new FUser();
                form.ShowDialog();
                this.Show();
            }
            else if (radiobtnAdmin.Checked)
            {
                this.Hide();
                Form form = new FAdmin();
                form.ShowDialog();
                this.Show();
            }
        }
    }
}
