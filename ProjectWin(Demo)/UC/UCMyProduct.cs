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
    public partial class UCMyProduct : UserControl
    {
        Product sp;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public UCMyProduct(Product sp)
        {
            InitializeComponent();
            this.sp = sp;
        }
        private void UCMyProduct_Load(object sender, EventArgs e)
        {
            lblTenSP.Text = sp.TenSP;
            lblMaSP.Text = sp.MaSP;
            lblSoLuong.Text = sp.SoLuong;
            lblGia.Text = sp.GiaHienTai;
            lblDanhMuc.Text = sp.DanhMuc;
        }

        private void pcbDelete_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.BackColor = Color.MediumPurple;
        }

        private void pcbDelete_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.BackColor = Color.WhiteSmoke;
        }

        private void pcbDelete_Click(object sender, EventArgs e)
        {
        
            //DialogResult result = MessageBox.Show("Bạn chắc chắn là muốn xóa sản phẩm này", "Xác nhận xóa", MessageBoxButtons.YesNo);
            //if (result == DialogResult.Yes)
            //{
            //    // thực hiện xóa 
                
            //    string SQL = string.Format("DELETE FROM SanPham WHERE MSP = '{0}'", sp.MaSP);
            //    try
            //    {
            //        conn.Open();
            //        SqlCommand cmd = new SqlCommand(SQL, conn);
            //        if (cmd.ExecuteNonQuery() > 0)
            //        {
            //            MessageBox.Show("Xóa Sản phẩm thành công", "Thông báo");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Không thể xóa sản phẩm này", "Thông báo");

            //    }
            //    finally
            //    {
            //        conn.Close();
            //    }
            //}        
        }

        private void pcbEdit_Click(object sender, EventArgs e)
        {
            //FAddProduct fedit = new FAddProduct(sp.IDChuSP, sp.MaSP, "Sua");
            //fedit.btnAddProduct.Hide();
            //fedit.btnUpdateProduct.Show();
            //fedit.ShowDialog();
        }
    }
}
