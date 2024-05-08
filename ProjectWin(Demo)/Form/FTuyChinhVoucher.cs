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
    public partial class FTuyChinhVoucher : Form
    {
        private bool isDragging;
        private Point lastCursor;
        private Point lastForm;

        private int id;
        private string maVoucher;
        VoucherDAO voucherDAO;
        private string thaoTac;
        private string maVoucherCu;
        public FTuyChinhVoucher(int id, string maVoucher, string thaoTac)
        {
            InitializeComponent();
            this.id = id;
            this.maVoucher = maVoucher;
            this.thaoTac = thaoTac;
            voucherDAO = new VoucherDAO(id);
            
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
                Voucher voucher = voucherDAO.LayVoucher(maVoucher);
                txtMaVoucher.Texts = voucher.MaVoucher;
                maVoucherCu = voucher.MaVoucher;
                txtMota.Texts = voucher.MoTa;
                txtGiaTri.Texts = voucher.GiaTri.ToString();
                DtpHSD.Value = voucher.HSD;
                nudSoLuong.Value = voucher.SoLuong;
            }
        }
        private void FThemVoucher_Load(object sender, EventArgs e)
        {
            if (thaoTac == "Them")
            {
                lblTieuDe.Text = "Thêm Voucher";
            }
            else
            {
                lblTieuDe.Text = "Sửa Voucher";
                btnThem.Text = "Sửa";
                Voucher voucher = voucherDAO.LayVoucher(maVoucher);
                txtMaVoucher.Texts = voucher.MaVoucher;
                maVoucherCu = voucher.MaVoucher;
                txtMota.Texts = voucher.MoTa;
                txtGiaTri.Texts = voucher.GiaTri.ToString();
                DtpHSD.Value = voucher.HSD;
                nudSoLuong.Value = voucher.SoLuong;    
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Voucher voucher = new Voucher(id, Int32.Parse(txtGiaTri.Texts), Int32.Parse(nudSoLuong.Value.ToString()), txtMaVoucher.Texts, txtMota.Texts, DtpHSD.Value);
            if (thaoTac == "Them")
            {
                voucherDAO.ThemVoucher(voucher);
            }
            else 
            {

                voucherDAO.suaVoucher(voucher, maVoucherCu);
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
