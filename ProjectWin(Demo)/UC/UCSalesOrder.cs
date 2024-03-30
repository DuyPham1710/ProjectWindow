﻿using System;
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
    public partial class UCSalesOrder : UserControl
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        private int id;
        List<Product> sanPham = new List<Product>();
        string trangThai;
        public UCSalesOrder(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            UCProcessSales sp = sender as UCProcessSales;
            try
            {
                string query = string.Format("UPDATE DaMua SET TrangThai = N'{0}' where MSP = '{1}'", trangThai, sp.lblMaSP.Text);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xác nhận thành công", "Thông báo");
                    UCSalesOrder_Load(sender, e);
                }
            }
            catch
            {
                MessageBox.Show("Xác nhận thất bại", "Thông báo");
            }
            finally
            {
                conn.Close();
            }

        }
        private List<Product> ThucThi(string trangThai)
        {
            List<Product> products = new List<Product>();
            try
            {
                conn.Open();
                string query = string.Format("SELECT *FROM DaMua inner join SanPham on DaMua.MSP = SanPham.MSP WHERE SanPham.IDChuSP = {0} and DaMua.TrangThai = N'{1}'", id, trangThai);
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Product sp = new Product((string)reader["MSP"], (int)reader["IDChuSP"], (string)reader["TenSP"], (string)reader["DanhMuc"], (string)reader["GiaTienLucMoiMua"],
                        (string)reader["GiaTienBayGio"], (DateTime)reader["NgayMuaSP"], (string)reader["SoLuong"], (string)reader["XuatXu"], (string)reader["BaoHanh"], (string)reader["TinhTrang"], (string)reader["MotaTinhTrang"], (string)reader["MotaSP"], (string)reader["AnhLucMoiMua"], (string)reader["AnhBayGio"]);
                    products.Add(sp);
                }

            }
            catch (Exception ex) { }
            finally
            {
                conn.Close();

            }
            return products;
        }

        private void btnWaitAccept_Click(object sender, EventArgs e)
        {
            btnWaitAccept.CustomBorderColor = Color.Gold;
            btnProcess.CustomBorderColor = Color.White;
            btnDelivery.CustomBorderColor = Color.White;
            btnDelivered.CustomBorderColor = Color.White;
            btnRefund.CustomBorderColor = Color.White;
            fPanel.Controls.Clear();
            sanPham = ThucThi("Chờ xác nhận");
            trangThai = "Đang xử lý";
            foreach (Product item in sanPham)
            {
                UCProcessSales ucSP = new UCProcessSales(item, id);
                ucSP.ButtonClickCustom += btnXacNhan_Click;
                fPanel.Controls.Add(ucSP);
            }

        }
        private void btnProcess_Click(object sender, EventArgs e)
        {
            btnWaitAccept.CustomBorderColor = Color.White;
            btnProcess.CustomBorderColor = Color.Gold;
            btnDelivery.CustomBorderColor = Color.White;
            btnDelivered.CustomBorderColor = Color.White;
            btnRefund.CustomBorderColor = Color.White;
            fPanel.Controls.Clear();
            sanPham = ThucThi("Đang xử lý");
            trangThai = "Đang giao";
            foreach (Product item in sanPham)
            {
                UCProcessSales ucSP = new UCProcessSales(item, id);
                ucSP.ButtonClickCustom += btnXacNhan_Click;
                fPanel.Controls.Add(ucSP);
            }
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            btnWaitAccept.CustomBorderColor = Color.White;
            btnProcess.CustomBorderColor = Color.White;
            btnDelivery.CustomBorderColor = Color.Gold;
            btnDelivered.CustomBorderColor = Color.White;
            btnRefund.CustomBorderColor = Color.White;
            sanPham = ThucThi("Đang giao");
            trangThai = "Đã giao";
            foreach (Product item in sanPham)
            {
                UCProcessSales ucSP = new UCProcessSales(item, id);
                ucSP.ButtonClickCustom += btnXacNhan_Click;
                fPanel.Controls.Add(ucSP);
            }
        }

        private void btnDelivered_Click(object sender, EventArgs e)
        {
            btnWaitAccept.CustomBorderColor = Color.White;
            btnProcess.CustomBorderColor = Color.White;
            btnDelivery.CustomBorderColor = Color.White;
            btnDelivered.CustomBorderColor = Color.Gold;
            btnRefund.CustomBorderColor = Color.White;
            sanPham = ThucThi("Đã giao");
            trangThai = "Hoàn tiền/Hủy đơn";
            foreach (Product item in sanPham)
            {
                UCProcessSales ucSP = new UCProcessSales(item, id);
                ucSP.ButtonClickCustom += btnXacNhan_Click;
                fPanel.Controls.Add(ucSP);
            }
        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            //
            btnWaitAccept.CustomBorderColor = Color.White;
            btnProcess.CustomBorderColor = Color.White;
            btnDelivery.CustomBorderColor = Color.White;
            btnDelivered.CustomBorderColor = Color.White;
            btnRefund.CustomBorderColor = Color.Gold;
            sanPham = ThucThi("Hoàn tiền/Hủy đơn");
            trangThai = "Hoàn tiền/Hủy đơn";
            foreach (Product item in sanPham)
            {
                UCProducts ucSP = new UCProducts(item, id);
             //   ucSP.ButtonClickCustom += btnXacNhan_Click;
                fPanel.Controls.Add(ucSP);
            }
        }

        private void UCSalesOrder_Load(object sender, EventArgs e)
        {
            btnWaitAccept_Click(sender, e);
        }
    }
}
