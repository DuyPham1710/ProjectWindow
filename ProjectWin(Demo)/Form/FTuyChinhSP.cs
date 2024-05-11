using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWin_Demo_
{
    public partial class FTuyChinhSP : Form
    {
        private bool isDragging;
        private Point lastCursor;
        private Point lastForm;
        private string ma;
        private int id;
        private string thaoTac;
        List<string> A = new List<string>();
        List<string> AnhCu = new List<string>();
        List<string> AnhMoi = new List<string>();
        int curr = 0;
        SanPhamDao SPDao;
        public FTuyChinhSP(int id, string ma, string thaoTac)
        {
            InitializeComponent();
            btnUpdateProduct.Hide();
            this.ma = ma;
            this.id = id;
            this.thaoTac = thaoTac;
            SPDao = new SanPhamDao(id);
        }
        private void FTuyChinhSP_Load(object sender, EventArgs e)
        {
            if (thaoTac == "Them")
            {
                int maSP = SPDao.TaoMaSP();
                if (maSP < 10)
                {
                    txtMaSP.Texts = "SP0" + maSP.ToString();
                }
                else
                {
                    txtMaSP.Texts = "SP" + maSP.ToString();
                }
                ma = txtMaSP.Texts;
            }
            else
            {
                SanPham sp = SPDao.LoadSanPhamChinhSua(ma);
                txtMaSP.Texts = sp.MaSP;
                cbBoxSoLuong.Value = Int32.Parse(sp.SoLuong);
                txtTenSP.Texts = sp.TenSP;
                cbBoxDanhMuc.SelectedItem = sp.DanhMuc;
                txtGiaBanDau.Texts = sp.GiaBanDau;
                txtGiaHienTai.Texts = sp.GiaHienTai;
                txtXuatXu.Texts = sp.XuatXu;
                cbBoxBaoHanh.SelectedItem = sp.BaoHanh;
                DtpNgayMua.Value = sp.NgayMuaSP;
                rtbMoTaSP.Text = sp.MotaSP;
                txtTinhTrang.Texts = sp.TinhTrang;
                rtbMoTaTinhTrang.Text = sp.MoTaTinhTrang;
                if (sp.AnhBanDau != "")
                    AnhMoi.AddRange(sp.AnhBanDau.Split(','));
                if (sp.AnhHienTai != "")
                    AnhCu.AddRange(sp.AnhHienTai.Split(','));
                if (AnhMoi.Count != 0)
                {
                    A = AnhMoi;
                    Bitmap bitmap = new Bitmap(Application.StartupPath + "\\AnhSanPham\\" + sp.MaSP + "\\" + A[curr]);
                    pctProduct.Image = bitmap;
                }
                else
                    pctProduct.Image = null;
            }
        }
        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            while (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    string imagePath = openFileDialog1.FileName;
                    pctProduct.Image = Image.FromFile(openFileDialog1.FileName);
                    string destinationFolderPath = Application.StartupPath + "\\AnhSanPham\\" + txtMaSP.Texts;
                    if (!Directory.Exists(destinationFolderPath))
                    {
                        try
                        {
                            Directory.CreateDirectory(destinationFolderPath);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Lỗi: {ex.Message}");
                        }
                    }
                    if (File.Exists(imagePath))
                    {
                        try
                        {
                            File.Copy(imagePath, Path.Combine(destinationFolderPath, Path.GetFileName(imagePath)));
                            if (rdoAnhBanDau.Checked)
                            {
                                AnhMoi.Add(Path.GetFileName(imagePath));
                                A = AnhMoi;
                            }
                            if (rdoAnhHienTai.Checked)
                            {
                                AnhCu.Add(Path.GetFileName(imagePath));
                                A = AnhCu;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Lỗi: {ex.Message}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Tập tin ảnh không tồn tại.");
                    }

                    break;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể chọn ảnh này !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if(A.Count != 0)
            {
                if (curr < A.Count - 1)
                    curr++;
                else
                    curr = 0;
                Bitmap bitmap = new Bitmap(Application.StartupPath + "\\AnhSanPham\\" + txtMaSP.Texts + "\\" + A[curr]);
                pctProduct.Image = bitmap;
            }
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if (A.Count != 0)
            {
                if (curr > 0)
                    curr--;
                else
                    curr = A.Count-1;
                Bitmap bitmap = new Bitmap(Application.StartupPath + "\\AnhSanPham\\" + txtMaSP.Texts + "\\" + A[curr]);
                pctProduct.Image = bitmap;
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm sản phẩm này không", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SanPham sanPham = new SanPham(txtMaSP.Texts, id, txtTenSP.Texts, cbBoxDanhMuc.Text, txtGiaBanDau.Texts, txtGiaHienTai.Texts,
                    DtpNgayMua.Value, cbBoxSoLuong.Value.ToString(), txtXuatXu.Texts, cbBoxBaoHanh.Text, txtTinhTrang.Texts, rtbMoTaTinhTrang.Text, rtbMoTaSP.Text, string.Join(",", AnhMoi), string.Join(",", AnhCu));
                if (sanPham.KiemTra())
                {
                    SPDao.ThemSanPham(sanPham);
                    this.Close();
                }
            }

        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn cập nhật sản phẩm này không", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SanPham sanPham = new SanPham(txtMaSP.Texts, id, txtTenSP.Texts, cbBoxDanhMuc.Text, txtGiaBanDau.Texts, txtGiaHienTai.Texts,
                DtpNgayMua.Value, cbBoxSoLuong.Value.ToString(), txtXuatXu.Texts, cbBoxBaoHanh.Text, txtTinhTrang.Texts, rtbMoTaTinhTrang.Text, rtbMoTaSP.Text, string.Join(",", AnhMoi), string.Join(",", AnhCu));
                if (sanPham.KiemTra())
                {
                    SPDao.SuaSanPham(sanPham);
                    this.Close();
                }
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
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void rdoAnhBanDau_CheckedChanged(object sender, EventArgs e)
        {
            A = AnhMoi;
            curr = 0;
            if (A.Count > 0)
            {
                Bitmap bitmap = new Bitmap(Application.StartupPath + "\\AnhSanPham\\" + txtMaSP.Texts + "\\" + A[curr]);
                pctProduct.Image = bitmap;
            }
            else
                pctProduct.Image = null;
        }

        private void rdoAnhHienTai_CheckedChanged(object sender, EventArgs e)
        {
            A = AnhCu;
            curr = 0;
            if (A.Count > 0)
            {
                Bitmap bitmap = new Bitmap(Application.StartupPath + "\\AnhSanPham\\" + txtMaSP.Texts + "\\" + A[curr]);
                pctProduct.Image = bitmap;
            }
            else
                pctProduct.Image = null;
        }
    }
}
