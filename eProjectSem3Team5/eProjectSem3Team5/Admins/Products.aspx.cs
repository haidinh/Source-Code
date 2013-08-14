using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;
using Entities;
using System.Data;
using MyWeb.Common;
using System.IO;
namespace eProjectSem3Team5.Admins
{
    public partial class Products : System.Web.UI.Page
    {
        Products_BL products_bl = new Products_BL();
        Category_BL cate_bl = new Category_BL();
        private static bool check_insert = false;
        private static string imageurl = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindingGrid();
                BindingDDL();
                pnlShow.Visible = true;
                pnlUpdate.Visible = false;
            }
        }
        private void BindingGrid()
        {
            GridView1.DataSource = products_bl.ProductSelectAll();
            GridView1.DataBind();
            foreach (GridViewRow gv in GridView1.Rows)
            {
                int id = int.Parse(gv.Cells[1].Text);
                DataTable dt = new DataTable();
                dt = cate_bl.CategorySelectById(id);
                gv.Cells[1].Text = dt.Rows[0]["CategoryName"].ToString();
            }
        }
        private void BindingDDL()
        {
            DataTable dt = new DataTable();
            dt = cate_bl.CategorySelectAll();
            ddl_Category.DataSource = dt;
            ddl_Category.DataValueField = "CategoryID";
            ddl_Category.DataTextField = "CategoryName";
            ddl_Category.DataBind();
            ddl_search.DataSource = dt;
            ddl_search.DataValueField = "CategoryID";
            ddl_search.DataTextField = "CategoryName";
            ddl_search.DataBind();
        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            // set value 
            pnlShow.Visible = false;
            pnlUpdate.Visible = true;
            txt_ExtraDescription.Text = "";
            txt_MachineSize.Text = "";
            txt_MadeGoods.Text = "";
            txt_Output.Text = "";
            txt_ProductName.Text = "";
            txt_UnitPrice.Text = "";
            txt_Weight.Text = "";
            lbl_FrequentlyViewed.Text = "0";
            lbl_AddedDate.Text = DateTime.Now.ToString();
            imageurl = "";
            check_insert = true;
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            if (e.CommandName == "edit")
            {
                check_insert = false;
                DataTable dt = new DataTable();
                dt = products_bl.ProductSelectByID(id);
                lbl_ProductId.Text = dt.Rows[0]["ProductID"].ToString();
                txt_ProductName.Text = dt.Rows[0]["ProductName"].ToString();
                ddl_Category.SelectedValue = dt.Rows[0]["CategoryID"].ToString();
                txt_Output.Text = dt.Rows[0]["Output"].ToString();
                txt_MachineSize.Text = dt.Rows[0]["MachineSize"].ToString();
                txt_Weight.Text = dt.Rows[0]["Weight"].ToString();
                txt_MadeGoods.Text = dt.Rows[0]["MadeGoodsSize"].ToString();
                lbl_AddedDate.Text = dt.Rows[0]["AddedDate"].ToString();
                img_upload.ImageUrl = "~/" + dt.Rows[0]["Picture"].ToString();
                lbl_FrequentlyViewed.Text = dt.Rows[0]["FrequentlyViewed"].ToString();
                txt_ExtraDescription.Text = dt.Rows[0]["ExtraDescription"].ToString();
                txt_UnitPrice.Text = dt.Rows[0]["UnitPrice"].ToString();
                pnlShow.Visible = false;
                pnlUpdate.Visible = true;
            }
            else if (e.CommandName == "delete")
            {
                products_bl.ProductDelete(id);
                BindingGrid();
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            e.Cancel = true;
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            e.Cancel = true;
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            BindingGrid();
        }

        protected void lbtn_Back_Click(object sender, EventArgs e)
        {
            pnlShow.Visible = true;
            pnlUpdate.Visible = false;
            lbl_catch.Text = "";
        }

        protected void lbtn_update_Click(object sender, EventArgs e)
        {
            lbl_catch.Text = "";
            int n = 0;
            float m = 0;
            // valid data
            if (txt_ProductName.Text.Equals(""))
            {
                lbl_catch.Text += "Enter product name \n";
            }
            if (img_upload.ImageUrl.Equals(""))
            {
                lbl_catch.Text += "Choose a picture \n";
            }
          
            if (!int.TryParse(txt_Output.Text, out n))
            {
                lbl_catch.Text += "Output has to numberic type \n";
            }
            if (!float.TryParse(txt_MadeGoods.Text, out m))
            {
                lbl_catch.Text += "MadeGoodsSize has to float type \n";
            }
            if (!float.TryParse(txt_Weight.Text, out m))
            {
                lbl_catch.Text += "Weight has to float type \n";
            }
            if (!float.TryParse(txt_UnitPrice.Text, out m))
            {
                lbl_catch.Text += "UnitPrice has to float type \n";
            }
            // pass valid
            if (lbl_catch.Text == "")
            {
                Entities.Product product = new Entities.Product();

                product.CategoryID = int.Parse(ddl_Category.SelectedValue.ToString());
                product.ProductName = txt_ProductName.Text;
                product.Output = int.Parse(txt_Output.Text);
                product.MadeGoodsSize = double.Parse(txt_MadeGoods.Text);
                product.MachineSize = txt_MachineSize.Text;
                product.Weight = double.Parse(txt_Weight.Text);
                product.Picture = imageurl;
                product.UnitPrice = decimal.Parse(txt_UnitPrice.Text);
                product.ExtraDescription = txt_ExtraDescription.Text;
                if (check_insert)
                {
                    products_bl.ProductInsert(product);
                }
                else
                {
                    product.ProductID = int.Parse(lbl_ProductId.Text.Trim());
                    products_bl.ProductUpdate(product);
                }
                BindingGrid();
                pnlShow.Visible = true;
                pnlUpdate.Visible = false;

            }
        }
        String path = HttpContext.Current.Request.PhysicalApplicationPath + "ImageStorage\\";
        protected void btnUpload_Click(object sender, EventArgs e)
        {
            Boolean FileOK = false;
            Boolean FileSaved = false;
            if (Upload.HasFile)
            {
                String FileExtension = Path.GetExtension(Upload.FileName.ToString()).ToLower();
                String[] allowedExtensions = { ".png", ".jpeg", ".jpg", ".gif" };
                for (int i = 0; i < allowedExtensions.Length; i++)
                {
                    if (FileExtension == allowedExtensions[i])
                    {
                        FileOK = true;
                    }
                }
            }
            if (FileOK)
            {
                try
                {
                    Upload.PostedFile.SaveAs(path + Upload.FileName);
                    img_upload.ImageUrl = "~/ImageStorage/" + Upload.FileName;
                    imageurl = "ImageStorage/" + Upload.FileName;
                    FileSaved = true;
                }
                catch (Exception)
                {
                    lbl_checkupload.Text = "Upload error";
                    lbl_checkupload.Visible = true;
                    FileSaved = false;
                    throw;
                }
            }
            else
            {
                lbl_checkupload.Text = "Files must have the form: .png, .jpeg, .jpg, .gif";
                lbl_checkupload.Visible = true;
            }
            if (FileSaved)
            {
                lbl_checkupload.Visible = true;
                lbl_checkupload.Text = " Upload success";
            }
        }

        protected void lbtn_Search_Click(object sender, EventArgs e)
        {
            int id = int.Parse(ddl_search.SelectedValue.ToString());
            GridView1.DataSource = products_bl.ProductSelectByCategory(id);
            GridView1.DataBind();
        }

        protected void lbtn_Refresh_Click(object sender, EventArgs e)
        {
            BindingGrid();
            pnlShow.Visible = true;
            pnlUpdate.Visible = false;
        }
    }
}