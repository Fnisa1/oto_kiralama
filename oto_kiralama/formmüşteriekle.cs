using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace oto_kiralama
{
    public partial class formmüşteriekle : Form
    {

        oto_kiralama otokirala = new oto_kiralama();
        public formmüşteriekle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ekle_Click(object sender, EventArgs e)
        {
            try
            {
                string cümle = "insert into müşteri(tc,ad,soyad,tel,email,adres) values(@tc,@ad,@soyad,@tel,@email,@adres)";
                SqlCommand komut2 = new SqlCommand();
                komut2.Parameters.AddWithValue("@tc", txtTc.Text);
                komut2.Parameters.AddWithValue("@ad", txtAd.Text);
                komut2.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                komut2.Parameters.AddWithValue("@tel", txtTel.Text);
                komut2.Parameters.AddWithValue("@email", txtEmail.Text);
                komut2.Parameters.AddWithValue("@adres", txtAdres.Text);
                otokirala.ekle_sil_güncelle(komut2, cümle);

                txtTc.Text = "";
                txtAd.Text = "";
                txtSoyad.Text = "";
                txtTel.Text = "";
                txtEmail.Text = "";
                txtAdres.Text = "";
                MessageBox.Show("Kayıt Başarılı");


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }




        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {

        }

        private void formmüşteriekle_Load(object sender, EventArgs e)
        {

        }
    }
}
