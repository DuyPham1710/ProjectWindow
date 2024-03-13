using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWin_Demo_
{
    public partial class UCMyProduct : UserControl
    {
        public UCMyProduct()
        {
            InitializeComponent();
        }

        private void pcbDelete_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.BackColor = Color.Linen;
        }

        private void pcbDelete_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.BackColor = Color.WhiteSmoke;
        }

        private void pcbDelete_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox != null)
            {
                UserControl userControl = pictureBox.Parent as UserControl;
                if (userControl != null)
                {
                    DialogResult result = MessageBox.Show("Bạn chắc chắn là muốn xóa sản phẩm này", "Xác nhận xóa", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        // thực hiện xóa 
                        MessageBox.Show("Xóa thành công", "Thông báo");
                    }
                }
            }
        }

        private void pcbEdit_Click(object sender, EventArgs e)
        {
            FAddProduct fedit = new FAddProduct();
            fedit.btnAddProduct.Hide();
            fedit.btnUpdateProduct.Show();
            fedit.ShowDialog();
        }
    }
}
