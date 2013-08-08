using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DL;

namespace BL
{
    public class BLUserInterfaceProcess
    {
        DLUserInterfaceProcess dlUserInterfaceProcess;

        public List<Category> GetAllCategory()
        {
            if (dlUserInterfaceProcess == null)
            {
                dlUserInterfaceProcess = new DLUserInterfaceProcess();
            }
            return dlUserInterfaceProcess.GetCategory();
        }

        public List<Product> GetProductByAddedDate()
        {
            if (dlUserInterfaceProcess == null)
            {
                dlUserInterfaceProcess = new DLUserInterfaceProcess();
            }
            return dlUserInterfaceProcess.GetProductByAddedDate();
        }

        // Get products that are most frequently viewed
        public List<Product> GetProductByMostFrequentlyViewed()
        {
            if (dlUserInterfaceProcess == null)
            {
                dlUserInterfaceProcess = new DLUserInterfaceProcess();
            }
            return dlUserInterfaceProcess.GetProductByMostFrequentlyViewed();
        }

        // Log in
        public Careerer Login(string sEmail, string sPassword)
        {
            if (dlUserInterfaceProcess == null)
            {
                dlUserInterfaceProcess = new DLUserInterfaceProcess();
            }
            return dlUserInterfaceProcess.Login(sEmail, sPassword);
        }

        // Sign up
        public bool SignUp(string sEmail, string sPassword, string sUserName)
        {
            if (dlUserInterfaceProcess == null)
            {
                dlUserInterfaceProcess = new DLUserInterfaceProcess();
            }
            return dlUserInterfaceProcess.SignUp(sEmail, sPassword, sUserName);
        }

        //Get products with certain category
        public List<Product> GetProductByCategory(int iCategoryID)
        {
            if (dlUserInterfaceProcess == null)
            {
                dlUserInterfaceProcess = new DLUserInterfaceProcess();
            }
            return dlUserInterfaceProcess.GetProductByCategory(iCategoryID);
        }

    }


}
