﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTra_Lan2
{
    public partial class FNguoiDung : Form
    {
        private bool isDragging;
        private Point lastCursor;
        private Point lastForm;

        private Form activeForm = null;

        Timer growTimer = new Timer();
        Timer shrinkTimer = new Timer();
        int originalWidth;

        int id;
        TraoDoiHangDF db = new TraoDoiHangDF();
        public FNguoiDung(int id)
        {
            InitializeComponent();
            this.id = id;
            openChildForm(new FTrangChu(id));

            // Lưu lại kích thước ban đầu của button
            originalWidth = panelControl.Width;

            // Cài đặt Timer cho việc phóng to
            growTimer.Interval = 1; // Thời gian cập nhật mỗi 10ms
            growTimer.Tick += GrowTimer_Tick;

            // Cài đặt Timer cho việc thu nhỏ
            shrinkTimer.Interval = 1;
            shrinkTimer.Tick += ShrinkTimer_Tick;
            this.id = id;
        }
        private void FUser_Load(object sender, EventArgs e)
        {
            //Nguoi nguoiDung = nguoiDAO.LoadThongTinCaNhan();
            Person nguoiDung = (from person in db.People join Account in db.Accounts on person.ID equals Account.ID where Account.ID == id select person).SingleOrDefault();
            lbTenNguoiDung.Text = nguoiDung.FullName;
            if (nguoiDung.Avarta != null)
            {
                MemoryStream ms = new MemoryStream(nguoiDung.Avarta);
                pcbAvt.Image = Image.FromStream(ms);
            }  
        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastForm = this.Location;
            }
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentCursor = Cursor.Position;
                this.Location = new Point(lastForm.X + (currentCursor.X - lastCursor.X), lastForm.Y + (currentCursor.Y - lastCursor.Y));
            }
        }

        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }
        private void GrowTimer_Tick(object sender, EventArgs e)
        {
            if (panelControl.Width < originalWidth * 2.5)
            {
                panelControl.Width += 8;
            }
            else
            {
                btnHome.Text = "Trang chủ";
                btnMyProduct.Text = "Sản phẩm\ncủa tôi  ";
                btnInfo.Text = "Thông tin\ncá nhân ";
                btnDonHang.Text = "Đơn hàng";
                btnLogOut.Text = "Đăng xuất";
                btnShop.Text = "Danh sách\nshop   ";
                btnKhachhang.Text = "Khách hàng";
                growTimer.Stop();
            }
        }
        private void ShrinkTimer_Tick(object sender, EventArgs e)
        {
            if (panelControl.Width > originalWidth)
            {
                panelControl.Width -= 8;
            }
            else
            {
                shrinkTimer.Stop();
            }
            btnHome.Text = "";
            btnMyProduct.Text = "";
            btnInfo.Text = "";
            btnDonHang.Text = "";
            btnLogOut.Text = "";
            btnShop.Text = "";
            btnKhachhang.Text = "";
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
            btnHome.FillColor = Color.LightCyan;
            btnMyProduct.FillColor = Color.White;
            btnInfo.FillColor = Color.White;
            btnShop.FillColor = Color.White;
            btnDonHang.FillColor = Color.White;
            btnKhachhang.FillColor = Color.White;

            btnHome.CustomBorderColor = Color.SkyBlue;
            btnMyProduct.CustomBorderColor = Color.White;
            btnInfo.CustomBorderColor = Color.White;
            btnDonHang.CustomBorderColor = Color.White;
            btnShop.CustomBorderColor = Color.White;
            btnKhachhang.CustomBorderColor = Color.White;
            openChildForm(new FTrangChu(id));

        }

        private void pictureBoxCart_Click(object sender, EventArgs e)
        {
            openChildForm(new FGioHang(id));
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            btnHome.FillColor = Color.White;
            btnMyProduct.FillColor = Color.White;
            btnInfo.FillColor = Color.LightCyan;
            btnDonHang.FillColor = Color.White;
            btnShop.FillColor = Color.White;
            btnKhachhang.FillColor = Color.White;

            btnHome.CustomBorderColor = Color.White;
            btnMyProduct.CustomBorderColor = Color.White;
            btnInfo.CustomBorderColor = Color.SkyBlue;
            btnDonHang.CustomBorderColor = Color.White;
            btnShop.CustomBorderColor = Color.White;
            btnKhachhang.CustomBorderColor = Color.White;
            openChildForm(new FThongTin(id));
        }

        private void btnMyProduct_Click(object sender, EventArgs e)
        {
            btnHome.FillColor = Color.White;
            btnMyProduct.FillColor = Color.LightCyan;
            btnInfo.FillColor = Color.White;
            btnDonHang.FillColor = Color.White;
            btnShop.FillColor = Color.White;
            btnKhachhang.FillColor = Color.White;

            btnHome.CustomBorderColor = Color.White;
            btnMyProduct.CustomBorderColor = Color.SkyBlue;
            btnInfo.CustomBorderColor = Color.White;
            btnDonHang.CustomBorderColor = Color.White;
            btnShop.CustomBorderColor = Color.White;
            btnKhachhang.CustomBorderColor = Color.White;
            openChildForm(new FSPCuaToi(id));

        }

        public void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMenu_MouseDown(object sender, MouseEventArgs e)
        {
            growTimer.Start();
            shrinkTimer.Stop();
        }

        private void btnMenu_LostFocus(object sender, EventArgs e)
        {
            growTimer.Stop();
            shrinkTimer.Start();
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            btnHome.FillColor = Color.White;
            btnMyProduct.FillColor = Color.White;
            btnInfo.FillColor = Color.White;
            btnDonHang.FillColor = Color.LightCyan;
            btnShop.FillColor = Color.White;
            btnKhachhang.FillColor = Color.White;

            btnHome.CustomBorderColor = Color.White;
            btnMyProduct.CustomBorderColor = Color.White;
            btnInfo.CustomBorderColor = Color.White;
            btnDonHang.CustomBorderColor = Color.SkyBlue;
            btnShop.CustomBorderColor = Color.White;
            btnKhachhang.CustomBorderColor = Color.White;
            openChildForm(new FDonHang(id));
        }


        private void avt_Click(object sender, EventArgs e)
        {
            btnInfo_Click(sender, e);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panelControl.Width < 80)
            {
                growTimer.Start();
                shrinkTimer.Stop();
            }
            else
            {
                growTimer.Stop();
                shrinkTimer.Start();
            }
        }



        private void btnShop_Click(object sender, EventArgs e)
        {
            btnHome.FillColor = Color.White;
            btnMyProduct.FillColor = Color.White;
            btnShop.FillColor = Color.LightCyan;
            btnDonHang.FillColor = Color.White;
            btnInfo.FillColor = Color.White;
            btnKhachhang.FillColor = Color.White;

            btnHome.CustomBorderColor = Color.White;
            btnMyProduct.CustomBorderColor = Color.White;
            btnInfo.CustomBorderColor = Color.White;
            btnShop.CustomBorderColor = Color.SkyBlue;
            btnDonHang.CustomBorderColor = Color.White;
            btnKhachhang.CustomBorderColor = Color.White;
            openChildForm(new FShop(id));
        }

        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            btnHome.FillColor = Color.White;
            btnMyProduct.FillColor = Color.White;
            btnShop.FillColor = Color.White;
            btnDonHang.FillColor = Color.White;
            btnInfo.FillColor = Color.White;
            btnKhachhang.FillColor = Color.LightCyan;

            btnHome.CustomBorderColor = Color.White;
            btnMyProduct.CustomBorderColor = Color.White;
            btnInfo.CustomBorderColor = Color.White;
            btnShop.CustomBorderColor = Color.White;
            btnDonHang.CustomBorderColor = Color.White;
            btnKhachhang.CustomBorderColor = Color.SkyBlue;
            openChildForm(new FKhachHang(id));
        }
    }
}