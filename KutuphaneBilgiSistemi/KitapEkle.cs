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
    public partial class KitapEkle : Form
    {
        public KitapEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=TB701-5876;Initial Catalog=KutuphaneBS;Integrated Security=True");
        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void KitapEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO Kitaplar (BarkodNo, KitapAdi, Yazari, Yayinevi, Turu, SayfaSayisi, StokMiktari, RafNumarasi, Aciklama) values(@BarkodNo, @KitapAdi, @Yazari, @Yayinevi, @Turu, @SayfaSayisi, @StokMiktari, @RafNumarasi, @Aciklama)", baglanti);
                komut.Parameters.AddWithValue("@BarkodNo", txtKBarkodNo.Text);
                komut.Parameters.AddWithValue("@KitapAdi", txtKitapAdi.Text);
                komut.Parameters.AddWithValue("@Yazari", txtYazari.Text);
                komut.Parameters.AddWithValue("@Yayinevi", txtYayinevi.Text);
                komut.Parameters.AddWithValue("@Turu", comboTuru.Text);
                komut.Parameters.AddWithValue("@SayfaSayisi", txtSayfaSayisi.Text);
                komut.Parameters.AddWithValue("@StokMiktari", txtStokMiktari.Text);
                komut.Parameters.AddWithValue("@RafNumarasi", txtRafNumarasi.Text);
                komut.Parameters.AddWithValue("@Aciklama", txtAciklama.Text);
                komut.Parameters.AddWithValue("@KayitTarihi", DateTime.Now.ToShortDateString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kitap kaydı yapılmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Girilen bilgilerde kitap bulunmaktadır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
