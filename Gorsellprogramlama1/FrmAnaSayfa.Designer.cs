﻿namespace Gorsellprogramlama1
{
    partial class FrmAnaSayfa
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnKayıtEkleme = new System.Windows.Forms.Button();
            this.BtnHakkımızda = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnKayıtEkleme
            // 
            this.BtnKayıtEkleme.BackColor = System.Drawing.Color.IndianRed;
            this.BtnKayıtEkleme.Location = new System.Drawing.Point(57, 63);
            this.BtnKayıtEkleme.Name = "BtnKayıtEkleme";
            this.BtnKayıtEkleme.Size = new System.Drawing.Size(197, 60);
            this.BtnKayıtEkleme.TabIndex = 0;
            this.BtnKayıtEkleme.Text = "Kayıt Ekleme";
            this.BtnKayıtEkleme.UseVisualStyleBackColor = false;
            this.BtnKayıtEkleme.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnHakkımızda
            // 
            this.BtnHakkımızda.BackColor = System.Drawing.Color.IndianRed;
            this.BtnHakkımızda.Location = new System.Drawing.Point(57, 190);
            this.BtnHakkımızda.Name = "BtnHakkımızda";
            this.BtnHakkımızda.Size = new System.Drawing.Size(197, 60);
            this.BtnHakkımızda.TabIndex = 3;
            this.BtnHakkımızda.Text = "Kurum Hakkında";
            this.BtnHakkımızda.UseVisualStyleBackColor = false;
            this.BtnHakkımızda.Click += new System.EventHandler(this.BtnHakkımızda_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gorsellprogramlama1.Properties.Resources.Gümüşhane_University;
            this.pictureBox1.Location = new System.Drawing.Point(272, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(516, 313);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(57, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 60);
            this.button1.TabIndex = 6;
            this.button1.Text = "ÇIKIŞ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnHakkımızda);
            this.Controls.Add(this.BtnKayıtEkleme);
            this.MaximizeBox = false;
            this.Name = "FrmAnaSayfa";
            this.Text = "Ana Sayfa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnKayıtEkleme;
        private System.Windows.Forms.Button BtnHakkımızda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

