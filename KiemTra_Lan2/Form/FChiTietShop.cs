using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTra_Lan2
{
    public partial class FChiTietShop : Form
    {
        private bool isDragging;
        private Point lastCursor;
        private Point lastForm;

        private int ID;
        private int IDShop;
      
        bool theodoi = false;
        TraoDoiHangDF db = new TraoDoiHangDF();
        public FChiTietShop(int id, int iDShop)
        {
            InitializeComponent();
            ID = id;
            IDShop = iDShop;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FChiTietShop_Load(object sender, EventArgs e)
        {
            fPanelSanPham.Controls.Clear();
            List<SanPham> DSSanPham = (from sp in db.SanPhams
                                       where sp.IDChuSP == IDShop
                                       select sp).ToList();
            foreach (SanPham sp in DSSanPham)
            {
                UCSanPham ucSP = new UCSanPham(sp, ID);
                ucSP.BtnClick_ChiTiet += UCChiTiet_Click;
                fPanelSanPham.Controls.Add(ucSP);
            }
            var nguoiBan = from person in db.People
                        join account in db.Accounts on person.ID equals account.ID
                        where account.ID == ID
                        select new
                        {
                            person.Addr,
                            person.Avarta,
                            account.UserName
                        };

           
            lblTen.Text = nguoiBan.First().UserName;
            lblDiaChi.Text = nguoiBan.First().Addr;
            MemoryStream ms = new MemoryStream(nguoiBan.First().Avarta);
            pcbAvt.Image = Image.FromStream(ms);
        }
        private void UCChiTiet_Click(object sender, EventArgs e)
        {
            UCSanPham sp = sender as UCSanPham;

            SanPham sanPham = (from s in db.SanPhams
                              where s.MSP == sp.lblMaSP.Text
                              select s).FirstOrDefault();
            FChiTiet fChiTiet = new FChiTiet(sanPham, ID);
            fChiTiet.ShowDialog();
            FChiTietShop_Load(sender, e);
        }

        private void btnTheoDoi_Click(object sender, EventArgs e)
        {
            //if (!theodoi)
            //{
            //    QuanTamDAO nguoiMua = new QuanTamDAO(ID);
            //    nguoiMua.TheoDoiShop(IDShop);
            //    btnTheoDoi.Text = "Đang theo dõi";
            //    theodoi = true;
            //}
            //else
            //{
            //    QuanTamDAO nguoiMua = new QuanTamDAO(ID);
            //    nguoiMua.BoTheoDoiShop(IDShop);
            //    btnTheoDoi.Text = "Theo dõi +";
            //    theodoi = false;
            //}

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
