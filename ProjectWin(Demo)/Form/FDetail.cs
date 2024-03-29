﻿using ProjectWin_Demo_.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProjectWin_Demo_
{
    
    public partial class FDetail : Form
    {
        Product sp;
        private bool isDragging;
        private Point lastCursor;
        private Point lastForm;
        string[] A = { };
        string[] AnhCu = { };
        string[] AnhMoi = { };
        int curr = 0;
        int id;
        public FDetail(Product sp, int id)
        {
            InitializeComponent();
            this.sp = sp;
            this.id = id;
        }
      
        private void FDetail_Load(object sender, EventArgs e)
        {
            lblTenSP.Text = sp.TenSP;
            lblGiaBanDau.Text = "<s>" + sp.GiaBanDau + "đ</s>";
            lblGiaHienTai.Text = sp.GiaHienTai + "đ";
            lblSPConLai.Text = "Còn lại: " + sp.SoLuong;
            lblXuatXu.Text = "Xuất xứ: " + sp.XuatXu;
            lblDanhMuc.Text = "Phân loại: " + sp.DanhMuc;
            lblTinhTrang.Text = "Tình trạng: " + sp.TinhTrang;
            lblBaoHanh.Text = "Bảo hành: " + sp.BaoHanh;
            rtbMoTaSP.Text = sp.MotaSP;
            rtbMoTaTinhTrang.Text = sp.MoTaTinhTrang;
            txtNgayMuaSP.Text = sp.NgayMuaSP.Day.ToString();
            txtThangMuaSP.Text = sp.NgayMuaSP.Month.ToString();
            txtNamMuaSP.Text = sp.NgayMuaSP.Year.ToString();
            if(sp.AnhBanDau!="")
                AnhMoi = sp.AnhBanDau.Split(',');
            if(sp.AnhHienTai!="")
                AnhCu = sp.AnhHienTai.Split(',');
            A = AnhMoi;
            if(A.Length > 0)
            {
                Bitmap bitmap = new Bitmap(Application.StartupPath + "\\AnhSanPham\\" + sp.MaSP + "\\" + A[curr]);
                pctSanPham.Image = bitmap;
            }
            else
                pctSanPham.Image = null;
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if(A.Length > 0)
            {
                if (curr < A.Length-1)
                    curr++;
                else
                    curr = 0;
                Bitmap bitmap = new Bitmap(Application.StartupPath + "\\AnhSanPham\\" + sp.MaSP + "\\" + A[curr]);
                pctSanPham.Image = bitmap;
            }
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if(A.Length > 0)
            {
                if (curr > 0)
                    curr--;
                else
                    curr = A.Length -1;

                Bitmap bitmap = new Bitmap(Application.StartupPath + "\\AnhSanPham\\" + sp.MaSP + "\\" + A[curr]);
                pctSanPham.Image = bitmap;
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            FPayment fPayment = new FPayment(sp, nudSoLuong.Value, id);
            fPayment.ShowDialog();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thêm và giỏ hàng thành công", "Thông báo");
        }

       

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pToolBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentCursor = Cursor.Position;
                this.Location = new Point(lastForm.X + (currentCursor.X - lastCursor.X), lastForm.Y + (currentCursor.Y - lastCursor.Y));
            }
        }

        private void pToolBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastForm = this.Location;
            }
        }

        private void pToolBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }
        private void rdbAnhBanDau_CheckedChanged(object sender, EventArgs e)
        {
            A = AnhMoi;
            curr = 0;
            if (AnhMoi.Length > 0)
            {
                Bitmap bitmap = new Bitmap(Application.StartupPath + "\\AnhSanPham\\" + sp.MaSP + "\\" + A[curr]);
                pctSanPham.Image = bitmap;
            }
            else
                pctSanPham.Image = null;
        }

        private void rdbHienTai_CheckedChanged(object sender, EventArgs e)
        {
            A = AnhCu;
            curr = 0;
            if (AnhCu.Length > 0)
            {
                Bitmap bitmap = new Bitmap(Application.StartupPath + "\\AnhSanPham\\" + sp.MaSP + "\\" + A[curr]);
                pctSanPham.Image = bitmap;
            }
            else
                pctSanPham.Image = null;
        }
    }
}