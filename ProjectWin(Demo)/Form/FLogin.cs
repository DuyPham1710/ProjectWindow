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
    public partial class FLogin : Form
    {
        private bool isDragging;
        private Point lastCursor;
        private Point lastForm;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public FLogin()
        {
            InitializeComponent();

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = string.Format("SELECT Position FROM Account WHERE UserName = '{0}' and Pass = '{1}'", txtUserName.Text, txtPassword.Text);
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string pos = reader.GetString(0);
                    if (rdoUser.Checked && pos == rdoUser.Text)
                    {
                        this.Hide();
                        Form form = new FUser();
                        form.ShowDialog();
                        this.Show();
                    }
                    else if (rdoAdmin.Checked && pos == rdoAdmin.Text)
                    {
                        this.Hide();
                        Form form = new FAdmin();
                        form.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Thông báo");
            }
            finally { conn.Close(); } 
        }

        private void FLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastForm = this.Location;
            }
        }
        private void FLogin_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }
        private void FLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentCursor = Cursor.Position;
                this.Location = new Point(lastForm.X + (currentCursor.X - lastCursor.X), lastForm.Y + (currentCursor.Y - lastCursor.Y));
            }
        }
        private void lbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
        private void lblSignUp_MouseDown(object sender, MouseEventArgs e)
        {
            lblSignUp.BackColor = Color.White;
        }

        private void lblSignUp_MouseLeave(object sender, EventArgs e)
        {
            lblSignUp.BackColor = Color.DodgerBlue;
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            Form SignUp = new FSignUp();
            SignUp.ShowDialog();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
