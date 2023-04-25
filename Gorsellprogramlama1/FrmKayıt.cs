using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Firebase.Auth;
using Firebase.Auth.Providers;
using Firebase.Auth.Repository;
using System.Diagnostics.Eventing.Reader;

namespace Gorsellprogramlama1
{
    public partial class FrmKayıt : Form
    {
        public FrmKayıt()
        {
            InitializeComponent();
        }

        
        

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            txtKurs.Text = "Görsel Programlama";
            txtEgitmen.Text = "Ramazan Ozgur Doğan";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            txtKurs.Text = "Yazılım, Test ve Doğrulama";
            txtEgitmen.Text = "Salih Turk";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtKurs.Text = "Elektronik Ticaret";
            txtEgitmen.Text = "Ozkan Bingol";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void FrmKayıt_Load(object sender, EventArgs e)
        {

        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnKayıt_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string mail = txtMail.Text;
            string telefon = maskedTextBox1.Text;
            string kurs = txtKurs.Text;
            string cinsiyet= maskedTextBox1.Text;

            if (ad == "" || soyad == "" || mail == "" || telefon == "" || kurs == "" || cinsiyet == "")
            {
                MessageBox.Show("Eksik Bilgi Girdiniz.");
            }
           
                               
            else
                MessageBox.Show("Kaydedildi");
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
    }
}
