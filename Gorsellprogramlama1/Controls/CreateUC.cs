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
    public partial class CreateUC : UserControl
    {
        public CreateUC()
        {
            InitializeComponent();
        }

        private void lblsifre_Click(object sender, EventArgs e)
        {

        }

        private void gosterCB_CheckedChanged(object sender, EventArgs e)
        {
            if (gosterCB.Checked)
                txtKsifre.PasswordChar = '\0';
            else txtKsifre.PasswordChar = '*';
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
       
        }

        private void txtKmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
