using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;
using Entities;
using MyWeb.Common;
using System.Data;
namespace eProjectSem3Team5.Admins
{
    public partial class Careerer : System.Web.UI.Page
    {
        Careerer_BL user_bl = new Careerer_BL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BlindingData();
                BindingDdl();
                pnlShow.Visible = true;
                pnlView.Visible = false;
            }
        }
        private void BindingDdl()
        {
            // list search
            ddl_Search.Items.Add("CareererID");
            ddl_Search.Items.Add("Email Address");
            ddl_Search.Items.Add("Full Name");
            // list sort
            ddl_Sort.Items.Add("CareererID");
            ddl_Sort.Items.Add("Email Address");
            ddl_Sort.Items.Add("Full Name");
           
        }
        private void BlindingData()
        {
            GridView1.DataSource = user_bl.CareererSelectAll();
            GridView1.DataBind();
            foreach (GridViewRow gv in GridView1.Rows)
            {
                if (gv.Cells[5].Text.Trim() != "")
                {
                    gv.Cells[5].Text = "Yes";
                }
                else
                {
                    gv.Cells[5].Text = "No";
                }
                if (gv.Cells[4].Text.Trim() == "True")
                {
                    gv.Cells[4].Text = "Male";
                }

                else
                {
                    gv.Cells[4].Text = "Female";
                }
            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            BlindingData();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
               
            string id = e.CommandArgument.ToString();
            if (e.CommandName == "view")
            {
                DataTable dt = new DataTable();
                dt = user_bl.CareererSelectById(int.Parse(id));
                pnlShow.Visible = false;
                pnlView.Visible = true;
                lbl_CareererID.Text = dt.Rows[0]["CareererID"].ToString();
                lbl_EmailAdress.Text = dt.Rows[0]["EmailAddress"].ToString();
                lbl_Fullname.Text = dt.Rows[0]["FullName"].ToString();
                lbl_Age.Text = dt.Rows[0]["Age"].ToString();
                txt_Education.Text = dt.Rows[0]["Education"].ToString();
                if (dt.Rows[0]["Gender"].ToString() == "True")
                {
                    lbl_gender.Text = "Male";
                }
                else
                {
                    lbl_gender.Text = "Female";
                }
                lbl_Address.Text = dt.Rows[0]["Address"].ToString();
                lbl_City.Text = dt.Rows[0]["City"].ToString();
                lbl_Nation.Text = dt.Rows[0]["Nation"].ToString();
                if (dt.Rows[0]["CV"].ToString().Trim() == "")
                {
                    lbl_CV.Text = "No CV";
                }
                else
                {
                    lbl_CV.Text = dt.Rows[0]["CV"].ToString().Trim();
                }
            }
            else if (e.CommandName == "btndownload")
            {
                return;
               
            }
       
        }

        protected void lbtn_download_Click(object sender, EventArgs e)
        {

        }

        protected void lbtn_Back_Click(object sender, EventArgs e)
        {
            pnlShow.Visible = true;
            pnlView.Visible = false;
        }

        protected void lbtn_Refresh_Click(object sender, EventArgs e)
        {
            pnlShow.Visible = true;
            pnlView.Visible = false;
            BlindingData();
        }

        protected void btnS_Click(object sender, EventArgs e)
        {
            int n = 0;
            string txtvalue = txt_Search.Text;
            string ddlvalue = ddl_Search.SelectedValue;
            if (ddlvalue == "CareererID")
            {
                if (!int.TryParse(txt_Search.Text, out n))
                {
                    WebMsgBox.Show("Only integer type. ");
                }
                else
                {
                    int id = int.Parse(txt_Search.Text.Trim());
                    GridView1.DataSource = user_bl.CareererSelectById(id);
                    GridView1.DataBind();
                }
            }
            else if (ddlvalue == "Email Address")
            {

            }
            else if (ddlvalue == "Full Name")
            {

            }
        }

        }
    }
