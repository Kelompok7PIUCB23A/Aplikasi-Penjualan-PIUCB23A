namespace PI_ONLINE_SHOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Seragam seragam = new Seragam();
            seragam.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AlatTulis alatTulis = new AlatTulis();
            alatTulis.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AksesorisPC aksesorisPC = new AksesorisPC();
            aksesorisPC.Show();
         
        }
    }
}
