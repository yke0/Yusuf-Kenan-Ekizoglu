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
    
    public partial class Buyukbas_islemler : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        public static string SqlCon = @"Data Source=DESKTOP-L7N942G\SQLEXPRESS;Initial Catalog=Çiftlik;Integrated Security=True";
        //user id=sa , password=XXXXXX  
        void GridDoldur()
        {
            con = new SqlConnection(SqlCon);
            da = new SqlDataAdapter("select * from tbl_buyukbas2", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "tbl_buyukbas2");

            dataGridView1.DataSource = ds.Tables["tbl_buyukbas2"];
            con.Close();
        }
        public Buyukbas_islemler()
        {
            InitializeComponent();
        }

        private void Ciftlik_islemleri_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBox10.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            richTextBox1.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            richTextBox1.Clear();
            textBox10.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            string sql = "insert into tbl_buyukbas2(sinif,tür,cins,yas,kilo,CiftligeEklenmeTarihi,SütÜretimi,OrtGünlükSüt,DogumSayısı,HakkındaNot,Cinsiyet) values (@sinif,@tür,@cins,@yas,@kilo,@tarih,@süt,@ortsüt,@dogum,@not,@cinsiyet)";
            cmd.Parameters.AddWithValue("@sinif", textBox2.Text);
            cmd.Parameters.AddWithValue("@tür",textBox3.Text);
            cmd.Parameters.AddWithValue("@cins", textBox4.Text);
            cmd.Parameters.AddWithValue("@yas", textBox6.Text);
            cmd.Parameters.AddWithValue("@kilo", textBox10.Text);
            cmd.Parameters.AddWithValue("@süt", textBox7.Text);
            cmd.Parameters.AddWithValue("@ortsüt", textBox8.Text);
            cmd.Parameters.AddWithValue("@dogum", textBox9.Text);
            cmd.Parameters.AddWithValue("@not", richTextBox1.Text);
            cmd.Parameters.AddWithValue("@tarih", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@cinsiyet", textBox5.Text);

            VeriTabanı.KomutYollaParametreli(sql, cmd);



            GridDoldur();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(SqlCon);
            string sql = "delete from tbl_buyukbas2 where sinif=@sinif and tür=@tür and KupeNo=@kNo and cins=@cins ";
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@sinif", textBox2.Text);
            cmd.Parameters.AddWithValue("@tür", textBox3.Text);
            cmd.Parameters.AddWithValue("@kNo", Convert.ToInt32(textBox1.Text));
            cmd.Parameters.AddWithValue("@cins", textBox4.Text);
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();
            GridDoldur();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(SqlCon);
            string sql = "update tbl_buyukbas2 set sinif=@sinif , tür=@tür , cins=@cins , yas=@yas , kilo=@kilo ,SütÜretimi=@süt ,OrtGünlükSüt=@ortsüt,DogumSayısı=@dogum, HakkındaNot=@not,Cinsiyet=@cinsiyet where KupeNo=@kNo ";
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@sinif", textBox2.Text);
            cmd.Parameters.AddWithValue("@tür", textBox3.Text);
            cmd.Parameters.AddWithValue("@cins", textBox4.Text);
            cmd.Parameters.AddWithValue("@yas", Convert.ToInt32(textBox6.Text));
            cmd.Parameters.AddWithValue("@kilo", Convert.ToInt32(textBox10.Text));
            cmd.Parameters.AddWithValue("@süt", textBox7.Text);
            cmd.Parameters.AddWithValue("@ortsüt", Convert.ToInt32(textBox8.Text));
            cmd.Parameters.AddWithValue("@dogum", Convert.ToInt32(textBox9.Text));
            cmd.Parameters.AddWithValue("@not", richTextBox1.Text);
            cmd.Parameters.AddWithValue("@tarih", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@cinsiyet", textBox5.Text);
            cmd.Parameters.AddWithValue("@kNo", Convert.ToInt32(textBox1.Text));

            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();
            GridDoldur();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
