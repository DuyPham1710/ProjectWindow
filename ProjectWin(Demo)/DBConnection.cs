using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWin_Demo_
{
    internal class DBConnection
    {
        static SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

        public static void Load()
        {

        }

        public static void thucThi(string SQL)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(SQL, conn);
                cmd = new SqlCommand(SQL, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thực thi thành công", "Thông báo");
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
    }
}
