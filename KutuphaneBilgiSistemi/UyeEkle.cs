using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace KutuphaneBilgiSistemi
{
    public partial class UyeEkle : Form
    {
        public UyeEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=TB701-5876;Initial Catalog=KutuphaneBS;Integrated Security=True");
        private void UyeEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO Uyeler (TCKimlikNO, AdSoyad, Yas, Cinsiyet, TelefonNo, Adres, Email, OkunanKitapSayisi) values(@TCKimlikNO, @AdSoyad, @Yas, @Cinsiyet, @TelefonNo, @Adres, @Email, @OkunanKitapSayisi)", baglanti);
                komut.Parameters.AddWithValue("@TCKimlikNo", txtTC.Text);
                komut.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@Yas", txtYas.Text);
                komut.Parameters.AddWithValue("@Cinsiyet", comboCinsiyet.Text);
                komut.Parameters.AddWithValue("@TelefonNo", txtTelefon.Text);
                komut.Parameters.AddWithValue("@Adres", txtAdres.Text);
                komut.Parameters.AddWithValue("@Email", txtEmail.Text);
                komut.Parameters.AddWithValue("@OkunanKitapSayisi", txtOKS.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Üye kaydınız yapılmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        if (item is TextBox)
                        {
                            item.Text = "";
                        }
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Bu bilgilerde kayıt bulunmaktadır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void txtOKS_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtAdres_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtYas_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtAdSoyad_TextChanged(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }
    }
}
