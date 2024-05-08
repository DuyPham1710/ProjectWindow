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
    public partial class FDanhGia : Form
    {
        private bool isDragging;
        private Point lastCursor;
        private Point lastForm;
        private int id;
        private SanPham sp;
        SanPhamDao SPDao;
        public FDanhGia(int id, SanPham sp)
        {
            InitializeComponent();
            this.id = id;
            this.sp = sp;
            SPDao = new SanPhamDao(id);
        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            SPDao.DanhGia(sp, txtBinhLuan.Text, Int32.Parse(Star.Value.ToString()));
            this.Close();
        }
        private void pToolBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentCursor = Cursor.Position;
                this.Location = new Point(lastForm.X + (currentCursor.X - lastCursor.X), lastForm.Y + (currentCursor.Y - lastCursor.Y));
            }
        }

        private void pToolBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastForm = this.Location;
            }
        }

        private void pToolBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
