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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace ProjectWin_Demo_
{
    public partial class FUser : Form
    {
        private bool isDragging;
        private Point lastCursor;
        private Point lastForm;
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
                btnMyProduct.Text = "Sản phẩm\ncủa tôi";
                btnInfo.Text = "Thông tin\ncá nhân";
                btnDonHang.Text = "Đơn hàng";
                btnLogOut.Text = "Đăng xuất";
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
            btnHome.FillColor = Color.Plum;
            btnMyProduct.FillColor = Color.Thistle;
            btnInfo.FillColor = Color.Thistle;
            btnDonHang.FillColor = Color.Thistle;
            openChildForm(new FHome());
            
        }

        private void pictureBoxCart_Click(object sender, EventArgs e)
        {
            openChildForm(new FCart());
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            btnHome.FillColor = Color.Thistle;
            btnMyProduct.FillColor = Color.Thistle;
            btnInfo.FillColor = Color.Plum;
            btnDonHang.FillColor = Color.Thistle;
            openChildForm(new FInfo());
        }

        private void btnMyProduct_Click(object sender, EventArgs e)
        {
            btnHome.FillColor = Color.Thistle;
            btnMyProduct.FillColor = Color.Plum;
            btnInfo.FillColor = Color.Thistle;
            btnDonHang.FillColor = Color.Thistle;
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panelControl.Width < 72)
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

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            btnHome.FillColor = Color.Thistle;
            btnMyProduct.FillColor = Color.Thistle;
            btnInfo.FillColor = Color.Thistle;
            btnDonHang.FillColor = Color.Plum;
        }

        
    }
}
