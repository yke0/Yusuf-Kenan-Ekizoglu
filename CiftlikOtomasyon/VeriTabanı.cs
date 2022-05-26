using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace CiftlikOtomasyon
{
    class VeriTabanı
    {
        VeriTabanı()
        {

        }
        static SqlConnection con;
        static SqlDataAdapter da;
        static SqlCommand cmd;
        static SqlDataReader dr;
        static System.Data.DataSet ds;

        public static string SqlCon = @"Data Source=DESKTOP-L7N942G\SQLEXPRESS;Initial Catalog=Çiftlik;Integrated Security=True";
        
        public static bool BaglantiDurumu()
        {
            using (con = new SqlConnection(SqlCon))
            {
                try
                {
                    con.Open();
                    
                    return true;
                }

                catch (SqlException exp)
                {
                    System.Windows.Forms.MessageBox.Show(exp.Message);
                    return false;

                }
            }
        }

        public static DataGridView GridDoldur(DataGridView gridim, string sqlSelectSorgu)
        {
            con = new SqlConnection(SqlCon);
            da = new SqlDataAdapter(sqlSelectSorgu, con);
            ds = new System.Data.DataSet();
            con.Open();
            da.Fill(ds, sqlSelectSorgu);

            gridim.DataSource = ds.Tables[sqlSelectSorgu];
            con.Close();

            return gridim;
        }

        public static string MD5Sifrele(string SifrelenecekMetin)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] dizi = Encoding.UTF8.GetBytes(SifrelenecekMetin);

            //Dizinin hash değeri çıkartılıyor

            dizi = md5.ComputeHash(dizi);

            StringBuilder sb = new StringBuilder();

            foreach (byte item in dizi)
                sb.Append(item.ToString("x2").ToLower());

            return sb.ToString();
        }

        

        public static bool LoginKontrol(string kullaniciAdi, string sifre)
        {
            string sorgu = "select * from tbl_giris where kullaniciAdi=@user and sifre=@pass";
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", kullaniciAdi);
            cmd.Parameters.AddWithValue("@pass", VeriTabanı.MD5Sifrele(sifre));

            con.Open();
            dr = cmd.ExecuteReader();
            

            if (dr.Read())
            {
                
                con.Close();
                return true;

            }
            else
            {
                
                con.Close();
                return false;

            }




        }

        public static void KomutYolla(string sql)
        {
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public static void KomutYollaParametreli(string sql, SqlCommand cmd)
        {
            con = new SqlConnection(SqlCon);
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();
        }









    }
}
