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
    public partial class Siralama : Form
    {
        public Siralama()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=TB701-5876;Initial Catalog=KutuphaneBS;Integrated Security=True");
        DataSet ds = new DataSet();
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Siralama_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Uyeler ORDER BY OkunanKitapSayisi DESC", baglanti);
            da.Fill(ds, "Uyeler");
            dataGridView1.DataSource = ds.Tables["Uyeler"];
            baglanti.Close();
            label3.Text = "";
            label4.Text = "";
            label3.Text = ds.Tables["Uyeler"].Rows[0]["AdSoyad"].ToString();
            label5.Text += ds.Tables["Uyeler"].Rows[0]["OkunanKitapSayisi"].ToString();
            label4.Text = ds.Tables["Uyeler"].Rows[dataGridView1.Rows.Count - 2]["AdSoyad"].ToString();
            label7.Text += ds.Tables["Uyeler"].Rows[dataGridView1.Rows.Count - 2]["OkunanKitapSayisi"].ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
