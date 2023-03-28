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
    public partial class EmanetKitapVerme : Form
    {
        public EmanetKitapVerme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=TB701-5876;Initial Catalog=KutuphaneBS;Integrated Security=True");
        DataSet ds = new DataSet();
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void sepettekileriListele()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Sepet", baglanti);
            da.Fill(ds, "Sepet");
            dataGridView1.DataSource = ds.Tables["Sepet"];
            baglanti.Close();
        }
        private void stokMiktari()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT sum(KitapSayisi) FROM Sepet", baglanti);
            lblSepetKitapSayi.Text = komut.ExecuteScalar().ToString();
            baglanti.Close();
        }
        private void EmanetKitapVerme_Load(object sender, EventArgs e)
        {
            sepettekileriListele();
            stokMiktari();
        }
        private void txtTCKimlik_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Uyeler where TCKimlikNo like '%" + txtTCKimlik.Text + "%'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtAdSoyad.Text = read["AdSoyad"].ToString();
                txtTelefon.Text = read["TelefonNo"].ToString();
                txtEmail.Text = read["Email"].ToString();

            }
            baglanti.Close();
            if (txtTCKimlik.Text == "")
            {
                foreach (Control Item in grpUyeBilgileri.Controls)
                {
                    if (Item is TextBox)
                    {
                        Item.Text = "";
                    }
                }
            }
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("SELECT sum(KitapSayisi) FROM EmanetKitaplar where TCKimlikNo='" + txtTCKimlik.Text + "'", baglanti);
            lblKayitliKitapSayi.Text = komut2.ExecuteScalar().ToString();
            baglanti.Close();
            if (txtTCKimlik.Text == "")
            {
                foreach (Control item in grpUyeBilgileri.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                        lblKayitliKitap.Text = "";
                    }

                }
            }
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Kitaplar where BarkodNo like '%" + txtBarkodNo.Text + "%'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtKitapAdi.Text = read["KitapAdi"].ToString();
                txtYazari.Text = read["Yazari"].ToString();
                txtYayinevi.Text = read["Yayinevi"].ToString();
                txtSayfaSayisi.Text = read["SayfaSayisi"].ToString();
                txtStokMiktari.Text = read["StokMiktari"].ToString();
            }
            baglanti.Close();
            if (txtBarkodNo.Text == "")
            {
                foreach (Control Item in grpKitapBilgileri.Controls)
                {
                    if (Item is TextBox)
                    {
                        Item.Text = "";
                    }
                }
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bu kaydı silmek istediğinize emin misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Sepet WHERE BarkodNo = '" + dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString() + "'", baglanti);
                komut.Parameters.AddWithValue("@BarkodNo", dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme işlemi yapıldı!", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ds.Tables["Sepet"].Clear();
                sepettekileriListele();
                lblSepetKitapSayi.Text = "";
                stokMiktari();
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }

                }
            }
        }

        private void btnTeslimEt_Click(object sender, EventArgs e)
        {
            if (lblSepetKitapSayi.Text != "")
            {
                if (lblKayitliKitapSayi.Text == "" && int.Parse(lblSepetKitapSayi.Text) <= 5 || lblKayitliKitapSayi.Text != "" && int.Parse(lblKayitliKitapSayi.Text) + int.Parse(lblSepetKitapSayi.Text) <= 5)
                {
                    if (txtTCKimlik.Text != "" && txtAdSoyad.Text != "" && txtTelefon.Text != "" && txtEmail.Text != "")
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            baglanti.Open();
                            SqlCommand komut = new SqlCommand("INSERT INTO EmanetKitaplar(TCKimlikNo, AdSoyad, TelefonNo, Eposta, BarkodNo, KitapAdi, Yazari, Yayinevi, SayfaSayisi, KitapSayisi, TeslimTarihi, IadeTarihi) values(@TCKimlikNo, @AdSoyad, @TelefonNo, @Eposta, @BarkodNo, @KitapAdi, @Yazari, @Yayinevi, @SayfaSayisi, @KitapSayisi, @TeslimTarihi, @IadeTarihi) ", baglanti);
                            komut.Parameters.AddWithValue("@TCKimlikNo", txtTCKimlik.Text);
                            komut.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
                            komut.Parameters.AddWithValue("@TelefonNo", txtTelefon.Text);
                            komut.Parameters.AddWithValue("@Eposta", txtEmail.Text);
                            komut.Parameters.AddWithValue("@BarkodNo", dataGridView1.Rows[i].Cells["BarkodNo"].Value.ToString());
                            komut.Parameters.AddWithValue("@KitapAdi", dataGridView1.Rows[i].Cells["KitapAdi"].Value.ToString());
                            komut.Parameters.AddWithValue("@Yazari", dataGridView1.Rows[i].Cells["Yazari"].Value.ToString());
                            komut.Parameters.AddWithValue("@Yayinevi", dataGridView1.Rows[i].Cells["Yayinevi"].Value.ToString());
                            komut.Parameters.AddWithValue("@SayfaSayisi", dataGridView1.Rows[i].Cells["SayfaSayisi"].Value.ToString());
                            komut.Parameters.AddWithValue("@KitapSayisi", int.Parse(dataGridView1.Rows[i].Cells["KitapSayisi"].Value.ToString()));
                            komut.Parameters.AddWithValue("@TeslimTarihi", dataGridView1.Rows[i].Cells["TeslimTarihi"].Value.ToString());
                            komut.Parameters.AddWithValue("@IadeTarihi", dataGridView1.Rows[i].Cells["IadeTarihi"].Value.ToString());
                            komut.ExecuteNonQuery();
                            SqlCommand komut2 = new SqlCommand("UPDATE Uyeler SET OkunanKitapSayisi = OkunanKitapSayisi + '" + int.Parse(dataGridView1.Rows[i].Cells["KitapSayisi"].Value.ToString()) + "' where TCKimlikNo = '" + txtTCKimlik.Text + "'", baglanti);
                            komut2.ExecuteNonQuery();
                            SqlCommand komut3 = new SqlCommand("UPDATE Kitaplar SET StokMiktari = StokMiktari - '" + int.Parse(dataGridView1.Rows[i].Cells["KitapSayisi"].Value.ToString()) + "' where BarkodNo = '" + dataGridView1.Rows[i].Cells["BarkodNo"].Value.ToString() + "'", baglanti);
                            komut3.ExecuteNonQuery();
                            baglanti.Close();
                        }
                        baglanti.Open();
                        SqlCommand komut4 = new SqlCommand("DELETE FROM Sepet", baglanti);
                        komut4.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Kitap/Kitaplar teslim edilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ds.Tables["Sepet"].Clear();
                        sepettekileriListele();
                        txtTCKimlik.Text = "";
                        lblSepetKitapSayi.Text = "";
                        stokMiktari();
                        lblKayitliKitapSayi.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Önce üye bilgilerini girmeniz gerekmektedir!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                }
                else
                {
                    MessageBox.Show("Ödünç alınabilecek kitap sayısı 5'ten fazla olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Önce sepetinize kitap eklemelisiniz", "Hatırlatma", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txtStokMiktari_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Sepet(BarkodNo, KitapAdi, Yazari, Yayinevi, SayfaSayisi, KitapSayisi, TeslimTarihi, IadeTarihi) VALUES(@BarkodNo,@KitapAdi, @Yazari, @Yayinevi, @SayfaSayisi, @KitapSayisi, @TeslimTarihi, @IadeTarihi)", baglanti);
            komut.Parameters.AddWithValue("@BarkodNo", txtBarkodNo.Text);
            komut.Parameters.AddWithValue("@KitapAdi", txtKitapAdi.Text);
            komut.Parameters.AddWithValue("@Yazari", txtYazari.Text);
            komut.Parameters.AddWithValue("@Yayinevi", txtYayinevi.Text);
            komut.Parameters.AddWithValue("@SayfaSayisi", txtSayfaSayisi.Text);
            komut.Parameters.AddWithValue("@KitapSayisi", int.Parse(txtStokMiktari.Text));
            komut.Parameters.AddWithValue("@TeslimTarihi", dateTimePickerTeslim.Text);
            komut.Parameters.AddWithValue("@IadeTarihi", dateTimePickerIade.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Seçilen kitap/kitaplar sepete eklendi", "Ekleme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ds.Tables["Sepet"].Clear();
            sepettekileriListele();
            lblSepetKitapSayi.Text = "";
            stokMiktari();
            foreach (Control Item in grpKitapBilgileri.Controls)
            {
                if (Item is TextBox)
                {
                    if (Item != txtStokMiktari)
                    {
                        Item.Text = "";
                    }
                }
            }
        }
    }
}
