using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    internal class SQLConnection
    {
        public SqlConnection connection()
        {
            SqlConnection connect = new SqlConnection(@"Data Source=PREDATOR;Initial Catalog=HospitalDB;Integrated Security=True;TrustServerCertificate=True");
            connect.Open();
            return connect;
        }
        
    }
}
