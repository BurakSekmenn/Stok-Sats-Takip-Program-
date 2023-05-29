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
    public partial class Frmİade : Form
    {
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from iade order by iade_no desc", bgl.baglantı());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public Frmİade()
        {
            InitializeComponent();
        }

        private void Frmİade_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
