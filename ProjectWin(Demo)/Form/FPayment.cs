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
    public partial class FPayment : Form
    {
        private bool isDragging;
        private Point lastCursor;
        private Point lastForm;
        public FPayment()
        {
            InitializeComponent();
        }
        private void pictureBoxPayMethod_MouseHover(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            // pictureBox.BackColor = Color.Pink;
        }

        private void pictureBoxPayMethod_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox.BackColor = Color.LavenderBlush;
        }

        private void pictureBoxPayMethod_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox.BorderStyle == BorderStyle.None)
            {
                pictureBox.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                pictureBox.BorderStyle = BorderStyle.None;
            }
            foreach (Control control in Controls)
            {
                if (control is PictureBox picture && picture != pictureBox)
                {
                    picture.BorderStyle = BorderStyle.None;
                }
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đặt hàng thành công", "Thông báo");
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

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastForm = this.Location;
            }
        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentCursor = Cursor.Position;
                this.Location = new Point(lastForm.X + (currentCursor.X - lastCursor.X), lastForm.Y + (currentCursor.Y - lastCursor.Y));
            }
        }

        private void panel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }
    }
}
