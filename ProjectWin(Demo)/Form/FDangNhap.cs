﻿using System;
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
    public partial class FDangNhap : Form
    {
        private int id;
        private bool isDragging;
        private Point lastCursor;
        private Point lastForm;
        NguoiDAO nguoiDAO;
        public FDangNhap()
        {
            InitializeComponent();
            nguoiDAO = new NguoiDAO();

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> thongTin = nguoiDAO.DangNhap(txtUserName.Text, txtPassword.Text);
            if (thongTin != null)
            {
                string viTri = "";
                foreach (int key in thongTin.Keys)
                {
                    id = key;
                    viTri = thongTin[key];
                }
                if (rdoUser.Checked && viTri == rdoUser.Text)
                {
                    this.Hide();
                    Form form = new FNguoiDung(id);
                    form.ShowDialog();
                    this.Show();
                }
                else if (rdoAdmin.Checked && viTri == rdoAdmin.Text)
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
            Form SignUp = new FDangKy();
            SignUp.ShowDialog();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
