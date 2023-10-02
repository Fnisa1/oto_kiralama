using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oto_kiralama
{
    public partial class formaraçekle : Form
    {
        oto_kiralama otokiralama = new oto_kiralama();
        public formaraçekle()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            string cümle = "insert into araç(plaka,marka,seri,model,km,yakıt,ücret) values(@plaka,@marka,@seri,@model,@km,@yakıt,@ücret)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@plaka", plakatxt.Text);
            komut2.Parameters.AddWithValue("@marka", markatxt.Text);
            komut2.Parameters.AddWithValue("@seri", seritxt.Text);
            komut2.Parameters.AddWithValue("@model", modeltxt.Text);
            komut2.Parameters.AddWithValue("@km", kmtxt.Text);
            komut2.Parameters.AddWithValue("@yakıt", yakıttxt.Text);
            komut2.Parameters.AddWithValue("@ücret", ücrettxt.Text);
            otokiralama.ekle_sil_güncelle(komut2, cümle);
            plakatxt.Text = "";
            markatxt.Text = "";
            seritxt.Text = "";
            modeltxt.Text = "";
            kmtxt.Text = "";
            yakıttxt.Text = "";
            ücrettxt.Text = "";
            MessageBox.Show("Kayıt Başarılı");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
