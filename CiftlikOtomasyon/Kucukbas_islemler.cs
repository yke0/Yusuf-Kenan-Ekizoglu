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
    public partial class Kucukbas_islemler : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        public static string SqlCon = @"Data Source=DESKTOP-L7N942G\SQLEXPRESS;Initial Catalog=Çiftlik;Integrated Security=True";

        void GridDoldur()
        {
            con = new SqlConnection(SqlCon);
            da = new SqlDataAdapter("select * from tbl_kucukbas", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "tbl_kucukbas");

            dataGridView1.DataSource = ds.Tables["tbl_kucukbas"];
            con.Close();
        }
        public Kucukbas_islemler()
        {
            InitializeComponent();
        }

        private void Kucukbas_islemler_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            richTextBox1.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
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
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            string sql = "insert into tbl_kucukbas(sinif,tür,cins,yas,kilo,CiftligeEklenmeTarihi,[Dogum Sayısı],HakkındaNot,Cinsiyet,VerimYonu) values (@sinif,@tür,@cins,@yas,@kilo,@tarih,@dogum,@not,@cinsiyet,@verim)";
            cmd.Parameters.AddWithValue("@sinif", textBox2.Text);
            cmd.Parameters.AddWithValue("@tür", textBox3.Text);
            cmd.Parameters.AddWithValue("@cins", textBox4.Text);
            cmd.Parameters.AddWithValue("@yas", textBox6.Text);
            cmd.Parameters.AddWithValue("@kilo", textBox7.Text);
            cmd.Parameters.AddWithValue("@verim", textBox8.Text);
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
            string sql = "delete from tbl_kucukbas where sinif=@sinif and tür=@tür and KupeNo=@kNo and cins=@cins ";
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
            string sql = "update tbl_kucukbas set sinif=@sinif , tür=@tür , cins=@cins , yas=@yas , kilo=@kilo , [Dogum Sayısı]=@dogum , HakkındaNot=@not , Cinsiyet=@cinsiyet, VerimYonu=@verim where KupeNo=@kNo ";
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@sinif", textBox2.Text);
            cmd.Parameters.AddWithValue("@tür", textBox3.Text);
            cmd.Parameters.AddWithValue("@cins", textBox4.Text);
            cmd.Parameters.AddWithValue("@yas", Convert.ToInt32(textBox6.Text));
            cmd.Parameters.AddWithValue("@kilo", Convert.ToInt32(textBox7.Text));
            cmd.Parameters.AddWithValue("@verim", textBox8.Text);
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
    }
}
