namespace App7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            Kullanici k = new Kullanici();
            k.KullaniciAdi = txtKullaniciAdi.Text;
            k.Sifre = txtSifre.Text;

            KullaniciYonetimi yonetim = new KullaniciYonetimi();
            bool durum = yonetim.Login(k);

        }
    }
}