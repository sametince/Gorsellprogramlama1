using Firebase.Auth.Providers;
using Firebase.Auth.Repository;
using Firebase.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gorsellprogramlama1.Controls;

namespace Gorsellprogramlama1
{
    public partial class Login : Form
    {
        private string AuthDomain, ApiKey;
        private LoginUC loginUC;
        private CreateUC createUC;
        private FirebaseAuthClient client;



        public Login(string AuthDomain, string ApiKey)
        {
            InitializeComponent();
            this.AuthDomain = AuthDomain;
            this.ApiKey = ApiKey;

            loginUC = new LoginUC();
            createUC = new CreateUC();

            btnKullanıcıGirisi_Click(this, EventArgs.Empty);

            this.createUC.btnGirisYap.Click += BtnGirisYap_Click;
            this.loginUC.btnKKaydol.Click += BtnKKaydol_Click;


            FirebaseAuthConfig config = new FirebaseAuthConfig
            {
                ApiKey = ApiKey,
                AuthDomain = AuthDomain,
                Providers = new FirebaseAuthProvider[]{new EmailProvider()},
            };


            this.client = new FirebaseAuthClient(config);
        }

        private async void BtnKKaydol_Click(object sender, EventArgs e)
        {
            try
            {
                UserCredential kullanici_kimligi = await client.CreateUserWithEmailAndPasswordAsync(this.loginUC.txtmail.Text.Trim(), this.loginUC.txtsifre.Text.Trim());
               
                FrmAnaSayfa nesne = new FrmAnaSayfa();
                nesne.Show();
                this.Hide();
            }
            catch (Exception exc)
            {
                MessageBox.Show("HATA:" + exc.Message);
            }
            finally
            {

            }
        }

        private async void BtnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                UserCredential kullanici_kimligi = await client.SignInWithEmailAndPasswordAsync(this.createUC.txtKmail.Text.Trim(), this.createUC.txtKsifre.Text.Trim());
                
                FrmAnaSayfa nesne=new FrmAnaSayfa(); 
                nesne.Show();
                this.Hide();

            }
            catch(Exception exc)
            {
                MessageBox.Show("HATA:" + exc.Message);            
            }
            finally { 
                            
            }
        
        }

        private void btnYeniKullanıcı_Click(object sender, EventArgs e)
        {     
            kullanıcıPanel.Controls.Clear();
            kullanıcıPanel.Controls.Add(loginUC);

        }

        private void btnKullanıcıGirisi_Click(object sender, EventArgs e)
        {
            kullanıcıPanel.Controls.Clear();
            kullanıcıPanel.Controls.Add(createUC);

        }

       
    }
}
