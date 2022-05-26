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
    public partial class login : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        SqlDataReader dr;
        public static string SqlCon = @"Data Source=DESKTOP-L7N942G\SQLEXPRESS;Initial Catalog=Çiftlik;Integrated Security=True";

        public int denemeSayisi = 0;

        public static string kullanicimSession = "";
       
        public login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Login()
        {
            string sorgu = "select * from tbl_giris where kullaniciAdi=@user and sifre=@pass";
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", textBox1.Text);
            cmd.Parameters.AddWithValue("@pass", VeriTabanı.MD5Sifrele(textBox2.Text));

            con.Open();
            dr = cmd.ExecuteReader();
            //Eğer veri gelidyse
            if (dr.Read())
            {
                //MessageBox.Show("Giriş Başarılı...");
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya parola hatalı...");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
            con.Close();



        }
        private void button1_Click(object sender, EventArgs e)
        {
            Login();
            if (VeriTabanı.LoginKontrol(textBox1.Text, textBox2.Text))
            {
                
                this.Hide();
                kullanicimSession = textBox1.Text;
                if (kullanicimSession == "Yusuf" || kullanicimSession=="İste")
                {
                    MessageBox.Show("Admin Girişi Başarılı...");
                    //yönetici girişi
                    AdminArayuz a = new AdminArayuz();
                    a.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Girişi Başarılı...");
                    Kullanici_arayuz a = new Kullanici_arayuz();
                    a.Show();
                    //kullanıcı girişi
                }



                
            }
            else
            {
                denemeSayisi++;
                if (denemeSayisi == 3)
                {
                    MessageBox.Show("3 defa hatalı giriş yaptınız...");
                    Application.Exit();
                }
                MessageBox.Show("Kullanıcı adı veya parola hatalı...");
                textBox2.Clear();
                textBox2.Focus();
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
