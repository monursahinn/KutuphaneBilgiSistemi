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
    public partial class EmanetKitapIade : Form
    {
        public EmanetKitapIade()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=TB701-5876;Initial Catalog=KutuphaneBS;Integrated Security=True");
        DataSet ds = new DataSet();
        private void EmanetListele()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM EmanetKitaplar", baglanti);
            da.Fill(ds, "EmanetKitaplar");
            dataGridView1.DataSource = ds.Tables["EmanetKitaplar"];
            baglanti.Close();
        }
        private void EmanetKitapIade_Load(object sender, EventArgs e)
        {
            EmanetListele();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ds.Tables["EmanetKitaplar"].Clear();
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM EmanetKitaplar WHERE TCKimlikNo like'%" + txtTCAra.Text + "%'", baglanti);
            da.Fill(ds, "EmanetKitaplar");
            baglanti.Close();
            if (txtTCAra.Text == "")
            {
                ds.Tables.Clear();
                EmanetListele();
            }
        }

        private void txtBarkodAra_TextChanged(object sender, EventArgs e)
        {
            ds.Tables["EmanetKitaplar"].Clear();
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM EmanetKitaplar WHERE BarkodNo like'%" + txtBarkodAra.Text + "%'", baglanti);
            da.Fill(ds, "EmanetKitaplar");
            baglanti.Close();
            if (txtBarkodAra.Text == "")
            {
                ds.Tables.Clear();
                EmanetListele();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM EmanetKitaplar WHERE TCKimlikNo=@TCKimlikNo and BarkodNo=@BarkodNo", baglanti);
            komut.Parameters.AddWithValue("@TCKimlikNo", dataGridView1.CurrentRow.Cells["TCKimlikNo"].Value.ToString());
            komut.Parameters.AddWithValue("@BarkodNo", dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString());
            komut.ExecuteNonQuery();
            SqlCommand komut2 = new SqlCommand("UPDATE Kitaplar SET StokMiktari = StokMiktari + '" + int.Parse(dataGridView1.CurrentRow.Cells["KitapSayisi"].Value.ToString()) + "' WHERE BarkodNo=@BarkodNo", baglanti);
            komut2.Parameters.AddWithValue("@BarkodNo", dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString());
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap(lar) iade edilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ds.Tables.Clear();
            EmanetListele();

        }
    }
}
