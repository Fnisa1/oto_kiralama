namespace oto_kiralama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formmüþteriekle ekle = new formmüþteriekle();
            ekle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formmüþterilistele liste = new formmüþterilistele();
            liste.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formaraçekle ekle=new formaraçekle();
            ekle.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formaraçlistele aracliste=new formaraçlistele();
            aracliste.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}