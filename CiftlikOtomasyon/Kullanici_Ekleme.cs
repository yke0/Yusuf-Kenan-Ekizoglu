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
    public partial class Kullanici_Ekleme : Form
    {

        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        public static string SqlCon = @"Data Source=DESKTOP-L7N942G\SQLEXPRESS;Initial Catalog=Çiftlik;Integrated Security=True";
        void GridDoldur()
        {
            con = new SqlConnection(SqlCon);
            da = new SqlDataAdapter("select * from tbl_giris", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "tbl_giris");

            dataGridView1.DataSource = ds.Tables["tbl_giris"];
            con.Close();
        }
        public Kullanici_Ekleme()
        {
            InitializeComponent();
        }

        private void Kullanici_Ekleme_Load(object sender, EventArgs e)
        {
            VeriTabanı.GridDoldur(dataGridView1, "select * from tbl_giris");
            dataGridView1.Columns[2].HeaderText = "Kullanıcının Şifresi(MD5)";
            dataGridView1.Columns[0].HeaderText = "Kullanıcı Numarası";
            dataGridView1.Columns[1].HeaderText = "Kullanıcı Adı";
            dataGridView1.Columns[3].HeaderText = "Kullanıcının Yetkisi";
            dataGridView1.Columns[4].HeaderText = "Son Giriş Tarihi";
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            string sql = "insert into tbl_giris(kullaniciAdi,sifre,songiristarihi,yetki) values (@user,@pass,@tarih,@yetki)";
            cmd.Parameters.AddWithValue("@user", textBox2.Text);
            cmd.Parameters.AddWithValue("@pass", VeriTabanı.MD5Sifrele(textBox3.Text));
            cmd.Parameters.AddWithValue("@tarih", DateTime.Now);
            cmd.Parameters.AddWithValue("@yetki", textBox4.Text);

            VeriTabanı.KomutYollaParametreli(sql, cmd);



            GridDoldur();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(SqlCon);
            string sql = "delete from tbl_giris where kullaniciAdi=@user and sifre=@pass and kID=@kID";
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@user", textBox2.Text);
            cmd.Parameters.AddWithValue("@pass", textBox3.Text);
            cmd.Parameters.AddWithValue("@kID", Convert.ToInt32(textBox1.Text));
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();
            GridDoldur();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(SqlCon);
            string sql = "update tbl_giris set sifre=@pass,yetki=@yetki where kullaniciAdi=@user and kID=@kID";
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@user", textBox2.Text);
            cmd.Parameters.AddWithValue("@pass", VeriTabanı.MD5Sifrele(textBox3.Text));
            cmd.Parameters.AddWithValue("@kID", Convert.ToInt32(textBox1.Text));
            cmd.Parameters.AddWithValue("@yetki", textBox4.Text);
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();
            GridDoldur();
        }
    }
}
