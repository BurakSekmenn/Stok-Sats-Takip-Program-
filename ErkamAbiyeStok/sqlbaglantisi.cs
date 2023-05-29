using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ErkamAbiyeStok
{
    class sqlbaglantisi
    {
        public SqlConnection baglantı()
        {
            // Data Source = BURAK - PC\BURAK; Initial Catalog = erkam_abiye; Integrated Security = True
            SqlConnection baglan = new SqlConnection(@"Data Source=BURAK-PC;Initial Catalog=erkam_abiye;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
