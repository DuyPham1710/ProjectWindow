using Guna.UI2.WinForms;
using ProjectWin_Demo_.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TheArtOfDevHtmlRenderer.Adapters;

namespace ProjectWin_Demo_
{
    public partial class FThongTin : Form
    {
        int id;
        UCThongTin ucThongTin;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        byte[] duLieuAnh;
        string gender = "";
        public FThongTin(int id)
        {
            InitializeComponent();

            btnHistory.MouseDown += btnHistory_MouseDown;
            guna2ContextMenuStrip1.LostFocus += btnHistory_LostFocus;
            ucThongTin = new UCThongTin(id);
            ucThongTin.btnSave.Click += btnSave_Click;
            panelTieuDe.Hide();
            this.id = id;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn lưu", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MemoryStream pic = new MemoryStream();
                try
                {
                    ucThongTin.pictureBoxUser.Image.Save(pic, ucThongTin.pictureBoxUser.Image.RawFormat);
                    duLieuAnh = pic.ToArray();
                    conn.Open();
                    gender = ucThongTin.rdoNam.Checked ? "Nam" : ucThongTin.rdoNu.Checked ? "Nữ" : "Khác";
                    Nguoi person = new Nguoi(id, ucThongTin.txtName.Text, ucThongTin.txtEmail.Text, ucThongTin.txtPhoneNumber.Text, ucThongTin.txtCCCD.Text
                   , gender, ucThongTin.cbAddress.Text, ucThongTin.txtUserName.Text, ucThongTin.txtPass.Text, ucThongTin.dtpNgaySinh.Value, duLieuAnh);
                    string sqlStr = "UPDATE Person SET FullName = @name, Phone = @phone, CCCD = @cccd, Gender = @gender, Bith = @birth, Email = @email, Avarta = @avatar, Addr = @address WHERE ID = @id";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.Parameters.AddWithValue("@name", person.FullName);
                    cmd.Parameters.AddWithValue("@phone", person.PhoneNumber);
                    cmd.Parameters.AddWithValue("@cccd", person.Cccd);
                    cmd.Parameters.AddWithValue("@gender", person.Gender);
                    cmd.Parameters.AddWithValue("@birth", person.DateOfBirth);
                    cmd.Parameters.AddWithValue("@email", person.Email);
                    cmd.Parameters.AddWithValue("@avatar", person.Avt);
                    cmd.Parameters.AddWithValue("@address", person.Address);
                    cmd.Parameters.AddWithValue("@id", person.ID);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Lưu thông tin thành công", "Thông báo");
                        FInfo_Load(sender, e);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Lưu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    conn.Close();
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
            //ucThongTin = new ucThongTin(id);
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
            UCDoanhThu ucRevenue = new UCDoanhThu();
            addUserControl(ucRevenue);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelChildForm.Controls.Clear();
            panelChildForm.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void FInfo_Load(object sender, EventArgs e)
        {
           // ucThongTin = new ucThongTin(id);
            addUserControl(ucThongTin);
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
