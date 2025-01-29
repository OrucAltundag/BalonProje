using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalonProje
{

    
    class sqlbaglanti
    {
        public SqlConnection baglanti()
        {
          
        SqlConnection baglan = new SqlConnection("Data Source=ORIGI\\SQLEXPRESS;Initial Catalog=BALONPROJE;Integrated Security=True;TrustServerCertificate=True");
            baglan.Open();
            return baglan;
        }
    }
}
