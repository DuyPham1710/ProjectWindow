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
    public partial class UCSPDatHang : UserControl
    {
        SanPham sp;
        int id;
        string[] AnhCu = { };
        public event EventHandler BtnClick_ChonVoucher;
        public UCSPDatHang(SanPham sp, int id)
        {
            InitializeComponent();
            this.sp = sp;
            this.id = id;
        }

        private void UCSPDatHang_Load(object sender, EventArgs e)
        {
            lblTenSP.Text = sp.TenSP;
            lblMaSP.Text = sp.MSP;
            lblSoLuong.Text = sp.SoLuong;
            lblGia.Text = sp.GiaTienBayGio;
            lblDanhMuc.Text = sp.DanhMuc;
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

        private void btnChonVoucher_Click(object sender, EventArgs e)
        {
            BtnClick_ChonVoucher?.Invoke(this, e);
        }
    }
}
