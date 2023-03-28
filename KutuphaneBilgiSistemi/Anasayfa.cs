namespace KutuphaneBilgiSistemi
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {

            UyeEkle uyeeklepen = new UyeEkle();
            uyeeklepen.ShowDialog();

        }

        private void btnUyeListele_Click(object sender, EventArgs e)
        {
            UyeListeleme uyelistelepen = new UyeListeleme();
            uyelistelepen.ShowDialog();
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            KitapEkle kitapekle = new KitapEkle();
            kitapekle.ShowDialog();
        }

        private void btnKitapListele_Click(object sender, EventArgs e)
        {
            KitapListeleme kitapListele = new KitapListeleme();
            kitapListele.ShowDialog();
        }

        private void btnEmanetKitap_Click(object sender, EventArgs e)
        {
            EmanetKitapVerme emanetkitap = new EmanetKitapVerme();
            emanetkitap.ShowDialog();
        }

        private void btnEmanetListe_Click(object sender, EventArgs e)
        {
            EmanetKitapListeleme emanetlistele = new EmanetKitapListeleme();
            emanetlistele.ShowDialog();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }

        private void btnEmanetIade_Click(object sender, EventArgs e)
        {
            EmanetKitapIade emanetiade = new EmanetKitapIade();
            emanetiade.ShowDialog();
        }

        private void btnSiralama_Click(object sender, EventArgs e)
        {
            Siralama sirala = new Siralama();
            sirala.ShowDialog();
        }

        private void btnGrafikler_Click(object sender, EventArgs e)
        {
            Grafikler grafik = new Grafikler();
            grafik.ShowDialog();
        }
    }
}