namespace App3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayac = 0;
        bool durum;
        private void btnSayac_Click(object sender, EventArgs e)
        {
            if (sayac == 10)
                durum = false;
            else if (sayac == 0)
                durum = true;

            if (durum)
                sayac++;
            else
                sayac--;

            btnSayac.Text = durum ? "Arttýr" : "Azalat";

            //if (durum)
            //    btnSayac.Text = "Arttýr";
            //else
            //    btnSayac.Text = "Azalt";

            //lblSayac.Text = Convert.ToString(sayac);
            lblSayac.Text = sayac.ToString();

            Random rnd = new Random();

            lblSayac.ForeColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
        }

        bool gorunum = true;
        private void btnGosterGizle_Click(object sender, EventArgs e)
        {
            btnBut.Visible = gorunum;
            //if (gorunum)
            //    gorunum = false;
            //else
            //    gorunum = true;
            // gorunum = gorunum ? false : true;
            gorunum = !gorunum;
        }
    }
}