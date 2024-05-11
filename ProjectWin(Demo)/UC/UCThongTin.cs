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

                txtName.Text = nguoiDung.HoTen;
                txtPhoneNumber.Text = nguoiDung.SoDT;
                txtEmail.Text = nguoiDung.Email; 
                txtCCCD.Text = nguoiDung.Cccd; 
                txtUserName.Text = nguoiDung.TenDangNhap; 
                txtPass.Text = nguoiDung.MatKhau; 
                cbAddress.SelectedItem = nguoiDung.DiaChi; 
                dtpNgaySinh.Value = nguoiDung.NgaySinh; 
                string gioiTinh = nguoiDung.GioiTinh; 
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
