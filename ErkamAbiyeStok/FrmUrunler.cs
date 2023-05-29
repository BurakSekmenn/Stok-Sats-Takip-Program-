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
using System.Runtime.InteropServices;
using System.Security.Permissions;
[assembly: SecurityPermission(SecurityAction.RequestMinimum, UnmanagedCode = true)]


namespace ErkamAbiyeStok
{


    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
            listele();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void temizle()
        {
            TxtBarkod.Text = "";
            Txturunad.Text = "";
            txturunkod.Text = "";
            txtadt.Text = "";
            txtbdn.Text = "";
            txtrenk.Text = "";
            txtkategori.Text = "";
            dateTimePicker1.Text = "";
            txtafiyat.Text = "";
            txtsfiyat.Text = "";
        }
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtBarkod.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            Txturunad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txturunkod.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtadt.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtbdn.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtrenk.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtkategori.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            txtafiyat.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            txtsfiyat.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand kaydet = new SqlCommand("insert into urunler(urun_adı,urun_kod,urun_adet,urun_beden,urun_renk,urun_kategori,urun_tarih,urun_afiyat,urun_sfiyat) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglantı());
                kaydet.Parameters.AddWithValue("@p1", Txturunad.Text);
                kaydet.Parameters.AddWithValue("@p2", txturunkod.Text);
                kaydet.Parameters.AddWithValue("@p3", txtadt.Text);
                kaydet.Parameters.AddWithValue("@p4", txtbdn.Text);
                kaydet.Parameters.AddWithValue("@p5", txtrenk.Text);
                kaydet.Parameters.AddWithValue("@p6", txtkategori.Text);
                kaydet.Parameters.AddWithValue("@p7", this.dateTimePicker1.Text);
                kaydet.Parameters.AddWithValue("@p8", txtafiyat.Text);
                kaydet.Parameters.AddWithValue("@p9", txtsfiyat.Text);
                kaydet.ExecuteNonQuery();
                bgl.baglantı().Close();
                listele();
                temizle();
            }
            catch (Exception) {
                MessageBox.Show("Yanlış Giriş Yapılıyor dikkat ederek girin..", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void dateTimePicker1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back) {
                dateTimePicker1.CustomFormat = "";
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutsil = new SqlCommand("Delete From urunler where urun_barkod=@p1", bgl.baglantı());
                komutsil.Parameters.AddWithValue("@p1", TxtBarkod.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglantı().Close();
                MessageBox.Show("Ürün Bilgileri Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
            catch (Exception) {
                MessageBox.Show("Barkod Seçili Olduğundan emin olunuz dikkat ederek seçiniz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            try {
                SqlCommand komut = new SqlCommand("update urunler set urun_adı=@p1,urun_kod=@p2,urun_adet=@p3,urun_beden=@p4,urun_renk=@p5,urun_kategori=@p6,urun_tarih=@p7,urun_afiyat=@p8,urun_sfiyat=@p9 where urun_barkod=@p10", bgl.baglantı());
                komut.Parameters.AddWithValue("@p1", Txturunad.Text);
                komut.Parameters.AddWithValue("@p2", txturunkod.Text);
                komut.Parameters.AddWithValue("@p3", txtadt.Text);
                komut.Parameters.AddWithValue("@p4", txtbdn.Text);
                komut.Parameters.AddWithValue("@p5", txtrenk.Text);
                komut.Parameters.AddWithValue("@p6", txtkategori.Text);
                komut.Parameters.AddWithValue("@p7", this.dateTimePicker1.Text);
                komut.Parameters.AddWithValue("@p8", txtafiyat.Text);
                komut.Parameters.AddWithValue("@p9", txtsfiyat.Text);
                komut.Parameters.AddWithValue("@p10", TxtBarkod.Text);
                komut.ExecuteNonQuery();
                bgl.baglantı().Close();
                listele();
                temizle();
            }
            catch (Exception)
            {
                MessageBox.Show("Bazı Verileri fazla girdiniz yada hatalı Giriş...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void barkodYazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutsil = new SqlCommand("Delete From urunler where urun_barkod=@p1", bgl.baglantı());
                komutsil.Parameters.AddWithValue("@p1", TxtBarkod.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglantı().Close();
                MessageBox.Show("Ürün Bilgileri Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
            catch (Exception)
            {
                MessageBox.Show("Barkod Seçili Olduğundan emin olunuz dikkat ederek seçiniz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update urunler set urun_adı=@p1,urun_kod=@p2,urun_adet=@p3,urun_beden=@p4,urun_renk=@p5,urun_kategori=@p6,urun_tarih=@p7,urun_afiyat=@p8,urun_sfiyat=@p9 where urun_barkod=@p10", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", Txturunad.Text);
            komut.Parameters.AddWithValue("@p2", txturunkod.Text);
            komut.Parameters.AddWithValue("@p3", txtadt.Text);
            komut.Parameters.AddWithValue("@p4", txtbdn.Text);
            komut.Parameters.AddWithValue("@p5", txtrenk.Text);
            komut.Parameters.AddWithValue("@p6", txtkategori.Text);
            komut.Parameters.AddWithValue("@p7", this.dateTimePicker1.Text);
            komut.Parameters.AddWithValue("@p8", txtafiyat.Text);
            komut.Parameters.AddWithValue("@p9", txtsfiyat.Text);
            komut.Parameters.AddWithValue("@p10", TxtBarkod.Text);
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();
            listele();
            temizle();
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listele();
        }
        string barkod, urunkod, beden, renkgeliyor,pesingeliyorr,kredikartlıgeliyor,urunadı;

        private void barkodYazdır30x30ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            barkod = TxtBarkod.Text;
            urunkod = txturunkod.Text;
            renkgeliyor = txtrenk.Text;
            beden = txtbdn.Text;
            pesingeliyorr = txtafiyat.Text;
            kredikartlıgeliyor = txtsfiyat.Text;
            urunadı = Txturunad.Text;
            Frmkucuk frba = new Frmkucuk();
            frba.barkodgeliyor = barkod;
            frba.kodgeliyor = urunkod;
            frba.bedengeliyor = beden;
            frba.renkgeliyorrr = renkgeliyor;
            frba.pesingeliyor = pesingeliyorr;
            frba.urunadıgeliyorr = urunadı;
            frba.kredikartlıgeliyor = txtsfiyat.Text;
            frba.Show();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            export_dgw_excel_1(dataGridView1);
        }

        private void FrmUrunler_Load(object sender, EventArgs e)
        {

        }

        private void barkodYazdırToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            barkod = TxtBarkod.Text;
            urunkod = txturunkod.Text;
            renkgeliyor = txtrenk.Text;
            beden = txtbdn.Text;
            pesingeliyorr = txtafiyat.Text;
            kredikartlıgeliyor = txtsfiyat.Text;
            urunadı = Txturunad.Text;
            FrmUrunBarkodGonder frb = new FrmUrunBarkodGonder();
            frb.barkodgeliyor = barkod;
            frb.kodgeliyor = urunkod;
            frb.bedengeliyor = beden;
            frb.renkgeliyorrr = renkgeliyor;
            frb.pesingeliyor = pesingeliyorr;
            frb.urunadıgeliyorr = urunadı;
            frb.kredikartlıgeliyor = txtsfiyat.Text;
            frb.Show();
        }
    }
}
