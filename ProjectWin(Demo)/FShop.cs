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
        List<Nguoi> nguoi = new List<Nguoi>();
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
            fPanelShop.Controls.Clear();
            List<UCShop> shop = nguoiDao.LoadShop();
            foreach (UCShop s in shop)
            {

                fPanelShop.Controls.Add(s);
            }
        }
        private void btnUyTin_Click(object sender, EventArgs e)
        {
            fPanelShop.Controls.Clear();
            List<UCShop> shop = nguoiDao.UyTin(">");
            foreach (UCShop s in shop)
            {

                fPanelShop.Controls.Add(s);
            }
        }

        private void btnItUyTin_Click(object sender, EventArgs e)
        {
            fPanelShop.Controls.Clear();
            List<UCShop> shop = nguoiDao.UyTin("<");
            foreach (UCShop s in shop)
            {

                fPanelShop.Controls.Add(s);
            }
        }
    }
}