using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
namespace DL
{
    public class Careerer_DL : SqlDataProvider
    {
        Careerer user = new Careerer();
        #region CareererSelectAll
        public DataTable CareererSelectAll()
        {
            DataTable dt = new DataTable();
            using (SqlCommand command = new SqlCommand("sp_CareererSelectAll", GetConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                return dt;
            }
        }
        #endregion

        #region CareererSelectById
        public DataTable CareererSelectById(int CareererID)
        {
            DataTable dt = new DataTable();
            using (SqlCommand command = new SqlCommand("sp_CareererSelectByID", GetConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CareererID", CareererID);
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                return dt;
            }
        }
        #endregion

    }
}
