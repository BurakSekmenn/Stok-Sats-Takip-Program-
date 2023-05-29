using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErkamAbiyeStok
{
    public partial class Frmkucuk : Form
    {
        public string barkodgeliyor;
        public string kodgeliyor;
        public string satısfiyat;
        public string bedengeliyor;
        public string renkgeliyorrr;
        public string pesingeliyor;
        public string kredikartlıgeliyor;
        public string urunadıgeliyorr;
        string renkal, lblurunad;
        Double barkodalaıs, bdnnoal, fıyatal, dovızal, urunkodal, kredi;

        private void Frmkucuk_Load(object sender, EventArgs e)
        {
            textBox2.Text = barkodgeliyor.ToString();
            textBox1.Text = kodgeliyor.ToString();
            txtpsn.Text = pesingeliyor.ToString();
            txtkredi.Text = kredikartlıgeliyor.ToString();
            textBox3.Text = bedengeliyor.ToString();
            txtrenk.Text = renkgeliyorrr.ToString();
            txturunad.Text = urunadıgeliyorr.ToString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //  Bitmap bmp = new Bitmap(groupBox1.ClientRectangle.Width, groupBox1.ClientRectangle.Height);
            //  groupBox1.DrawToBitmap(bmp, groupBox1.ClientRectangle);
            //  e.Graphics.DrawImage(bmp, 0, 0);
            Bitmap bmp = new Bitmap(groupBox1.Width, groupBox1.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            groupBox1.DrawToBitmap(bmp, new Rectangle(0, 0, groupBox1.Width, groupBox1.Height));
            e.Graphics.DrawImage((Image)bmp, 0, 0);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            PrintDocument Pd = new PrintDocument();
            Pd.PrintPage += this.printDocument1_PrintPage;
            ppd.Document = Pd;
            ppd.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                urunkodal = double.Parse(textBox1.Text);//boş atayınca öyle 
                barkodalaıs = double.Parse(textBox2.Text);
                bdnnoal = double.Parse(textBox3.Text);
                fıyatal = double.Parse(txtpsn.Text);
                dovızal = double.Parse(textBox5.Text);
                renkal = txtrenk.Text;
                lblurunad = txturunad.Text;
                kredi = double.Parse(txtkredi.Text);
                string Barkod = barkodgeliyor;
                /*  int beden = 36;
                  int fiyat = 500;
                  int doviz = 200;//bu değerleri istediğin yerden çekebilirsin. */

                /* brkkod.Text = Barkod.ToString();*/
                label2.Text = barkodgeliyor;
                Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                pictureBox1.Image = barcode.Draw(barkodgeliyor, 50);
                /* kod.Text = Kod.ToString();*/
                bdntxt.Text = "Beden" + bdnnoal.ToString();
                label7.Text = "Kod " + urunkodal.ToString();
                fiyattxt.Text = "Fiyat " + fıyatal.ToString() + "₺";
                doviztxt.Text = "Döviz :" + dovızal.ToString() + "$";
                renk.Text = renkal.ToString();
                label11.Text = lblurunad.ToString();
                label12.Text = "Kredi Kartı Fiyat :" + kredi.ToString() + "₺";
            }
            catch (Exception)
            {

                MessageBox.Show("Lüften Boş Veri Bırakmayın..", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public Frmkucuk()
        {
            InitializeComponent();
        }
    }
}
