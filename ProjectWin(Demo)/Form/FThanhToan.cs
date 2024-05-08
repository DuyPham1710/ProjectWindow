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
    public partial class FThanhToan : Form
    {
        private bool isDragging;
        private Point lastCursor;
        private Point lastForm;

        //SanPham sp;
        List<SanPham> sanPham = new List<SanPham>();
        List<string> MaVouchers = new List<string>();
        int id;
        string[] AnhCu = { };
        SanPhamDao SPDao;
        //public FThanhToan(SanPham sp, Decimal soLuongSP, int id)
        //{
        //    InitializeComponent();
        //    this.sp = sp;
        //    nudSoLuong.Value = soLuongSP;
        //    this.id = id;
        //    SPDao = new SanPhamDao(id);
        //}
        public FThanhToan(List<SanPham> sanPham, int id)
        {
            InitializeComponent();
            this.sanPham = sanPham;
            this.id = id;
            SPDao = new SanPhamDao(id);

        }
        private void FThanhToan_Load(object sender, EventArgs e)
        {
            FPanelSanPham.Controls.Clear();
            int tongTienSP = 0;
            foreach (SanPham sp in sanPham)
            {
                tongTienSP = tongTienSP + Int32.Parse(sp.GiaHienTai);
                UCSPDatHang ucSPDatHang = new UCSPDatHang(sp, id);
                ucSPDatHang.BtnClick_ChonVoucher += btnChonVoucher_Click;
                FPanelSanPham.Controls.Add(ucSPDatHang);
            }
            NguoiDAO nguoiDAO = new NguoiDAO(id);
            Nguoi nguoiMua = nguoiDAO.LoadThongTinCaNhan();
            lblHoTen.Text = nguoiMua.FullName;
            lblSdt.Text = nguoiMua.PhoneNumber;
            lblDiaChi.Text = nguoiMua.Address;
            DateTime date = DateTime.Now;
            txtNgay.Text = date.Day.ToString();
            txtThang.Text = date.Month.ToString();
            txtNam.Text = date.Year.ToString();
            lblTienSP.Text = tongTienSP.ToString();
            lblTongTien.Text = tongTienSP.ToString() + "đ";
        }

        private void pictureBoxPayMethod_MouseHover(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            // pictureBox.BackColor = Color.Pink;
        }

        private void pictureBoxPayMethod_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox.BackColor = Color.LavenderBlush;
        }

        private void pictureBoxPayMethod_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox.BorderStyle == BorderStyle.None)
            {
                pictureBox.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                pictureBox.BorderStyle = BorderStyle.None;
            }
            foreach (Control control in Controls)
            {
                if (control is PictureBox picture && picture != pictureBox)
                {
                    picture.BorderStyle = BorderStyle.None;
                }
            }
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            UCSPDatHang uCSPDatHang = sender as UCSPDatHang;
            int i = 0;
            foreach (SanPham sp in sanPham)
            {
                if (MaVouchers.Count == 0)
                {
                    SPDao.DatHang(sp, "");
                }
                else
                {
                    SPDao.DatHang(sp, MaVouchers[i]);
                    i++;
                }
              
            }
            this.Close();
            //try
            //{
            //    conn.Open();
            //    string sqlStr = string.Format("INSERT INTO DaMua(ID, MSP, TrangThai) VALUES ('{0}', '{1}', N'{2}')",
            //            id, sp.MaSP, "Chờ xác nhận");
            //    string query = string.Format("UPDATE SanPham SET SoLuong = '{0}' WHERE MSP = '{1}'", (Decimal.Parse(sp.SoLuong) - nudSoLuong.Value).ToString(), sp.MaSP);
            //    SqlCommand cmd = new SqlCommand(sqlStr, conn);

            //    if (cmd.ExecuteNonQuery() > 0)
            //    {
            //        MessageBox.Show("Đặt hàng thành công", "Thông báo");
            //        this.Close();
            //    }
            //}
            //catch (Exception ex){ }
            //finally { conn.Close(); }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastForm = this.Location;
            }
        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentCursor = Cursor.Position;
                this.Location = new Point(lastForm.X + (currentCursor.X - lastCursor.X), lastForm.Y + (currentCursor.Y - lastCursor.Y));
            }
        }

        private void panel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void btnThayDoiDC_Click(object sender, EventArgs e)
        {
            FDiaChiNhanHang fDCNH = new FDiaChiNhanHang(id, sanPham);
            fDCNH.ShowDialog();
            DiaChiGiaoHangDAO DiaChiDAO = new DiaChiGiaoHangDAO(id);
            List<string> thongTinNhanHang= DiaChiDAO.LoadDiaChiMoi();
            lblHoTen.Text = thongTinNhanHang[0];
            lblSdt.Text = thongTinNhanHang[1];
            lblDiaChi.Text = thongTinNhanHang[2];
        }

        //private void nudSoLuong_ValueChanged(object sender, EventArgs e)
        //{        
        //    //if (nudSoLuong.Value > Decimal.Parse(sp.SoLuong))
        //    //{
        //    //    nudSoLuong.Value = Decimal.Parse(sp.SoLuong);
        //    //}
        //    //else if (nudSoLuong.Value == 0)
        //    //{
        //    //    nudSoLuong.Value = 1;
        //    //}
        //    //else
        //    //{
        //    //    lblTongTien.Text = (nudSoLuong.Value * Decimal.Parse(sp.GiaHienTai)).ToString() + "đ";
        //    //}
        //}

        private void btnChonVoucher_Click(object sender, EventArgs e)
        {
            UCSPDatHang ucSPDatHang = sender as UCSPDatHang;
            FVoucher fVoucher = new FVoucher(id, ucSPDatHang.lblMaSP.Text);
            fVoucher.ShowDialog();
            if (fVoucher.MaVoucher != "") 
            {
                MaVouchers.Add(fVoucher.MaVoucher);
            }
            
            VoucherDAO voucherDAO = new VoucherDAO(id);
            int GiatriVoucher = voucherDAO.GiaVoucher(fVoucher.MaVoucher);
            lblTienVoucher.Text = (Int32.Parse(lblTienVoucher.Text) + GiatriVoucher).ToString();
            lblTongTien.Text = (Int32.Parse(lblTienSP.Text) - Int32.Parse(lblTienVoucher.Text)).ToString() + "đ";
        }
    }
}
