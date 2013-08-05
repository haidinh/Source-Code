using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;
using Entities;
using System.Web.UI.HtmlControls;

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
                // Find controls in master page
                //int sLogin = Convert.ToInt32( Request.QueryString["PageLogin"]);
                //if (sLogin==1)
                //{
                //    HtmlAnchor aLogin = (HtmlAnchor)Master.FindControl("aLogin");
                //    HtmlAnchor aSignUp = (HtmlAnchor)Master.FindControl("aSignUp");
                //    HtmlGenericControl divLogin = (HtmlGenericControl)Master.FindControl("divLogin");
                    
                //    aLogin.Visible = false;
                //    aSignUp.Visible = false;
                //    Label lblUserName = new Label();
                //    lblUserName.Text = "aaa";
                //    divLogin.Controls.Add(lblUserName);
                //    divLogin.InnerHtml = "<a href='Login.aspx' class='login'>Log out</a>";
                //}

                // Load products from database to my page
                divCenterContent.InnerHtml += "<div class='center_title_bar'>Latest Products</div>";
                List<Product> listOfProduct = blUserInterfaceProcess.GetProductByAddedDate();
                foreach (Product obj in listOfProduct)
                {
                    divCenterContent.InnerHtml += "<div class='prod_box'>" +
                                                    "<div class='center_prod_box'>" +
                                                        "<div class='product_title'><a href='ProductDetails.aspx?ProductID=" + obj.ProductID + "'>" + obj.ProductName + "</a></div>" +
                                                        "<div class='product_img'><a href='ProductDetails.aspx?ProductID=" + obj.ProductID + "'><img src='../"+obj.Picture+"' alt='' width='91' height='71' /></a></div>" +
                                                        "<div class='prod_price'><span class='price'>" +Math.Round( obj.UnitPrice,1) + " $</span></div>" +
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
                                                       "<div class='product_img'><a href='ProductDetails.aspx?ProductID=" + obj.ProductID + "'><img src='../" + obj.Picture + "' alt='' width='91' height='71' /></a></div>" +
                                                       "<div class='prod_price'><span class='price'>" + Math.Round( obj.UnitPrice,1) + " $</span></div>" +
                                                   "</div>" +
                                                   "<div class='prod_details_tab'> <a href='ProductDetails.aspx?ProductID=" + obj.ProductID + "' class='prod_details'>Details</a> </div>" +
                                                   "</div>";
                }
            }
        }
    }
}