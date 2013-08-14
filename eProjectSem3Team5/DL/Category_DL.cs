using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data;
using MyWeb.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
namespace DL
{
    public class Category_DL: SqlDataProvider
    {
        #region CategorySelectAll
        public DataTable CategorySelectAll()
        {
            DataTable dt = new DataTable();
            using (SqlCommand command = new SqlCommand("sp_CategorySelectAll", GetConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                return dt;
            }
        }
        #endregion

        #region CategorySelectById
        public DataTable CategorySelectById(int id)
        {
            DataTable dt = new DataTable();
            using (SqlCommand command = new SqlCommand("sp_CategorySelectByID", GetConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CategoryId", id);
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                return dt;
            }
        }
        #endregion

        #region CategoryInsert
        public void CategoryInsert(Category category)
        {
            using (SqlCommand command = new SqlCommand("sp_CategoryInsert", GetConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Category", category.CategoryName));
                command.ExecuteNonQuery();
            }
        }
        #endregion

        #region CategoryDelete
        public void CategoryDelete(int  id)
        {
            using (SqlCommand command = new SqlCommand("sp_CategoryDelete", GetConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CategoryId", id);
                command.ExecuteNonQuery();
            }
        }
        #endregion

        #region CategoryUpdate
        public void CategoryUpdate(Category category)
        {
            using (SqlCommand command = new SqlCommand("sp_CategoryUpdate", GetConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CategoryId", category.CategoryID);
                command.Parameters.AddWithValue("@CategoryName", category.CategoryName);
                command.ExecuteNonQuery();
            }
        }
        #endregion
    }
}
