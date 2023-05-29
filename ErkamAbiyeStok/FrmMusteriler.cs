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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from musteri order by musteri_id desc", bgl.baglantı());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["musteri_id"].HeaderText = "Müşteri Sırası";
            dataGridView1.Columns["musteri_ad"].HeaderText = "Müşteri Adı";
            dataGridView1.Columns["musteri_soyad"].HeaderText = "Müşteri Soyadı";
            dataGridView1.Columns["musteri_cep"].HeaderText = "Müşteri Cep 1";
            dataGridView1.Columns["musteri_cep2"].HeaderText = "Müşteri Cep 2";
            dataGridView1.Columns["mus_email"].HeaderText = "Müşteri Mail";
            dataGridView1.Columns["mus_notlar"].HeaderText = "Müşteri Notları";
        }
        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtMid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtMad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtMsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            MskCep1.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            MskCep2.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtMmail.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            rchMnot.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand kaydet = new SqlCommand("insert into musteri(musteri_ad,musteri_soyad,musteri_cep,musteri_cep2,mus_email,mus_notlar) values(@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglantı());
            kaydet.Parameters.AddWithValue("@p1", TxtMad.Text);
            kaydet.Parameters.AddWithValue("@p2", TxtMsoyad.Text);
            kaydet.Parameters.AddWithValue("@p3", MskCep1.Text);
            kaydet.Parameters.AddWithValue("@p4", MskCep2.Text);
            kaydet.Parameters.AddWithValue("@p5", TxtMmail.Text);
            kaydet.Parameters.AddWithValue("@p6", rchMnot.Text);
            kaydet.ExecuteNonQuery();
            bgl.baglantı().Close();
            listele();
        }
        private void btnsil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutsil = new SqlCommand("Delete From musteri where musteri_id=@p1", bgl.baglantı());
                komutsil.Parameters.AddWithValue("@p1", txtMid.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglantı().Close();
                MessageBox.Show("Müşteri Bilgileri Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            catch (Exception)
            {
                MessageBox.Show("Müşteri Sayısı Seçili Olduğundan emin olunuz dikkat ederek seçiniz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update musteri set musteri_ad=@p1,musteri_soyad=@p2,musteri_cep=@p3,musteri_cep2=@p4,mus_email=@p5,mus_notlar=@p6 where musteri_id=@p10", bgl.baglantı());
                komut.Parameters.AddWithValue("@p1", TxtMad.Text);
                komut.Parameters.AddWithValue("@p2", TxtMsoyad.Text);
                komut.Parameters.AddWithValue("@p3", MskCep1.Text);
                komut.Parameters.AddWithValue("@p4", MskCep2.Text);
                komut.Parameters.AddWithValue("@p5", TxtMmail.Text);
                komut.Parameters.AddWithValue("@p6", rchMnot.Text);
                komut.Parameters.AddWithValue("@p10", txtMid.Text);
                komut.ExecuteNonQuery();
                bgl.baglantı().Close();
                listele();
            }
            catch (Exception)
            {
                MessageBox.Show("Notları Çok fazla Girilmiş olabilir lütfen verileri kontrol edip tekrar giriniz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
