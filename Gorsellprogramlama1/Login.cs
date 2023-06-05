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

namespace Gorsellprogramlama1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnGiriş_Click(object sender, EventArgs e)
        {
            loginAsync().RunSynchronously();
        }
        public async Task loginAsync()
        {
            // Configure...
            var config = new FirebaseAuthConfig
            {
                ApiKey = "AIzaSyBht0mtjAcTojE2TulHuTQ-vkFgWUaLst4",
                AuthDomain = "gorselprogramlama-60cce.firebaseapp.com",
                Providers = new FirebaseAuthProvider[]
                {
                    // Add and configure individual providers
                    new GoogleProvider().AddScopes("email"),
                    new EmailProvider()
                    // ...
                },

            };

            // ...and create your FirebaseAuthClient
            var client = new FirebaseAuthClient(config);

            var userCredential = await client.SignInWithEmailAndPasswordAsync("samet.inc@icloud.com", "12345sa!");

            var user = userCredential.User;
            var uid = user.Uid;
            var name = user.Info.DisplayName; // more properties are available in user.Info
            var refreshToken = user.Credential.RefreshToken;

            // user methods
            var token = await user.GetIdTokenAsync();
        }
    }
}
