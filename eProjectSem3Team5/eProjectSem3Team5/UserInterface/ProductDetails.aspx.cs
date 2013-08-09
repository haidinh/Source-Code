using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Entities;
using BL;
using System.Data;
namespace eProjectSem3Team5.UserInterface
{
    public partial class ProductDetails : System.Web.UI.Page
    {
        BLUserInterfaceProcess blUserInterfaceProcess;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int iProductID = Convert.ToInt32(Request.QueryString["ProductID"]);
                if (blUserInterfaceProcess == null)
                {
                    blUserInterfaceProcess = new BLUserInterfaceProcess();
                }
                Product objProduct = blUserInterfaceProcess.GetDetailProduct(iProductID);
                DataTable dtDetailProduct = new DataTable();
                dtDetailProduct.Columns.Add("Properties");
                dtDetailProduct.Columns.Add("Value");
                dtDetailProduct.Rows.Add("Name", objProduct.ProductName);
                dtDetailProduct.Rows.Add("Output", objProduct.Output +" products/h");
                dtDetailProduct.Rows.Add("Made Goods Size", objProduct.MadeGoodsSize+" mm");
                dtDetailProduct.Rows.Add("Machine Size", objProduct.MachineSize + " mm");
                dtDetailProduct.Rows.Add("Weight", objProduct.Weight +" kg");
                dtDetailProduct.Rows.Add("Viewed", objProduct.FrequentlyViewed);
                string sExtraDescription = objProduct.ExtraDescription;
                string[] sDescriptions = sExtraDescription.Split(',');     
                for(int i=0;i<sDescriptions.Length;i++)
                {
                    string[] sSplitMedium = sDescriptions[i].Split(':');
                    dtDetailProduct.Rows.Add(sSplitMedium[0], sSplitMedium[1]);
                }
                // Display product details 
                title.InnerText = objProduct.ProductName;
                divDetailPrice.InnerHtml = Math.Round(objProduct.UnitPrice, 1).ToString();
                imgProduct.ImageUrl ="~/"+ objProduct.Picture;
                divDetailPrice.InnerText = objProduct.UnitPrice.ToString();
                gvDetailProduct.DataSource = dtDetailProduct;
                gvDetailProduct.DataBind();

            }
        }
    }
}