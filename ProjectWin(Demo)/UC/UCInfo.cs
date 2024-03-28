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
      //  string gender = "";
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
    //    byte[] duLieuAnh;
        int id;
        public UCInfo(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Bạn có muốn lưu", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //    MemoryStream pic = new MemoryStream();
            //    try
            //    {
            //        pictureBoxUser.Image.Save(pic, pictureBoxUser.Image.RawFormat);
            //        duLieuAnh = pic.ToArray();
            //        conn.Open();
            //        gender = rdoNam.Checked ? "Nam" : rdoNu.Checked ? "Nữ" : "Khác";
            //        Person person = new Person(id, txtName.Text, txtEmail.Text, txtPhoneNumber.Text, txtCCCD.Text
            //       , gender, cbAddress.Text, txtUserName.Text, txtPass.Text, dtpNgaySinh.Value, duLieuAnh);
            //        string sqlStr = "UPDATE Person SET FullName = @name, Phone = @phone, CCCD = @cccd, Gender = @gender, Bith = @birth, Email = @email, Avarta = @avatar, Addr = @address WHERE ID = @id";
            //        SqlCommand cmd = new SqlCommand(sqlStr, conn);
            //        cmd.Parameters.AddWithValue("@name", person.FullName);
            //        cmd.Parameters.AddWithValue("@phone", person.PhoneNumber);
            //        cmd.Parameters.AddWithValue("@cccd", person.Cccd);
            //        cmd.Parameters.AddWithValue("@gender", person.Gender);
            //        cmd.Parameters.AddWithValue("@birth", person.DateOfBirth);
            //        cmd.Parameters.AddWithValue("@email", person.Email);
            //        cmd.Parameters.AddWithValue("@avatar", person.Avt);
            //        cmd.Parameters.AddWithValue("@address", person.Address);
            //        cmd.Parameters.AddWithValue("@id", person.ID);
            //        if (cmd.ExecuteNonQuery() > 0)
            //        {
            //            MessageBox.Show("Lưu thông tin thành công", "Thông báo");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Lưu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //    finally
            //    {
            //        conn.Close();
            //    }
            //}
        }

        private void btnAddAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(.jpg;.png;*.gif)|*.jpg;*.png;*.gif";
            while (opf.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBoxUser.Image = Image.FromFile(opf.FileName);
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
            try
            {
                string query = "SELECT *FROM Person,Account WHERE Person.ID = Account.ID and Account.ID = " + id.ToString();
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    if (reader["Avarta"] != DBNull.Value)
                    {
                        byte[] imageBytes = (byte[])reader["Avarta"];
                        MemoryStream ms = new MemoryStream(imageBytes);
                        pictureBoxUser.Image = Image.FromStream(ms);

                    }
                    txtName.Text = (string)reader["FullName"];
                    txtPhoneNumber.Text = (string)reader["Phone"];
                    txtEmail.Text = (string)reader["Email"];
                    txtCCCD.Text = (string)reader["CCCD"];
                    txtUserName.Text = (string)reader["UserName"];
                    txtPass.Text = (string)reader["Pass"];
                    cbAddress.SelectedItem = (string)reader["Addr"];
                    dtpNgaySinh.Value = (DateTime)reader["Bith"];
                    string gioiTinh = (string)reader["Gender"];
                    if(gioiTinh == "Nam")
                    {
                        rdoNam.Checked = true;
                    }
                    else if(gioiTinh == "Nữ")
                    {
                        rdoNu.Checked = true;
                    }
                    else
                    {
                        rdoLGBT.Checked = true; 
                    }

                }
            }
            catch (Exception ex)  
            {
                MessageBox.Show("Không load được", "Thông báo");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
