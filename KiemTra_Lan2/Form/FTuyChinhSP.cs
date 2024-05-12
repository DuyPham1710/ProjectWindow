using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTra_Lan2
{
    public partial class FTuyChinhSP : Form
    {
        TraoDoiHangDF db = new TraoDoiHangDF();
        private string ma;
        private int id;
        private string thaoTac;
        private bool isDragging;
        private Point lastCursor;
        private Point lastForm;
        List<string> A = new List<string>();
        List<string> AnhCu = new List<string>();
        List<string> AnhMoi = new List<string>();
        int curr = 0;
        public FTuyChinhSP(int id, string ma, string thaoTac)
        {
            InitializeComponent();
            btnCapNhatSP.Hide();
            this.ma = ma;
            this.id = id;
            this.thaoTac = thaoTac;
        }
        private void FTuyChinhSP_Load(object sender, EventArgs e)
        {
            if (thaoTac == "Them")
            {
                string maxMaSP = db.SanPhams.Max(p => p.MSP).ToString();
                string temp = "";
                for (int i=2; i<maxMaSP.Length; i++)
                {
                    temp += maxMaSP[i];
                }
                int maSP = Int32.Parse(temp) + 1;
                if (maSP < 10)
                {
                    txtMaSP.Text = "SP0" + maSP.ToString();
                }
                else
                {
                    txtMaSP.Text = "SP" + maSP.ToString();
                }
                ma = txtMaSP.Text;
            }
            else
            {   
                SanPham sp = (from p in db.SanPhams where p.MSP == ma select p).SingleOrDefault();
                txtMaSP.Text = sp.MSP;
                cbBoxSoLuong.Value = Int32.Parse(sp.SoLuong);
                txtTenSP.Text = sp.TenSP;
                cbBoxDanhMuc.SelectedItem = sp.DanhMuc;
                txtGiaBanDau.Text = sp.GiaTienLucMoiMua;
                txtGiaHienTai.Text = sp.GiaTienBayGio;
                txtXuatXu.Text = sp.XuatXu;
                cbBoxBaoHanh.SelectedItem = sp.BaoHanh;
                DtpNgayMua.Value = sp.NgayMuaSP.Value;
                rtbMoTaSP.Text = sp.MotaSP;
                txtTinhTrang.Text = sp.TinhTrang;
                rtbMoTaTinhTrang.Text = sp.MotaTinhTrang;
                if (sp.AnhLucMoiMua != "")
                    AnhMoi.AddRange(sp.AnhLucMoiMua.Split(','));
                if (sp.AnhBayGio != "")
                    AnhCu.AddRange(sp.AnhBayGio.Split(','));
                if (AnhMoi.Count != 0)
                {
                    A = AnhMoi;
                    Bitmap bitmap = new Bitmap(Application.StartupPath + "\\AnhSanPham\\" + sp.MSP + "\\" + A[curr]);
                    pctSanPham.Image = bitmap;
                }
                else
                    pctSanPham.Image = null;
            }
        }
        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            while (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    string imagePath = openFileDialog1.FileName;
                    pctSanPham.Image = Image.FromFile(openFileDialog1.FileName);
                    string destinationFolderPath = Application.StartupPath + "\\AnhSanPham\\" + txtMaSP.Text;
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

        private void btnTruocDo_Click(object sender, EventArgs e)
        {
            if (A.Count != 0)
            {
                if (curr > 0)
                    curr--;
                else
                    curr = A.Count - 1;
                Bitmap bitmap = new Bitmap(Application.StartupPath + "\\AnhSanPham\\" + txtMaSP.Text + "\\" + A[curr]);
                pctSanPham.Image = bitmap;
            }
        }

        private void btnTiepTheo_Click(object sender, EventArgs e)
        {
            if (A.Count != 0)
            {
                if (curr < A.Count - 1)
                    curr++;
                else
                    curr = 0;
                Bitmap bitmap = new Bitmap(Application.StartupPath + "\\AnhSanPham\\" + txtMaSP.Text + "\\" + A[curr]);
                pctSanPham.Image = bitmap;
            }
        }
        private void btnThemSP_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm sản phẩm này không", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    var sanPham = new SanPham
                    {
                        MSP = txtMaSP.Text,
                        IDChuSP = id,
                        TenSP = txtTenSP.Text,
                        DanhMuc = cbBoxDanhMuc.Text,
                        GiaTienLucMoiMua = txtGiaBanDau.Text,
                        GiaTienBayGio = txtGiaHienTai.Text,
                        NgayMuaSP = DtpNgayMua.Value,
                        SoLuong = cbBoxSoLuong.Value.ToString(),
                        XuatXu = txtXuatXu.Text,
                        BaoHanh = cbBoxBaoHanh.Text,
                        TinhTrang = txtTinhTrang.Text,
                        MotaTinhTrang = rtbMoTaTinhTrang.Text,
                        MotaSP = rtbMoTaSP.Text,
                        AnhLucMoiMua = string.Join(",", AnhMoi),
                        AnhBayGio = string.Join(",", AnhCu)
                    };
                    db.SanPhams.Add(sanPham);
                    db.SaveChanges();
                    MessageBox.Show("Thêm sản phẩm thành công", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể thêm sản phảm này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
            }
        }

        private void btnCapNhatSP_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn cập nhật sản phẩm này không", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    SanPham sp = db.SanPhams.Find(txtMaSP.Text);
                    sp.TenSP = txtTenSP.Text;
                    sp.DanhMuc = cbBoxDanhMuc.Text;
                    sp.GiaTienLucMoiMua = txtGiaBanDau.Text;
                    sp.GiaTienBayGio = txtGiaHienTai.Text;
                    sp.NgayMuaSP = DtpNgayMua.Value;
                    sp.SoLuong = cbBoxSoLuong.Value.ToString();
                    sp.XuatXu = txtXuatXu.Text;
                    sp.BaoHanh = cbBoxBaoHanh.Text;
                    sp.TinhTrang = txtTinhTrang.Text;
                    sp.MotaTinhTrang = rtbMoTaTinhTrang.Text;
                    sp.MotaSP = rtbMoTaSP.Text;
                    sp.AnhLucMoiMua = string.Join(",", AnhMoi);
                    sp.AnhBayGio = string.Join(",", AnhCu);
                    db.SaveChanges();

                    MessageBox.Show("Cập nhật sản phẩm thành công", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể cập nhật sản phảm này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
            }
        }
        private void rdoAnhBanDau_CheckedChanged(object sender, EventArgs e)
        {
            A = AnhMoi;
            curr = 0;
            if (A.Count > 0)
            {
                Bitmap bitmap = new Bitmap(Application.StartupPath + "\\AnhSanPham\\" + txtMaSP.Text + "\\" + A[curr]);
                pctSanPham.Image = bitmap;
            }
            else
                pctSanPham.Image = null;
        }

        private void rdoAnhHienTai_CheckedChanged(object sender, EventArgs e)
        {
            A = AnhCu;
            curr = 0;
            if (A.Count > 0)
            {
                Bitmap bitmap = new Bitmap(Application.StartupPath + "\\AnhSanPham\\" + txtMaSP.Text + "\\" + A[curr]);
                pctSanPham.Image = bitmap;
            }
            else
                pctSanPham.Image = null;
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

     
    }
}
