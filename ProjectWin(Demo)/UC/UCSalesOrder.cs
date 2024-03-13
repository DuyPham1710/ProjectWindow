using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWin_Demo_.UC
{
    public partial class UCSalesOrder : UserControl
    {
        public UCSalesOrder()
        {
            InitializeComponent();
        }

        private void btnWaitAccept_Click(object sender, EventArgs e)
        {
            btnWaitAccept.CustomBorderColor = Color.Gold;
            btnProcess.CustomBorderColor = Color.White;
            btnDelivery.CustomBorderColor = Color.White;
            btnDelivered.CustomBorderColor = Color.White;
            btnRefund.CustomBorderColor = Color.White;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            btnWaitAccept.CustomBorderColor = Color.White;
            btnProcess.CustomBorderColor = Color.Gold;
            btnDelivery.CustomBorderColor = Color.White;
            btnDelivered.CustomBorderColor = Color.White;
            btnRefund.CustomBorderColor = Color.White;
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            btnWaitAccept.CustomBorderColor = Color.White;
            btnProcess.CustomBorderColor = Color.White;
            btnDelivery.CustomBorderColor = Color.Gold;
            btnDelivered.CustomBorderColor = Color.White;
            btnRefund.CustomBorderColor = Color.White;
        }

        private void btnDelivered_Click(object sender, EventArgs e)
        {
            btnWaitAccept.CustomBorderColor = Color.White;
            btnProcess.CustomBorderColor = Color.White;
            btnDelivery.CustomBorderColor = Color.White;
            btnDelivered.CustomBorderColor = Color.Gold;
            btnRefund.CustomBorderColor = Color.White;
        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            btnWaitAccept.CustomBorderColor = Color.White;
            btnProcess.CustomBorderColor = Color.White;
            btnDelivery.CustomBorderColor = Color.White;
            btnDelivered.CustomBorderColor = Color.White;
            btnRefund.CustomBorderColor = Color.Gold;
        }
    }
}
