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
    public partial class Form2 : Form
    {
        string baglantimetin = "Server=localhost;Database=film_arsiv;Uid=root;Pwd='';";
        public Form2()
        {
            InitializeComponent();
        }

      
        private void Form2_Load(object sender, EventArgs e)
        {
            using (MySqlConnection baglan = new MySqlConnection(baglantimetin))
            {
                baglan.Open();
                string sorgu = "SELECT filmler.film_id,film_ad,tur,elestiri_metin,elestirmen\r\nFROM filmler\r\nJOIN elestiriler ON filmler.film_id = elestiriler.film_id;";

                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;

            }
        }
    }
}
