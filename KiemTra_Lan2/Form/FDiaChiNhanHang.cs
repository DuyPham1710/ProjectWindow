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
    public partial class FDiaChiNhanHang : Form
    {
        private bool isDragging;
        private Point lastCursor;
        private Point lastForm;

        private int id;
        List<SanPham> cacSanPham;
        TraoDoiHangDF db = new TraoDoiHangDF();
        public FDiaChiNhanHang(int id, List<SanPham> cacSanPham)
        {
            InitializeComponent();
            this.id = id;
            this.cacSanPham = cacSanPham;
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string cacMaSP = "";
            foreach (SanPham sp in cacSanPham)
            {
                cacMaSP = cacMaSP + sp.MSP + ", ";
            }
            DiaChiGiaoHang dc = new DiaChiGiaoHang 
            {
                IDNguoiMua = id, 
                MSP = cacMaSP, 
                HoTen = txtHoTen.Text, 
                soDT = txtSoDT.Text, 
                DiaChiNhanHang = txtDiaChiNhanHang.Text, 
                ThoiGianThayDoi = DateTime.Now
            };
            db.DiaChiGiaoHangs.Add(dc);
            db.SaveChanges();
            //DiaChiDAO.DiaChiNhanHang(txtHoTen.Text, cacMaSP, txtSoDT.Text, txtDiaChiNhanHang.Text);
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
