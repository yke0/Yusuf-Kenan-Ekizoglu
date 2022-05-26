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
    public partial class Kullanıcı_Bilgileri : Form
        
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        public static string SqlCon = @"Data Source=DESKTOP-L7N942G\SQLEXPRESS;Initial Catalog=Çiftlik;Integrated Security=True";
        public Kullanıcı_Bilgileri()
        {
            InitializeComponent();
        }

        private void Kullanıcı_Bilgileri_Load(object sender, EventArgs e)
        {
            VeriTabanı.GridDoldur(dataGridView1, "select * from tbl_giris");
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[0].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
