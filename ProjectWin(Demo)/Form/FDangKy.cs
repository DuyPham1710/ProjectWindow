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
            lblXacNhanMK.Hide();
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string gioiTinh = "";
            if (rdoNam.Checked)
                gioiTinh = rdoNam.Text;
            else if (rdoNu.Checked)
                gioiTinh = rdoNu.Text;
            else
                gioiTinh = rdoKhac.Text;
            if (txtXacNhanMK.Text == txtMatKhau.Text)
            {
                int id = nguoiDAO.TaoID();
                Nguoi nguoiDung = new Nguoi(id, txtHoTen.Text, txtEmail.Text, txtSoDT.Text, txtCCCD.Text, gioiTinh, cbDiaChi.Text, txtTenDangNhap.Text, txtMatKhau.Text, dtpNgaySinh.Value, null);
                if (nguoiDung.KiemTra("Thêm"))
                {
                    nguoiDAO.DangKy(nguoiDung);
                    MessageBox.Show("Đăng ký tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                lblXacNhanMK.Show();
            }
          
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
