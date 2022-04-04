namespace App8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            frmOgrenciEkle frm = new frmOgrenciEkle();

            // frmOgrenciEkle'inin mainForm fieldýna bu formun instancesini gönderiyoruz..

            // this => runtime'da frmOgrenciEkle'inin instancesini temsil eder. this ifadeini frm nesnesinin mainForm fieldýna set ederek mevcut instance o tarafa göndermiþ olduk...
            
            
            frm.mainForm = this;

            frm.Show();
        }
    }
}