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
    public partial class FrmFirmalar : Form
    {
        public FrmFirmalar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from firma order by firma_id desc", bgl.baglantı());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["firma_id"].HeaderText = "Firma Sırası";
            dataGridView1.Columns["firma_adı"].HeaderText = "Firma Adı";
            dataGridView1.Columns["firm_yetkili"].HeaderText = "Firma Yetkilisi";
            dataGridView1.Columns["firma_cep1"].HeaderText = "Firma Cep 1";
            dataGridView1.Columns["firma_cep2"].HeaderText = "Firma Cep 2";
            dataGridView1.Columns["firma_mail"].HeaderText = "Firma Mail";
          
        }

        private void FrmFirmalar_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtFid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtFad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtFyet.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            MskCep1.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            MskCep2.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtFmail.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();            
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand kaydet = new SqlCommand("insert into firma(firma_adı,firm_yetkili,firma_cep1,firma_cep2,firma_mail) values(@p1,@p2,@p3,@p4,@p5)", bgl.baglantı());
                kaydet.Parameters.AddWithValue("@p1", TxtFad.Text);
                kaydet.Parameters.AddWithValue("@p2", txtFyet.Text);
                kaydet.Parameters.AddWithValue("@p3", MskCep1.Text);
                kaydet.Parameters.AddWithValue("@p4", MskCep2.Text);
                kaydet.Parameters.AddWithValue("@p5", TxtFmail.Text);
                kaydet.ExecuteNonQuery();
                bgl.baglantı().Close();
                listele();
            }
            catch (Exception)
            {
                MessageBox.Show("Dikket Ederek Giriniz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutsil = new SqlCommand("Delete From firma where firma_id=@p1", bgl.baglantı());
                komutsil.Parameters.AddWithValue("@p1", txtFid.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglantı().Close();
                MessageBox.Show("Firma Bilgileri Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                SqlCommand komut = new SqlCommand("update firma set firma_adı=@p1,firm_yetkili=@p2,firma_cep1=@p3,firma_cep2=@p4,firma_mail=@p5 where firma_id=@p10", bgl.baglantı());
                komut.Parameters.AddWithValue("@p1", TxtFad.Text);
                komut.Parameters.AddWithValue("@p2", txtFyet.Text);
                komut.Parameters.AddWithValue("@p3", MskCep1.Text);
                komut.Parameters.AddWithValue("@p4", MskCep2.Text);
                komut.Parameters.AddWithValue("@p5", TxtFmail.Text);
                komut.Parameters.AddWithValue("@p10", txtFid.Text);
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
