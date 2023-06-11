using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gorsellprogramlama1.Controls
{
    public partial class LoginUC : UserControl
    {
        public LoginUC()
        {
            InitializeComponent();
        }

        private void gosterK_CheckedChanged(object sender, EventArgs e)
        {
            if (gosterK.Checked)
                txtsifre.PasswordChar = '\0';
            else txtsifre.PasswordChar = '*';
        }

        private void btnKKaydol_Click(object sender, EventArgs e)
        {
            
        }

      

        private void txtGmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
