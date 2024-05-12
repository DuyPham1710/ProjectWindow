using System;
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
    public partial class FDangKy : Form
    {
        private bool isDragging;
        private Point lastCursor;
        private Point lastForm;
        TraoDoiHangDF db = new TraoDoiHangDF();
        public FDangKy()
        {
            InitializeComponent();
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
            int id = db.Accounts.Count() + 1;
            if (txtXacNhanMK.Text == txtMatKhau.Text)
            {
                string path = Path.Combine(Application.StartupPath, "Resources", "icons8-user-64 (1).png");
                
                Person nguoiDung = new Person
                {
                    ID = id,
                    FullName = txtHoTen.Text,
                    Phone = txtSoDT.Text,
                    CCCD = txtCCCD.Text,
                    Gender = gioiTinh,
                    Bith = dtpNgaySinh.Value,
                    Email = txtEmail.Text,
                    Avarta = File.ReadAllBytes(path),
                    Addr = cbDiaChi.Text,
                    DiaChiNhanHang = null
                };
                db.People.Add(nguoiDung);
                db.SaveChanges();
                Account account = new Account
                {
                    ID = id,
                    UserName = txtTenDangNhap.Text,
                    Pass = txtMatKhau.Text,
                    Position = "User"
                };
                db.Accounts.Add(account);
                db.SaveChanges();
                MessageBox.Show("Đăng ký tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
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
