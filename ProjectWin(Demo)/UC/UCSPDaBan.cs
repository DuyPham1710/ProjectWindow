using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWin_Demo_
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
            lblMaSP.Text = sp.MaSP;
            lblTenSP.Text = sp.TenSP;
            lblGia.Text = (Int32.Parse(sp.GiaHienTai) * Int32.Parse(sp.SoLuong)).ToString() + "đ";
            lblSoLuongSP.Text = sp.SoLuong;
            lblPhanLoai.Text = sp.DanhMuc;

            if (sp.AnhHienTai != "")
                AnhCu = sp.AnhHienTai.Split(',');
            if (AnhCu.Length > 0)
            {
                Bitmap bitmap = new Bitmap(Application.StartupPath + "\\AnhSanPham\\" + sp.MaSP + "\\" + AnhCu[0]);
                pctSanPham.Image = bitmap;
            }
            else
                pctSanPham.Image = null;
        }
    }
}
