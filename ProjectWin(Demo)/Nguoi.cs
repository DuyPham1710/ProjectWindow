using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;

namespace ProjectWin_Demo_
{
    internal class Nguoi
    {
        private int iD;
        private string hoTen, email, soDT, cccd, gioiTinh, diaChi, tenDangNhap, matKhau, viTri;
        private byte[] avt;
        private DateTime ngaySinh;

        public int ID { get => iD; set => iD = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string Email { get => email; set => email = value; }
        public string SoDT { get => soDT; set => soDT = value; }
        public string Cccd { get => cccd; set => cccd = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string ViTri { get => viTri; set => viTri = value; }
        public byte[] Avt { get => avt; set => avt = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }

        public Nguoi(int iDValue, string nameValue, string emailValue, string phoneNumberValue, string cccdValue, string genderValue, string addr, string username, string pass, DateTime bornYear, byte[] avtValue)
        {
            ID = iDValue;
            HoTen = nameValue;
            Email = emailValue;
            SoDT = phoneNumberValue;
            Cccd = cccdValue;
            GioiTinh = genderValue;
            DiaChi = addr;
            TenDangNhap = username;
            MatKhau = pass;
            ViTri = "User";
            NgaySinh = bornYear;
            Avt = avtValue;
        }

      
        public Nguoi(DataTable duLieu)
        {
            ID = Int32.Parse(duLieu.Rows[0]["ID"].ToString());
            HoTen = duLieu.Rows[0]["FullName"].ToString();
            Email = duLieu.Rows[0]["Email"].ToString();
            SoDT = duLieu.Rows[0]["Phone"].ToString();
            Cccd = duLieu.Rows[0]["CCCD"].ToString();
            GioiTinh = duLieu.Rows[0]["Gender"].ToString();
            DiaChi = duLieu.Rows[0]["Addr"].ToString();
            TenDangNhap = duLieu.Rows[0]["UserName"].ToString();
            MatKhau = duLieu.Rows[0]["Pass"].ToString();
            ViTri = duLieu.Rows[0]["Position"].ToString();
            NgaySinh = DateTime.Parse(duLieu.Rows[0]["Bith"].ToString());
            object avarta = duLieu.Rows[0]["Avarta"];
            Avt = avarta != DBNull.Value ? (byte[])avarta : null;
        }
        public Nguoi(DataRow duLieu)
        {
            ID = Int32.Parse(duLieu["ID"].ToString());
            HoTen = duLieu["FullName"].ToString();
            Email = duLieu["Email"].ToString();
            SoDT = duLieu["Phone"].ToString();
            Cccd = duLieu["CCCD"].ToString();
            GioiTinh = duLieu["Gender"].ToString();
            DiaChi = duLieu["Addr"].ToString();
            NgaySinh = DateTime.Parse(duLieu["Bith"].ToString());
            object avarta = duLieu["Avarta"];
            Avt = avarta != DBNull.Value ? (byte[])avarta : null;
        }
        public virtual bool KiemTra(string thaoTac)
        {
            var properties = typeof(Nguoi).GetProperties();
            if (Avt == null)
            {
                string path = Path.Combine(Application.StartupPath, "Resources", "icons8-user-64 (1).png");
                Avt = File.ReadAllBytes(path);
            }
            foreach (var property in properties)
            {
                object value = property.GetValue(this);

                if ((value == null || string.IsNullOrWhiteSpace(value.ToString())))
                {
                    MessageBox.Show($"{property.Name} trống");
                    return false;
                }
            }
            
            // Biểu thức  kiểm tra email
            string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(Email) == false)
            {
                MessageBox.Show("Email không hợp lệ", "Thông báo");
                return false;
            }
            // Biểu thức kiểm tra số điện thoại (dạng xxx-xxxx-xxx)
            pattern = @"^\d{10}$";
            regex = new Regex(pattern);
            if (regex.IsMatch(SoDT) == false)
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo");
                return false;
            }
            // Kiểm tra tuổi
            int tuoi = (int)(((DateTime.Now - NgaySinh).Days) / 365.25);
            if (tuoi < 17)
            {
                MessageBox.Show("Chưa đủ 18 tuổi!!", "Thông báo");
                return false;
            }

            if (thaoTac == "thêm")
            {
                //kiểm tra trùng tên đăng nhập không 
                string sqlQuery = string.Format("SELECT * FROM Account WHERE UserName = '{0}'", TenDangNhap);
                DBConnection dB = new DBConnection();
                DataTable tmp = dB.LoadDuLieu(sqlQuery);
                if (tmp.Rows.Count != 0)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại", "Thông báo");
                    return false;
                }
                return true;
            }
            return true;

        }
    }
}
