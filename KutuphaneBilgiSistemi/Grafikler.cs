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

namespace KutuphaneBilgiSistemi
{
    public partial class Grafikler : Form
    {
        public Grafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=TB701-5876;Initial Catalog=KutuphaneBS;Integrated Security=True");
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Grafikler_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT AdSoyad, OkunanKitapSayisi FROM Uyeler", baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                // chart1.Series["OkunanKitapSayisi"].Points.AddXY(reader["AdSoyad"].ToString(), reader["OkunanKitapSayisi"]);
            }
            baglanti.Close();
            // chart1.Series["OkunanKitapSayisi"].Color = Color.Green;
        }
    }
}
