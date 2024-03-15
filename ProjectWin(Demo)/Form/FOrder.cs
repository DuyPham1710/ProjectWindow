using ProjectWin_Demo_.UC;
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
    public partial class FOrder : Form
    {
        public FOrder()
        {
            InitializeComponent();
        }

        private void btnPurchaseOrder_Click(object sender, EventArgs e)
        {
            btnPurchaseOrder.CustomBorderColor = Color.MediumSlateBlue;
            btnPurchaseOrder.ForeColor = Color.MediumSlateBlue;
            btnSaleOrder.CustomBorderColor = Color.White;
            btnSaleOrder.ForeColor = Color.Black;
            UCPurchaseOrder uCPurchaseOrder = new UCPurchaseOrder();
            addUserControl(uCPurchaseOrder);
        }

        private void btnSaleOrder_Click(object sender, EventArgs e)
        {
            btnPurchaseOrder.CustomBorderColor = Color.White;
            btnPurchaseOrder.ForeColor = Color.Black;
            btnSaleOrder.CustomBorderColor = Color.MediumSlateBlue;
            btnSaleOrder.ForeColor = Color.MediumSlateBlue;
            UCSalesOrder uCSalesOrder = new UCSalesOrder();
            addUserControl(uCSalesOrder);
        }
        private void addUserControl(UserControl userControl)
        {

            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
            userControl.Dock = DockStyle.Fill;
        }
    }
}
