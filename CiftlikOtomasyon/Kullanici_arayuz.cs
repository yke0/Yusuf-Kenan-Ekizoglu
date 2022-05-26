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
    public partial class Kullanici_arayuz : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd, cmd1;
        DataSet ds;
        public static string SqlCon = @"Data Source=DESKTOP-L7N942G\SQLEXPRESS;Initial Catalog=Çiftlik;Integrated Security=True";
        public string sqlSorgu;

        void GridDoldur(string sqlSorgu)
        {
            con = new SqlConnection(SqlCon);
            da = new SqlDataAdapter(sqlSorgu, con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "tbl_buyukbas2");

            dataGridView1.DataSource = ds.Tables["tbl_buyukbas2"];
            con.Close();
        }
        public Kullanici_arayuz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            VeriTabanı.GridDoldur(dataGridView1, "select * from tbl_buyukbas2");
            dataGridView1.Columns[0].HeaderText = "Küpe Numarası";
            dataGridView1.Columns[1].HeaderText = "Sınıf";
            dataGridView1.Columns[2].HeaderText = "Tür";
            dataGridView1.Columns[3].HeaderText = "Cins";
            dataGridView1.Columns[4].HeaderText = "Cinsiyet";
            dataGridView1.Columns[5].HeaderText = "Yaş";
            dataGridView1.Columns[6].HeaderText = "Süt Veriyor mu?";
            dataGridView1.Columns[7].HeaderText = "Verdiği Günlük Sütün Ortalaması(L)";
            dataGridView1.Columns[8].HeaderText = "Yaptığı Doğum Sayısı";
            dataGridView1.Columns[9].HeaderText = "Kilo";
            dataGridView1.Columns[10].HeaderText = "Not";
            dataGridView1.Columns[11].HeaderText = "Çiftliğe Eklendiği Tarih";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VeriTabanı.GridDoldur(dataGridView1, "select * from tbl_kucukbas");
            dataGridView1.Columns[0].HeaderText = "Küpe Numarası";
            dataGridView1.Columns[1].HeaderText = "Sınıf";
            dataGridView1.Columns[2].HeaderText = "Tür";
            dataGridView1.Columns[3].HeaderText = "Cins";
            dataGridView1.Columns[4].HeaderText = "Cinsiyet";
            dataGridView1.Columns[5].HeaderText = "Yaş";
            dataGridView1.Columns[6].HeaderText = "Beslenme Amacı";
            dataGridView1.Columns[7].HeaderText = "Yaptığı Doğum Sayısı";
            dataGridView1.Columns[8].HeaderText = "Kilo";
            dataGridView1.Columns[9].HeaderText = "Not";
            dataGridView1.Columns[10].HeaderText = "Çiftliğe Eklenme Tarihi";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Buyukbas_islemler a = new Buyukbas_islemler();
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Kucukbas_islemler a = new Kucukbas_islemler();
            a.Show();
        }

        private void Kullanici_arayuz_Load(object sender, EventArgs e)
        {
           
        }
    }
}
