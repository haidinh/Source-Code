using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;
using Entities;

namespace eProjectSem3Team5.UserInterface
{
    public partial class Index : System.Web.UI.Page
    {
        BLUserInterfaceProcess blUserInterfaceProcess;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (blUserInterfaceProcess == null)
            {
                blUserInterfaceProcess = new BLUserInterfaceProcess();
            }
            if (!IsPostBack)
            {
                divCenterContent.InnerHtml += "<div class='center_title_bar'>Latest Products</div>";
                List<Product> listOfProduct = blUserInterfaceProcess.GetProductByAddedDate();
                foreach (Product obj in listOfProduct)
                {
                    divCenterContent.InnerHtml += "<div class='prod_box'>" +
                                                    "<div class='center_prod_box'>" +
                                                        "<div class='product_title'><a href='ProductDetails.aspx?ProductID=" + obj.ProductID + "'>" + obj.ProductName + "</a></div>" +
                                                        "<div class='product_img'><a href='ProductDetails.aspx?ProductID=" + obj.ProductID + "'><img src='../"+obj.Picture+"' alt='' border='0' /></a></div>" +
                                                        "<div class='prod_price'><span class='price'>" + obj.UnitPrice + "</span></div>" +
                                                    "</div>" +
                                                    "<div class='prod_details_tab'> <a href='ProductDetails.aspx?ProductID=" + obj.ProductID + "' class='prod_details'>Details</a> </div>" +
                                                    "</div>";
                }
                divCenterContent.InnerHtml += "<div class='center_title_bar'> Recommended Product </div>";
                List<Product> listOfProductByMostFrequentlyViewed = blUserInterfaceProcess.GetProductByMostFrequentlyViewed();
                foreach (Product obj in listOfProductByMostFrequentlyViewed)
                {
                    divCenterContent.InnerHtml += "<div class='prod_box'>" +
                                                   "<div class='center_prod_box'>" +
                                                       "<div class='product_title'><a href='ProductDetails.aspx?ProductID=" + obj.ProductID + "'>" + obj.ProductName + "</a></div>" +
                                                       "<div class='product_img'><a href='ProductDetails.aspx?ProductID=" + obj.ProductID + "'><img src='../" + obj.Picture + "' alt='' border='0' /></a></div>" +
                                                       "<div class='prod_price'><span class='price'>" + obj.UnitPrice + "</span></div>" +
                                                   "</div>" +
                                                   "<div class='prod_details_tab'> <a href='ProductDetails.aspx?ProductID=" + obj.ProductID + "' class='prod_details'>Details</a> </div>" +
                                                   "</div>";
                }
            }
        }
    }
}