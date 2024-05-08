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
    public partial class FDoanhThu : Form
    {
        private int id;
        bool detail = false;
        DBConnection a;
        public FDoanhThu(int id)
        {
            this.id = id;
            InitializeComponent();
            gvDoanhThu.Show();
            chartDoanhThu.Show();
            gvChiTiet.Hide();
            a = new DBConnection(id);
        }

        private void cbxMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            btnThongKe.CustomBorderColor = Color.DarkTurquoise;
            btnChiTiet.CustomBorderColor = Color.White;
            gvDoanhThu.Show();
            chartDoanhThu.Show();
            gvChiTiet.Hide();
            detail = false;
            a.LoadDoanhThu(gvDoanhThu, cbxThang.Text, txtNam.Text);
            chartDoanhThu.Text = "Doanh thu năm: " + txtNam.Text;
            if (int.TryParse(txtNam.Text, out int nguyen))
            {
                a.LoadBieuDoDoanhThu(txtNam.Text, chartDoanhThu);
            }
        }
        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            btnThongKe.CustomBorderColor = Color.White;
            btnChiTiet.CustomBorderColor = Color.DarkTurquoise;
            gvDoanhThu.Hide();
            chartDoanhThu.Hide();
            gvChiTiet.Show();
            detail = true;
            a.LoadChiTietDoanhThu(gvChiTiet, cbxThang.Text, txtNam.Text);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (detail)
            {
                btnChiTiet_Click(sender, e);
            }
            else
            {
                btnThongKe_Click(sender, e);
            }
        }

        private void FDoanhThu_Load(object sender, EventArgs e)
        {
            btnThongKe.CustomBorderColor = Color.White;
            btnChiTiet.CustomBorderColor = Color.DarkTurquoise;
            gvDoanhThu.Hide();
            chartDoanhThu.Hide();
            gvChiTiet.Show();
            detail = true;
            a.LoadChiTietDoanhThu(gvChiTiet, cbxThang.Text, txtNam.Text);
        }
    }
}