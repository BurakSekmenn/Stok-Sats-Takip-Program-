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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand kontrol = new SqlCommand("Select * From TBLADMİN where Kullanıcıadı=@p1 and Kullanıcısifre=@p2", bgl.baglantı());
            kontrol.Parameters.AddWithValue("@p1", txtkull.Text);
            kontrol.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = kontrol.ExecuteReader();
            if (dr.Read())
            {
                AnaForm frh = new AnaForm();
                frh.Show();
            }
            else
            {
                MessageBox.Show("Böyle bir kayıt bulanamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
