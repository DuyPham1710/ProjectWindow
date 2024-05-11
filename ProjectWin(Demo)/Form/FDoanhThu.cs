using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProjectWin_Demo_
{
    public partial class FDoanhThu : Form
    {
        private int id;
        bool detail = false;
        DBConnection a;
        DaMuaDAO daMuaDAO;
        public FDoanhThu(int id)
        {
            this.id = id;
            InitializeComponent();
            gvDoanhThu.Show();
            chartDoanhThu.Show();
            gvChiTiet.Hide();
            daMuaDAO = new DaMuaDAO(id);
            a = new DBConnection(id);
        }

        private void cbxMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            btnThongKe.CustomBorderColor = Color.DarkTurquoise;
            btnChiTiet.CustomBorderColor = Color.White;
            gvDoanhThu.Show();
            chartDoanhThu.Show();
            gvChiTiet.Hide();
            detail = false;
            gvDoanhThu.DataSource = daMuaDAO.LoadDoanhThu(cbxThang.Text, txtNam.Text);
            gvDoanhThu.Columns[0].HeaderText = "Số lượng bán được";
            gvDoanhThu.Columns[1].HeaderText = "Tổng tiền";
            chartDoanhThu.Text = "Doanh thu năm: " + txtNam.Text;
            if (int.TryParse(txtNam.Text, out int nguyen))
            {
                DataTable dt = daMuaDAO.LoadBieuDoDoanhThu(txtNam.Text);
                chartDoanhThu.DataSource = default;
                chartDoanhThu.Series.Clear();

                DataTable processedData = new DataTable();
                processedData.Columns.Add("Tháng", typeof(int));
                processedData.Columns.Add("Doanh thu", typeof(decimal));

                // Thêm dữ liệu đã xử lý từ dữ liệu ban đầu
                for (int i = 1; i <= 12; i++)
                {
                    DataRow[] rows = dt.Select($"Tháng = {i}");
                    if (rows.Length > 0)
                    {
                        processedData.Rows.Add(i, rows[0]["Doanh thu"]);
                    }
                    else
                    {
                        processedData.Rows.Add(i, 0);
                    }
                }
                // Thêm dữ liệu mới vào biểu đồ
                Series series = chartDoanhThu.Series.Add("Doanh thu");
                series.ChartType = SeriesChartType.Area;

                // Thêm các điểm dữ liệu vào loạt dữ liệu
                foreach (DataRow row in processedData.Rows)
                {
                    series.Points.AddXY($"T {row["Tháng"]}", row["Doanh thu"]);
                }
            }
        }
        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            btnThongKe.CustomBorderColor = Color.White;
            btnChiTiet.CustomBorderColor = Color.DarkTurquoise;
            gvDoanhThu.Hide();
            chartDoanhThu.Hide();
            gvChiTiet.Show();
            detail = true;
            gvChiTiet.DataSource = daMuaDAO.LoadChiTietDoanhThu(cbxThang.Text, txtNam.Text);
            gvChiTiet.Columns[0].HeaderText = "MSP";
            gvChiTiet.Columns[1].HeaderText = "Tên Sản phẩm";
            gvChiTiet.Columns[2].HeaderText = "Số lượng bán";
            gvChiTiet.Columns[3].HeaderText = "Người mua";
            gvChiTiet.Columns[4].HeaderText = "Thời gian đặt";
            gvChiTiet.Columns[5].HeaderText = "Thời gian nhận";
            gvChiTiet.Columns[6].HeaderText = "Địa chỉ giao";
            gvChiTiet.Columns[7].HeaderText = "Thành tiền";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (detail)
            {
                btnChiTiet_Click(sender, e);
            }
            else
            {
                btnThongKe_Click(sender, e);
            }
        }

        private void FDoanhThu_Load(object sender, EventArgs e)
        {
            btnChiTiet_Click(sender, e);
        }
    }
}