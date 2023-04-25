namespace Gorsellprogramlama1
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
            this.BtnDersler = new System.Windows.Forms.Button();
            this.BtnDersEkle = new System.Windows.Forms.Button();
            this.BtnHakkımızda = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDersler
            // 
            this.BtnDersler.Location = new System.Drawing.Point(51, 53);
            this.BtnDersler.Name = "BtnDersler";
            this.BtnDersler.Size = new System.Drawing.Size(197, 37);
            this.BtnDersler.TabIndex = 0;
            this.BtnDersler.Text = "Kayıt Ekleme";
            this.BtnDersler.UseVisualStyleBackColor = true;
            this.BtnDersler.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnDersEkle
            // 
            this.BtnDersEkle.Location = new System.Drawing.Point(51, 188);
            this.BtnDersEkle.Name = "BtnDersEkle";
            this.BtnDersEkle.Size = new System.Drawing.Size(197, 37);
            this.BtnDersEkle.TabIndex = 1;
            this.BtnDersEkle.Text = "Dersler";
            this.BtnDersEkle.UseVisualStyleBackColor = true;
            this.BtnDersEkle.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnHakkımızda
            // 
            this.BtnHakkımızda.Location = new System.Drawing.Point(51, 329);
            this.BtnHakkımızda.Name = "BtnHakkımızda";
            this.BtnHakkımızda.Size = new System.Drawing.Size(197, 37);
            this.BtnHakkımızda.TabIndex = 3;
            this.BtnHakkımızda.Text = "Hakkımızda";
            this.BtnHakkımızda.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gorsellprogramlama1.Properties.Resources.Gümüşhane_University;
            this.pictureBox1.Location = new System.Drawing.Point(272, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(516, 313);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnHakkımızda);
            this.Controls.Add(this.BtnDersEkle);
            this.Controls.Add(this.BtnDersler);
            this.Name = "FrmAnaSayfa";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnDersler;
        private System.Windows.Forms.Button BtnDersEkle;
        private System.Windows.Forms.Button BtnHakkımızda;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

