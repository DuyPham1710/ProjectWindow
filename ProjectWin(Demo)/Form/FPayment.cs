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
    public partial class FPayment : Form
    {
        private bool isDragging;
        private Point lastCursor;
        private Point lastForm;
        Product sp;
        int id;
        string[] AnhCu = { };
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public FPayment(Product sp, Decimal soLuongSP, int id)
        {
            InitializeComponent();
            this.sp = sp;
            nudSoLuong.Value = soLuongSP;
            this.id = id;
        }

        private void FPayment_Load(object sender, EventArgs e)
        {
            txtTenSP.Text = sp.TenSP;
            txtPhanLoai.Text = sp.DanhMuc;
            txtGia.Text = (Decimal.Parse(sp.GiaHienTai) * nudSoLuong.Value).ToString() + "đ";
            DateTime date = DateTime.Now; 
            txtNgay.Text = date.Day.ToString();
            txtThang.Text = date.Month.ToString();
            txtNam.Text = date.Year.ToString();
            if (sp.AnhHienTai != "")
                AnhCu = sp.AnhHienTai.Split(',');
            if (AnhCu.Length > 0)
            {
                Bitmap bitmap = new Bitmap(Application.StartupPath + "\\AnhSanPham\\" + sp.MaSP + "\\" + AnhCu[0]);
                pctSanPham.Image = bitmap;
            }
            else
                pctSanPham.Image = null;
            try
            {
                conn.Open();
                string query = "select * from Person where ID = " + id;
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtHoTen.Text = (string)reader["FullName"];
                    txtSoDT.Text = (string)reader["Phone"];
                    txtDiaChi.Text = (string)reader["Addr"];
                }

            }
            catch { }
            finally { conn.Close(); }

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

        private void btnOrder_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("INSERT INTO DaMua(ID, MSP, TrangThai) VALUES ('{0}', '{1}', N'{2}')",
                        id, sp.MaSP, "Chờ xác nhận");
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Đặt hàng thành công", "Thông báo");
                    this.Close();
                }
            }
            catch { }
            finally { conn.Close(); }
            
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
            FDiaChiNhanHang fDCNH = new FDiaChiNhanHang();
            fDCNH.ShowDialog();
        }
    }
}
