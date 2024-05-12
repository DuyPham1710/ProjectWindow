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
    public partial class UCThongTin : UserControl
    {
        private int id;
        TraoDoiHangDF db = new TraoDoiHangDF();
        public UCThongTin(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void UCThongTin_Load(object sender, EventArgs e)
        {
            var query = (from person in db.People join account in db.Accounts on person.ID equals account.ID
                                where account.ID == id
                                select new
                                {
                                    Person = person,
                                    Account = account
                                });

            Person nguoiDung = query.First().Person;
            Account taiKhoan = query.First().Account;
            if (nguoiDung != null)
            {
                if (nguoiDung.Avarta != null)
                {
                    byte[] imageBytes = nguoiDung.Avarta;
                    MemoryStream ms = new MemoryStream(imageBytes);
                    pictureBoxUser.Image = Image.FromStream(ms);
                }

                txtName.Text = nguoiDung.FullName;
                txtPhoneNumber.Text = nguoiDung.Phone;
                txtEmail.Text = nguoiDung.Email;
                txtCCCD.Text = nguoiDung.CCCD;
                txtUserName.Text = taiKhoan.UserName;
                txtPass.Text = taiKhoan.Pass;
                cbAddress.SelectedItem = nguoiDung.Addr;
                dtpNgaySinh.Value = DateTime.Parse(nguoiDung.Bith.ToString());
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
