using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App8
{
    public partial class frmOgrenciEkle : Form
    {
        public frmOgrenciEkle()
        {
            InitializeComponent();
        }

        public Form1 mainForm;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            mainForm.lstOgrenciler.Items.Add(txtOgrenciAdi.Text);
            mainForm.lblCount.Text = mainForm.lstOgrenciler.Items.Count.ToString();
        }
    }
}