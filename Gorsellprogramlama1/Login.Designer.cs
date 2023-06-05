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
            this.BtnGiriş = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGiriş
            // 
            this.BtnGiriş.Location = new System.Drawing.Point(201, 280);
            this.BtnGiriş.Name = "BtnGiriş";
            this.BtnGiriş.Size = new System.Drawing.Size(75, 23);
            this.BtnGiriş.TabIndex = 0;
            this.BtnGiriş.Text = "Giriş Yap";
            this.BtnGiriş.UseVisualStyleBackColor = true;
            this.BtnGiriş.Click += new System.EventHandler(this.BtnGiriş_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnGiriş);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGiriş;
    }
}