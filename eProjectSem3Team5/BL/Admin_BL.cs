using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DL;
using Entities;
namespace BL
{
    public class Admin_BL
    {
        Admin_DL admin_dl = new Admin_DL();
        #region AdminSelectAll
        public DataTable AdminSelectAll()
        {
            return admin_dl.AdminSelectAll();
        }
        #endregion 

        #region AdminSelectById
        public DataTable AdminSelectById()
        {
            return admin_dl.AdminSelectById();
        }
        #endregion 

        #region AdminInsert
        public void AdminInsert(Admin admin)
        {
            admin_dl.AdminInsert(admin);
        }
        #endregion 

        #region AdminCheckLogin
        public DataTable AdminCheckLogin(string username, string password)
        {
            return admin_dl.AdminCheckLogin(username, password);
        }
        #endregion

        #region AdminChangePassowrd
        public void AdminChangePassowrd(int adminid, string password, string newpassword)
        {
            admin_dl.AdminChangePassowrd(adminid, password, newpassword);
        }
        #endregion

        #region AdminUpdateProfile
        public void AdminUpdateProfile(int adminid, string email, string name)
        {
            admin_dl.AdminUpdateProfile(adminid, email, name);
        }
        #endregion 
    }
}
