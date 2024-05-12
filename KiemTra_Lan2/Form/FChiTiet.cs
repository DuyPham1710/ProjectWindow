using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTra_Lan2
{
    public partial class FChiTiet : Form
    {
        SanPham sp;
        private bool isDragging;
        private Point lastCursor;
        private Point lastForm;
        string[] A = { };
        string[] AnhCu = { };
        string[] AnhMoi = { };
        int curr = 0;
        int id;
        TraoDoiHangDF db = new TraoDoiHangDF();
        public FChiTiet(SanPham sp, int id)
        {
            InitializeComponent();
            this.sp = sp;
            this.id = id;

        }
        private void FDetail_Load(object sender, EventArgs e)
        {
            lblTenSP.Text = sp.TenSP;
            lblGiaBanDau.Text = "<s>" + sp.GiaTienLucMoiMua + "đ</s>";
            lblGiaHienTai.Text = sp.GiaTienBayGio + "đ";
            lblSPConLai.Text = sp.SoLuong;
            lblXuatXu.Text = "Xuất xứ: " + sp.XuatXu;
            lblDanhMuc.Text = "Phân loại: " + sp.DanhMuc;
            lblTinhTrang.Text = "Tình trạng: " + sp.TinhTrang;
            lblBaoHanh.Text = "Bảo hành: " + sp.BaoHanh;
            rtbMoTaSP.Text = sp.MotaSP;
            rtbMoTaTinhTrang.Text = sp.MotaTinhTrang;
            DateTime dt = (DateTime)sp.NgayMuaSP;
            txtNgayMuaSP.Text = dt.Day.ToString();
            txtThangMuaSP.Text = dt.Month.ToString();
            txtNamMuaSP.Text = dt.Year.ToString();
            if (sp.AnhLucMoiMua != "")
                AnhMoi = sp.AnhLucMoiMua.Split(',');
            if (sp.AnhBayGio != "")
                AnhCu = sp.AnhBayGio.Split(',');
            A = AnhMoi;
            if (A.Length > 0)
            {
                Bitmap bitmap = new Bitmap(Application.StartupPath + "\\AnhSanPham\\" + sp.MSP + "\\" + A[curr]);
                pctSanPham.Image = bitmap;
            }
            else
                pctSanPham.Image = null;

            // Load dánh giá sản phẩm
            fPanelDanhGiaSP.Controls.Clear();

            var cacBinhLuan = (from person in db.People
                            join danhGia in db.DanhGias on person.ID equals danhGia.IDNguoiMua
                            join sanPham in db.SanPhams on danhGia.MSP equals sanPham.MSP
                            where sanPham.MSP == sp.MSP
                            select new 
                            {
                                person.ID,
                                person.FullName,
                                person.Avarta,
                                danhGia.BinhLuan,
                                danhGia.SoSao
                            }).ToList();
            foreach (var binhLuan in cacBinhLuan)
            {
                object avarta = binhLuan.Avarta;
                byte[] Avt = avarta != DBNull.Value ? (byte[])avarta : null;
                UCBinhLuan ucBinhLuan = new UCBinhLuan(binhLuan.ID, binhLuan.FullName, Avt, binhLuan.BinhLuan, binhLuan.SoSao.Value);

                fPanelDanhGiaSP.Controls.Add(ucBinhLuan);
            }

            // Load sản phẩm tương tự
            fPanelSPTuongTu.Controls.Clear();

            List<SanPham> cacSanPham = (from sanPham in db.SanPhams
                                        where sanPham.IDChuSP != id && sanPham.DanhMuc == sp.DanhMuc && sanPham.MSP != sp.MSP
                                        select sanPham).ToList();
            foreach (SanPham sanPham in cacSanPham)
            {
                UCSanPham ucSP = new UCSanPham(sanPham, id);
                ucSP.Padding = new Padding(0);
                ucSP.BtnClick_ChiTiet += UCChiTiet_Click;
                fPanelSPTuongTu.Controls.Add(ucSP);
            }

            //Load Thông tin shop
            var shop = (from nguoi in db.People join account in db.Accounts on nguoi.ID equals account.ID
                        where account.ID == sp.IDChuSP
                        select new
                        {
                            Person = nguoi,
                            Account = account
                        }).SingleOrDefault();
         
            if (shop != null)
            {
                if (shop.Person.Avarta != null)
                {
                    byte[] imageBytes = shop.Person.Avarta;
                    MemoryStream ms = new MemoryStream(imageBytes);
                    pcbAvt.Image = Image.FromStream(ms);
                }
                lblTenShop.Text = shop.Account.UserName;
                lblDiaChiShop.Text = shop.Person.Addr;
            }
        }
        private void UCChiTiet_Click(object sender, EventArgs e)
        {
            UCSanPham sp = sender as UCSanPham;
            SanPham sanPham = db.SanPhams.Where(p => p.MSP == sp.lblMaSP.Text).SingleOrDefault();
            FChiTiet fChiTiet = new FChiTiet(sanPham, id);
            fChiTiet.ShowDialog();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (A.Length > 0)
            {
                if (curr < A.Length - 1)
                    curr++;
                else
                    curr = 0;
                Bitmap bitmap = new Bitmap(Application.StartupPath + "\\AnhSanPham\\" + sp.MSP + "\\" + A[curr]);
                pctSanPham.Image = bitmap;
            }
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if (A.Length > 0)
            {
                if (curr > 0)
                    curr--;
                else
                    curr = A.Length - 1;

                Bitmap bitmap = new Bitmap(Application.StartupPath + "\\AnhSanPham\\" + sp.MSP + "\\" + A[curr]);
                pctSanPham.Image = bitmap;
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(lblSPConLai.Text) > 0)
            {
                List<SanPham> sanPham = new List<SanPham>();
                sp.SoLuong = nudSoLuong.Value.ToString();
                sp.GiaTienBayGio = (Int32.Parse(sp.GiaTienBayGio) * nudSoLuong.Value).ToString();
                sanPham.Add(sp);
                FThanhToan fPayment = new FThanhToan(sanPham, id);
                fPayment.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sản phẩm đã hết hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGioHang_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(lblSPConLai.Text) > 0)
            {
                var soLuong = (from gh in db.GioHangs
                               where gh.IDNguoiMua == id && gh.MSP == sp.MSP
                               select gh.SoLuong).Count();
                if (soLuong == 0)
                {
                    GioHang gh = new GioHang
                    {
                        IDNguoiMua = id,
                        MSP = sp.MSP,
                        SoLuong = int.Parse(nudSoLuong.Value.ToString())
                    };
                    db.GioHangs.Add(gh);
                    db.SaveChanges();
                }
                else
                {
                    GioHang gh = db.GioHangs.Find(sp.MSP);
                    gh.SoLuong += int.Parse(nudSoLuong.Value.ToString());
                    db.SaveChanges();
                }
                MessageBox.Show("Thêm và giỏ hàng thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Sản phẩm đã hết hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void pToolBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentCursor = Cursor.Position;
                this.Location = new Point(lastForm.X + (currentCursor.X - lastCursor.X), lastForm.Y + (currentCursor.Y - lastCursor.Y));
            }
        }

        private void pToolBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastForm = this.Location;
            }
        }

        private void pToolBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }
        private void rdbAnhBanDau_CheckedChanged(object sender, EventArgs e)
        {
            A = AnhMoi;
            curr = 0;
            if (AnhMoi.Length > 0)
            {
                Bitmap bitmap = new Bitmap(Application.StartupPath + "\\AnhSanPham\\" + sp.MSP + "\\" + A[curr]);
                pctSanPham.Image = bitmap;
            }
            else
                pctSanPham.Image = null;
        }

        private void rdbHienTai_CheckedChanged(object sender, EventArgs e)
        {
            A = AnhCu;
            curr = 0;
            if (AnhCu.Length > 0)
            {
                Bitmap bitmap = new Bitmap(Application.StartupPath + "\\AnhSanPham\\" + sp.MSP + "\\" + A[curr]);
                pctSanPham.Image = bitmap;
            }
            else
                pctSanPham.Image = null;
        }

        private void nudSoLuong_ValueChanged(object sender, EventArgs e)
        {
            if (nudSoLuong.Value > Decimal.Parse(sp.SoLuong))
            {
                nudSoLuong.Value = Decimal.Parse(sp.SoLuong);
            }
            else if (nudSoLuong.Value == 0)
            {
                nudSoLuong.Value = 1;
            }
        }

        private void btnXemTrang_Click(object sender, EventArgs e)
        {
            //FChiTietShop fChiTietShop = new FChiTietShop(id, sp.IDChuSP);
            //fChiTietShop.ShowDialog();
            //this.Close();
        }
    }
}
