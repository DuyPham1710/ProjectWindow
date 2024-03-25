using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWin_Demo_
{
    public partial class FSignUp : Form
    {
        private bool isDragging;
        private Point lastCursor;
        private Point lastForm;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public FSignUp()
        {
            InitializeComponent();
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (rdoMan.Checked)
                gender = rdoMan.Text;
            else if (rdoWoman.Checked)
                gender = rdoWoman.Text;
            else
                gender = rdoOther.Text;
            try
            {
                conn.Open();
                string idStr = "SELECT count(*) FROM Person";
                SqlCommand cmd = new SqlCommand(idStr, conn);
                int id = (int)cmd.ExecuteScalar() + 1;

                Person person = new Person(id, txtFullName.Text, txtEmail.Text, txtPhoneNumber.Text, txtCCCD.Text,  gender, cbAddress.Text, txtUserName.Text, txtPassWord.Text, "User", dtpBornYear.Value, null);

                string sqlStr = string.Format("INSERT INTO Person(ID, FullName, Phone, CCCD, Gender, Bith, Email, Avarta, Addr) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')",
                person.ID, person.FullName, person.PhoneNumber, person.Cccd, person.Gender, person.DateOfBirth.ToString(), person.Email, person.Avt, person.Address);
                
                cmd = new SqlCommand(sqlStr, conn);

                sqlStr = string.Format("INSERT INTO Account(ID, UserName, Pass, Position) VALUES ('{0}', '{1}', '{2}', '{3}')",
                    person.ID, person.UserName, person.Password, person.Position);
                
                SqlCommand cmd1 = new SqlCommand(sqlStr, conn);


                if (cmd.ExecuteNonQuery() > 0 && cmd1.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Đăng kí tài khoản thành công", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng kí tài khoản thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                conn.Close();
            }
            
            this.Close();
        }
        private void FSignUp_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastForm = this.Location;
            }
        }
        private void FSignUp_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }
        private void FSignUp_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentCursor = Cursor.Position;
                this.Location = new Point(lastForm.X + (currentCursor.X - lastCursor.X), lastForm.Y + (currentCursor.Y - lastCursor.Y));
            }
        }
       

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
