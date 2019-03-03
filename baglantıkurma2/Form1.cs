using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace baglantıkurma2
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti2 = new SqlConnection();
            baglanti2.ConnectionString = @"Data Source=WISSEN\MSSQLSRV;Initial Catalog=Northwind; User ID=sa;Password=12345srv;Integrated Security=False";

            baglanti2.Open();
            MessageBox.Show("baglanti local degisken ile saglandi");

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (baglanti.State != ConnectionState.Open)
                baglanti.ConnectionString = @"Data Source=WISSEN\MSSQLSRV;Initial Catalog=Northwind; User ID=sa;Password=12345srv;Integrated Security=False";

            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
                MessageBox.Show("Global degisken  ile açılan bağlantı kapatıldı.");
            }
            else
            {
                baglanti.Open();
                MessageBox.Show("baglanti global ile saglandi");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (baglanti.State != ConnectionState.Open)
                baglanti.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;

            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
                MessageBox.Show("App.config ile açılan bağlantı kapatıldı.");
            }
            else
            {
                baglanti.Open();
                MessageBox.Show("baglanti app.config ile saglandi");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (baglanti.State != ConnectionState.Open)
                baglanti.ConnectionString = Tools.ConnectionString;

            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
                MessageBox.Show("Tools classı ile açılan bağlantı kapatıldı");
            }
            else
            {
                baglanti.Open();
                MessageBox.Show("Bağlantı  Tools classı ile  açıldı.");
            }
        }

       
    }
}
