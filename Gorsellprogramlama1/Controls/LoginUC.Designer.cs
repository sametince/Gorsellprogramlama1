namespace Gorsellprogramlama1.Controls
{
    partial class LoginUC
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnKKaydol = new System.Windows.Forms.Button();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.lblsifre = new System.Windows.Forms.Label();
            this.lblmail = new System.Windows.Forms.Label();
            this.gosterK = new System.Windows.Forms.CheckBox();
            this.txtGmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKKaydol
            // 
            this.btnKKaydol.Location = new System.Drawing.Point(122, 101);
            this.btnKKaydol.Name = "btnKKaydol";
            this.btnKKaydol.Size = new System.Drawing.Size(182, 27);
            this.btnKKaydol.TabIndex = 11;
            this.btnKKaydol.Text = "Kaydol";
            this.btnKKaydol.UseVisualStyleBackColor = true;
            this.btnKKaydol.Click += new System.EventHandler(this.btnKKaydol_Click);
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(76, 72);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.PasswordChar = '*';
            this.txtsifre.Size = new System.Drawing.Size(261, 22);
            this.txtsifre.TabIndex = 9;
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsifre.Location = new System.Drawing.Point(26, 72);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(44, 17);
            this.lblsifre.TabIndex = 7;
            this.lblsifre.Text = "Şifre :";
            // 
            // lblmail
            // 
            this.lblmail.AutoSize = true;
            this.lblmail.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmail.Location = new System.Drawing.Point(15, 29);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(55, 17);
            this.lblmail.TabIndex = 6;
            this.lblmail.Text = "E-Mail :";
            // 
            // gosterK
            // 
            this.gosterK.AutoSize = true;
            this.gosterK.Location = new System.Drawing.Point(343, 74);
            this.gosterK.Name = "gosterK";
            this.gosterK.Size = new System.Drawing.Size(69, 20);
            this.gosterK.TabIndex = 12;
            this.gosterK.Text = "Göster";
            this.gosterK.UseVisualStyleBackColor = true;
            this.gosterK.CheckedChanged += new System.EventHandler(this.gosterK_CheckedChanged);
            // 
            // txtGmail
            // 
            this.txtGmail.Location = new System.Drawing.Point(76, 27);
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.Size = new System.Drawing.Size(261, 22);
            this.txtGmail.TabIndex = 13;
            this.txtGmail.TextChanged += new System.EventHandler(this.txtGmail_TextChanged);
            // 
            // LoginUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtGmail);
            this.Controls.Add(this.gosterK);
            this.Controls.Add(this.btnKKaydol);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.lblmail);
            this.Name = "LoginUC";
            this.Size = new System.Drawing.Size(457, 232);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.CheckBox gosterK;
        public System.Windows.Forms.Button btnKKaydol;
        public System.Windows.Forms.TextBox txtsifre;
        public System.Windows.Forms.TextBox txtGmail;
    }
}
