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
    public partial class BuyukbasRapor : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        public static string SqlCon = @"Data Source=DESKTOP-L7N942G\SQLEXPRESS;Initial Catalog=Çiftlik;Integrated Security=True";

        public void RaporDoldur(string sql)
        {
            con = new SqlConnection(SqlCon);
            da = new SqlDataAdapter(sql,con);
            ds = new DataSet();

            con.Open();
            da.Fill(ds);
            crystalReport22.SetDataSource(ds.Tables[0]);
            crystalReportViewer1.ReportSource = crystalReport22;
            con.Close();
        }
        public BuyukbasRapor()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            RaporDoldur("select * from tbl_buyukbas2");
        }
    }
}
