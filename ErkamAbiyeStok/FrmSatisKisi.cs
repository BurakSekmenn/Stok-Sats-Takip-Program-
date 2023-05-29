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
    public partial class FrmSatisKisi : Form
    {
        public FrmSatisKisi()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public void listele() {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from satisisim ", bgl.baglantı());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["satıs_id"].HeaderText = "Kisi Numarası";
            dataGridView1.Columns["satan_kisi"].HeaderText = "Kisi Adı Soyadı";
        }
        public void temizle() {
            textEdit1.Text = "";
            textEdit2.Text = "";
        }
        private void FrmSatisKisi_Load(object sender, EventArgs e)
        {
            listele();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand kaydet = new SqlCommand("insert into satisisim (satıs_id,satan_kisi) values (@p1,@p2)", bgl.baglantı());
            kaydet.Parameters.AddWithValue("@p1", textEdit1.Text);
            kaydet.Parameters.AddWithValue("@p2", textEdit2.Text);
            kaydet.ExecuteNonQuery();
            listele();
            temizle();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textEdit1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textEdit2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand kaydet = new SqlCommand("delete from satisisim where satıs_id=@p1", bgl.baglantı());
            kaydet.Parameters.AddWithValue("@p1", textEdit1.Text);
            kaydet.ExecuteNonQuery();
            listele();
            temizle();
        }
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SqlCommand kaydet = new SqlCommand("update satisisim set satan_kisi=@p1 where satıs_id=@p2", bgl.baglantı());
            kaydet.Parameters.AddWithValue("@p1", textEdit2.Text);
            kaydet.Parameters.AddWithValue("@p2", textEdit1.Text);
            kaydet.ExecuteNonQuery();
            listele();
            temizle();
        }
    }
}
