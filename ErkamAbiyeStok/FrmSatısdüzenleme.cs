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
    public partial class FrmSatısdüzenleme : Form
    {
        public FrmSatısdüzenleme()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public void yenile() {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from satis order by satis_id desc",bgl.baglantı());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }
        DataSet daset = new DataSet();
        public void siparislitele() {
            SqlDataAdapter adtr = new SqlDataAdapter("select * from satis order by satis_id desc", bgl.baglantı());
            adtr.Fill(daset, "satis");
            dataGridView1.DataSource = daset.Tables["satis"];
            bgl.baglantı().Close();
            dataGridView1.Columns["satis_id"].HeaderText = "Satış Sırası";
            dataGridView1.Columns["urun_barkod"].HeaderText = "Barkod";
            dataGridView1.Columns["urun_adi"].HeaderText = "Ürün Adı";
            dataGridView1.Columns["urun_kodu"].HeaderText = "Ürün Kodu";
            dataGridView1.Columns["urun_beden"].HeaderText = "Ürün Beden";
            dataGridView1.Columns["urun_renk"].HeaderText = "Ürün Renk";
            dataGridView1.Columns["urun_kategori"].HeaderText = "Ürün Kategori";
            dataGridView1.Columns["urun_fiyat"].HeaderText = "Ürün Satış Fiyatı";
            dataGridView1.Columns["urun_satıs_miktari"].HeaderText = "Satılan Adet";
            dataGridView1.Columns["urun_satis_tipi"].HeaderText = "Tür";
            dataGridView1.Columns["satan_kisi_ad"].HeaderText = "Satışı Gerçekleştiren";
            dataGridView1.Columns["satıs_tarihi"].HeaderText = "Satış Tarihi";
        }

        private void FrmSatısdüzenleme_Load(object sender, EventArgs e)
        {
            siparislitele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtsıra.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtbarkod.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txturunad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtkod.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtbdn.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtrenk.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtktg.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txtsatısfiyat.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            txtstok.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            txttur.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            txtsatanad.Text = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            dateTimePicker1.Text= dataGridView1.Rows[secilen].Cells[11].Value.ToString();
        }

        private void txtbdn_TextChanged(object sender, EventArgs e)
        {
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yenile();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From satis where satis_id=@p1", bgl.baglantı());
            komutsil.Parameters.AddWithValue("@p1", txtsıra.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Sipariş Bilgileri Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            yenile();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update satis set urun_barkod=@p1,urun_adi=@p2,urun_kodu=@p3,urun_beden=@p4,urun_renk=@p5,urun_kategori=@p6,urun_fiyat=@p7,urun_satıs_miktari=@p8,urun_satis_tipi=@p9,satan_kisi_ad=@p10,satıs_tarihi=@p11 where satis_id=@p12", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", txtbarkod.Text);
            komut.Parameters.AddWithValue("@p2", txturunad.Text);
            komut.Parameters.AddWithValue("@p3", txtkod.Text);
            komut.Parameters.AddWithValue("@p4", txtbdn.Text);
            komut.Parameters.AddWithValue("@p5", txtrenk.Text);
            komut.Parameters.AddWithValue("@p6", txtktg.Text);
            komut.Parameters.AddWithValue("@p7", txtsatısfiyat.Text);
            komut.Parameters.AddWithValue("@p8", txtstok.Text);
            komut.Parameters.AddWithValue("@p9", txttur.Text);
            komut.Parameters.AddWithValue("@p10", txtsatanad.Text);   
            komut.Parameters.AddWithValue("@p11", this.dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@p12", txtsıra.Text);
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();
            yenile(); 
        }
    }
}
