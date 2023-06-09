namespace Gorsellprogramlama1.Controls
{
    partial class CreateUC
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
            this.lblKmail = new System.Windows.Forms.Label();
            this.lblKsifre = new System.Windows.Forms.Label();
            this.txtKmail = new System.Windows.Forms.TextBox();
            this.txtKsifre = new System.Windows.Forms.TextBox();
            this.gosterCB = new System.Windows.Forms.CheckBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKmail
            // 
            this.lblKmail.AutoSize = true;
            this.lblKmail.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKmail.Location = new System.Drawing.Point(18, 33);
            this.lblKmail.Name = "lblKmail";
            this.lblKmail.Size = new System.Drawing.Size(55, 17);
            this.lblKmail.TabIndex = 0;
            this.lblKmail.Text = "E-Mail :";
            // 
            // lblKsifre
            // 
            this.lblKsifre.AutoSize = true;
            this.lblKsifre.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKsifre.Location = new System.Drawing.Point(29, 78);
            this.lblKsifre.Name = "lblKsifre";
            this.lblKsifre.Size = new System.Drawing.Size(44, 17);
            this.lblKsifre.TabIndex = 1;
            this.lblKsifre.Text = "Şifre :";
            this.lblKsifre.Click += new System.EventHandler(this.lblsifre_Click);
            // 
            // txtKmail
            // 
            this.txtKmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKmail.Location = new System.Drawing.Point(83, 33);
            this.txtKmail.Name = "txtKmail";
            this.txtKmail.Size = new System.Drawing.Size(245, 22);
            this.txtKmail.TabIndex = 2;
            this.txtKmail.TextChanged += new System.EventHandler(this.txtKmail_TextChanged);
            // 
            // txtKsifre
            // 
            this.txtKsifre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKsifre.Location = new System.Drawing.Point(83, 78);
            this.txtKsifre.Name = "txtKsifre";
            this.txtKsifre.PasswordChar = '*';
            this.txtKsifre.Size = new System.Drawing.Size(245, 22);
            this.txtKsifre.TabIndex = 3;
            // 
            // gosterCB
            // 
            this.gosterCB.AutoSize = true;
            this.gosterCB.Location = new System.Drawing.Point(334, 80);
            this.gosterCB.Name = "gosterCB";
            this.gosterCB.Size = new System.Drawing.Size(69, 20);
            this.gosterCB.TabIndex = 4;
            this.gosterCB.Text = "Göster";
            this.gosterCB.UseVisualStyleBackColor = true;
            this.gosterCB.CheckedChanged += new System.EventHandler(this.gosterCB_CheckedChanged);
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(111, 106);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(182, 30);
            this.btnGirisYap.TabIndex = 6;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // CreateUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.gosterCB);
            this.Controls.Add(this.txtKsifre);
            this.Controls.Add(this.txtKmail);
            this.Controls.Add(this.lblKsifre);
            this.Controls.Add(this.lblKmail);
            this.Name = "CreateUC";
            this.Size = new System.Drawing.Size(418, 183);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKmail;
        private System.Windows.Forms.Label lblKsifre;
        private System.Windows.Forms.CheckBox gosterCB;
        public System.Windows.Forms.Button btnGirisYap;
        public System.Windows.Forms.TextBox txtKmail;
        public System.Windows.Forms.TextBox txtKsifre;
    }
}
