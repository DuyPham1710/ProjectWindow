using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTra_Lan2
{
    public partial class FVoucher : Form
    {
        private int id;

        private string maSP;
        TraoDoiHangDF db = new TraoDoiHangDF();
        Dictionary<string, string> maVoycher = new Dictionary<string, string>();
        public Dictionary<string, string> MaVoycher { get => maVoycher; set => maVoycher = value; }

        public FVoucher(int id, string maSP)
        {
            InitializeComponent();
            this.id = id;
            this.maSP = maSP;
        }

        private void FVoucher_Load(object sender, EventArgs e)
        {
            var IDChuSP = (from sanPham in db.SanPhams
                           where sanPham.MSP == maSP
                           select sanPham.IDChuSP).FirstOrDefault();

            List<Voucher> vouchers = (from voucher in db.Vouchers
                                     join account in db.Accounts on voucher.ID equals account.ID
                                     where voucher.ID == IDChuSP
                                      select voucher).Distinct().ToList();
           
            if (vouchers.Count == 0)
            {
                fPanelVoucher.Hide();
            }
            else
            {
                fPanelVoucher.Controls.Clear();
                foreach (Voucher voucher in vouchers)
                {
                    UCVoucher ucVoucher = new UCVoucher(voucher, id);
                  
                    ucVoucher.BtnClick_ApDung += btnApDung_Click;
                    fPanelVoucher.Controls.Add(ucVoucher);
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
            int kiemTraVoucher = (from Voucher in db.Vouchers
                                  where Voucher.MaVoucher == txtTimKiem.Text
                                  select Voucher).Count();
            if (kiemTraVoucher != 0)
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
