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
            formm��teriekle ekle = new formm��teriekle();
            ekle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formm��terilistele liste = new formm��terilistele();
            liste.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formara�ekle ekle=new formara�ekle();
            ekle.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formara�listele aracliste=new formara�listele();
            aracliste.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}