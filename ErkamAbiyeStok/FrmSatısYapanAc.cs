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

namespace ErkamAbiyeStok
{
    public partial class FrmSatısYapanAc : Form
    {
        public string verigelior;
        public FrmSatısYapanAc()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public void urunmiktar() {
            SqlCommand komut = new SqlCommand("Select sum(urun_satıs_miktari) as 'Toplam Ciro' From satis where satan_kisi_ad='" + label1.Text + "'", bgl.baglantı());
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                label5.Text = read["Toplam Ciro"].ToString();
            }
            bgl.baglantı().Close();
        }
        public void kisiyegoregetir()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from satis where satan_kisi_ad like'%" + label1.Text + "'", bgl.baglantı()); ;
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglantı().Close();

            SqlCommand komut = new SqlCommand("Select sum(urun_fiyat) as 'Toplam Ciro' From satis where satan_kisi_ad='" + label1.Text + "'", bgl.baglantı());
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                label3.Text = read["Toplam Ciro"].ToString()+" TL";
            }
            bgl.baglantı().Close();
            urunmiktar();
        }
        private void FrmSatısYapanAc_Load(object sender, EventArgs e)
        {
            label1.Text = verigelior;
            kisiyegoregetir();
            this.Text = verigelior +"'in yaptığı siparişler";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
