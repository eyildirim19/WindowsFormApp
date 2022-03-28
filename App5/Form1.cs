namespace App5
{
    public partial class Form1 : Form
    {
        double Sayi1
        {
            get
            {
                return Convert.ToDouble(this.Controls["txtSayi1"].Text);
            }
        }

        double Sayi2
        {
            get
            {
                return Convert.ToDouble(this.Controls["txtSayi2"].Text);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Button btn = new Button();
            btn.Text = "+";
            btn.Left = 50;
            btn.Top = 70;
            btn.Width = 30;
            btn.Click += Btn_Click;

            Button btn2 = new Button();
            btn2.Text = "-";
            btn2.Left = btn.Left + btn.Width + 5;
            btn2.Top = 70;
            btn2.Width = 30;
            btn2.Click += Btn2_Click;

            Button btn3 = new Button();
            btn3.Text = "*";
            btn3.Left = btn2.Left + btn2.Width + 5;
            btn3.Top = 70;
            btn3.Width = 30;
            btn3.Click += Btn3_Click;

            Button btn4 = new Button();
            btn4.Text = "/";
            btn4.Left = btn3.Left + btn3.Width + 5;
            btn4.Top = 70;
            btn4.Width = 30;
            btn4.Click += Btn4_Click;

            // bulunulan instance...
            this.Controls.Add(btn);
            this.Controls.Add(btn2);
            this.Controls.Add(btn3);
            this.Controls.Add(btn4);

            TextBox txt = new TextBox();
            txt.Name = "txtSayi1";
            txt.Width = 135;
            txt.Left = 50;
            txt.Top = 10;

            TextBox txt1 = new TextBox();
            txt1.Name = "txtSayi2";
            txt1.Left = 50;
            txt1.Top = 40;
            txt1.Width = 135;

            this.Controls.Add(txt);
            this.Controls.Add(txt1);
        }

        private void Btn4_Click(object? sender, EventArgs e)
        {
            lblSonuc.Text = IslemYap('/').ToString();
        }

        private void Btn3_Click(object? sender, EventArgs e)
        {
            lblSonuc.Text = IslemYap('*').ToString();
        }

        private void Btn2_Click(object? sender, EventArgs e)
        {
            lblSonuc.Text = IslemYap('-').ToString();
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            lblSonuc.Text = IslemYap('+').ToString();
        }

        double IslemYap(char islem)
        {
            double result = 0;
            switch (islem)
            {
                case '+':
                    result = Sayi1 + Sayi2;
                    break;
                case '-':
                    result = Sayi1 - Sayi2;
                    break;
                case '/':
                    result = Sayi1 / Sayi2;
                    break;
                case '*':
                    result = Sayi1 * Sayi2;
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}