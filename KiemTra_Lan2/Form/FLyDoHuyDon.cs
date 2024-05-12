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
    public partial class FLyDoHuyDon : Form
    {
        private bool isDragging;
        private Point lastCursor;
        private Point lastForm;

        private SanPham sp;
        private int id;
        private int maVanChuyen;
        TraoDoiHangDF db = new TraoDoiHangDF();
        public FLyDoHuyDon(SanPham sp, int id, int maVanChuyen)
        {
            InitializeComponent();
            this.sp = sp;
            this.id = id;
            this.maVanChuyen = maVanChuyen;
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string lyDo = "";
            foreach (Control control in Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    lyDo = radioButton.Text;
                }
            }

            SanPhamHuy sanPhamHuy = new SanPhamHuy
            {
                ID = id, 
                MSP = sp.MSP, 
                LyDoHuy = lyDo, 
                ThoiGianHuy = DateTime.Now
            };
            db.SanPhamHuys.Add(sanPhamHuy);
            db.SaveChanges();

            var soLuongDaMua = (from daMua in db.DaMuas
                                where daMua.MaVanChuyen == maVanChuyen
                                select daMua.SoLuongDaMua).FirstOrDefault();

            // cập nhật lại số lượng ban đầu khi hủy đơn
            DaMua d = db.DaMuas.Find(maVanChuyen);
            d.TrangThai = "Đã hủy";
            d.ThoiGianHienTai = DateTime.Now;
            db.SaveChanges();

            SanPham sanPham = db.SanPhams.Find(sp.MSP);
            sanPham.SoLuong = (Int32.Parse(sanPham.SoLuong) + Int32.Parse(soLuongDaMua)).ToString();
            db.SaveChanges();
            this.Close();
        }
        private void btnDong_Click(object sender, EventArgs e)
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
