using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class Connection
    {
        public SqlConnection Connect { get; set; }
        public Connection()
        {
            string ConnectionString = "Data Source=DATPT-PC\\;Initial Catalog=EprojectSem3Team5;Persist Security Info=True;User ID=sa;Password=sa123";
            Connect = new SqlConnection(ConnectionString);
        }
    }
}
