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

namespace ProjectWin_Demo_
{
    public partial class FMyProduct : Form
    {
        private int id;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public FMyProduct(int id)
        {
            InitializeComponent();
            foreach (Control control in fPanelHienThi.Controls)
            {
                control.Margin = new Padding(5); // Đặt giá trị phần đệm là 5 cho các cạnh
            }
            this.id = id;
        }
        private void FMyProduct_Load(object sender, EventArgs e)
        {
            fPanelHienThi.Controls.Clear();
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT * FROM SanPham WHERE IDchuSP = {0}", id);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Product sp = new Product((string)reader["MSP"], (int)reader["IDChuSP"], (string)reader["TenSP"], (string)reader["DanhMuc"], (string)reader["GiaTienLucMoiMua"],
                        (string)reader["GiaTienBayGio"], (DateTime)reader["NgayMuaSP"], (string)reader["SoLuong"], (string)reader["XuatXu"], (string)reader["BaoHanh"], (string)reader["TinhTrang"], (string)reader["MotaTinhTrang"], (string)reader["MotaSP"], (List<string>)reader["AnhLucMoiMua"], (List<string>)reader["AnhBayGio"]);

                    fPanelHienThi.Controls.Add(new UCMyProduct(sp));
                }
            }
            catch { }
            finally { conn.Close(); }
          
            
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            FAddProduct addProduct = new FAddProduct(id, "", "Them");
            addProduct.ShowDialog();
            FMyProduct_Load(sender, e);
        }

        private void btnProductSold_Click(object sender, EventArgs e)
        {
            btnTotalProduct.CustomBorderColor = Color.White;
            btnTotalProduct.ForeColor = Color.Black;
            btnProductSold.CustomBorderColor = Color.MediumSlateBlue;
            btnProductSold.ForeColor = Color.MediumSlateBlue;
            UCHistory uCHistory = new UCHistory();
            addUserControl(uCHistory);
        }
        private void addUserControl(UserControl userControl)
        {
            fPanelHienThi.Controls.Clear();
            fPanelHienThi.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnTotalProduct_Click(object sender, EventArgs e)
        {
            btnTotalProduct.CustomBorderColor = Color.MediumSlateBlue;
            btnTotalProduct.ForeColor = Color.MediumSlateBlue;
            btnProductSold.CustomBorderColor = Color.White;
            btnProductSold.ForeColor = Color.Black;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

       
    }
}
