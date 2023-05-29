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
    public partial class Frmgorsel : Form
    {
        sqlbaglantisi bgl = new sqlbaglantisi();
        public Frmgorsel()
        {
            InitializeComponent();
        }
        public void sipariş10()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select top 7 urun_barkod,urun_adi,satan_kisi_ad,urun_fiyat from  satis order by satis_id desc  ", bgl.baglantı());
            da.Fill(dt);
            son10.DataSource = dt;  
        }
        public void urun7() {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select top 7 urun_barkod,urun_kod,urun_kategori from urunler order by urun_barkod  ", bgl.baglantı());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void enfazlas() {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select satan_kisi_ad,count(*) as 'En Fazla Satış Yapan' from satis group by satan_kisi_ad order by 'En Fazla Satış Yapan' desc ", bgl.baglantı());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void Frmgorsel_Load(object sender, EventArgs e)
        {
            sipariş10();
            urun7();
            enfazlas();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            verialacazins.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            FrmSatısYapanAc fsya = new FrmSatısYapanAc();
            fsya.verigelior = verialacazins.Text;
            fsya.Show();
        }
    }
}
