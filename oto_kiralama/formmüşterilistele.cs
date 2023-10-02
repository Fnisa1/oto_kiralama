using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oto_kiralama
{

    public partial class formmüşterilistele : Form
    {
        oto_kiralama otokiralama = new oto_kiralama();

        public formmüşterilistele()
        {
            InitializeComponent();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void formmüşterilistele_Load(object sender, EventArgs e)
        {
            YenileListele();
        }

        private void YenileListele()
        {

            string cümle = "select * from müşteri";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = otokiralama.listele(adtr2, cümle);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            string cümle = "delete from müşteri where tc='" + satır.Cells["tc"].Value.ToString() + "'";
            SqlCommand adtr2 = new SqlCommand();
            otokiralama.ekle_sil_güncelle(adtr2, cümle);
            YenileListele();
        }

        private void ekle_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
