using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Entities;
using BL;


namespace eProjectSem3Team5.UserInterface
{
    public partial class ShowProductByCategory : System.Web.UI.Page
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
                int iCategoryID = Convert.ToInt32(Request.QueryString["CategoryID"]);
                string sCategoryName = Request.QueryString["CategoryName"];
                divCenterContent.InnerHtml += "<div class='center_title_bar'>" + sCategoryName + "</div>";
                List<Product> listOfProduct = blUserInterfaceProcess.GetProductByCategory(iCategoryID);
                foreach (Product obj in listOfProduct)
                {
                    divCenterContent.InnerHtml += "<div class='prod_box'>" +
                                                   "<div class='center_prod_box'>" +
                                                       "<div class='product_title'><a href='ProductDetails.aspx?ProductID=" + obj.ProductID + "'>" + obj.ProductName + "</a></div>" +
                                                       "<div class='product_img'><a href='ProductDetails.aspx?ProductID=" + obj.ProductID + "'><img src='../" + obj.Picture + "' alt='' width='91' height='71' /></a></div>" +
                                                       "<div class='prod_price'><span class='price'>" + Math.Round(obj.UnitPrice, 1) + " $</span></div>" +
                                                   "</div>" +
                                                   "<div class='prod_details_tab'> <a href='ProductDetails.aspx?ProductID=" + obj.ProductID + "' class='prod_details'>Details</a> </div>" +
                                                   "</div>";
                }
            }
        }
    }
}