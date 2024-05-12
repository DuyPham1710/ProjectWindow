using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace KiemTra_Lan2
{
    public partial class FThongTin : Form
    {
        int id;
        UCThongTin ucThongTin;
        TraoDoiHangDF db = new TraoDoiHangDF();
        public FThongTin(int id)
        {
            InitializeComponent();

            btnHistory.MouseDown += btnHistory_MouseDown;
            guna2ContextMenuStrip1.LostFocus += btnHistory_LostFocus;
            ucThongTin = new UCThongTin(id);
            ucThongTin.btnLuu.Click += btnSave_Click;
            panelTieuDe.Hide();
            this.id = id;
        }
        private void FInfo_Load(object sender, EventArgs e)
        {
            addUserControl(ucThongTin);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn lưu", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MemoryStream pic = new MemoryStream();
                byte[] duLieuAnh = null;
                try
                {
                    if (ucThongTin.pictureBoxUser.Image != null)
                    {
                        ucThongTin.pictureBoxUser.Image.Save(pic, ucThongTin.pictureBoxUser.Image.RawFormat);
                        duLieuAnh = pic.ToArray();
                    }
                    string gender = ucThongTin.rdoNam.Checked ? "Nam" : ucThongTin.rdoNu.Checked ? "Nữ" : "Khác";

                    Person nguoi = db.People.Find(id);
                    nguoi.FullName = ucThongTin.txtName.Text;
                    nguoi.Phone = ucThongTin.txtPhoneNumber.Text;
                    nguoi.CCCD = ucThongTin.txtCCCD.Text;
                    nguoi.Gender = gender;
                    nguoi.Bith = ucThongTin.dtpNgaySinh.Value;
                    nguoi.Email = ucThongTin.txtEmail.Text;
                    nguoi.Avarta = duLieuAnh;
                    nguoi.Addr = ucThongTin.cbAddress.Text;
                    db.SaveChanges();

                    Account account = db.Accounts.Find(id);
                    account.UserName = ucThongTin.txtUserName.Text;
                    account.Pass = ucThongTin.txtPass.Text;
                    db.SaveChanges();      
                    
                    MessageBox.Show("Lưu thông tin thành công", "Thông báo");
                }
                catch (Exception)
                {
                    MessageBox.Show("Lưu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnHistory_MouseDown(object sender, MouseEventArgs e)
        {
            Point location = btnHistory.PointToScreen(new Point(0, btnHistory.Height));
            guna2ContextMenuStrip1.Show(location);
        }

        private void btnHistory_LostFocus(object sender, EventArgs e)
        {
            guna2ContextMenuStrip1.Hide();
        }
        private void btnInfo_Click(object sender, EventArgs e)
        {
            panelTieuDe.Hide();
            btnInfo.ForeColor = Color.MediumSlateBlue;
            btnInfo.CustomBorderColor = Color.MediumSlateBlue;
            btnHistory.ForeColor = Color.Black;
            btnHistory.CustomBorderColor = Color.White;
            btnRevenue.ForeColor = Color.Black;
            btnRevenue.CustomBorderColor = Color.White;
            addUserControl(ucThongTin);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            panelTieuDe.Hide();
            btnInfo.ForeColor = Color.Black;
            btnInfo.CustomBorderColor = Color.White;
            btnHistory.ForeColor = Color.MediumSlateBlue;
            btnHistory.CustomBorderColor = Color.MediumSlateBlue;
            btnRevenue.ForeColor = Color.Black;
            btnRevenue.CustomBorderColor = Color.White;
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            panelTieuDe.Hide();
            btnInfo.ForeColor = Color.Black;
            btnInfo.CustomBorderColor = Color.White;
            btnHistory.ForeColor = Color.Black;
            btnHistory.CustomBorderColor = Color.White;
            btnRevenue.ForeColor = Color.MediumSlateBlue;
            btnRevenue.CustomBorderColor = Color.MediumSlateBlue;
            openChildForm(new FDoanhThu(id));
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelChildForm.Controls.Clear();
            panelChildForm.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private Form activeForm = null;
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
        private void ItemPurchaseHistoryToolStripMenuItem(object sender, EventArgs e)
        {
            panelTieuDe.Hide();
            UCLichSuDaMua ucHistory = new UCLichSuDaMua(id);
            addUserControl(ucHistory);
        }

        private void ItemSalesHistoryToolStripMenuItem(object sender, EventArgs e)
        {
            panelTieuDe.Show();
            UCLichSuDaBan ucHistory = new UCLichSuDaBan(id);
            addUserControl(ucHistory);
        }
    }
}
