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
    public class GuestFeedback_DL: SqlDataProvider
    {
        #region GuestFeedBackSelectAll
        public DataTable GuestFeedBackSelectAll()
        {
            DataTable dt = new DataTable();
            using (SqlCommand command = new SqlCommand("sp_GuestFeedBackSelectAll", GetConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                return dt;
            }
        }
        #endregion

        #region GuestFeedBackSelectByEmail
        public DataTable GuestFeedBackSelectByEmail(string email)
        {
            DataTable dt = new DataTable();
            using (SqlCommand command = new SqlCommand("sp_GuestFeedBackSelectByEmail", GetConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Email", email);
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                return dt;
            }
        }
        #endregion

        #region GuestFeedBackSelectById
        public DataTable GuestFeedBackSelectById(int id)
        {
            DataTable dt = new DataTable();
            using (SqlCommand command = new SqlCommand("sp_GuestFeedBackSelectByID", GetConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@FeedBackID", id);
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                return dt;
            }
        }
        #endregion
    }
}
