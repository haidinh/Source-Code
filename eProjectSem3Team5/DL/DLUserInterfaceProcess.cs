using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entities;

namespace DL
{
    public class DLUserInterfaceProcess
    {
        public SqlConnection connect { get; set; }
        public SqlCommand Command { get; set; }
        public List<Category> GetCategory()
        {
            try
            {
                List<Category> ListOfCategory = new List<Category>();
                connect = new Connection().Connect;
                connect.Open();
                Command = new SqlCommand("sp_getAllCategory", connect);
                Command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader dr = Command.ExecuteReader();
                while (dr.Read())
                {
                    Category objCategory = new Category();
                    objCategory.CategoryID = dr.GetInt32(0);
                    objCategory.CategoryName = dr.GetString(1);
                    ListOfCategory.Add(objCategory);
                }
                connect.Close();
                return ListOfCategory;
            }
            catch (Exception)
            {
                connect.Close();
                return null;
            }
        }
        public List<Product> GetProductByAddedDate()
        {
            try
            {
                List<Product> ListOfProduct = new List<Product>();
                connect = new Connection().Connect;
                connect.Open();
                Command = new SqlCommand("sp_GetProductByAddedDate", connect);
                Command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader dr = Command.ExecuteReader();
                while (dr.Read())
                {
                    Product objProduct = new Product();
                    objProduct.ProductName = dr.GetString(0);
                    objProduct.Output = dr.GetInt32(1);
                    objProduct.MadeGoodsSize = dr.GetDouble(2);
                    objProduct.MachineSize = dr.GetString(3);
                    objProduct.Weight = dr.GetDouble(4);
                    objProduct.UnitPrice =  dr.GetDecimal(5);
                    objProduct.Picture = dr.GetString(6);
                    objProduct.FrequentlyViewed = dr.GetInt32(7);
                    objProduct.ProductID = dr.GetInt32(8);
                    objProduct.ExtraDescription = dr.GetString(9);
                    ListOfProduct.Add(objProduct);
                }
                connect.Close();
                return ListOfProduct;
            }
            catch (Exception)
            {
                connect.Close();
                return null;
            }
        }
        public List<Product> GetProductByMostFrequentlyViewed()
        {
            try
            {
                List<Product> ListOfProduct = new List<Product>();
                connect = new Connection().Connect;
                connect.Open();
                Command = new SqlCommand("sp_GetProductByFrequentlyViewed", connect);
                Command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader dr = Command.ExecuteReader();
                while (dr.Read())
                {
                    Product objProduct = new Product();
                    objProduct.ProductName = dr.GetString(0);
                    objProduct.Output = dr.GetInt32(1);
                    objProduct.MadeGoodsSize = dr.GetDouble(2);
                    objProduct.MachineSize = dr.GetString(3);
                    objProduct.Weight = dr.GetDouble(4);
                    objProduct.UnitPrice = dr.GetDecimal(5);
                    objProduct.Picture =  dr.GetString(6);
                    objProduct.FrequentlyViewed = dr.GetInt32(7);
                    objProduct.ProductID = dr.GetInt32(8);
                    objProduct.ExtraDescription = dr.GetString(9);
                    ListOfProduct.Add(objProduct);
                }
                connect.Close();
                return ListOfProduct;
            }
            catch (Exception)
            {
                connect.Close();
                return null;
            }
        }


    }
}
