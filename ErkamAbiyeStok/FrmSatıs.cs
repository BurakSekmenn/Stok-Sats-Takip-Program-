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
    public partial class FrmSatıs : Form
    {
        sqlbaglantisi bgl = new sqlbaglantisi();
        DataSet daset = new DataSet();
        private void sepetlistele() {
           
            SqlDataAdapter adtr = new SqlDataAdapter("select * from sepet",bgl.baglantı());
            adtr.Fill(daset, "sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];
            bgl.baglantı().Close();
        }
        public FrmSatıs()
        {
            InitializeComponent();
        }
        private void hesapla() {
            try
            {
                SqlCommand komut = new SqlCommand("select sum(urun_fiyat) from sepet",bgl.baglantı());
                uruntoplamfiyat.Text = komut.ExecuteScalar() + " TL";
                bgl.baglantı().Close();
            }
            catch (Exception)
            { 
            }
        }
        private void FrmSatıs_Load(object sender, EventArgs e)
        {
            sepetlistele();
            txtbarkod.Enabled = true;
            txturunad.Enabled = false;
            txturunkod.Enabled = false;
            txturunbdn.Enabled = false;
            txturunrenk.Enabled = false;
            txturunktg.Enabled = false;
            txttür.Enabled = false;
            comboBox1.Enabled = false;
            //txtpesinfiyat.Enabled = false;
            //txtkredifiyat.Enabled = false;
            txtsatısadsoyad.Enabled = false;
            temizle();
            //2,34
            simpleButton2.Enabled = false;
            simpleButton3.Enabled = false;
            simpleButton4.Enabled = false;
        }
        private void txtsatisid_TextChanged(object sender, EventArgs e)
        {
            if (txtsatanid.Text=="") {
                txtsatısadsoyad.Text = "";
                txtsatısadsoyad.Enabled = false;
            }
            SqlCommand komut = new SqlCommand("select * from satisisim where satıs_id like '" + txtsatanid.Text + "'", bgl.baglantı());
            SqlDataReader read = komut.ExecuteReader();
            while(read.Read())
            {
                txtsatısadsoyad.Text = read["satan_kisi"].ToString();
                txtsatısadsoyad.Enabled = true;
            }
            bgl.baglantı().Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtbarkod.Text == "")
            {
                txturunad.Text = "";
                txturunkod.Text = "";
                txturunbdn.Text = "";
                txturunrenk.Text = "";
                txturunktg.Text = "";
                //txtpesinfiyat.Text = "";
                //txtkredifiyat.Text = "";
                txturunad.Enabled = false;
                txturunkod.Enabled = false;
                txturunbdn.Enabled = false;
                txturunrenk.Enabled = false;
                txturunktg.Enabled = false;
                comboBox1.Enabled = false;
                //txtpesinfiyat.Enabled = false;
                //txtkredifiyat.Enabled = false;
            }
            SqlCommand komut = new SqlCommand("select * from urunler where urun_barkod like '" + txtbarkod.Text + "'", bgl.baglantı());
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txturunad.Text = read["urun_adı"].ToString();
                txturunkod.Text = read["urun_kod"].ToString();
                txturunbdn.Text = read["urun_beden"].ToString();
                txturunrenk.Text = read["urun_renk"].ToString();
                txturunktg.Text = read["urun_kategori"].ToString();
                Lblgizli.Text = read["urun_adet"].ToString();
                //txtpesinfiyat.Text = read["urun_afiyat"].ToString();
                //txtkredifiyat.Text = read["urun_sfiyat"].ToString();
                txturunad.Enabled = true;
                txturunkod.Enabled = true;
                txturunbdn.Enabled = true;
                txturunrenk.Enabled = true;
                txturunktg.Enabled = true;
                comboBox1.Enabled = true;
                //txtpesinfiyat.Enabled = true;
                //txtkredifiyat.Enabled = true;
                stokcagır();
            }
           
            bgl.baglantı().Close();
        }

        private void txtsatistip_TextChanged(object sender, EventArgs e)
        {
            if (txtsatanid.Text == "")
            {
                txttür.Text = "";
                txttür.Enabled = false;
            }
            SqlCommand komut = new SqlCommand("select * from satıstipi where satıs_id like '" + txtsatistip.Text + "'", bgl.baglantı());
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txttür.Text = read["satıs_türü"].ToString();
                txttür.Enabled = true;
            }
            bgl.baglantı().Close();
        }
        public void temizle() {
            txtbarkod.Text = "";
            txturunad.Text = "";
            txtsatanid.Text = "";
            txturunkod.Text = "";
            txturunbdn.Text = "";
            txturunrenk.Text = "";
            txturunktg.Text = "";
            txtsatıstutarı.Text = "";
            txtsatısadsoyad.Text = "";
            comboBox1.Items.Clear();
            txtsatistip.Text = "";
            this.dateTimePicker1.Text = "";
        }
        public void stokcagır() {
            SqlCommand sehir = new SqlCommand("Select urun_adet From urunler where urun_barkod='" + txtbarkod.Text + "'", bgl.baglantı());
            SqlDataReader dr = sehir.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            bgl.baglantı().Close();
            int a = Convert.ToInt32(Lblgizli.Text);
            comboBox1.Items.Clear();
            for (int sayım = 1; sayım <= a; sayım++)
            {
                comboBox1.Items.Add(sayım);
            }
            simpleButton1.Enabled = true;
            if(comboBox1.Items.Count==0)
            {
                comboBox1.Items.Add("stok yok");
                simpleButton1.Enabled = false;
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
                SqlCommand kaydet = new SqlCommand("insert into sepet(urun_barkod,urun_adi,urun_kodu,urun_beden,urun_renk,urun_kategori,urun_satıs_miktari,urun_fiyat,urun_satis_tipi,satan_kisi_ad,satıs_tarihi) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglantı());
                kaydet.Parameters.AddWithValue("@p1", txtbarkod.Text);
                kaydet.Parameters.AddWithValue("@p2", txturunad.Text);
                kaydet.Parameters.AddWithValue("@p3", txturunkod.Text);
                kaydet.Parameters.AddWithValue("@p4", txturunbdn.Text);
                kaydet.Parameters.AddWithValue("@p5", txturunrenk.Text);
                kaydet.Parameters.AddWithValue("@p6", txturunktg.Text);
                kaydet.Parameters.AddWithValue("@p7", comboBox1.SelectedItem.ToString());
                kaydet.Parameters.AddWithValue("@p8", txtsatıstutarı.Text);
                kaydet.Parameters.AddWithValue("@p9", txttür.Text);
                kaydet.Parameters.AddWithValue("@p10", txtsatısadsoyad.Text);
                kaydet.Parameters.AddWithValue("@p11", this.dateTimePicker1.Value);
                kaydet.ExecuteNonQuery();
                bgl.baglantı().Close();
                temizle();
                txtbarkod.Text = "";
                daset.Tables["sepet"].Clear();
                hesapla();
                sepetlistele();
                simpleButton2.Enabled = true;
                simpleButton3.Enabled = true;
                simpleButton4.Enabled = true;

                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            
                    SqlCommand komut = new SqlCommand("delete From sepet where urun_barkod='" + dataGridView1.CurrentRow.Cells["urun_barkod"].Value.ToString() + "'", bgl.baglantı());
                    komut.ExecuteNonQuery();
                    bgl.baglantı().Close();
                    MessageBox.Show("Ürün Sepetten Çıkarıldı..");
                    daset.Tables["sepet"].Clear();
                    sepetlistele();
                    hesapla();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete From sepet", bgl.baglantı());
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Sipariş İptal Edildi..");
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            for (int i=0;i<dataGridView1.Rows.Count-1;i++)
            {
                SqlCommand kaydet = new SqlCommand("insert into satis(urun_barkod,urun_adi,urun_kodu,urun_beden,urun_renk,urun_kategori,urun_satıs_miktari,urun_fiyat,urun_satis_tipi,satan_kisi_ad,satıs_tarihi) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglantı());
                kaydet.Parameters.AddWithValue("@p1", dataGridView1.Rows[i].Cells["urun_barkod"].Value.ToString());
                kaydet.Parameters.AddWithValue("@p2", dataGridView1.Rows[i].Cells["urun_adi"].Value.ToString());
                kaydet.Parameters.AddWithValue("@p3", dataGridView1.Rows[i].Cells["urun_kodu"].Value.ToString());
                kaydet.Parameters.AddWithValue("@p4", dataGridView1.Rows[i].Cells["urun_beden"].Value.ToString());
                kaydet.Parameters.AddWithValue("@p5", dataGridView1.Rows[i].Cells["urun_renk"].Value.ToString());
                kaydet.Parameters.AddWithValue("@p6", dataGridView1.Rows[i].Cells["urun_kategori"].Value.ToString());
                kaydet.Parameters.AddWithValue("@p7", dataGridView1.Rows[i].Cells["urun_satıs_miktari"].Value.ToString());
                kaydet.Parameters.AddWithValue("@p8", dataGridView1.Rows[i].Cells["urun_fiyat"].Value.ToString());
                kaydet.Parameters.AddWithValue("@p9", dataGridView1.Rows[i].Cells["urun_satis_tipi"].Value.ToString());
                kaydet.Parameters.AddWithValue("@p10", dataGridView1.Rows[i].Cells["satan_kisi_ad"].Value.ToString());
                kaydet.Parameters.AddWithValue("@p11", dataGridView1.Rows[i].Cells["satıs_tarihi"].Value);
                //kaydet.Parameters.AddWithValue("@p11", this.dateTimePicker1.Value.ToString());
                kaydet.ExecuteNonQuery();
                SqlCommand kaydet2 = new SqlCommand("update urunler set urun_adet=urun_adet-'"+ dataGridView1.Rows[i].Cells["urun_satıs_miktari"].Value.ToString()+ "'where urun_barkod='"+ dataGridView1.Rows[i].Cells["urun_barkod"].Value.ToString() + "'",bgl.baglantı());
                kaydet2.ExecuteNonQuery();
                bgl.baglantı().Close();
            }
            SqlCommand komut3 = new SqlCommand("delete From sepet", bgl.baglantı());
            komut3.ExecuteNonQuery();
            bgl.baglantı().Close();
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
        }

        private void txtmiktar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            int miktar, tutar,sonuc;
            miktar = Convert.ToInt32(comboBox1.SelectedItem.ToString());
            tutar = Convert.ToInt32(txtsatishesapla.Text);
            sonuc = miktar * tutar;
            txtsatıstutarı.Text = sonuc.ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
