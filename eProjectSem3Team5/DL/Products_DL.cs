using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Entities;
namespace DL
{
    public class Products_DL: SqlDataProvider
    {
        #region ProductSelectAll
        public DataTable ProductSelectAll()
        {
            DataTable dt = new DataTable();
            using (SqlCommand command = new SqlCommand("sp_ProductSelectAll", GetConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                return dt;
            }
        }
        #endregion

        #region ProductSelectByID
        public DataTable ProductSelectByID(int id)
        {
            DataTable dt = new DataTable();
            using (SqlCommand command = new SqlCommand("sp_ProductSelectByID", GetConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ProductID", id);
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                return dt;
            }
        }
        #endregion

        #region ProductSelectByCategory
        public DataTable ProductSelectByCategory(int id)
        {
            DataTable dt = new DataTable();
            using (SqlCommand command = new SqlCommand("sp_ProductSelectByCategory", GetConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CategoryID", id);
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                return dt;
            }
        }
        #endregion

        #region ProductInsert
        public void ProductInsert(Product product)
        {
            using (SqlCommand command = new SqlCommand("sp_ProductInsert", GetConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@CategoryID", product.CategoryID));
                command.Parameters.Add(new SqlParameter("@ProductName", product.ProductName));
                command.Parameters.Add(new SqlParameter("@Output", product.Output));
                command.Parameters.Add(new SqlParameter("@MadeGoodsSize", product.MadeGoodsSize));
                command.Parameters.Add(new SqlParameter("@MachineSize", product.MachineSize));
                command.Parameters.Add(new SqlParameter("@Picture", product.Picture));
                command.Parameters.Add(new SqlParameter("@UnitPrice", product.UnitPrice));
                command.Parameters.Add(new SqlParameter("@Weight", product.Weight));
                command.Parameters.Add(new SqlParameter("@ExtraDescription", product.ExtraDescription));
                command.ExecuteNonQuery();
            }
        }
        #endregion

        #region ProductUpdate
        public void ProductUpdate(Product product)
        {
            using (SqlCommand command = new SqlCommand("sp_ProductUpdate", GetConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ProductID", product.ProductID));
                command.Parameters.Add(new SqlParameter("@CategoryID", product.CategoryID));
                command.Parameters.Add(new SqlParameter("@ProductName", product.ProductName));
                command.Parameters.Add(new SqlParameter("@Output", product.Output));
                command.Parameters.Add(new SqlParameter("@MadeGoodsSize", product.MadeGoodsSize));
                command.Parameters.Add(new SqlParameter("@MachineSize", product.MachineSize));
                command.Parameters.Add(new SqlParameter("@Picture", product.Picture));
                command.Parameters.Add(new SqlParameter("@Weight", product.Weight));
                command.Parameters.Add(new SqlParameter("@UnitPrice", product.UnitPrice));
                command.Parameters.Add(new SqlParameter("@ExtraDescription", product.ExtraDescription));
                command.ExecuteNonQuery();
            }
        }
        #endregion

        #region ProductDelete
        public void ProductDelete(int id)
        {
            using (SqlCommand command = new SqlCommand("sp_ProductDelete", GetConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ProductID", id));
                command.ExecuteNonQuery();
            }
        }
        #endregion
    }
}
