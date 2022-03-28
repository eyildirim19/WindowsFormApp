using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App4
{
    public partial class Form2 : Form
    {
        double sayi1, sayi2, sonuc;
        public Form2()
        {
            InitializeComponent();
        }

        void SayiHazirla()
        {
            sayi1 = Convert.ToDouble(txtSayi1.Text);
            sayi2 = Convert.ToDouble(txtSayi2.Text);
        }

        void Reset()
        {
            txtSayi1.Clear();
            txtSayi2.Clear();
        }

        private void btnArti_Click(object sender, EventArgs e)
        {
            SayiHazirla();
            //sonuc = sayi1 + sayi2;
            //lblSonuc.Text = sonuc.ToString();
            lblSonuc.Text = (sayi1 + sayi2).ToString();
            Reset();
        }

        private void btnEksi_Click(object sender, EventArgs e)
        {
            SayiHazirla();
            lblSonuc.Text = (sayi1 - sayi2).ToString();
            Reset();
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            SayiHazirla();
            lblSonuc.Text = (sayi1 / sayi2).ToString();
            Reset();
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            SayiHazirla();
            lblSonuc.Text = (sayi1 * sayi2).ToString();
            Reset();
        }
    }
}
