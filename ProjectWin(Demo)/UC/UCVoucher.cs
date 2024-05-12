﻿using System;
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
    public partial class UCVoucher : UserControl
    {
        private int id;
        Voucher voucher;
        public event EventHandler BtnClick_ApDung;
        public UCVoucher(Voucher voucher, int id)
        {
            InitializeComponent();
            this.voucher = voucher;
            this.id = id;
        }

        private void UCVoucher_Load(object sender, EventArgs e)
        {
            lblMoTa.Text = voucher.MoTa;
            lblMaVoucher.Text = voucher.MaVoucher;
            lblSoLuong.Text = "x" + voucher.SoLuong.ToString();
            lblHSD.Text = voucher.HSD.ToString("dd/MM/yyyy");
        }

        private void btnApDung_Click(object sender, EventArgs e)
        {
            BtnClick_ApDung?.Invoke(this, e);
        }
    }
}