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
    public partial class FTuyChinhVoucher : Form
    {
        private bool isDragging;
        private Point lastCursor;
        private Point lastForm;

        private int id;
        private string maVoucher;
        private string thaoTac;
        private string maVoucherCu;
        TraoDoiHangDF db = new TraoDoiHangDF();
        public FTuyChinhVoucher(int id, string maVoucher, string thaoTac)
        {
            InitializeComponent();
            this.id = id;
            this.maVoucher = maVoucher;
            this.thaoTac = thaoTac;

        }
        private void FTuyChinhVoucher_Load(object sender, EventArgs e)
        {
            if (thaoTac == "Them")
            {
                lblTieuDe.Text = "Thêm Voucher";
            }
            else
            {
                lblTieuDe.Text = "Sửa Voucher";
                btnThem.Text = "Sửa";
                Voucher voucher = (from v in db.Vouchers where v.MaVoucher == maVoucher select v).SingleOrDefault();
                txtMaVoucher.Text = voucher.MaVoucher;
                maVoucherCu = voucher.MaVoucher;
                txtMota.Text = voucher.Mota;
                txtGiaTri.Text = voucher.GiaTri.ToString();
                DtpHSD.Value = (DateTime)voucher.HSD;
                nudSoLuong.Value = decimal.Parse(voucher.SoLuongVoucher.ToString());
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
         
            if (thaoTac == "Them")
            {
                Voucher voucher = new Voucher
                {
                    ID = id,
                    GiaTri = Int32.Parse(txtGiaTri.Text),
                    SoLuongVoucher = Int32.Parse(nudSoLuong.Value.ToString()),
                    MaVoucher = txtMaVoucher.Text,
                    Mota = txtMota.Text,
                    HSD = DtpHSD.Value
                };
                db.Vouchers.Add(voucher);
                db.SaveChanges();
            }
            else
            {
                
                Voucher voucher = db.Vouchers.FirstOrDefault(v => v.ID == id && v.MaVoucher == maVoucherCu);
                voucher.MaVoucher = txtMaVoucher.Text;
                voucher.Mota = txtMota.Text;
                voucher.GiaTri = Int32.Parse(txtGiaTri.Text);
                voucher.HSD = DtpHSD.Value;
                voucher.SoLuongVoucher = Int32.Parse(nudSoLuong.Value.ToString());
                db.SaveChanges();
            }
            this.Close();
        }
        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastForm = this.Location;
            }
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentCursor = Cursor.Position;
                this.Location = new Point(lastForm.X + (currentCursor.X - lastCursor.X), lastForm.Y + (currentCursor.Y - lastCursor.Y));
            }
        }

        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }
    }
}
