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
    public partial class UCSPDaBan : UserControl
    {
        SanPham sp;
        private int id;
        string[] AnhCu = { };
        public UCSPDaBan(SanPham sp, int id)
        {
            InitializeComponent();
            this.sp = sp;
            this.id = id;
        }

        private void UCSPDaBan_Load(object sender, EventArgs e)
        {
            lblMaSP.Text = sp.MSP;
            lblTenSP.Text = sp.TenSP;
            lblGia.Text = (Int32.Parse(sp.GiaTienBayGio) * Int32.Parse(sp.SoLuong)).ToString() + "đ";
            lblSoLuongSP.Text = sp.SoLuong;
            lblPhanLoai.Text = sp.DanhMuc;

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
    }
}
