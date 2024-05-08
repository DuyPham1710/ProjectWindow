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
        private int ID;
        private int IDShop;
        SanPhamDao sanPhamDao;
        NguoiDAO nguoiDAO;
        public FChiTietShop(int id, int iDShop)
        {
            InitializeComponent();
            ID = id;
            IDShop = iDShop;
            sanPhamDao = new SanPhamDao(ID, IDShop);
            nguoiDAO = new NguoiDAO(iDShop);

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FChiTietShop_Load(object sender, EventArgs e)
        {
            fPanelSanPham.Controls.Clear();
            List<UCSanPham> sanPham = sanPhamDao.LoadSanPhamCuaShop("=");
            foreach (UCSanPham sp in sanPham)
            {
                fPanelSanPham.Controls.Add(sp);
            }

            Nguoi nguoiBan = nguoiDAO.LoadThongTinCaNhan();
            lblTen.Text = nguoiBan.UserName;
            lblDiaChi.Text = nguoiBan.Address;
            MemoryStream ms = new MemoryStream(nguoiBan.Avt);
            pcbAvt.Image = Image.FromStream(ms);
        }
    }
}