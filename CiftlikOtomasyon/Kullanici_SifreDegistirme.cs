using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CiftlikOtomasyon
{
    public partial class Kullanici_SifreDegistirme : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        SqlDataReader dr;
        public static string SqlCon = @"Data Source=DESKTOP-L7N942G\SQLEXPRESS;Initial Catalog=Çiftlik;Integrated Security=True";

        public int sonuc = 0;
        public Kullanici_SifreDegistirme()
        {
            InitializeComponent();
        }

        private void Kullanici_SifreDegistirme_Load(object sender, EventArgs e)
        {
            CapcthaOlustur();
            label_mesaj.Text = "";

        }
        public void EskiSifreKontrol()
        {
            string sorgu = "select sifre from tbl_giris where kullaniciAdi=@user and sifre=@pass ";
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", login.kullanicimSession);
            cmd.Parameters.AddWithValue("@pass", VeriTabanı.MD5Sifrele(textBox_EskiSifre.Text));

            con.Open();
            dr = cmd.ExecuteReader();
            //Eğer veri gelidyse
            if (dr.Read())
            {
                //eski şifre doğruysa

                string sql = "update tbl_giris set sifre='" + VeriTabanı.MD5Sifrele(textBox_YeniSifre.Text) + "'";
                VeriTabanı.KomutYolla(sql);
                MessageBox.Show("Şifreniz değiştirildi.");
                label_mesaj.Text = "Şifreniz değiştirildi.";

            }
            else
            {
                label_mesaj.Text = "Eski şifreniz yanlış.";
                CapcthaOlustur();

            }
            con.Close();
            }
        public void CapcthaOlustur()
        {
            Random r = new Random();
            int ilk = r.Next(0, 50);
            int ikinci = r.Next(0, 50);

            sonuc = ilk + ikinci;
            label_captcha.Text = ilk.ToString() + "+" + ikinci.ToString() + "=";
            textBox4.Clear();
            //label_Mesaj.Text =login.kullanicimSession;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == sonuc.ToString())
            {
                label_mesaj.Text = "";
                if (textBox_YeniSifre.Text == textBox_SifreOnay.Text)
                {
                    label_mesaj.Text = "";
                    EskiSifreKontrol();
                }
                else
                {
                    label_mesaj.Text = "Girilen yeni şifreler aynı değil...";
                    CapcthaOlustur();
                }

            }
            else
            {
                label_mesaj.Text = "Caphtca işlemini kontrol ediniz...";
                CapcthaOlustur();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
