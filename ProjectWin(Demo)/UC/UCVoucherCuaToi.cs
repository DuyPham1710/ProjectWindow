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
    public partial class UCVoucherCuaToi : UserControl
    {
        private int id;
        Voucher voucher;
        public event EventHandler BtnClick_sua;
        public event EventHandler BtnClick_xoa;
        public UCVoucherCuaToi(Voucher voucher, int id)
        {
            InitializeComponent();
            this.voucher = voucher;
            this.id = id;
        }

        private void UCVoucherCuaToi_Load(object sender, EventArgs e)
        {
            lblMoTa.Text = voucher.MoTa;
            lblMaVoucher.Text = voucher.MaVoucher;
            lblSoLuong.Text = voucher.SoLuong.ToString();
            lblGiaTri.Text = voucher.GiaTri.ToString();
            lblHSD.Text = voucher.HSD.ToString("dd/MM/yyyy");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            BtnClick_sua?.Invoke(this, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BtnClick_xoa?.Invoke(this, e);
        }
    }
}
