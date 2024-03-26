using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Net;
namespace ProjectWin_Demo_
{
    public partial class UCInfo : UserControl
    {
        string gender = "";
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        byte[] duLieuAnh;
        int id;
        public UCInfo(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn lưu", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    gender = rdoNam.Checked ? "Nam" : rdoNu.Checked ? "Nữ" : "Khác";
                    Person person = new Person(id, txtName.Text, txtEmail.Text, txtPhoneNumber.Text, txtCCCD.Text
                   , gender, cbAddress.Text, txtUserName.Text, txtPass.Text, dtpNgaySinh.Value, duLieuAnh);
                    MessageBox.Show(duLieuAnh.Length.ToString());
                    string sqlStr = string.Format("UPDATE Person SET FullName = N'{0}', Phone = '{1}', CCCD = '{2}', Gender = N'{3}', Bith = '{4}', Email = '{5}', Avarta = '{6}', Addr = N'{7}' WHERE ID = {8}",
                        person.FullName, person.PhoneNumber, person.Cccd, person.Gender, person.DateOfBirth.ToString(), person.Email, person.Avt, person.Address, person.ID);
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Lưu thông tin thành công", "Thông báo");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lưu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    conn.Close();
                }
                
            }
        }

        private void btnAddAvatar_Click(object sender, EventArgs e)
        {
            while (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBoxUser.Image = Image.FromFile(openFileDialog1.FileName);
                    string imagePath = openFileDialog1.FileName;
                    using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                    {
                        duLieuAnh = new byte[fs.Length];
                        fs.Read(duLieuAnh, 0, (int)fs.Length);
                    }
                    break;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể chọn ảnh này !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void UCInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
