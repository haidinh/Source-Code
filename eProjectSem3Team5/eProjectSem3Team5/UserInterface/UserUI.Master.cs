using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities;
using BL;

namespace eProjectSem3Team5.UserInterface
{
    public partial class User : System.Web.UI.MasterPage
    {
        BLUserInterfaceProcess blUserInterfaceProcess;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (blUserInterfaceProcess == null)
                {
                    blUserInterfaceProcess = new BLUserInterfaceProcess();
                }
                List<Category> ListOfCategory = blUserInterfaceProcess.GetAllCategory();
                int i = 0;
                foreach (Category obj in ListOfCategory)
                {
                    int iCategoryID = obj.CategoryID;
                    string sCategoryName = obj.CategoryName;
                    if (i % 2 == 0)
                    {
                        //ulCategory.InnerHtml = "<li class='even'><a href='#'>"++"</a></li>"; 
                        ulCategory.InnerHtml += "<li class='even'><a href='ShowProductByCategory.aspx?CategoryID=" + iCategoryID + "&CategoryName=" + sCategoryName + "'>" + sCategoryName + "</a></li>";
                        i++;
                    }
                    else
                    {
                        ulCategory.InnerHtml += "<li class='odd'><a href='ShowProductByCategory.aspx?CategoryID=" + iCategoryID + "&CategoryName=" + sCategoryName + "'>" + sCategoryName + "</a></li>";
                        i++;
                    }
                }

            }
        }
    }
}