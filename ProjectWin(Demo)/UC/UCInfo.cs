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
using Guna.UI2.WinForms;
namespace ProjectWin_Demo_
{
    public partial class UCInfo : UserControl
    {
        public UCInfo()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn lưu", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Lưu thông tin thành công", "Thông báo");
            }
        }

        private void btnAddAvatar_Click(object sender, EventArgs e)
        {
            while (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                try
                {
                    pictureBoxUser.Image = Image.FromFile(openFileDialog1.FileName);
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
