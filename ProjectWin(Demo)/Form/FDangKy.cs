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
    public partial class FDangKy : Form
    {
        private bool isDragging;
        private Point lastCursor;
        private Point lastForm;
        NguoiDAO nguoiDAO;
        public FDangKy()
        {
            InitializeComponent();
            nguoiDAO = new NguoiDAO();
            lbl0.Hide();
            lbl1.Hide();
            lbl2.Hide();
            lbl3.Hide();
            lbl4.Hide();
            lbl5.Hide();
            lbl6.Hide();
            lbl7.Hide();
            lbl8.Hide();
            lbl9.Hide();
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string gioiTinh = "";
            if (rdoMan.Checked)
                gioiTinh = rdoMan.Text;
            else if (rdoWoman.Checked)
                gioiTinh = rdoWoman.Text;
            else
                gioiTinh = rdoOther.Text;
            int id = nguoiDAO.TaoID();
            Nguoi nguoiDung = new Nguoi(id, txtFullName.Text, txtEmail.Text, txtPhoneNumber.Text, txtCCCD.Text, gioiTinh, cbAddress.Text, txtUserName.Text, txtPassWord.Text, "User", dtpBornYear.Value, null);
            if (nguoiDung.KiemTra())
            {
                nguoiDAO.DangKy(nguoiDung);
                MessageBox.Show("Đăng ký tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            //try
            //{
            //    conn.Open();
            //    string idStr = "SELECT count(*) FROM Person";
            //    SqlCommand cmd = new SqlCommand(idStr, conn);
            //    int id = (int)cmd.ExecuteScalar() + 1;

            //    Nguoi person = new Nguoi(id, txtFullName.Text, txtEmail.Text, txtPhoneNumber.Text, txtCCCD.Text, gioiTinh, cbAddress.Text, txtUserName.Text, txtPassWord.Text, "User", dtpBornYear.Value, null);

            //    string sqlStr = string.Format("INSERT INTO Person(ID, FullName, Phone, CCCD, Gender, Bith, Email, Addr) VALUES ({0}, N'{1}', '{2}', '{3}', N'{4}', '{5}', '{6}', N'{7}')",
            //    person.ID, person.FullName, person.PhoneNumber, person.Cccd, person.Gender, person.DateOfBirth.ToString(), person.Email, person.Address);

            //    SqlCommand cmd1 = new SqlCommand(sqlStr, conn);

            //    sqlStr = string.Format("INSERT INTO Account(ID, UserName, Pass, Position) VALUES ({0}, '{1}', '{2}', '{3}')",
            //        person.ID, person.UserName, person.Password, person.Position);
                
            //    SqlCommand cmd2 = new SqlCommand(sqlStr, conn);

            //    if (cmd1.ExecuteNonQuery() > 0 && cmd2.ExecuteNonQuery() > 0)
            //    {
            //        MessageBox.Show("Đăng kí tài khoản thành công", "Thông báo");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Đăng kí tài khoản thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //finally
            //{
            //    conn.Close();
            //}
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
