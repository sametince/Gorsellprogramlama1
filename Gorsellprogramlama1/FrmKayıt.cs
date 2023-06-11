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
using Firebase.Database;
using Firebase.Database.Query;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Gorsellprogramlama1.Controls;

namespace Gorsellprogramlama1
{
    public partial class FrmKayıt : Form
    {
        private FirebaseClient firebase_istemci;

        public FrmKayıt()
        {
            InitializeComponent();

            firebase_istemci = new FirebaseClient("https://gorselprogramlama-48e82-default-rtdb.firebaseio.com/");

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

        private void txtKurs_TextChanged(object sender, EventArgs e)
        {

        }
        public void txtMail_TextChanged(object sender, EventArgs e)
        {
        
        }


        private void FrmKayıt_Load(object sender, EventArgs e)
        {
           

        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }

       

        private async void BtnKayıt_Click(object sender, EventArgs e)
        {
            string Ad = txtAd.Text;
            string SoyAd = txtSoyad.Text;
            string Mail = txtMail.Text;
            string Cinsiyet = comboBox1.Text;
            string Kurs = txtKurs.Text;
            string Egitmen = txtEgitmen.Text;
            string Telefon = maskedTextBox1.Text;
            if (Ad == "" || SoyAd == "" || Mail == "" || Telefon == "" || Kurs == "" || Cinsiyet == "" )
            {
                MessageBox.Show("Eksik Bilgi Girdiniz.");
            }


            else
            {
                MessageBox.Show("Kaydediliyor..");

                KursK ogr1 = new KursK();
                ogr1.Ad = txtAd.Text;
                ogr1.SoyAd = txtSoyad.Text;
                ogr1.Mail = txtMail.Text;
                ogr1.Cinsiyet = comboBox1.Text;
                ogr1.Kurs = txtKurs.Text;
                ogr1.Egitmen = txtEgitmen.Text;
                ogr1.Telefon = maskedTextBox1.Text;

                if (txtKurs.Text == button2.Text)
                {
                   
                    await firebase_istemci.Child("Kurs").Child("Gorsel Programlama").Child(ogr1.Mail).PutAsync(ogr1);
                    return;
                }
                if (txtKurs.Text == button3.Text)
                {
                    await firebase_istemci.Child("Kurs").Child("Yazılım, Test, Doğrulama").Child(ogr1.Mail).PutAsync(ogr1);

                    return;
                }
                if(txtKurs.Text == button4.Text)
                {
                    await firebase_istemci.Child("Kurs").Child("Elektronik Ticaret").Child(ogr1.Mail).PutAsync(ogr1);
                    return;
                }

               
            }
        }

        private  void geriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa frm = new FrmAnaSayfa();
            frm.Show();
            this.Hide();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private async void btnsil_Click(object sender, EventArgs e)
        {
            string Ad = txtAd.Text;
            string SoyAd = txtSoyad.Text;
            string Mail = txtMail.Text;
            string Cinsiyet = comboBox1.Text;
            string Kurs = txtKurs.Text;
            string Egitmen = txtEgitmen.Text;
            string Telefon = maskedTextBox1.Text;
            if (Ad == "" || SoyAd == "" || Mail == "" || Telefon == "" || Kurs == "" || Cinsiyet == "")
            {
                MessageBox.Show("Eksik Bilgi Girdiniz.");
            }


            else
            {
                MessageBox.Show("Siliniyor..");

                KursK ogr1 = new KursK();
                ogr1.Ad = txtAd.Text;
                ogr1.SoyAd = txtSoyad.Text;
                ogr1.Mail = txtMail.Text;
                ogr1.Cinsiyet = comboBox1.Text;
                ogr1.Kurs = txtKurs.Text;
                ogr1.Egitmen = txtEgitmen.Text;
                ogr1.Telefon = maskedTextBox1.Text;

                if (txtKurs.Text == button2.Text)
                {

                    await firebase_istemci.Child("Kurs").Child("Gorsel Programlama").Child(ogr1.Mail).DeleteAsync();
                    return;
                }
                if (txtKurs.Text == button3.Text)
                {
                    await firebase_istemci.Child("Kurs").Child("Yazılım, Test, Doğrulama").Child(ogr1.Mail).DeleteAsync();

                    return;
                }
                if (txtKurs.Text == button4.Text)
                {
                    await firebase_istemci.Child("Kurs").Child("Elektronik Ticaret").Child(ogr1.Mail).DeleteAsync();
                    return;
                }


            }
        }
    }
}
