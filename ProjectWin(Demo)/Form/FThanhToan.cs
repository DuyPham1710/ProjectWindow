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
        int id;
        string[] AnhCu = { };
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
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
            int tongTien = 0;
            foreach (SanPham sp in sanPham)
            {
                //try
                //{
                //    conn.Open();
                //    string query = string.Format("Select * from SanPham WHERE MSP = '{0}'", sp.MaSP);
                //    MessageBox.Show(query);
                //    SqlCommand cmd = new SqlCommand(query, conn);
                //    SqlDataReader reader = cmd.ExecuteReader();
                //    if (reader.Read())
                //    {
                //        SanPham sps = new SanPham((string)reader["MSP"], (int)reader["IDChuSP"], (string)reader["TenSP"], (string)reader["DanhMuc"], (string)reader["GiaTienLucMoiMua"],
                //        (string)reader["GiaTienBayGio"], (DateTime)reader["NgayMuaSP"], (string)reader["SoLuong"], (string)reader["XuatXu"], (string)reader["BaoHanh"], (string)reader["TinhTrang"], (string)reader["MotaTinhTrang"], (string)reader["MotaSP"], (string)reader["AnhLucMoiMua"], (string)reader["AnhBayGio"]);
                //MessageBox.Show((string)reader["TenSP"] + " " + (string)reader["GiaTienBayGio"] + " " + (string)reader["AnhBayGio"]);
                //sp.IDChuSP = (int)reader["IDChuShop"];
                //sp.TenSP = (string)reader["TenSP"];
                //sp.GiaHienTai = (string)reader["GiaTienBayGio"];
                //sp.DanhMuc = (string)reader["DanhMuc"];
                //sp.AnhHienTai = (string)reader["AnhBayGio"];
                tongTien = tongTien + Int32.Parse(sp.GiaHienTai);
                        UCSanPhamMua ucSPMua = new UCSanPhamMua(sp, id);
                        ucSPMua.btnHuyDon.Hide();
                        FPanelSanPham.Controls.Add(ucSPMua);
                lblTongTien.Text = "Tổng tiền: " + tongTien.ToString();
                //lblTenSP.Text = sp.TenSP;
                //lblMaSP.Text = sp.MaSP;
                //lblSoLuong.Text = sp.SoLuong;
                //lblGia.Text = sp.GiaHienTai;
                //lblDanhMuc.Text = sp.DanhMuc;
                //if (sp.AnhHienTai != "")
                //    AnhCu = sp.AnhHienTai.Split(',');
                //if (AnhCu.Length > 0)
                //{
                //    Bitmap bitmap = new Bitmap(Application.StartupPath + "\\AnhSanPham\\" + sp.MaSP + "\\" + AnhCu[0]);
                //    pctSanPham.Image = bitmap;
                //}
                //else
                //    pctSanPham.Image = null;
                //    }
                //}
                //catch { }
                //finally { conn.Close(); }

                //txtTenSP.Text = sp.TenSP;
                //txtPhanLoai.Text = sp.DanhMuc;
                //txtGia.Text = (Decimal.Parse(sp.GiaHienTai) * nudSoLuong.Value).ToString() + "đ";
                //lblTongTien.Text = (Decimal.Parse(sp.GiaHienTai) * nudSoLuong.Value).ToString() + "đ";
                DateTime date = DateTime.Now;
                txtNgay.Text = date.Day.ToString();
                txtThang.Text = date.Month.ToString();
                txtNam.Text = date.Year.ToString();
                //if (sp.AnhHienTai != "")
                //    AnhCu = sp.AnhHienTai.Split(',');
                //if (AnhCu.Length > 0)
                //{
                //    Bitmap bitmap = new Bitmap(Application.StartupPath + "\\AnhSanPham\\" + sp.MaSP + "\\" + AnhCu[0]);
                //    pctSanPham.Image = bitmap;
                //}
                //else
                //    pctSanPham.Image = null;
                //try
                //{
                //    conn.Open();
                //    string query = "select * from Person where ID = " + id;
                //    SqlCommand cmd = new SqlCommand(query, conn);
                //    SqlDataReader reader = cmd.ExecuteReader();
                //    if (reader.Read())
                //    {
                //        txtHoTen.Text = (string)reader["FullName"];
                //        txtSoDT.Text = (string)reader["Phone"];
                //        txtDiaChi.Text = (string)reader["Addr"];
                //    }

                //}
                //catch { }
                //finally { conn.Close(); }
            }   
            
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
            UCSanPhamMua uCSanPhamMua = sender as UCSanPhamMua;
            foreach (SanPham sp in sanPham)
            {
                SPDao.DatHang(sp, nudSoLuong.Value);
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
            FDiaChiNhanHang fDCNH = new FDiaChiNhanHang(id);
            fDCNH.ShowDialog();
        }

        private void nudSoLuong_ValueChanged(object sender, EventArgs e)
        {        
            //if (nudSoLuong.Value > Decimal.Parse(sp.SoLuong))
            //{
            //    nudSoLuong.Value = Decimal.Parse(sp.SoLuong);
            //}
            //else if (nudSoLuong.Value == 0)
            //{
            //    nudSoLuong.Value = 1;
            //}
            //else
            //{
            //    lblTongTien.Text = (nudSoLuong.Value * Decimal.Parse(sp.GiaHienTai)).ToString() + "đ";
            //}
        }
    }
}
