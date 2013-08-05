using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace DL
{
    public class SqlDataProvider
    {
        public static string connectString = ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString;
        public static SqlConnection connect;
        public SqlDataProvider()
        {
            if (connect == null)
            {
                connect = new SqlConnection(connectString);
            }
        }
        public SqlConnection GetConnection()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
            {
                connect.Open();
                return connect;
            }
            else
            {
                return connect;
            }
        }
    }
}
