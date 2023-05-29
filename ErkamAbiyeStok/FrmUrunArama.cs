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
    public partial class FrmUrunArama : Form
    {
        public FrmUrunArama()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from urunler order by urun_barkod desc", bgl.baglantı());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["urun_barkod"].HeaderText = "Barkod";
            dataGridView1.Columns["urun_adı"].HeaderText = "Ürün Adı";
            dataGridView1.Columns["urun_kod"].HeaderText = "Kod";
            dataGridView1.Columns["urun_adet"].HeaderText = "Adet";
            dataGridView1.Columns["urun_beden"].HeaderText = "Beden";
            dataGridView1.Columns["urun_renk"].HeaderText = "Renk";
            dataGridView1.Columns["urun_kategori"].HeaderText = "Kategori";
            dataGridView1.Columns["urun_tarih"].HeaderText = "Tarih";
            dataGridView1.Columns["urun_afiyat"].HeaderText = "Peşin Fiyatı";
            dataGridView1.Columns["urun_sfiyat"].HeaderText = "Kredi Kartlı Fiyatı";
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from urunler where urun_barkod like'%" + txtbarkod.Text + "%'", bgl.baglantı()); ;
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglantı().Close();
        }

        private void FrmUrunArama_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnkktgara_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from urunler where urun_kategori like'%" + txtktg.Text + "'", bgl.baglantı()); ;
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglantı().Close();
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

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string arama = "Select * From urunler where urun_tarih BETWEEN @tarih1 and @tarih2 and urun_kategori=@aranan";
            SqlDataAdapter da = new SqlDataAdapter(arama,bgl.baglantı());
            da.SelectCommand.Parameters.AddWithValue("@tarih1", dateTimePicker1.Text); 
            da.SelectCommand.Parameters.AddWithValue("@tarih2", dateTimePicker2.Text);
            da.SelectCommand.Parameters.AddWithValue("@aranan", txtkatgadı.Text);
           
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglantı().Close();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            export_dgw_excel_1(dataGridView1);
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;     
            Frmürünarmaek fra = new Frmürünarmaek();
            fra.barkod = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            fra.urunad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            fra.urunkod = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            fra.urunadet = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            fra.urunbeden = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            fra.urunrenk = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            fra.urun_kategori = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            fra.urun_tarih = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            fra.urunafiyat = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            fra.urunsfiyat = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            fra.Show();
        }
    }
}
