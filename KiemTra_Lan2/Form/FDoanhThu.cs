using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;

namespace KiemTra_Lan2
{
    public partial class FDoanhThu : Form
    {
        private int id;
        bool detail = false;
        TraoDoiHangDF db = new TraoDoiHangDF();
        public FDoanhThu(int id)
        {
            this.id = id;
            InitializeComponent();
            gvDoanhThu.Show();
            chartDoanhThu.Show();
            gvChiTiet.Hide();
        }
    }
}
