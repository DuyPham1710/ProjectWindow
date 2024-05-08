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
    public partial class FGioHang : Form
    {
        private int id;
        SanPhamDao SPDao;
        GioHangDAO ghDAO;
        List<UCGioHang> gioHang = new List<UCGioHang>();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public FGioHang(int id)
        {
            InitializeComponent();
            this.id = id;
            SPDao = new SanPhamDao(id);
            ghDAO = new GioHangDAO(id); 
        }
        private void FGioHang_Load(object sender, EventArgs e)
        {
            fPanelGioHang.Controls.Clear();
            List<UCGioHang> sanPham = ghDAO.LoadGioHang();
            gioHang = sanPham;
            foreach (UCGioHang sp in sanPham)
            {
                sp.BtnClick_ChiTiet += UCGioHang_Click;
                sp.BtnClick_Xoa += pcbBin_Click;
                sp.BtnClick_Chon += cbChonSP_Click;
                fPanelGioHang.Controls.Add(sp);
            }
        }
        private void btnMuaHang_Click(object sender, EventArgs e)
        {
            if (lblTongTien.Text == "0")
            {
                MessageBox.Show("Bạn vẫn chưa chọn sản phẩm nào để mua", "Thông báo");
            }
            else
            {
                List<SanPham> danhSachsanPham = new List<SanPham>();
                foreach (UCGioHang gh in gioHang)
                {
                    if (gh.cbChonSP.Checked)
                    {
                        //SanPham sp = new SanPham(gh.lblMaSP.Text);
                        try
                        {
                            conn.Open();
                            string query = string.Format("Select * from SanPham WHERE MSP = '{0}'", gh.lblMaSP.Text);
                            SqlCommand cmd = new SqlCommand(query, conn);
                            SqlDataReader reader = cmd.ExecuteReader();
                            if (reader.Read())
                            {
                                SanPham sp = new SanPham((string)reader["MSP"], (int)reader["IDChuSP"], (string)reader["TenSP"], (string)reader["DanhMuc"], (string)reader["GiaTienLucMoiMua"],
                                (string)reader["GiaTienBayGio"], (DateTime)reader["NgayMuaSP"], (string)reader["SoLuong"], (string)reader["XuatXu"], (string)reader["BaoHanh"], (string)reader["TinhTrang"], (string)reader["MotaTinhTrang"], (string)reader["MotaSP"], (string)reader["AnhLucMoiMua"], (string)reader["AnhBayGio"]);
                                sp.SoLuong = gh.nudSoLuong.Value.ToString();
                                sp.GiaHienTai = (Int32.Parse(sp.GiaHienTai) * gh.nudSoLuong.Value).ToString();
                                danhSachsanPham.Add(sp);
                            }
                        }
                        catch { }
                        finally { conn.Close(); }     
                    }
                }
                FThanhToan fThanhToan = new FThanhToan(danhSachsanPham, id);
                fThanhToan.ShowDialog();
            }
        }

       
        private void UCGioHang_Click(object sender, EventArgs e)
        {
            UCGioHang sanPham = sender as UCGioHang;
            List<SanPham> sp = SPDao.chiTietSanPham(sanPham.lblMaSP.Text);
            FChiTiet fChiTiet = new FChiTiet(sp[0], id);
            fChiTiet.ShowDialog();
        }
        private void pcbBin_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn là muốn xóa sản phẩm này", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                UCGioHang sanPham = sender as UCGioHang;
                SanPham sp = new SanPham(sanPham.lblMaSP.Text);
                ghDAO.xoaGioHang(sp);
                FGioHang_Load(sender, e);
                //MessageBox.Show("Xóa thành công", "Thông báo");
            }
        }
        
        private void cbChonSP_Click(object sender, EventArgs e)
        {
            UCGioHang sanPham = sender as UCGioHang;
            if (sanPham.cbChonSP.Checked)
            {
                lblTongTien.Text = (int.Parse(lblTongTien.Text) + int.Parse(sanPham.lblTongTien.Text)).ToString();
                sanPham.panelGioHanh.BackColor = Color.LightCyan;
            }
            else
            {
                lblTongTien.Text = (int.Parse(lblTongTien.Text) - int.Parse(sanPham.lblTongTien.Text)).ToString();
                sanPham.panelGioHanh.BackColor = Color.White;
            }
            
        }
        private void cbChonTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (cbChonTatCa.Checked)
            {
                foreach(UCGioHang gh in gioHang)
                {
                    gh.cbChonSP.Checked = true;
                    gh.panelGioHanh.BackColor = Color.LightCyan;
                    lblTongTien.Text = (int.Parse(lblTongTien.Text) + int.Parse(gh.lblTongTien.Text)).ToString();
                }
                
            }
            else
            {
                foreach (UCGioHang gh in gioHang)
                {
                    gh.cbChonSP.Checked = false;
                    gh.panelGioHanh.BackColor = Color.White;
                }
                lblTongTien.Text = "0";
            }
        }
        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                FGioHang_Load(sender, e);
            }
            else
            {
                SearchAndDisplay(txtTimKiem.Text);
            }
        }
        private void SearchAndDisplay(string searchText)
        {
            fPanelGioHang.Controls.Clear();
            List<UCGioHang> sanPham = ghDAO.timKiemGioHang(searchText);
            foreach (UCGioHang sp in sanPham)
            {
                sp.BtnClick_ChiTiet += UCGioHang_Click;
                sp.BtnClick_Xoa += pcbBin_Click;
                sp.BtnClick_Chon += cbChonSP_Click;
                fPanelGioHang.Controls.Add(sp);
            }
        }
       
    }
}
