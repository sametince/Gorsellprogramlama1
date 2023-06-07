namespace Gorsellprogramlama1
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kullanıcıPanel = new System.Windows.Forms.Panel();
            this.btnKullanıcıGirisi = new System.Windows.Forms.Button();
            this.btnYeniKullanıcı = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kullanıcıPanel
            // 
            this.kullanıcıPanel.Location = new System.Drawing.Point(11, 41);
            this.kullanıcıPanel.Name = "kullanıcıPanel";
            this.kullanıcıPanel.Size = new System.Drawing.Size(445, 371);
            this.kullanıcıPanel.TabIndex = 0;
            // 
            // btnKullanıcıGirisi
            // 
            this.btnKullanıcıGirisi.Location = new System.Drawing.Point(12, 12);
            this.btnKullanıcıGirisi.Name = "btnKullanıcıGirisi";
            this.btnKullanıcıGirisi.Size = new System.Drawing.Size(100, 23);
            this.btnKullanıcıGirisi.TabIndex = 1;
            this.btnKullanıcıGirisi.Text = "Kullanıcı Girişi";
            this.btnKullanıcıGirisi.UseVisualStyleBackColor = true;
            this.btnKullanıcıGirisi.Click += new System.EventHandler(this.btnKullanıcıGirisi_Click);
            // 
            // btnYeniKullanıcı
            // 
            this.btnYeniKullanıcı.Location = new System.Drawing.Point(128, 12);
            this.btnYeniKullanıcı.Name = "btnYeniKullanıcı";
            this.btnYeniKullanıcı.Size = new System.Drawing.Size(129, 23);
            this.btnYeniKullanıcı.TabIndex = 2;
            this.btnYeniKullanıcı.Text = "Yeni Kullanıcı Girişi";
            this.btnYeniKullanıcı.UseVisualStyleBackColor = true;
            this.btnYeniKullanıcı.Click += new System.EventHandler(this.btnYeniKullanıcı_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 415);
            this.Controls.Add(this.btnYeniKullanıcı);
            this.Controls.Add(this.btnKullanıcıGirisi);
            this.Controls.Add(this.kullanıcıPanel);
            this.Name = "Login";
            this.Text = "Giriş Yap";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel kullanıcıPanel;
        private System.Windows.Forms.Button btnKullanıcıGirisi;
        private System.Windows.Forms.Button btnYeniKullanıcı;
    }
}