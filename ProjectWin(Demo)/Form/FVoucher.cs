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
    public partial class FVoucher : Form
    {
        private int id;
        VoucherDAO voucherDAO;
        List<UCVoucher> Vouchers;
        private string maSP;
        Dictionary<string, string> maVoycher = new Dictionary<string, string>();
        public Dictionary<string, string> MaVoycher { get => maVoycher; set => maVoycher = value; }

        public FVoucher(int id, string maSP)
        {
            InitializeComponent();
            this.id = id;
            voucherDAO = new VoucherDAO(id);
            this.maSP = maSP;
        }

        private void FVoucher_Load(object sender, EventArgs e)
        {
            List<UCVoucher> vouchers = voucherDAO.LoadVoucher<UCVoucher>(maSP);
            
            Vouchers = vouchers;
            if (vouchers.Count == 0)
            {
                fPanelVoucher.Hide();
            }
            else
            {
                fPanelVoucher.Controls.Clear();
                foreach (UCVoucher voucher in vouchers)
                {
                    voucher.BtnClick_ApDung += btnApDung_Click;
                    fPanelVoucher.Controls.Add(voucher);
                }
            }     
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApDung_Click(object sender, EventArgs e)
        {
            UCVoucher ucVoucher = sender as UCVoucher;
            MaVoycher[maSP] = ucVoucher.lblMaVoucher.Text;
            MessageBox.Show("Đã chọn voucher " + MaVoycher[maSP]);        
            this.Close();
        }

        private void btnMaVoucher_Click(object sender, EventArgs e)
        {
            if (voucherDAO.KiemTraVoucher(txtTimKiem.Text))
            {
                MaVoycher[maSP] = txtTimKiem.Text;
                MessageBox.Show("Đã chọn voucher " + MaVoycher[maSP]);
                this.Close();
            }
            else
            {
                MessageBox.Show("Voucher không tồn tại");
            }
        }
    }
}
