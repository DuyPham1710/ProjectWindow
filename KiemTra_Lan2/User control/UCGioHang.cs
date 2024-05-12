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
    public partial class UCGioHang : UserControl
    {
        private int id;
        private SanPham sp;
        public event EventHandler BtnClick_ChiTiet;
        public event EventHandler BtnClick_Xoa;
        public event EventHandler BtnClick_Chon;
        string[] AnhCu = { };
       
        private int soLuong;
        public UCGioHang(SanPham sp, int id, int soLuong)
        {
            InitializeComponent();
            this.id = id;
            this.sp = sp;
            this.soLuong = soLuong;
        }
        private void UCGioHang_Load(object sender, EventArgs e)
        {
            lblTenSP.Text = sp.TenSP;
            lblMaSP.Text = sp.MSP;
            nudSoLuong.Value = soLuong;
            lblGia.Text = sp.GiaTienBayGio;
            lblDanhMuc.Text = sp.DanhMuc;
            lblTongTien.Text = (nudSoLuong.Value * Decimal.Parse(sp.GiaTienBayGio)).ToString();
            if (sp.AnhBayGio != "")
                AnhCu = sp.AnhBayGio.Split(',');
            if (AnhCu.Length > 0)
            {
                Bitmap bitmap = new Bitmap(Application.StartupPath + "\\AnhSanPham\\" + sp.MSP + "\\" + AnhCu[0]);
                pctSanPham.Image = bitmap;
            }
            else
                pctSanPham.Image = null;
        }
        private void pcbBin_Click(object sender, EventArgs e)
        {
            BtnClick_Xoa?.Invoke(this, e);
        }
        private void panel1_Click(object sender, EventArgs e)
        {
            BtnClick_ChiTiet?.Invoke(this, e);
        }

        private void cbChonSP_Click(object sender, EventArgs e)
        {
            BtnClick_Chon?.Invoke(this, e);
        }
        private void nudSoLuong_ValueChanged(object sender, EventArgs e)
        {
            lblTongTien.Text = (nudSoLuong.Value * Decimal.Parse(sp.GiaTienBayGio)).ToString();
        }

        private void panelGioHanh_MouseHover(object sender, EventArgs e)
        {
            panelGioHanh.BackColor = Color.LightCyan;
        }

        private void panelGioHanh_MouseLeave(object sender, EventArgs e)
        {
            panelGioHanh.BackColor = Color.White;
        }
    }
}
