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

namespace ProjectWin_Demo_
{
    public partial class UCBinhLuan : UserControl
    {
        private int id;
        private SanPham sp;
        SanPhamDao SPDao;
        MemoryStream ms;
        public UCBinhLuan(int id, string hoTen, Byte[] Avt, string binhLuan, int soSao)
        {
            InitializeComponent();
            this.id = id;
            lblHoTen.Text = hoTen;
            txtBinhLuan.Text = binhLuan;
            Star.Value = soSao;
            //pcbAvt = Avt
            ms = new MemoryStream(Avt);
            pcbAvt.Image = Image.FromStream(ms);
            SPDao = new SanPhamDao(id);
        }

        private void UCBinhLuan_Load(object sender, EventArgs e)
        {
            SPDao.LoadDanhGia();
        }
    }
}
