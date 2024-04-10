using ProjectWin_Demo_.UC;
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
    
    public partial class FSPCuaToi : Form
    {
        private int id;
        SanPhamDao SPDao;
        public FSPCuaToi(int id)
        {
            InitializeComponent();

            foreach (Control control in fPanelHienThi.Controls)
            {
                control.Margin = new Padding(5); // Đặt giá trị phần đệm là 5 cho các cạnh
            }
            this.id = id;
            SPDao = new SanPhamDao(id);

        }
        private void FSPCuaToi_Load(object sender, EventArgs e)
        {
            lblTuyChon.Text = "Tùy chọn";
            fPanelHienThi.Controls.Clear();
            List<UCSPCuaToi> sanPham = SPDao.LoadSanPham<UCSPCuaToi>("=");
            foreach (UCSPCuaToi sp in sanPham)
            {
                sp.BtnClick_delete += pcbDelete_Click;
                sp.BtnClick_edit += pcbEdit_Click;
                fPanelHienThi.Controls.Add(sp);
            }
            //try
            //{
            //    conn.Open();
            //    string sqlStr = string.Format("SELECT * FROM SanPham WHERE IDchuSP = {0}", id);
            //    SqlCommand cmd = new SqlCommand(sqlStr, conn);
            //    SqlDataReader reader = cmd.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        SanPham sp = new SanPham((string)reader["MSP"], (int)reader["IDChuSP"], (string)reader["TenSP"], (string)reader["DanhMuc"], (string)reader["GiaTienLucMoiMua"],
            //            (string)reader["GiaTienBayGio"], (DateTime)reader["NgayMuaSP"], (string)reader["SoLuong"], (string)reader["XuatXu"], (string)reader["BaoHanh"], (string)reader["TinhTrang"], (string)reader["MotaTinhTrang"], (string)reader["MotaSP"], (string)reader["AnhLucMoiMua"], (string)reader["AnhBayGio"]);
            //        UCSPCuaToi uCMyProduct = new UCSPCuaToi(sp);
            //        uCMyProduct.BtnClick_delete += pcbDelete_Click;
            //        uCMyProduct.BtnClick_edit += pcbEdit_Click;
            //        fPanelHienThi.Controls.Add(uCMyProduct);

            //    
            //}
            //catch { }
            //finally { conn.Close(); }
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            FTuyChinhSP addProduct = new FTuyChinhSP(id, "", "Them");
            addProduct.ShowDialog();
            FSPCuaToi_Load(sender, e);
        }

        private void btnSPBanDuoc_Click(object sender, EventArgs e)
        {
            btnTotalProduct.CustomBorderColor = Color.White;
            btnTotalProduct.ForeColor = Color.Black;
            btnProductSold.CustomBorderColor = Color.MediumSlateBlue;
            btnProductSold.ForeColor = Color.MediumSlateBlue;
            lblTuyChon.Text = "Người mua";
            fPanelHienThi.Controls.Clear();
            List<UCSPDaBan> sanPham = SPDao.LoadSanPhamDaBan<UCSPDaBan>();
            foreach (UCSPDaBan sp in sanPham)
            {
                fPanelHienThi.Controls.Add(sp);
            }
            //UCHistory uCHistory = new UCHistory();
            //addUserControl(uCHistory);
        }
        private void btnTongSanPham_Click(object sender, EventArgs e)
        {
            lblTuyChon.Text = "Tùy chọn";
            btnTotalProduct.CustomBorderColor = Color.MediumSlateBlue;
            btnTotalProduct.ForeColor = Color.MediumSlateBlue;
            btnProductSold.CustomBorderColor = Color.White;
            btnProductSold.ForeColor = Color.Black;
            FSPCuaToi_Load(sender, e);
        }
        private void addUserControl(UserControl userControl)
        {
            fPanelHienThi.Controls.Clear();
            fPanelHienThi.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void pcbDelete_Click(object sender, EventArgs e)
        {
            UCSPCuaToi sp = sender as UCSPCuaToi;
            DialogResult result = MessageBox.Show("Bạn chắc chắn là muốn xóa sản phẩm này", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SanPham sanPham = new SanPham(sp.lblMaSP.Text);
                SPDao.Delete(sanPham, "SanPham");
                FSPCuaToi_Load(sender, e);          
            }
        }

        private void pcbEdit_Click(object sender, EventArgs e)
        {
            UCSPCuaToi sp = sender as UCSPCuaToi;
            FTuyChinhSP fedit = new FTuyChinhSP(id, sp.lblMaSP.Text, "Sua");
            fedit.btnAddProduct.Hide();
            fedit.btnUpdateProduct.Show();
            fedit.ShowDialog();
            FSPCuaToi_Load(sender, e);
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                FSPCuaToi_Load(sender, e);
            }
            else
            {
                SearchAndDisplay(txtTimKiem.Text);
            }          
        }
        private void SearchAndDisplay(string searchText)
        {
            fPanelHienThi.Controls.Clear();
            List<UCSPCuaToi> sanPham = SPDao.timKiem<UCSPCuaToi>(searchText, "=");
            foreach (UCSPCuaToi sp in sanPham)
            {
                sp.BtnClick_delete += pcbDelete_Click;
                sp.BtnClick_edit += pcbEdit_Click;
                fPanelHienThi.Controls.Add(sp);
            }
            //try
            //{
            //    conn.Open();

            //    string sqlQuery = "SELECT * FROM SanPham WHERE TenSP LIKE @searchText";
            //    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
            //    cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

            //    SqlDataReader reader = cmd.ExecuteReader();
            //    fPanelHienThi.Controls.Clear();

            //    while (reader.Read())
            //    {
            //        SanPham sp = new SanPham((string)reader["MSP"], (int)reader["IDChuSP"], (string)reader["TenSP"], (string)reader["DanhMuc"], (string)reader["GiaTienLucMoiMua"],
            //            (string)reader["GiaTienBayGio"], (DateTime)reader["NgayMuaSP"], (string)reader["SoLuong"], (string)reader["XuatXu"], (string)reader["BaoHanh"], (string)reader["TinhTrang"], (string)reader["MotaTinhTrang"], (string)reader["MotaSP"], (string)reader["AnhLucMoiMua"], (string)reader["AnhBayGio"]);
            //        //SanPham.Add(sp);
            //        UCSPCuaToi ucSP = new UCSPCuaToi(sp);
            //        fPanelHienThi.Controls.Add(ucSP);
            //    }
            //}
            //catch (Exception ex) { }
            //finally { conn.Close(); }

        }
    }
}
