using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Database;
using Firebase.Storage;
using Firebase.Database.Query;




namespace Gorsellprogramlama1
{
    public partial class FrmAnaSayfa : Form
    {
       
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            FrmKayıt frm2 = new FrmKayıt();
            frm2.Show();
            this.Hide();

        }

        private void BtnDers_Click(object sender, EventArgs e)
        {
            FrmDersler frm3 = new FrmDersler();
            frm3.Show();
            this.Hide();
        }

        private void BtnHakkımızda_Click(object sender, EventArgs e)
        {
            FrmHakkımızda frm4 = new FrmHakkımızda();
            frm4.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
