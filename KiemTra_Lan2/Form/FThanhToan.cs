using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTra_Lan2
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
        int tongGia = 0;
        string[] AnhCu = { };
        TraoDoiHangDF db = new TraoDoiHangDF();
        public FThanhToan(List<SanPham> sanPham, int id)
        {
            InitializeComponent();
            this.sanPham = sanPham;
            this.id = id;

        }
        private void FThanhToan_Load(object sender, EventArgs e)
        {
            FPanelSanPham.Controls.Clear();
            int tongTienSP = 0;
            foreach (SanPham sp in sanPham)
            {
                tongGia += Int32.Parse(sp.GiaTienBayGio);
                giaBanDau.Add(sp.GiaTienBayGio);
                tongTienSP = tongTienSP + Int32.Parse(sp.GiaTienBayGio);
                UCSPDatHang ucSPDatHang = new UCSPDatHang(sp, id);
                ucSPDatHang.BtnClick_ChonVoucher += btnChonVoucher_Click;
                FPanelSanPham.Controls.Add(ucSPDatHang);
            }
          
            Person nguoiMua = (from nguoi in db.People
                            join account in db.Accounts on nguoi.ID equals account.ID
                            where account.ID == id
                            select nguoi).SingleOrDefault();

            lblHoTen.Text = nguoiMua.FullName;
            lblSdt.Text = nguoiMua.Phone;
            lblDiaChi.Text = nguoiMua.Addr;
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

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (SanPham sp in sanPham)
            {
                if (MaVouchers.Count == 0 || MaVouchers.Count < i + 1)
                {
                    DatHang(sp, "");
                    i++;
                }
                else
                {
                    if (MaVouchers[i].ContainsKey(sp.MSP))
                    {
                        DatHang(sp, MaVouchers[i][sp.MSP]);
                        i++;
                    }
                    else
                    {
                        DatHang(sp, "");
                    }
                }

            }
            MessageBox.Show("Đặt hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        public void DatHang(SanPham sp, string maVoucher)
        {
            DaMua daMua = new DaMua
            {
                ID = id,
                MSP = sp.MSP,
                TrangThai = "Chờ xác nhận",
                SoLuongDaMua = sp.SoLuong,
                MaVoucher = maVoucher,
                Gia = Int32.Parse(sp.GiaTienBayGio),
                ThoiGianHienTai = DateTime.Now,
                ThoiGianDat = DateTime.Now
            };
            db.DaMuas.Add(daMua);
            db.SaveChanges();

            // Cập nhật số lượng sản phẩm
            var soLuongBanDau = (from sanPham in db.SanPhams
                           where sanPham.MSP == sp.MSP
                           select sanPham.SoLuong).SingleOrDefault();
            SanPham sanPham1 = db.SanPhams.Find(sp.MSP);
            sanPham1.SoLuong = (Int32.Parse(soLuongBanDau) - Decimal.Parse(sp.SoLuong)).ToString();
            db.SaveChanges();

            // Cập nhật voucher
            if (maVoucher != "") 
            {
                Voucher voucher = db.Vouchers.Find(maVoucher);
                voucher.SoLuongVoucher = voucher.SoLuongVoucher - 1;
                db.SaveChanges();
            }
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

            var maxMaDiaChi = db.DiaChiGiaoHangs.Where(diaChi => diaChi.IDNguoiMua == id).Max(diaChi => diaChi.MaDiaChi);
            var thongTinNhanHang = (from diaChi in db.DiaChiGiaoHangs
                                             where diaChi.MaDiaChi == maxMaDiaChi
                                             select diaChi).SingleOrDefault();

            lblHoTen.Text = thongTinNhanHang.HoTen;
            lblSdt.Text = thongTinNhanHang.soDT;
            lblDiaChi.Text = thongTinNhanHang.DiaChiNhanHang;
        }

        private void btnChonVoucher_Click(object sender, EventArgs e)
        {
            UCSPDatHang ucSPDatHang = sender as UCSPDatHang;
            FVoucher fVoucher = new FVoucher(id, ucSPDatHang.lblMaSP.Text);
            fVoucher.ShowDialog();
            if (fVoucher.MaVoycher.Count != 0)
            {
                MaVouchers.Add(fVoucher.MaVoycher);
                var maVoucher = fVoucher.MaVoycher[ucSPDatHang.lblMaSP.Text];
                Voucher voucher = (from v in db.Vouchers
                                   where v.MaVoucher == maVoucher
                                   select v).SingleOrDefault();

                if (voucher != null)
                {
                    int i = 0, tongGiaHienTai = 0;
                    foreach (SanPham sp in sanPham)
                    {
                        if (sp.MSP == ucSPDatHang.lblMaSP.Text)
                        {
                            sp.GiaTienBayGio = (Int32.Parse(giaBanDau[i]) - voucher.GiaTri).ToString();
                            ucSPDatHang.lblGia.Text = sp.GiaTienBayGio;
                        }
                        else
                        {
                            i++;
                        }
                        tongGiaHienTai += Int32.Parse(sp.GiaTienBayGio);

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
