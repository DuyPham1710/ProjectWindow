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
    public partial class UCSPCuaToi : UserControl
    {
        public event EventHandler BtnClick_sua;
        public event EventHandler BtnClick_xoa;
        private SanPham sp;
        private string[] AnhCu = { };
        public UCSPCuaToi(SanPham sp)
        {
            InitializeComponent();
            this.sp = sp;
        }
        private void UCSPCuaToi_Load(object sender, EventArgs e)
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
        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            BtnClick_sua?.Invoke(this, e);
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            BtnClick_xoa?.Invoke(this, e);
        }

        private void UCSPCuaToi_MouseHover(object sender, EventArgs e)
        {
            pctSanPham.SizeMode = PictureBoxSizeMode.StretchImage;
            ShadowPanel.FillColor = Color.LightCyan;
            this.BackColor = Color.LightCyan;
        }

        private void UCSPCuaToi_MouseLeave(object sender, EventArgs e)
        {
            pctSanPham.SizeMode = PictureBoxSizeMode.Zoom;
            ShadowPanel.FillColor = Color.White;
            this.BackColor = Color.White;
        }   
    }
}
