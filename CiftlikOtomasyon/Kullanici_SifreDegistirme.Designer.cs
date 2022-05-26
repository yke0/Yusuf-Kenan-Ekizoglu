
namespace CiftlikOtomasyon
{
    partial class Kullanici_SifreDegistirme
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
            this.textBox_EskiSifre = new System.Windows.Forms.TextBox();
            this.textBox_YeniSifre = new System.Windows.Forms.TextBox();
            this.textBox_SifreOnay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_captcha = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label_mesaj = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_EskiSifre
            // 
            this.textBox_EskiSifre.Location = new System.Drawing.Point(129, 20);
            this.textBox_EskiSifre.Name = "textBox_EskiSifre";
            this.textBox_EskiSifre.Size = new System.Drawing.Size(100, 20);
            this.textBox_EskiSifre.TabIndex = 0;
            // 
            // textBox_YeniSifre
            // 
            this.textBox_YeniSifre.Location = new System.Drawing.Point(129, 46);
            this.textBox_YeniSifre.Name = "textBox_YeniSifre";
            this.textBox_YeniSifre.Size = new System.Drawing.Size(100, 20);
            this.textBox_YeniSifre.TabIndex = 1;
            // 
            // textBox_SifreOnay
            // 
            this.textBox_SifreOnay.Location = new System.Drawing.Point(129, 72);
            this.textBox_SifreOnay.Name = "textBox_SifreOnay";
            this.textBox_SifreOnay.Size = new System.Drawing.Size(100, 20);
            this.textBox_SifreOnay.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Eski Şifrenizi Giriniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yeni Şifrenizi Giriniz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yeni Şifrenizi Onaylayın:";
            // 
            // label_captcha
            // 
            this.label_captcha.AutoSize = true;
            this.label_captcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_captcha.Location = new System.Drawing.Point(22, 120);
            this.label_captcha.Name = "label_captcha";
            this.label_captcha.Size = new System.Drawing.Size(86, 24);
            this.label_captcha.TabIndex = 6;
            this.label_captcha.Text = "Captcha";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(129, 124);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(57, 20);
            this.textBox4.TabIndex = 7;
            // 
            // label_mesaj
            // 
            this.label_mesaj.AutoSize = true;
            this.label_mesaj.Location = new System.Drawing.Point(35, 196);
            this.label_mesaj.Name = "label_mesaj";
            this.label_mesaj.Size = new System.Drawing.Size(35, 13);
            this.label_mesaj.TabIndex = 8;
            this.label_mesaj.Text = "Mesaj";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "Şifreyi Değiştir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(156, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 30);
            this.button2.TabIndex = 10;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Kullanici_SifreDegistirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 292);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_mesaj);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label_captcha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_SifreOnay);
            this.Controls.Add(this.textBox_YeniSifre);
            this.Controls.Add(this.textBox_EskiSifre);
            this.Name = "Kullanici_SifreDegistirme";
            this.ShowIcon = false;
            this.Text = "Şifre Değiştirme";
            this.Load += new System.EventHandler(this.Kullanici_SifreDegistirme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_EskiSifre;
        private System.Windows.Forms.TextBox textBox_YeniSifre;
        private System.Windows.Forms.TextBox textBox_SifreOnay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_captcha;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label_mesaj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}