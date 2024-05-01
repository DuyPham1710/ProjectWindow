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
    public partial class FLyDoHuyDon : Form
    {
        private bool isDragging;
        private Point lastCursor;
        private Point lastForm;

        private SanPham sp;
        private int id;
        SanPhamDao SPDao;
        public FLyDoHuyDon(SanPham sp, int id)
        {
            InitializeComponent();
            this.sp = sp;
            this.id = id;
            SPDao = new SanPhamDao(id);
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string lyDo = "";
            foreach (Control control in Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    lyDo = radioButton.Text;
                }
            }
            SPDao.LyDoHuySP(sp, lyDo);
            this.Close();
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
