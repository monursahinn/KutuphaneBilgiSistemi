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
    public partial class UyeListeleme : Form
    {
        public UyeListeleme()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTC.Text = dataGridView1.CurrentRow.Cells["TcKimlikNo"].Value.ToString();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=TB701-5876;Initial Catalog=KutuphaneBS;Integrated Security=True");
        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            if (txtTC.Text!="")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM Uyeler where TCKimlikNo like '%" + txtTC.Text + "%'", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    txtAdSoyad.Text = read["AdSoyad"].ToString();
                    txtYas.Text = read["Yas"].ToString();
                    comboCinsiyet.Text = read["Cinsiyet"].ToString();
                    txtTelefon.Text = read["TelefonNo"].ToString();
                    txtAdres.Text = read["Adres"].ToString();
                    txtEmail.Text = read["Email"].ToString();
                    txtOKS.Text = read["OkunanKitapSayisi"].ToString();
                    
                }
            
            }
            else
            {
                txtAdSoyad.Text = "";
                txtYas.Text = "";
                comboCinsiyet.Text = "";
                txtTelefon.Text = "";
                txtAdres.Text ="";
                txtEmail.Text = "";
                txtOKS.Text = "";

            }
            baglanti.Close();

        }
        DataSet ds = new DataSet();
        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            ds.Tables["Uyeler"].Clear();
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Uyeler where TCKimlikNo like'%" + txtAra.Text + "%'", baglanti);
            da.Fill(ds, "Uyeler");
            dataGridView1.DataSource = ds.Tables["Uyeler"];
            baglanti.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bu kaydı silmek istediğinize emin misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Uyeler WHERE TCKimlikNo=@TCKimlikNo", baglanti);
                komut.Parameters.AddWithValue("@TCKimlikNo", dataGridView1.CurrentRow.Cells["TCKimlikNo"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme işlemi yapıldı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ds.Tables["Uyeler"].Clear();
                uyeListeleme();
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }

                }
            }

        }
        private void uyeListeleme()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Uyeler", baglanti);
            da.Fill(ds, "Uyeler");
            dataGridView1.DataSource = ds.Tables["Uyeler"];
            baglanti.Close();
        }
        private void UyeListeleme_Load(object sender, EventArgs e)
        {
            uyeListeleme();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE Uyeler SET AdSoyad=@AdSoyad, Yas=@Yas, Cinsiyet=@Cinsiyet, TelefonNo=@TelefonNo, Adres=@Adres, Email=@Email, OkunanKitapSayisi=@OkunanKitapSayisi where TCKimlikNo=@TCKimlikNo", baglanti);
                komut.Parameters.AddWithValue("@TCKimlikNo", txtTC.Text);
                komut.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@Yas", txtYas.Text);
                komut.Parameters.AddWithValue("@Cinsiyet", comboCinsiyet.Text);
                komut.Parameters.AddWithValue("@TelefonNo", txtTelefon.Text);
                komut.Parameters.AddWithValue("@Adres", txtAdres.Text);
                komut.Parameters.AddWithValue("@Email", txtEmail.Text);
                komut.Parameters.AddWithValue("@OkunanKitapSayisi", int.Parse(txtOKS.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Güncelleme işlemi yapılmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ds.Tables["Uyeler"].Clear();
                uyeListeleme();
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

                MessageBox.Show("Bu alan boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

}
