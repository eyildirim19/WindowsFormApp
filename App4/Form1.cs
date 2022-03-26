namespace App4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            kullanicilar = new Dictionary<string, string>();
            kullanicilar.Add("Recep", "123");
            kullanicilar.Add("Emre", "1234");
            kullanicilar.Add("Kaan", "12345");
        }

        int hak = 3;
        Dictionary<string, string> kullanicilar;
        private void btnGirisYap_Click(object sender, EventArgs e)
        {


            //SOL�D PRENS�BLER�NDEN S'Y� ARA�TIRINIZ....


            #region MyRegion

            List<int> nums = new List<int>() { 1, 2, 3, 5, 8, 34, 60, 49, 22, 1 };
            var r = (from na in nums
                     where na < 10
                     select na).ToList();

            var re = nums.Where(c => c < 10).ToList();
            var ree = nums.First(c => c == 1);
            var reeeeee = nums.FirstOrDefault(c => c == 99);

            //var reee = nums.Single(c => c == 1);
            //First  => tek bir obje �ekmek i�in kullan�l�r. e�er koleksiyonda o objeden birden fazla varsa ilkini verir...e�er aranan obje dizide koleksiyonda yoksa hata verir. Bu y�zden First yerine FirstOrDefault kullan�l�r
            // FirstOrDefault =>�ekilen objenin ilki. e�er obje koleksiyonda yoksa default de�eri d�ner...
            //Single => tek bir obje �ekmek i�in kullan�l�r.e�er koleksiyonda o objeden birden fazla varsa hata verir...

            #endregion
            // y�ntem 1.
            var list = (from a in kullanicilar
                        where a.Key == txtKullaniciAdi.Text && a.Value == txtSifre.Text
                        select a).FirstOrDefault();

            // y�ntem 2.
            // c# lambda ifadesi => isimsiz fonksiyonlard�r..linq ifadelerinin k�satl�tm�� versiyonlar�n� yazmak i�in kulan�l�r..
            // var list2 = kullanicilar.Where(k => k.Key == txtKullaniciAdi.Text && k.Value == txtSifre.Text);
            var obj3 = kullanicilar.FirstOrDefault(k => k.Key == txtKullaniciAdi.Text && k.Value == txtSifre.Text);
            if (list.Key != null)
            {
                MessageBox.Show("Ho� Geldin Admin");

                Form2 frm = new Form2();
                frm.Show(); // formu a�...
                this.Hide(); // mevcut formu gizle...
            }
            else
            {
                MessageBox.Show($"Hatal� bilgi. Kalan hakk�n�z {hak--}");
            }

            if (hak == 0)
                btnGirisYap.Enabled = false;
        }
    }
}