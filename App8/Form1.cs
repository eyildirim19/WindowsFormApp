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

            // frmOgrenciEkle'inin mainForm field�na bu formun instancesini g�nderiyoruz..

            // this => runtime'da frmOgrenciEkle'inin instancesini temsil eder. this ifadeini frm nesnesinin mainForm field�na set ederek mevcut instance o tarafa g�ndermi� olduk...
            
            
            frm.mainForm = this;

            frm.Show();
        }
    }
}