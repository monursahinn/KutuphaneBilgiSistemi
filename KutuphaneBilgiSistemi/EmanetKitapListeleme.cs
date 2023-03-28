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
    public partial class EmanetKitapListeleme : Form
    {
        public EmanetKitapListeleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=TB701-5876;Initial Catalog=KutuphaneBS;Integrated Security=True");
        DataSet ds = new DataSet();
        private void EmanetKitapListeleme_Load(object sender, EventArgs e)
        {
            EmanetListele();
            comboBox1.SelectedIndex = 0;
        }

        private void EmanetListele()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM EmanetKitaplar", baglanti);
            da.Fill(ds, "EmanetKitaplar");
            dataGridView1.DataSource = ds.Tables["EmanetKitaplar"];
            baglanti.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ds.Tables["EmanetKitaplar"].Clear();
            if (comboBox1.SelectedIndex == 0)
            {
                EmanetListele();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM EmanetKitaplar WHERE '" + DateTime.Now.ToShortDateString + "'>IadeTarihi", baglanti);
                da.Fill(ds, "EmanetKitaplar");
                dataGridView1.DataSource = ds.Tables["EmanetKitaplar"];
                baglanti.Close();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM EmanetKitaplar WHERE '" + DateTime.Now.ToShortDateString + "'<=IadeTarihi", baglanti);
                da.Fill(ds, "EmanetKitaplar");
                dataGridView1.DataSource = ds.Tables["EmanetKitaplar"];
                baglanti.Close();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
