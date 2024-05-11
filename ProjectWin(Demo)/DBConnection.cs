using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;
using TheArtOfDevHtmlRenderer.Adapters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjectWin_Demo_
{
    internal class DBConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        private int id;

        public DBConnection() { }
        public DBConnection(int id)
        {
            this.id = id;
        }
        public DataTable LoadDuLieu(string query)
        {
            try
            {
                conn.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                Adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không load được dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }
     
        public void thucThi(string SQL)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(SQL, conn);
                cmd = new SqlCommand(SQL, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    //MessageBox.Show("Thực thi thành công", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        public int demDB(string sql)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                int soDong = (int)cmd.ExecuteScalar();
                return soDong;
            }
            catch
            {
                return 0;
            }
            finally
            {
                conn.Close();
            }
        }
     
        public int soLuongSanPham(string sql)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return Convert.ToInt32(reader["SoLuong"]);
                }
                else
                {
                    return 0;
                }

            }
            catch
            {
                return 0;
            }
            finally
            {
                conn.Close();
            }
        }
      
    }
}
