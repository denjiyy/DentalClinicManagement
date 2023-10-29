using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DentalClinicManagement.LessImportantClasses
{
    class Connection
    {
        public SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tabut\OneDrive\Documents\DentalDatabase.mdf;Integrated Security=True;Connect Timeout=30";
            return conn;
        }
    }
}
