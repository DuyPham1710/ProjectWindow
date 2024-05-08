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
    public partial class UCThongTin : UserControl
    {
        private int id;
        NguoiDAO nguoiDAO;
        public UCThongTin(int id)
        {
            InitializeComponent();
            this.id = id;
            nguoiDAO = new NguoiDAO(id);
        }

        //private void btnSave_Click(object sender, EventArgs e)
        //{
        //    if (MessageBox.Show("Bạn có muốn lưu", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
        //    {
        //        MemoryStream pic = new MemoryStream();
        //        try
        //        {
        //            pictureBoxUser.Image.Save(pic, pictureBoxUser.Image.RawFormat);
        //            duLieuAnh = pic.ToArray();
        //            conn.Open();
        //            gender = rdoNam.Checked ? "Nam" : rdoNu.Checked ? "Nữ" : "Khác";
        //            Person person = new Person(id, txtName.Text, txtEmail.Text, txtPhoneNumber.Text, txtCCCD.Text
        //           , gender, cbAddress.Text, txtUserName.Text, txtPass.Text, dtpNgaySinh.Value, duLieuAnh);
        //            string sqlStr = "UPDATE Person SET FullName = @name, Phone = @phone, CCCD = @cccd, Gender = @gender, Bith = @birth, Email = @email, Avarta = @avatar, Addr = @address WHERE ID = @id";
        //            SqlCommand cmd = new SqlCommand(sqlStr, conn);
        //            cmd.Parameters.AddWithValue("@name", person.FullName);
        //            cmd.Parameters.AddWithValue("@phone", person.PhoneNumber);
        //            cmd.Parameters.AddWithValue("@cccd", person.Cccd);
        //            cmd.Parameters.AddWithValue("@gender", person.Gender);
        //            cmd.Parameters.AddWithValue("@birth", person.DateOfBirth);
        //            cmd.Parameters.AddWithValue("@email", person.Email);
        //            cmd.Parameters.AddWithValue("@avatar", person.Avt);
        //            cmd.Parameters.AddWithValue("@address", person.Address);
        //            cmd.Parameters.AddWithValue("@id", person.ID);
        //            if (cmd.ExecuteNonQuery() > 0)
        //            {
        //                MessageBox.Show("Lưu thông tin thành công", "Thông báo");
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Lưu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        }
        //        finally
        //        {
        //            conn.Close();
        //        }
        //    }
        //}
        private void UCThongTin_Load(object sender, EventArgs e)
        {
            Nguoi nguoiDung = nguoiDAO.LoadThongTinCaNhan();
           
            if (nguoiDung != null)
            {
                if (nguoiDung.Avt != null)
                {
                    byte[] imageBytes = nguoiDung.Avt;
                    MemoryStream ms = new MemoryStream(imageBytes);
                    pictureBoxUser.Image = Image.FromStream(ms);  
                }

                txtName.Text = nguoiDung.FullName;
                txtPhoneNumber.Text = nguoiDung.PhoneNumber;
                txtEmail.Text = nguoiDung.Email; 
                txtCCCD.Text = nguoiDung.Cccd; 
                txtUserName.Text = nguoiDung.UserName; 
                txtPass.Text = nguoiDung.Password; 
                cbAddress.SelectedItem = nguoiDung.Address; 
                dtpNgaySinh.Value = nguoiDung.DateOfBirth; 
                string gioiTinh = nguoiDung.Gender; 
                if (gioiTinh == "Nam")
                {
                    rdoNam.Checked = true;
                }
                else if (gioiTinh == "Nữ")
                {
                    rdoNu.Checked = true;
                }
                else
                {
                    rdoLGBT.Checked = true;
                }

            }
        }
        private void btnThemAvt_Click(object sender, EventArgs e)
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
    }
}
