using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Latihan1
{
    
    internal class Koneksi
    {

      public SqlConnection getConn()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source = LAPTOP-6NU2B9QC\\SQLEXPRESS; Initial catalog = posDB; Integrated Security = True";
            return conn;
        }
    }
}
