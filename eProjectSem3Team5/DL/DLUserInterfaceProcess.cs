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

        // Get all categories of products
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
        
        // Get products that are added lastest to database
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
                    objProduct.UnitPrice = dr.GetDecimal(5);
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

        // Get products which are most viewed 
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
        
        //  Log in
        public Careerer Login(string sEmail, string sPassword)
        {
            try
            {
                connect = new Connection().Connect;
                connect.Open();
                Command = new SqlCommand("sp_Login", connect);
                Command.CommandType = System.Data.CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@EmailAddress", sEmail);
                Command.Parameters.AddWithValue("@Password", sPassword);
                SqlDataReader dr = Command.ExecuteReader();
                if (dr.Read())
                {
                    Careerer objCareerer = new Careerer();
                    objCareerer.UserName = dr.GetString(0);
                    objCareerer.Password = dr.GetString(1);
                    objCareerer.CareererID = dr.GetInt32(2);
                    connect.Close();
                    return objCareerer;
                }
                else
                {
                    connect.Close();
                    return null;
                }

            }
            catch (Exception)
            {
                connect.Close();
                return null;
            }
        }
        
        // Sign up
        public bool SignUp(string sEmail, string sPassword, string sUserName)
        {
            try
            {
                connect = new Connection().Connect;
                connect.Open();
                Command = new SqlCommand("sp_SignUp", connect);
                Command.CommandType = System.Data.CommandType.StoredProcedure;
                // Assign input value to variables
                Command.Parameters.AddWithValue("@EmailAddress", sEmail);
                Command.Parameters.AddWithValue("@Password", sPassword);
                Command.Parameters.AddWithValue("@UserName", sUserName);
                // 
                Command.ExecuteNonQuery();
                connect.Close();
                return true;
            }
            catch (Exception)
            {
                connect.Close();
                return false;
            }
        }

        // Get products with certain category
        public List<Product> GetProductByCategory(int iCategoryID)
        {
            try
            {
                List<Product> ListOfProductByCategory = new List<Product>();
                connect = new Connection().Connect;
                connect.Open();
                Command = new SqlCommand("sp_GetProductByCategory", connect);
                Command.CommandType = System.Data.CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@CategoryID", iCategoryID);
                SqlDataReader dr = Command.ExecuteReader();
                while (dr.Read())
                {
                    Product objProduct = new Product();
                    objProduct.ProductName = dr.GetString(0);
                    objProduct.UnitPrice = dr.GetDecimal(1);
                    objProduct.Picture = dr.GetString(2);
                    objProduct.ProductID = dr.GetInt32(3);
                    ListOfProductByCategory.Add(objProduct);
                }
                connect.Close();
                return ListOfProductByCategory;
            }
            catch (Exception)
            {
                connect.Close();
                return null;
            }
        }

        // Get product's details
        public Product GetDetailProduct(int iProductID)
        {
            try
            {
                Product objProduct = new Product();
                connect = new Connection().Connect;
                connect.Open();
                Command = new SqlCommand("sp_GetDetailProductByProductID", connect);
                Command.CommandType = System.Data.CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@ProductID", iProductID);
                SqlDataReader dr = Command.ExecuteReader();
                while (dr.Read())
                {
                    objProduct.ProductID = dr.GetInt32(0);
                    objProduct.ProductName = dr.GetString(2);
                    objProduct.Output = dr.GetInt32(3);
                    objProduct.MadeGoodsSize = dr.GetDouble(4);
                    objProduct.MachineSize = dr.GetString(5);
                    objProduct.Weight = dr.GetDouble(6);
                    objProduct.Picture = dr.GetString(7);
                    objProduct.ExtraDescription = dr.GetString(8);
                    objProduct.FrequentlyViewed = dr.GetInt32(9);
                    objProduct.UnitPrice = dr.GetDecimal(10);
                }
                connect.Close();
                return objProduct;
            }
            catch (Exception)
            {
                connect.Close();
                return null;
            }
        }

        // Get FeedBack from guest and save
        public bool AddFeedBack(GuestFeedBack obj)
        {
            try
            {                
                connect = new Connection().Connect;
                connect.Open();
                Command = new SqlCommand("sp_Add2GuestFeedBack", connect);
                Command.CommandType = System.Data.CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@Email", obj.Email);
                Command.Parameters.AddWithValue("@FullName", obj.FullName);
                Command.Parameters.AddWithValue("@CompanyName", obj.CompanyName);
                Command.Parameters.AddWithValue("@Address", obj.Address);
                Command.Parameters.AddWithValue("@City", obj.City);
                Command.Parameters.AddWithValue("@Nation", obj.Nation);
                Command.Parameters.AddWithValue("@PhoneNumber", obj.PhoneNumber);
                Command.Parameters.AddWithValue("@PostalCode", obj.PostalCode);
                Command.Parameters.AddWithValue("@Subject", obj.Subject);
                Command.Parameters.AddWithValue("@Comment", obj.Comment);
                Command.ExecuteNonQuery();               
                connect.Close();
                return true;
            }
            catch (Exception)
            {
                connect.Close();
                return false;
            }
        }

        // Update FrequentlyViewedProduct after the product had been viewd 
        public void UpdateViewedProduct(int iProductID,int newViewedNumberProuduct)
        {
            try
            {
                connect = new Connection().Connect;
                connect.Open();
                Command = new SqlCommand("sp_UpdateViewedProduct", connect);
                Command.CommandType = System.Data.CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@ProductID",iProductID);
                Command.Parameters.AddWithValue("@FrequentlyViewed", newViewedNumberProuduct);                
                Command.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception)
            {
                connect.Close();
            }
        }

    }
}
