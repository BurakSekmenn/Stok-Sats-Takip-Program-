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
using Microsoft.SqlServer.Management;
using Microsoft.SqlServer.Management.Smo;
using Grpc.Core;
namespace ErkamAbiyeStok
{
    public partial class FrmYedek : Form
    {
        public FrmYedek()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmYedek_Load(object sender, EventArgs e)
        {
            try {
                if (bgl.baglantı().State == ConnectionState.Open)
                {
                    label1.Text = "Veri Tabanı Bağlantısı Başarılı Yedek Alma İşlemini Başlatınız";
                    label1.ForeColor = Color.FromArgb(0, 255, 0);

                }
                else
                {
                    label1.Text = "Veri Tabanı Bağlantısı Başarılı olmadı yöneticiye başvurun";
                }
            }
           catch (Exception)
            {
                MessageBox.Show("Veri Tabanı Bağlantısı Başarılı olmadı yöneticiye başvurun");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string komutcumle = "BACKUP DATABASE erkam_abiye TO DISK = '" + Application.StartupPath + "\\" + DateTime.Now.ToString("yyyyMMdd") + ".bak'";
            SqlCommand komut = new SqlCommand(komutcumle, bgl.baglantı());
            komut.ExecuteNonQuery();
            MessageBox.Show("Veritabanı yedek alma işlemi başarılı bir şekilde alındı");
        }
    }
}
