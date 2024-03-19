using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mysql_1313
{
    public partial class Form1 : Form
    {
      string baglantimetin =  "Server=localhost;Database=film_arsiv;Uid=root;Pwd='';";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (MySqlConnection baglan = new MySqlConnection(baglantimetin))
            {
                baglan.Open();
                string sorgu = "SELECT * FROM filmler;";

                MySqlCommand cmd = new MySqlCommand(sorgu,baglan);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);

                dgwFilmler.DataSource = dt;

            }  
        }

        private void btnElestiriForm_Click(object sender, EventArgs e)
        {
            FormElestiri formElestiri = new FormElestiri();
            formElestiri.ShowDialog();
        }

     
    }
}
