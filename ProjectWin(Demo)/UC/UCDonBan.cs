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

namespace ProjectWin_Demo_.UC
{
    public partial class UCDonBan : UserControl
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        private int id;
        List<SanPham> sanPham = new List<SanPham>();
        string trangThai;
        SanPhamDao sanPhamDao = new SanPhamDao();
        public UCDonBan(int id)
        {
            InitializeComponent();
            this.id = id;
            pTieuDe.Hide();
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            UCQuyTrinhDonHang sp = sender as UCQuyTrinhDonHang;
            SanPham sanPham = new SanPham(sp.lblMaSP.Text);
            sanPhamDao.XacNhanDonhang(sanPham, trangThai);
            UCSalesOrder_Load(sender, e);
            //try
            //{
            //    string query = string.Format("UPDATE DaMua SET TrangThai = N'{0}' where MSP = '{1}'", trangThai, sp.lblMaSP.Text);
            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand(query, conn);

            //    if (cmd.ExecuteNonQuery() > 0)
            //    {
            //        MessageBox.Show("Xác nhận thành công", "Thông báo");
            //        UCSalesOrder_Load(sender, e);
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Xác nhận thất bại", "Thông báo");
            //}
            //finally
            //{
            //    conn.Close();
            //}

        }
        //private List<SanPham> ThucThi(string trangThai)
        //{
        //    List<SanPham> products = new List<SanPham>();
        //    try
        //    {
        //        conn.Open();
        //        string query = string.Format("SELECT *FROM DaMua inner join SanPham on DaMua.MSP = SanPham.MSP WHERE SanPham.IDChuSP = {0} and DaMua.TrangThai = N'{1}'", id, trangThai);
        //        SqlCommand cmd = new SqlCommand(query, conn);
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            SanPham sp = new SanPham((string)reader["MSP"], (int)reader["IDChuSP"], (string)reader["TenSP"], (string)reader["DanhMuc"], (string)reader["GiaTienLucMoiMua"],
        //                (string)reader["GiaTienBayGio"], (DateTime)reader["NgayMuaSP"], (string)reader["SoLuong"], (string)reader["XuatXu"], (string)reader["BaoHanh"], (string)reader["TinhTrang"], (string)reader["MotaTinhTrang"], (string)reader["MotaSP"], (string)reader["AnhLucMoiMua"], (string)reader["AnhBayGio"]);
        //            products.Add(sp);
        //        }

        //    }
        //    catch (Exception ex) { }
        //    finally
        //    {
        //        conn.Close();

        //    }
        //    return products;
        //}

        private void UCSalesOrder_Load(object sender, EventArgs e)
        {
            btnChoXacNhan_Click(sender, e);
        }

        private void btnChoXacNhan_Click(object sender, EventArgs e)
        {
            pTieuDe.Hide();
            btnChoXacNhan.CustomBorderColor = Color.Gold;
            btnDangXuLy.CustomBorderColor = Color.White;
            btnDangGiao.CustomBorderColor = Color.White;
            btnDaGiao.CustomBorderColor = Color.White;
            btnHuyDon.CustomBorderColor = Color.White;
            fPanelDonhang.Controls.Clear();
            sanPham = sanPhamDao.DSDonBan(id, "Chờ xác nhận");
            trangThai = "Đang xử lý";
            foreach (SanPham item in sanPham)
            {
                UCQuyTrinhDonHang ucSP = new UCQuyTrinhDonHang(item, id);
                ucSP.ButtonClickCustom += btnXacNhan_Click;
                fPanelDonhang.Controls.Add(ucSP);
            }
        }

        private void btnDangXuLy_Click(object sender, EventArgs e)
        {
            pTieuDe.Hide();
            btnChoXacNhan.CustomBorderColor = Color.White;
            btnDangXuLy.CustomBorderColor = Color.Gold;
            btnDangGiao.CustomBorderColor = Color.White;
            btnDaGiao.CustomBorderColor = Color.White;
            btnHuyDon.CustomBorderColor = Color.White;
            fPanelDonhang.Controls.Clear();
            sanPham = sanPhamDao.DSDonBan(id, "Đang xử lý");
            trangThai = "Đang giao";
            foreach (SanPham item in sanPham)
            {
                UCQuyTrinhDonHang ucSP = new UCQuyTrinhDonHang(item, id);
                ucSP.ButtonClickCustom += btnXacNhan_Click;
                fPanelDonhang.Controls.Add(ucSP);
            }
        }

        private void btnDangGiao_Click(object sender, EventArgs e)
        {
            pTieuDe.Hide();
            btnChoXacNhan.CustomBorderColor = Color.White;
            btnDangXuLy.CustomBorderColor = Color.White;
            btnDangGiao.CustomBorderColor = Color.Gold;
            btnDaGiao.CustomBorderColor = Color.White;
            btnHuyDon.CustomBorderColor = Color.White;
            fPanelDonhang.Controls.Clear();
            sanPham = sanPhamDao.DSDonBan(id, "Đang giao");
            trangThai = "Đã giao";
            foreach (SanPham item in sanPham)
            {
                UCQuyTrinhDonHang ucSP = new UCQuyTrinhDonHang(item, id);
                ucSP.ButtonClickCustom += btnXacNhan_Click;
                fPanelDonhang.Controls.Add(ucSP);
            }
        }

        private void btnDaGiao_Click(object sender, EventArgs e)
        {
            pTieuDe.Show();
            btnChoXacNhan.CustomBorderColor = Color.White;
            btnDangXuLy.CustomBorderColor = Color.White;
            btnDangGiao.CustomBorderColor = Color.White;
            btnDaGiao.CustomBorderColor = Color.Gold;
            btnHuyDon.CustomBorderColor = Color.White;
            fPanelDonhang.Controls.Clear();
            sanPham = sanPhamDao.DSDonBan(id, "Đã giao");
            trangThai = "Hoàn tiền/Hủy đơn";
            foreach (SanPham item in sanPham)
            {
                UCSPDaBan ucSP = new UCSPDaBan(item, id);
                fPanelDonhang.Controls.Add(ucSP);
            }
        }

        private void btnHuyDon_Click(object sender, EventArgs e)
        {
            btnChoXacNhan.CustomBorderColor = Color.White;
            btnDangXuLy.CustomBorderColor = Color.White;
            btnDangGiao.CustomBorderColor = Color.White;
            btnDaGiao.CustomBorderColor = Color.White;
            btnHuyDon.CustomBorderColor = Color.Gold;
            fPanelDonhang.Controls.Clear();
            sanPham = sanPhamDao.DSDonBan(id, "Hoàn tiền/Hủy đơn");
            trangThai = "Hoàn tiền/Hủy đơn";
            foreach (SanPham item in sanPham)
            {
                UCQuyTrinhDonHang ucSP = new UCQuyTrinhDonHang(item, id);
                ucSP.ButtonClickCustom += btnXacNhan_Click;
                fPanelDonhang.Controls.Add(ucSP);
            }
        }
    }
}
