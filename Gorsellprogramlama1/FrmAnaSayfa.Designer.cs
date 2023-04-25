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
            this.BtnKayıtEkleme = new System.Windows.Forms.Button();
            this.BtnHakkımızda = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnDers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnKayıtEkleme
            // 
            this.BtnKayıtEkleme.Location = new System.Drawing.Point(57, 53);
            this.BtnKayıtEkleme.Name = "BtnKayıtEkleme";
            this.BtnKayıtEkleme.Size = new System.Drawing.Size(197, 60);
            this.BtnKayıtEkleme.TabIndex = 0;
            this.BtnKayıtEkleme.Text = "Kayıt Ekleme";
            this.BtnKayıtEkleme.UseVisualStyleBackColor = true;
            this.BtnKayıtEkleme.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnHakkımızda
            // 
            this.BtnHakkımızda.Location = new System.Drawing.Point(57, 329);
            this.BtnHakkımızda.Name = "BtnHakkımızda";
            this.BtnHakkımızda.Size = new System.Drawing.Size(197, 60);
            this.BtnHakkımızda.TabIndex = 3;
            this.BtnHakkımızda.Text = "Hakkımızda";
            this.BtnHakkımızda.UseVisualStyleBackColor = true;
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
            // BtnDers
            // 
            this.BtnDers.Location = new System.Drawing.Point(57, 183);
            this.BtnDers.Name = "BtnDers";
            this.BtnDers.Size = new System.Drawing.Size(197, 60);
            this.BtnDers.TabIndex = 5;
            this.BtnDers.Text = "Dersler";
            this.BtnDers.UseVisualStyleBackColor = true;
            this.BtnDers.Click += new System.EventHandler(this.BtnDers_Click);
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDers);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnHakkımızda);
            this.Controls.Add(this.BtnKayıtEkleme);
            this.Name = "FrmAnaSayfa";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnKayıtEkleme;
        private System.Windows.Forms.Button BtnHakkımızda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnDers;
    }
}

