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
using Excel = Microsoft.Office.Interop.Excel;

namespace ErkamAbiyeStok
{
    public partial class FrmSatısListele : Form
    {
        sqlbaglantisi bgl = new sqlbaglantisi();
        DataSet daset = new DataSet();
        private void siparislistele()
        {
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
        public FrmSatısListele()
        {
            InitializeComponent();
        }
        public void yıllıktutar()
        {
            SqlCommand komut = new SqlCommand("select sum(urun_fiyat) from satis", bgl.baglantı());
            tplmciro.Text = komut.ExecuteScalar() + " TL";
            bgl.baglantı().Close();
            tplmciro.Visible = true;
        }
        public void kisisayısı() {
            SqlCommand komut = new SqlCommand("select max(satıs_id) from satisisim", bgl.baglantı());
            tplkisi.Text = komut.ExecuteScalar() + " Kişi";
            bgl.baglantı().Close();
        }
        private void FrmSatısListele_Load(object sender, EventArgs e)
        {
            siparislistele();
            yıllıktutar();
            kisisayısı();
        }
        public void yenile()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from satis order by satis_id desc", bgl.baglantı());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yenile();
            kisisayısı();
            yıllıktutar();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string arama = "Select * From satis where satıs_tarihi BETWEEN @tarih1 and @tarih2";
            SqlDataAdapter da = new SqlDataAdapter(arama, bgl.baglantı());
            da.SelectCommand.Parameters.AddWithValue("@tarih1", dateTimePicker1.Text);
            da.SelectCommand.Parameters.AddWithValue("@tarih2", dateTimePicker2.Text);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglantı().Close();
            SqlCommand komut = new SqlCommand("Select sum(urun_fiyat) as 'Toplam Ciro' From satis where satıs_tarihi BETWEEN '" + dateTimePicker1.Text + "' and '"+dateTimePicker2.Text+"' ", bgl.baglantı());
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                AyCiro.Text = read["Toplam Ciro"].ToString();
            }
            bgl.baglantı().Close();
            label5.Visible = true;
            AyCiro.Visible = true;
        }
        bool export_dgw_excel_1(DataGridView dgw)
        {
            bool durum = false;
            try
            {
                dgw.SelectAll();
                DataObject dataObj = dgw.GetClipboardContent();
                if (dataObj != null)
                    Clipboard.SetDataObject(dataObj);
                Excel.Application xlexcel;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlexcel = new Excel.Application();
                xlexcel.Visible = true;
                xlWorkBook = xlexcel.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                //Kodumuz buraya kadar gelip veri aktarımını tamamladı ise durum true yaparak işlemin başarılı
                //Olduğu bilgisini alıyoruz.
                durum = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("DataGrid Verileri Aktarılamadı : " + ex.Message);
            }
            return durum;
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            export_dgw_excel_1(dataGridView1);
        }
        public void toplammiktar() {
            SqlCommand komut = new SqlCommand("Select sum(urun_satıs_miktari) as 'deneme' From satis where urun_kategori='" + txtktg.Text + "'", bgl.baglantı());
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                lbltoplam.Text = read["deneme"].ToString();
            }
            lbltoplam.Visible = true;
            label10.Visible = true;
        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from satis where urun_kategori like'%" + txtktg.Text + "'", bgl.baglantı()); ;
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglantı().Close();

            SqlCommand komut = new SqlCommand("Select sum(urun_fiyat) as 'Toplam Ciro' From satis where urun_kategori='"+txtktg.Text+"'", bgl.baglantı());
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                label7.Text = read["Toplam Ciro"].ToString();
            }
            bgl.baglantı().Close();
            label7.Visible = true;
            label8.Visible = true;
            bgl.baglantı().Close();
            toplammiktar();
            
           
        }
        

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            export_dgw_excel_1(dataGridView1);
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from satis where satan_kisi_ad like'%" + txtkad.Text + "'", bgl.baglantı()); ;
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglantı().Close();

            SqlCommand komut = new SqlCommand("Select sum(urun_fiyat) as 'Toplam Ciro' From satis where satan_kisi_ad='" + txtkad.Text + "'", bgl.baglantı());
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                lblkisiciro.Text = read["Toplam Ciro"].ToString();
            }
            bgl.baglantı().Close();
            label11.Visible = true;
            lblkisiciro.Visible = true;
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            export_dgw_excel_1(dataGridView1);
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            yenile();
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            export_dgw_excel_1(dataGridView1);
        }
    }
}
