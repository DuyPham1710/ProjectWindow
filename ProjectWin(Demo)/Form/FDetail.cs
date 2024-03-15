using ProjectWin_Demo_.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProjectWin_Demo_
{
    public partial class FDetail : Form
    {
        private bool isDragging;
        private Point lastCursor;
        private Point lastForm;
        public FDetail()
        {
            InitializeComponent();
            lblCost.Text = "<s>" + lblCost.Text  + "</s>";
        }
        List<string> A=new List<string>();
        List<string> imgList = new List<string>() { "4", "5" };
        List<string> imgListBefore = new List<string>() { "1", "2" };
        int curr = 0;
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (curr < 1)
                curr++;
            else
                curr = 0;
            if(rdbBefore.Checked==true)
                A = imgListBefore;
            else
                A = imgList;
            Bitmap bitmap = new Bitmap(Application.StartupPath + "\\Resources\\" + A[curr] + ".jpg");
            pctProduct.Image = bitmap;
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if (curr > 0)
                curr--;
            else
                curr = 1;
            if (rdbBefore.Checked == true)
                A = imgListBefore;
            else
                A = imgList;
            Bitmap bitmap = new Bitmap(Application.StartupPath + "\\Resources\\" + imgList[curr] + ".jpg");
            pctProduct.Image = bitmap;
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            FPayment fPayment = new FPayment();
            fPayment.ShowDialog();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thêm và giỏ hàng thành công", "Thông báo");
        }

        private void FDetail_Load(object sender, EventArgs e)
        {

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
    }
}