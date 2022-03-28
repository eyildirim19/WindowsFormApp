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
                btn.Click += Btn_Click;
                flowLayoutPanel1.Controls.Add(btn);
            }

            foreach (var opt in operatos)
            {
                Button btn = new Button();
                btn.Text = opt;
                btn.Width = 50;
                btn.Height = 30;
                flowLayoutPanel2.Controls.Add(btn);
            }
        }

        // e parametresi => eventi temsil eder..
        // sender => metodu tetikleyen kontrolü temsil eder...
        // buttonlarýmýzýn referansý sender parametresi ile Btn_Click metoduna gönderilir..Bu referans object tipinde olduðu için bunu unboxing yöntemiyle btn nesnesine atarýz..Artýk referansda gönderilen button bilgilerine btn nesnesine ile eriþiriz...
        private void Btn_Click(object? sender, EventArgs e)
        {
            Button btn = (Button)sender;
            //if (btn.Text == ",")
            //{
            //    if (txtInput.Text.IndexOf(",") >= 0)
            //    {
            //        return;
            //    }
            //}
            txtInput.Text += btn.Text;
            virgulEngelle();
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
                index = txtInput.Text.IndexOf(",", index+1);
                if (index > 0)
                {
                    txtInput.Text = txtInput.Text.Remove(index, 1);
                }
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Show metodu dönüþ tipi DialogResulttýr. Dialog buttonlardan hangisine týklanrýrsa o tipte result döner..
            DialogResult result = MessageBox.Show("Uygulama Kapanacak. \nEmin misin?", "Uyarý", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.Cancel) // result cancel ise
            {
                e.Cancel = true; // formu kapatma....
            }
        }
    }
}