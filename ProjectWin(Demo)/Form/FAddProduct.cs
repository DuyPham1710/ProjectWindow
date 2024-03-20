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
    public partial class FAddProduct : Form
    {
        private bool isDragging;
        private Point lastCursor;
        private Point lastForm;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public FAddProduct()
        {
            InitializeComponent();
            btnUpdateProduct.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product(txtMaSP.Texts, txtTenSP.Texts, cbBoxDanhMuc.Text, txtGiaBanDau.Texts, txtGiaHienTai.Texts, cbBoxSoLuong.ToString(), txtXuatXu.Texts, txtGiaBanDau.Texts, txtTinhTrang.Texts, txtMoTaTinhTrang.Text, txtMoTaSP.Text, "", "", DtpNgayMua.Value);
            string sqlStr = string.Format("INSERT INTO SanPham(MSP, IDChuSP, TenSP, DanhMuc, GiaTienLucMoiMua, GiaTienBayGio, NgayMuaSP, SoLuong, XuatXu, BaoHanh, TinhTrang, MotaSP, AnhLucMoiMua, AnhBayGio) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}')",
                product.MaSP, product);

            DialogResult result = MessageBox.Show("Bạn có muốn thêm sản phẩm này không", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Thêm sản phẩm thành công", "Thông báo");
                this.Close();
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn cập nhật sản phẩm này không", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Cập nhật sản phẩm thành công", "Thông báo");
                this.Close();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            while (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    pctProduct.Image = Image.FromFile(openFileDialog1.FileName);
                    break;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể chọn ảnh này !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
