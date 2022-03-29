using System.Data;

namespace App6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> nums = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9", ",", "0", "=" };

        List<string> operatos = new List<string>() { "+", "-", "*", "/" };
        private void Form1_Load(object sender, EventArgs e)
        {
            //txtInput.Text = "0";
            foreach (var num in nums)
            {
                Button btn = new Button();
                btn.Text = num;
                btn.Width = 50;
                btn.Height = 30;

                if (num != "=")
                    btn.Click += Btn_Click;
                else
                    btn.Click += Hesapla_Click;

                flowLayoutPanel1.Controls.Add(btn);
            }

            foreach (var opt in operatos)
            {
                Button btn = new Button();
                btn.Text = opt;
                btn.Width = 50;
                btn.Margin = new Padding(0, 1, 0, 0);
                btn.Height = 27;
                btn.Click += Btn_Click1;
                btn.Enabled = false;
                flowLayoutPanel2.Controls.Add(btn);
            }
        }

        string Hesapla()
        {
            string[] str = txtInput.Text.Split(islem);
            if (txtInput.Text.IndexOf(islem) > 0)
            {
                double sayi1 = 0, sayi2 = 0, sonuc = 0;
                sayi1 = Convert.ToDouble(str[0]);
                sayi2 = Convert.ToDouble(str[1]);
                switch (islem)
                {
                    case "+":
                        sonuc = sayi1 + sayi2;
                        break;
                    case "*":
                        sonuc = sayi1 * sayi2;
                        break;
                    case "/":
                        sonuc = sayi1 / sayi2;
                        break;
                    case "-":
                        sonuc = sayi1 - sayi2;
                        break;
                }
                return sonuc.ToString();
                //DataTable dt = new DataTable();
                //object result = dt.Compute(txtInput.Text, "");
                //return result.ToString();
            }
            else
            {
                return "a";
            }
        }

        private void Hesapla_Click(object? sender, EventArgs e)
        {
            //DataTable dt = new DataTable();
            //object result = dt.Compute(txtInput.Text, "");
            //txtInput.Text = result.ToString();
            txtInput.Text = Hesapla();
        }

        string islem = "";
        private void Btn_Click1(object? sender, EventArgs e)
        {
            Button btn = (Button)sender;
            // DisableOperatorsButton(false);

            // son karakter
            string str = txtInput.Text[txtInput.Text.Length - 1].ToString();
            if (operatos.IndexOf(str) > -1) // operat�r karakteri ise
            {
                txtInput.Text = txtInput.Text.Replace(str, "");
            }

            string t = Hesapla();
            if (t != "a")
            {
                txtInput.Text = t + btn.Text;
            }
            else
            {
                txtInput.Text += btn.Text;
            }
            islem = btn.Text;
        }

        // e parametresi => eventi temsil eder..
        // sender => metodu tetikleyen kontrol� temsil eder...
        // buttonlar�m�z�n referans� sender parametresi ile Btn_Click metoduna g�nderilir..Bu referans object tipinde oldu�u i�in bunu unboxing y�ntemiyle btn nesnesine atar�z..Art�k referansda g�nderilen button bilgilerine btn nesnesine ile eri�iriz...
        private void Btn_Click(object? sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtInput.Text += btn.Text;
            virgulEngelle();
            DisableOperatorsButton(true);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Show metodu d�n�� tipi DialogResultt�r. Dialog buttonlardan hangisine t�klanr�rsa o tipte result d�ner..
            DialogResult result = MessageBox.Show("Uygulama Kapanacak. \nEmin misin?", "Uyar�", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.Cancel) // result cancel ise
            {
                e.Cancel = true; // formu kapatma....
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            // tek tek temizle
            if (txtInput.Text.Length > 0)
                txtInput.Text = txtInput.Text.Remove(txtInput.Text.Length - 1, 1);



            // e�er text silindiyse
            if (txtInput.Text.Length == 0)
                DisableOperatorsButton(false); // i�lem operat�rleri disable et...
        }

        void DisableOperatorsButton(bool isEnable)
        {
            // Control
            foreach (Control control in flowLayoutPanel2.Controls)
            {
                control.Enabled = isEnable;
            }
        }

        void virgulEngelle()
        {
            int index = txtInput.Text.IndexOf(",");
            if (index == 0)
            {
                txtInput.Text = txtInput.Text.Insert(0, "0");
            }
            else if (index > 0)
            {
                index = txtInput.Text.IndexOf(",", index + 1);
                if (index > 0)
                {
                    txtInput.Text = txtInput.Text.Remove(index, 1);
                }
            }
        }
    }
}