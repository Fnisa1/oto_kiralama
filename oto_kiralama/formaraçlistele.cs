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
    public partial class formaraçlistele : Form
    {

        oto_kiralama otokiralama = new oto_kiralama();
        public formaraçlistele()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            plakatxt.Text = satır.Cells["plaka"].Value.ToString();
            markatxt.Text = satır.Cells["marka"].Value.ToString();
            seritxt.Text = satır.Cells["seri"].Value.ToString();
            modeltxt.Text = satır.Cells["model"].Value.ToString();
            kmtxt.Text = satır.Cells["km"].Value.ToString();
            yakıttxt.Text = satır.Cells["yakıt"].Value.ToString();
            ücrettxt.Text = satır.Cells["ücret"].Value.ToString();

        }

        private void formaraçlistele_Load(object sender, EventArgs e)
        {
            YenileAraçlarListesi();
        }

        private void YenileAraçlarListesi()
        {
            string cümle = "select * from araç";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = otokiralama.listele(adtr2, cümle);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cümle = "update araç set marka=@marka,seri=@seri,model=@model,km=@km,yakıt=@yakıt,ücret=@ücret where plaka=@plaka";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@plaka", plakatxt.Text);
            komut2.Parameters.AddWithValue("@marka", markatxt.Text);
            komut2.Parameters.AddWithValue("@seri", seritxt.Text);
            komut2.Parameters.AddWithValue("@model", modeltxt.Text);
            komut2.Parameters.AddWithValue("@km", kmtxt.Text);
            komut2.Parameters.AddWithValue("@yakıt", yakıttxt.Text);
            komut2.Parameters.AddWithValue("@ücret", ücrettxt.Text);
            otokiralama.ekle_sil_güncelle(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            string cümle = "delete from araç where plaka='" + satır.Cells["plaka"].Value.ToString() + "'";
            SqlCommand komut2 = new SqlCommand();
            otokiralama.ekle_sil_güncelle(komut2, cümle);
            YenileAraçlarListesi();
        }
    }
}
