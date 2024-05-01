using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWin_Demo_
{
    public partial class FDonMua : Form
    {
        private int id;
        SanPhamDao sanPhamDao;
        List<SanPham> sanPham = new List<SanPham>();
        public FDonMua(int id)
        {
            InitializeComponent();
            this.id = id;
            sanPhamDao = new SanPhamDao(id);
        }

        private void FDonMua_Load(object sender, EventArgs e)
        {
            btnChoXacNhan_Click(sender, e);
        }
        //private List<SanPham> ThucThi(string trangThai)
        //{
        //    List<SanPham> products = new List<SanPham>();  
        //    try
        //    {
        //        conn.Open();
        //        string query = string.Format("SELECT *FROM DaMua inner join SanPham on DaMua.MSP = SanPham.MSP WHERE DaMua.ID = {0} and DaMua.TrangThai = N'{1}'",id,trangThai);
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
        private void btnChoXacNhan_Click(object sender, EventArgs e)
        {
            btnChoXacNhan.CustomBorderColor = Color.Gold;
            btnDangGiao.CustomBorderColor = Color.White;
            btnDaGiao.CustomBorderColor = Color.White;
            btnHuyDon.CustomBorderColor = Color.White;
            fPanelDonhang.Controls.Clear();
            sanPham = sanPhamDao.DSDonMua("Chờ xác nhận");
            foreach (SanPham item in sanPham)
            {
                UCSanPhamMua ucSP = new UCSanPhamMua(item, id);
                ucSP.BtnClick_HuyDon += btnHuySPDaMua_Click;
                fPanelDonhang.Controls.Add(ucSP);
            }
        }
        private void btnHuySPDaMua_Click(object sender, EventArgs e)
        {
            UCSanPhamMua uCSanPhamMua = sender as UCSanPhamMua;
            SanPham sp = new SanPham(uCSanPhamMua.lblMaSP.Text);
            FLyDoHuyDon fLyDoHuy = new FLyDoHuyDon(sp, id);
            fLyDoHuy.ShowDialog();
            btnChoXacNhan_Click(sender, e);
        }
        //private void btnDangXuLy_Click(object sender, EventArgs e)
        //{
        //    btnChoXacNhan.CustomBorderColor = Color.White;
        //    btnDangXuLy.CustomBorderColor = Color.Gold;
        //    btnDangGiao.CustomBorderColor = Color.White;
        //    btnDaGiao.CustomBorderColor = Color.White;
        //    btnHuyDon.CustomBorderColor = Color.White;
        //    fPanelDonhang.Controls.Clear();
        //    sanPham = sanPhamDao.DSDonMua("Đang xử lý");
        //    foreach (SanPham item in sanPham)
        //    {
        //        UCSanPham ucSP = new UCSanPham(item, id);
        //        fPanelDonhang.Controls.Add(ucSP);
        //    }
        //}

        private void btnDangGiao_Click(object sender, EventArgs e)
        {
            btnChoXacNhan.CustomBorderColor = Color.White;
            btnDangGiao.CustomBorderColor = Color.Gold;
            btnDaGiao.CustomBorderColor = Color.White;
            btnHuyDon.CustomBorderColor = Color.White;
            fPanelDonhang.Controls.Clear();
            sanPham = sanPhamDao.DSDonMua("Đang giao");
            foreach (SanPham item in sanPham)
            {
                UCSanPhamMua ucSP = new UCSanPhamMua(item, id);
                fPanelDonhang.Controls.Add(ucSP);
            }
        }

        private void btnDaGiao_Click(object sender, EventArgs e)
        {
            btnChoXacNhan.CustomBorderColor = Color.White;
            btnDangGiao.CustomBorderColor = Color.White;
            btnDaGiao.CustomBorderColor = Color.Gold;
            btnHuyDon.CustomBorderColor = Color.White;
            fPanelDonhang.Controls.Clear();
            sanPham = sanPhamDao.DSDonMua("Đã giao");
            foreach (SanPham item in sanPham)
            {
                UCSPDaMua ucSP = new UCSPDaMua(item, id);
                fPanelDonhang.Controls.Add(ucSP);
            }
        }

        private void btnHuyDon_Click(object sender, EventArgs e)
        {
            pTieuDe.Hide();
            btnChoXacNhan.CustomBorderColor = Color.White;
            btnDangGiao.CustomBorderColor = Color.White;
            btnDaGiao.CustomBorderColor = Color.White;
            btnHuyDon.CustomBorderColor = Color.Gold;
            fPanelDonhang.Controls.Clear();
            sanPham = sanPhamDao.DSDonMua("Đã hủy");
            foreach (SanPham item in sanPham)
            {
                UCSPDaHuy ucSP = new UCSPDaHuy(item, id);
                fPanelDonhang.Controls.Add(ucSP);
            }
        }
    }
}
