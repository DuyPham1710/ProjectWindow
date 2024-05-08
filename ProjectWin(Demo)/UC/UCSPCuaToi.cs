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
    public partial class UCSPCuaToi : UserControl
    {
        SanPham sp;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        string[] AnhCu = { };
        public event EventHandler BtnClick_edit;
        public event EventHandler BtnClick_delete;
        public UCSPCuaToi(SanPham sp)
        {
            InitializeComponent();
            this.sp = sp;
        }
        private void UCMyProduct_Load(object sender, EventArgs e)
        {
            lblTenSP.Text = sp.TenSP;
            lblMaSP.Text = sp.MaSP;
            lblSoLuong.Text = sp.SoLuong;
            lblGia.Text = sp.GiaHienTai;
            lblDanhMuc.Text = sp.DanhMuc;
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

        private void pcbDelete_MouseHover(object sender, EventArgs e)
        {
            pctSanPham.SizeMode = PictureBoxSizeMode.StretchImage;
            ShadowPanel.FillColor = Color.LightCyan;
            this.BackColor = Color.LightCyan;
        }

        private void pcbDelete_MouseLeave(object sender, EventArgs e)
        {
            pctSanPham.SizeMode = PictureBoxSizeMode.Zoom;
            ShadowPanel.FillColor = Color.White;
            this.BackColor = Color.White;
        }

        private void pcbDelete_Click(object sender, EventArgs e)
        {
            BtnClick_delete?.Invoke(this, e);
        }

        private void pcbEdit_Click(object sender, EventArgs e)
        {
            BtnClick_edit?.Invoke(this, e);
        }
    }
}
