using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWin_Demo_
{
    public partial class FShop : Form
    {
        private int id;
        NguoiDAO nguoiDao;
        public FShop(int id)
        {
            InitializeComponent();
            this.id = id;
            nguoiDao = new NguoiDAO(id);
        }

        private void FShop_Load(object sender, EventArgs e)
        {
            btnTatCaShop.CustomBorderColor = Color.DarkTurquoise;
            btnUyTin.CustomBorderColor = Color.White;
            btnItUyTin.CustomBorderColor = Color.White;
            btnShopTheoDoi.CustomBorderColor = Color.White;

            fPanelShop.Controls.Clear();
            List<UCShop> shop = nguoiDao.LoadShop();
            foreach (UCShop s in shop)
            {

                fPanelShop.Controls.Add(s);
            }
        }
        private void btnUyTin_Click(object sender, EventArgs e)
        {
            btnTatCaShop.CustomBorderColor = Color.White;
            btnUyTin.CustomBorderColor = Color.DarkTurquoise;
            btnItUyTin.CustomBorderColor = Color.White;
            btnShopTheoDoi.CustomBorderColor = Color.White;

            fPanelShop.Controls.Clear();
            List<UCShop> shop = nguoiDao.UyTin(">");
            foreach (UCShop s in shop)
            {
                fPanelShop.Controls.Add(s);
            }
        }
        private void btnItUyTin_Click(object sender, EventArgs e)
        {
            btnTatCaShop.CustomBorderColor = Color.White;
            btnUyTin.CustomBorderColor = Color.White;
            btnItUyTin.CustomBorderColor = Color.DarkTurquoise;
            btnShopTheoDoi.CustomBorderColor = Color.White;

            fPanelShop.Controls.Clear();
            List<UCShop> shop = nguoiDao.UyTin("<");
            foreach (UCShop s in shop)
            {

                fPanelShop.Controls.Add(s);
            }
        }

        private void btnAllShop_Click(object sender, EventArgs e)
        {
            FShop_Load(sender, e);
        }

        private void btnShopTheoDoi_Click(object sender, EventArgs e)
        {
            btnTatCaShop.CustomBorderColor = Color.White;
            btnUyTin.CustomBorderColor = Color.White;
            btnItUyTin.CustomBorderColor = Color.White;
            btnShopTheoDoi.CustomBorderColor = Color.DarkTurquoise;

            fPanelShop.Controls.Clear();
            List<UCShop> shop = nguoiDao.TheoDoi();
            foreach (UCShop s in shop)
            {
                fPanelShop.Controls.Add(s);
            }
        }
    }
}