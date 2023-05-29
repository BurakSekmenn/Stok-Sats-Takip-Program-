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
    
    public partial class Frmürünarmaek : Form
    {
        public string barkod;
        public string urunad;
        public string urunkod;
        public string urunadet;
        public string urunbeden;
        public string urunrenk;
        public string urun_kategori;
        public string urun_tarih;
        public string urunafiyat;
        public string urunsfiyat;
        public Frmürünarmaek()
        {
            InitializeComponent();
        }

        private void Frmürünarmaek_Load(object sender, EventArgs e)
        {
            txtbarkod.Text = barkod;
            txturunad.Text = urunad;
            txtkod.Text = urunkod;
            txtadet.Text = urunadet;
            txtbdn.Text = urunbeden;
            txtrenk.Text = urunrenk;
            txtktg.Text = urun_kategori;
            txtpfiyat.Text = urunafiyat;
            txtkfiyat.Text = urunsfiyat;
            label11.Text = urun_tarih;
            this.dateTimePicker1.Text = label11.Text;
        }
        
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update urunler set urun_adı=@p1,urun_kod=@p2,urun_adet=@p3,urun_beden=@p4,urun_renk=@p5,urun_kategori=@p6,urun_tarih=@p7,urun_afiyat=@p8,urun_sfiyat=@p9 where urun_barkod=@p10", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", txturunad.Text);
            komut.Parameters.AddWithValue("@p2", txtkod.Text);
            komut.Parameters.AddWithValue("@p3", txtadet.Text);
            komut.Parameters.AddWithValue("@p4", txtbdn.Text);
            komut.Parameters.AddWithValue("@p5", txtrenk.Text);
            komut.Parameters.AddWithValue("@p6", txtktg.Text);
            komut.Parameters.AddWithValue("@p7", this.dateTimePicker1.Text);
            komut.Parameters.AddWithValue("@p8", txtpfiyat.Text);
            komut.Parameters.AddWithValue("@p9", txtkfiyat.Text);
            komut.Parameters.AddWithValue("@p10", txtbarkod.Text);
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Güncelleme Başarılı");
        }
        void temizle()
        {
            txtbarkod.Text = "";
            txturunad.Text = "";
            txtkod.Text = "";
            txtadet.Text = "";
            txtbdn.Text = "";
            txtrenk.Text = "";
            txtktg.Text = "";
            dateTimePicker1.Text = "";
            txtpfiyat.Text = "";
            txtbarkod.Text = "";
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into iade(urun_barkod,urun_adı,urun_kod,urun_adet,urun_beden,urun_renk,urun_kategori,urun_tarih,urun_afiyat,urun_sfiyat) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", txtbarkod.Text);
            komut.Parameters.AddWithValue("@p2", txturunad.Text);
            komut.Parameters.AddWithValue("@p3", txtkod.Text);
            komut.Parameters.AddWithValue("@p4", txtadet.Text);
            komut.Parameters.AddWithValue("@p5", txtbdn.Text);
            komut.Parameters.AddWithValue("@p6", txtrenk.Text);
            komut.Parameters.AddWithValue("@p7", txtktg.Text);
            komut.Parameters.AddWithValue("@p8", this.dateTimePicker1.Text);
            komut.Parameters.AddWithValue("@p9", txtpfiyat.Text);
            komut.Parameters.AddWithValue("@p10", txtkfiyat.Text);
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Ürün İadesi Başarılırılı bir şekilde gerçekleşti ve ürünlerden çıkarıldır","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            SqlCommand komutsil = new SqlCommand("Delete From urunler where urun_barkod=@p1", bgl.baglantı());
            komutsil.Parameters.AddWithValue("@p1", txtbarkod.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglantı().Close();
        }
    }
}
