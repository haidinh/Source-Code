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
    public class Admin_DL: SqlDataProvider
    {
        #region AdminSelectAll
        public DataTable AdminSelectAll()
        {
            DataTable dt = new DataTable();
            using (SqlCommand command = new SqlCommand("sp_AdminSelectAll", GetConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                return dt;
            }         
        }
        #endregion 

        #region AdminSelectById
        public DataTable AdminSelectById(int id)
        {
            DataTable dt = new DataTable();
            using (SqlCommand command = new SqlCommand("sp_AdminSelectById", GetConnection()))
            {
                command.Parameters.AddWithValue("@AdminID",id);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                return dt; ;
            }
        }
        #endregion

        #region AdminInsert
        public void AdminInsert(Admin admin)
        {
            using (SqlCommand command = new SqlCommand("sp_AdminInsert",GetConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Username",admin.UserName));
                command.Parameters.Add(new SqlParameter("@Password", admin.PassWord));
                command.Parameters.Add(new SqlParameter("@Email", admin.Email));
                command.Parameters.Add(new SqlParameter("@Name", admin.Name));
                command.ExecuteNonQuery();
            }
        }
        #endregion

        #region AdminCheckLogin
        public DataTable AdminCheckLogin(string username, string password)
        {
          
            DataTable dt = new DataTable();
            using (SqlCommand command = new SqlCommand("sp_AdminCheckLogin",GetConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Username", username));
                command.Parameters.Add(new SqlParameter("@Password", password));
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
            }
            return dt;
        }
        #endregion

        #region AdminChangePassowrd
        public void AdminChangePassowrd(int adminid,string password,string newpassword)
        {
            using (SqlCommand command = new SqlCommand("sp_AdminChangePassword",GetConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@AdminID", adminid));
                command.Parameters.Add(new SqlParameter("@Password", password));
                command.Parameters.Add(new SqlParameter("@NewPassword", newpassword));
                command.ExecuteNonQuery();
            }
        }
        #endregion

        #region AdminUpdateProfile
        public void AdminUpdateProfile(int adminid,string email,string name)
        {
            using (SqlCommand command = new SqlCommand("sp_AdminUpdateProfile", GetConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@AdminID", adminid));
                command.Parameters.Add(new SqlParameter("@Email", email));
                command.Parameters.Add(new SqlParameter("@Name", name));
                command.ExecuteNonQuery();
            }
        }
        #endregion 
    }
}
