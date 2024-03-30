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
    public partial class FInfo : Form
    {
        int id;
        UCInfo ucInfo;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        byte[] duLieuAnh;
        string gender = "";
        public FInfo(int id)
        {
            InitializeComponent();

            btnHistory.MouseDown += btnHistory_MouseDown;
            guna2ContextMenuStrip1.LostFocus += btnHistory_LostFocus;
            ucInfo = new UCInfo(id);
            ucInfo.btnSave.Click += btnSave_Click;
            this.id = id;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn lưu", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MemoryStream pic = new MemoryStream();
                try
                {
                    ucInfo.pictureBoxUser.Image.Save(pic, ucInfo.pictureBoxUser.Image.RawFormat);
                    duLieuAnh = pic.ToArray();
                    conn.Open();
                    gender = ucInfo.rdoNam.Checked ? "Nam" : ucInfo.rdoNu.Checked ? "Nữ" : "Khác";
                    Person person = new Person(id, ucInfo.txtName.Text, ucInfo.txtEmail.Text, ucInfo.txtPhoneNumber.Text, ucInfo.txtCCCD.Text
                   , gender, ucInfo.cbAddress.Text, ucInfo.txtUserName.Text, ucInfo.txtPass.Text, ucInfo.dtpNgaySinh.Value, duLieuAnh);
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
            btnInfo.ForeColor = Color.MediumSlateBlue;
            btnInfo.CustomBorderColor = Color.MediumSlateBlue;
            btnHistory.ForeColor = Color.Black;
            btnHistory.CustomBorderColor = Color.White;
            btnRevenue.ForeColor = Color.Black;
            btnRevenue.CustomBorderColor = Color.White;
            //ucInfo = new UCInfo(id);
            addUserControl(ucInfo);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            btnInfo.ForeColor = Color.Black;
            btnInfo.CustomBorderColor = Color.White;
            btnHistory.ForeColor = Color.MediumSlateBlue;
            btnHistory.CustomBorderColor = Color.MediumSlateBlue;
            btnRevenue.ForeColor = Color.Black;
            btnRevenue.CustomBorderColor = Color.White;
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            btnInfo.ForeColor = Color.Black;
            btnInfo.CustomBorderColor = Color.White;
            btnHistory.ForeColor = Color.Black;
            btnHistory.CustomBorderColor = Color.White;
            btnRevenue.ForeColor = Color.MediumSlateBlue;
            btnRevenue.CustomBorderColor = Color.MediumSlateBlue;
            UCRevenue ucRevenue = new UCRevenue();
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
           // ucInfo = new UCInfo(id);
            addUserControl(ucInfo);
        }

        private void ItemPurchaseHistoryToolStripMenuItem(object sender, EventArgs e)
        {
            UCHistory ucHistory = new UCHistory(id);
            addUserControl(ucHistory);
        }

        private void ItemSalesHistoryToolStripMenuItem(object sender, EventArgs e)
        {
            UCHistory ucHistory = new UCHistory(id);
            addUserControl(ucHistory);
        }
    }
}
