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
    public partial class UCBinhLuan : UserControl
    {
        private int id;
        private SanPham sp;
        MemoryStream ms;
        public UCBinhLuan(int id, string hoTen, byte[] Avt, string binhLuan, int soSao)
        {
            InitializeComponent();
            this.id = id;
            lblHoTen.Text = hoTen;
            txtBinhLuan.Text = binhLuan;
            Star.Value = soSao;
            if (Avt != null)
            {
                ms = new MemoryStream(Avt);
                pcbAvt.Image = Image.FromStream(ms);
            }
        }
    }
}
