﻿using System;
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
        Timer growTimer = new Timer();
        Timer shrinkTimer = new Timer();
        int originalWidth;
        public FUser()
        {
            InitializeComponent();
            openChildForm(new FHome());
            // Lưu lại kích thước ban đầu của button
            originalWidth = panelControl.Width;

            // Cài đặt Timer cho việc phóng to
            growTimer.Interval = 1; // Thời gian cập nhật mỗi 10ms
            growTimer.Tick += GrowTimer_Tick;

            // Cài đặt Timer cho việc thu nhỏ
            shrinkTimer.Interval = 1;
            shrinkTimer.Tick += ShrinkTimer_Tick;

            // Sự kiện di chuột vào và ra
            btnHome.MouseHover += (s, e) => { shrinkTimer.Stop(); growTimer.Start(); };
            btnHome.MouseLeave += (s, e) => { growTimer.Stop(); shrinkTimer.Start(); };
            btnInfo.MouseHover += (s, e) => { shrinkTimer.Stop(); growTimer.Start(); };
            btnInfo.MouseLeave += (s, e) => { growTimer.Stop(); shrinkTimer.Start(); };
            btnLogOut.MouseHover += (s, e) => { shrinkTimer.Stop(); growTimer.Start(); };
            btnLogOut.MouseLeave += (s, e) => { growTimer.Stop(); shrinkTimer.Start(); };
            btnMyProduct.MouseHover += (s, e) => { shrinkTimer.Stop(); growTimer.Start(); };
            btnMyProduct.MouseLeave += (s, e) => { growTimer.Stop(); shrinkTimer.Start(); };
        }
        private void GrowTimer_Tick(object sender, EventArgs e)
        {
            if (panelControl.Width < originalWidth * 2.5)
            {
                panelControl.Width += 4;
            }
            else
            {
                btnHome.Text = "Trang chủ";
                btnMyProduct.Text = "Sản phẩm\ncủa tôi";
                btnInfo.Text = "Thông tin\ncá nhân";
                btnLogOut.Text = "Đăng xuất";
                growTimer.Stop();
            }
        }

        private void ShrinkTimer_Tick(object sender, EventArgs e)
        {
            
            if (panelControl.Width > originalWidth)
            {
                panelControl.Width -= 4;
            }
            else
            {
                shrinkTimer.Stop();
            }
            btnHome.Text = "";
            btnMyProduct.Text = "";
            btnInfo.Text = "";
            btnLogOut.Text = "";
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

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
