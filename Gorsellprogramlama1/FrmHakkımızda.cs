﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gorsellprogramlama1
{
    public partial class FrmHakkımızda : Form
    {
        public FrmHakkımızda()
        {
            InitializeComponent();
        }

        private void FrmHakkımızda_Load(object sender, EventArgs e)
        {

        }

        private void geriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa frm = new FrmAnaSayfa();
            frm.Show();
            this.Hide();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnrmzn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dr. Öğretim Üyesi Ramazan Özgür Doğan");
        }

        private void btnslh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Öğretim Üyesi Salih Türk");
        }

        private void btnozkn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dr. Öğretim Üyesi Özkan Bingöl");
        }
    }
}
