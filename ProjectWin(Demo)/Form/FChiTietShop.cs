using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TheArtOfDevHtmlRenderer.Adapters;

namespace ProjectWin_Demo_
{
    public partial class FChiTietShop : Form
    {
        private bool isDragging;
        private Point lastCursor;
        private Point lastForm;

        private int ID;
        private int IDShop;
        SanPhamDao sanPhamDao;
        QuanTamDAO quanTamDAO;
        NguoiDAO nguoiDAO;
        bool theodoi = false;
        public FChiTietShop(int id, int iDShop)
        {
            InitializeComponent();
            ID = id;
            IDShop = iDShop;
            sanPhamDao = new SanPhamDao(ID, IDShop);
            quanTamDAO = new QuanTamDAO(iDShop);
            nguoiDAO = new NguoiDAO(iDShop);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FChiTietShop_Load(object sender, EventArgs e)
        {
            //Kiem tra theo doi
            QuanTamDAO nguoiMua = new QuanTamDAO(ID);
            if (nguoiMua.KiemTraTheoDoi(IDShop))
            {
                theodoi = true;
                btnTheoDoi.Text = "Đang theo dõi";
            }
            else
            {
                theodoi = false;
                btnTheoDoi.Text = "Theo dõi +";
            }

            fPanelSanPham.Controls.Clear();
            List<UCSanPham> sanPham = sanPhamDao.LoadSanPhamCuaShop("=");
            foreach (UCSanPham sp in sanPham)
            {
                sp.BtnClick_ChiTiet += UCChiTiet_Click;
                fPanelSanPham.Controls.Add(sp);
            }

            Nguoi nguoiBan = nguoiDAO.LoadThongTinCaNhan();
            lblTen.Text = nguoiBan.UserName;
            lblDiaChi.Text = nguoiBan.Address;
            MemoryStream ms = new MemoryStream(nguoiBan.Avt);
            pcbAvt.Image = Image.FromStream(ms);
        }
        private void UCChiTiet_Click(object sender, EventArgs e)
        {
            UCSanPham sp = sender as UCSanPham;
            SanPham sanPham = sanPhamDao.LoadSanPhamChinhSua(sp.lblMaSP.Text);
            FChiTiet fChiTiet = new FChiTiet(sanPham, ID);
            fChiTiet.ShowDialog();
            FChiTietShop_Load(sender, e);
        }

        private void btnTheoDoi_Click(object sender, EventArgs e)
        {
            if (!theodoi)
            {
                QuanTamDAO nguoiMua = new QuanTamDAO(ID);
                nguoiMua.TheoDoiShop(IDShop);
                btnTheoDoi.Text = "Đang theo dõi";
                theodoi = true;
                //MessageBox.Show("Đã theo dõi shop", "Thông báo");
            }
            else
            {
                QuanTamDAO nguoiMua = new QuanTamDAO(ID);
                nguoiMua.BoTheoDoiShop(IDShop);
                btnTheoDoi.Text = "Theo dõi +";
                theodoi = false;
                //MessageBox.Show("Đã bỏ theo dõi shop", "Thông báo");
            }

        }
        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastForm = this.Location;
            }
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentCursor = Cursor.Position;
                this.Location = new Point(lastForm.X + (currentCursor.X - lastCursor.X), lastForm.Y + (currentCursor.Y - lastCursor.Y));
            }
        }

        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }
    }
}