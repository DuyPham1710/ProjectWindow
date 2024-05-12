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

        List<SanPham> sanPham = new List<SanPham>();
        List<Dictionary<string, string>> MaVouchers = new List<Dictionary<string, string>>();
        List<string> giaBanDau = new List<string>();    
        int id;
        string[] AnhCu = { };
        int tongGia = 0;
        SanPhamDao SPDao;
      
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
                tongGia += Int32.Parse(sp.GiaHienTai);
                giaBanDau.Add(sp.GiaHienTai);
                tongTienSP = tongTienSP + Int32.Parse(sp.GiaHienTai);
                UCSPDatHang ucSPDatHang = new UCSPDatHang(sp, id);
                ucSPDatHang.BtnClick_ChonVoucher += btnChonVoucher_Click;
                FPanelSanPham.Controls.Add(ucSPDatHang);
            }
            NguoiDAO nguoiDAO = new NguoiDAO(id);
            Nguoi nguoiMua = nguoiDAO.LoadThongTinCaNhan();
            lblHoTen.Text = nguoiMua.HoTen;
            lblSdt.Text = nguoiMua.SoDT;
            lblDiaChi.Text = nguoiMua.DiaChi;
            DateTime date = DateTime.Now;
            txtNgay.Text = date.Day.ToString();
            txtThang.Text = date.Month.ToString();
            txtNam.Text = date.Year.ToString();
            lblTienSP.Text = tongTienSP.ToString();
            lblTongTien.Text = tongTienSP.ToString();
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
            int i = 0;
            foreach (SanPham sp in sanPham)
            {
                if (MaVouchers.Count == 0 || MaVouchers.Count < i + 1)
                {
                    SPDao.DatHang(sp, "");
                    i++;
                }
                else
                {
                    if (MaVouchers[i].ContainsKey(sp.MaSP))
                    {
                        SPDao.DatHang(sp, MaVouchers[i][sp.MaSP]);
                        i++;
                    }
                    else
                    {
                        SPDao.DatHang(sp, "");
                    }
                }
                
            }
            MessageBox.Show("Đặt hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
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

        private void btnChonVoucher_Click(object sender, EventArgs e)
        {
            UCSPDatHang ucSPDatHang = sender as UCSPDatHang;
            FVoucher fVoucher = new FVoucher(id, ucSPDatHang.lblMaSP.Text);
            fVoucher.ShowDialog();
           
            if (fVoucher.MaVoycher.Count != 0)
            {
                MaVouchers.Add(fVoucher.MaVoycher);

                VoucherDAO voucherDAO = new VoucherDAO(id);
                Voucher voucher = voucherDAO.LayVoucher(fVoucher.MaVoycher[ucSPDatHang.lblMaSP.Text]);
                if (voucher != null)
                {
                    int i = 0, tongGiaHienTai = 0;
                    foreach (SanPham sp in sanPham)
                    {
                        if (sp.MaSP == ucSPDatHang.lblMaSP.Text)
                        {
                            sp.GiaHienTai = (Int32.Parse(giaBanDau[i]) - voucher.GiaTri).ToString();
                            ucSPDatHang.lblGia.Text = sp.GiaHienTai;
                        }
                        else
                        {
                            i++;
                        }
                        tongGiaHienTai += Int32.Parse(sp.GiaHienTai);

                    }
                    lblTienVoucher.Text = (tongGia - tongGiaHienTai).ToString();
                    int tongTien = (Int32.Parse(lblTienSP.Text) - Int32.Parse(lblTienVoucher.Text));
                    if (tongTien < 0)
                    {
                        lblTongTien.Text = "0";
                    }
                    else
                    {
                        lblTongTien.Text = tongTien.ToString();
                    }
                }
            }
           
        }
    }
}
