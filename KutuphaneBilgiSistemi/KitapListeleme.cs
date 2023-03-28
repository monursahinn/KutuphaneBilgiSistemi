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
    public partial class KitapListeleme : Form
    {
        public KitapListeleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=TB701-5876;Initial Catalog=KutuphaneBS;Integrated Security=True");
        DataSet ds = new DataSet();
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void kitapListeleme()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Kitaplar", baglanti);
            da.Fill(ds, "Kitaplar");
            dataGridView1.DataSource = ds.Tables["Kitaplar"];
            baglanti.Close();
        }

        private void KitapListeleme_Load(object sender, EventArgs e)
        {
            kitapListeleme();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bu kaydı silmek istediğinize emin misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Kitaplar WHERE BarkodNo=@BarkodNo", baglanti);
                komut.Parameters.AddWithValue("@BarkodNo", dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme işlemi yapıldı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ds.Tables["Kitaplar"].Clear();
                kitapListeleme();
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }

                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Kitaplar set KitapAdi=@KitapAdi, Yazari=@Yazari, Yayinevi=@Yayinevi, Turu=@Turu, SayfaSayisi=@SayfaSayisi, StokMiktari=@StokMiktari, RafNumarasi=@RafNumarasi, Aciklama=@Aciklama where BarkodNo=@BarkodNo", baglanti);
            komut.Parameters.AddWithValue("@BarkodNo", txtKBarkodNo.Text);
            komut.Parameters.AddWithValue("@KitapAdi", txtKitapAdi.Text);
            komut.Parameters.AddWithValue("@Yazari", txtYazari.Text);
            komut.Parameters.AddWithValue("@Yayinevi", txtYayinevi.Text);
            komut.Parameters.AddWithValue("@Turu", comboTuru.Text);
            komut.Parameters.AddWithValue("@SayfaSayisi", txtSayfaSayisi.Text);
            komut.Parameters.AddWithValue("@StokMiktari", txtStokMiktari.Text);
            komut.Parameters.AddWithValue("@RafNumarasi", txtRafNumarasi.Text);
            komut.Parameters.AddWithValue("@Aciklama", txtAciklama.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme işlemi yapılmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ds.Tables["Kitaplar"].Clear();
            kitapListeleme();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }

            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            ds.Tables["Kitaplar"].Clear();
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Kitaplar where BarkodNo like'%" + txtAra.Text + "%'", baglanti);
            da.Fill(ds, "Kitaplar");
            dataGridView1.DataSource = ds.Tables["Kitaplar"];
            baglanti.Close();
        }
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtKBarkodNo_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Kitaplar where BarkodNo like '%" + txtKBarkodNo.Text + "%'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtKitapAdi.Text = read["KitapAdi"].ToString();
                txtYazari.Text = read["Yazari"].ToString();
                txtYayinevi.Text = read["Yayinevi"].ToString();
                comboTuru.Text = read["Turu"].ToString();
                txtSayfaSayisi.Text = read["SayfaSayisi"].ToString();
                txtStokMiktari.Text = read["StokMiktari"].ToString();
                txtRafNumarasi.Text = read["RafNumarasi"].ToString();
                txtAciklama.Text = read["Aciklama"].ToString();
            }
            baglanti.Close();
        }
    }
}
