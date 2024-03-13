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
    public partial class FMyProduct : Form
    {
        public FMyProduct()
        {
            InitializeComponent();
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                control.Margin = new Padding(5); // Đặt giá trị phần đệm là 5 cho các cạnh
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            FAddProduct addProduct = new FAddProduct();
            addProduct.ShowDialog();
        }

        private void btnProductSold_Click(object sender, EventArgs e)
        {
            btnTotalProduct.CustomBorderColor = Color.White;
            btnTotalProduct.ForeColor = Color.Black;
            btnProductSold.CustomBorderColor = Color.MediumSlateBlue;
            btnProductSold.ForeColor = Color.MediumSlateBlue;
            UCProductSold ucProductSold = new UCProductSold();
            addUserControl(ucProductSold);
        }
        private void addUserControl(UserControl userControl)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnTotalProduct_Click(object sender, EventArgs e)
        {
            btnTotalProduct.CustomBorderColor = Color.MediumSlateBlue;
            btnTotalProduct.ForeColor = Color.MediumSlateBlue;
            btnProductSold.CustomBorderColor = Color.White;
            btnProductSold.ForeColor = Color.Black;
        }
    }
}
