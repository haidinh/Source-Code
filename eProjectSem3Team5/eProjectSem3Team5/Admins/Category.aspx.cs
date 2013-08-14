using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;
using MyWeb.Common;
using Entities;
using System.Data;
namespace eProjectSem3Team5.Admins
{
    public partial class Category : System.Web.UI.Page
    {
        Category_BL cate_bl = new Category_BL();
        private static bool check_insert = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindingGrid();
                BindingDdl();
                pnlUpdate.Visible = false;
            }
        }
        private void BindingDdl()
        {
            // list search
            ddl_Search.Items.Add("Category ID");
            ddl_Search.Items.Add("Category Name");
            // list sort
            ddl_Sort.Items.Add("Category ID");
            ddl_Sort.Items.Add("Category Name");
        }
        public void BindingGrid()
        {
            GridView1.DataSource = cate_bl.CategorySelectAll();
            GridView1.DataBind();
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

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string id = e.CommandArgument.ToString().Trim();
            if (e.CommandName == "edit")
            {
                check_insert = false;
                DataTable dt = cate_bl.CategorySelectById(int.Parse(id));
                lbl_CateId.Text = dt.Rows[0]["CategoryID"].ToString();
                txt_CateName.Text = dt.Rows[0]["CategoryName"].ToString();
                pnlShow.Visible = false;
                pnlUpdate.Visible = true;
            }
            else if (e.CommandName == "delete")
            {
                cate_bl.CategoryDelete(int.Parse(id));
                BindingGrid();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            pnlShow.Visible = false;
            pnlUpdate.Visible = true;
            ControlClass.ResetControlValues(pnlUpdate);
            check_insert = true;
        }

        protected void lbtn_update_Click(object sender, EventArgs e)
        {
            lbl_catch.Text = "";
            if (txt_CateName.Text.Equals(""))
            {
                lbl_catch.Text += "Enter Category name";
            }
            if (lbl_catch.Text.Equals(""))
            {
                Entities.Category cate = new Entities.Category();
                cate.CategoryID = int.Parse(lbl_CateId.Text.Trim());
                cate.CategoryName = txt_CateName.Text;
                cate_bl.CategoryUpdate(cate);
                if (check_insert)
                {
                    cate_bl.CategoryUpdate(cate);
                }
                else
                {
                    cate_bl.CategoryInsert(cate);
                }
                pnlShow.Visible = true;
                pnlUpdate.Visible = false;
            }
        }

        protected void lbtn_Back_Click(object sender, EventArgs e)
        {
            pnlShow.Visible = true;
            pnlUpdate.Visible = false;
        }

        protected void lbtn_Search_Click(object sender, EventArgs e)
        {
            int n = 0;
            string txtvalue = txt_Search.Text;
            string ddlvalue = ddl_Search.SelectedValue;
            if (ddlvalue == "Category ID")
            {
                if (!int.TryParse(txt_Search.Text, out n))
                {
                    WebMsgBox.Show("Only integer type. ");
                }
                else
                {
                    int id = int.Parse(txt_Search.Text.Trim());
                    GridView1.DataSource = cate_bl.CategorySelectById(id);
                    GridView1.DataBind();
                }
            }
            else if (ddlvalue == "Category Name" )
            {
                
            }
        }

        protected void lbtn_Refresh_Click(object sender, EventArgs e)
        {
            pnlShow.Visible = true;
            pnlUpdate.Visible = false;
            BindingGrid();
        }
    }
}