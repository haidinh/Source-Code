using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;
using System.Data;
namespace eProjectSem3Team5.Admins
{
    public partial class GuestFeedBack : System.Web.UI.Page
    {
        GuestFeedback_BL feedback_bl = new GuestFeedback_BL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BlindingData();
                BindingDdl();
                pnlShow.Visible = true;
                pnlUpdate.Visible = false;
            }
        }
        private void BlindingData()
        {
            GridView1.DataSource = feedback_bl.GuestFeedBackSelectAll();
            GridView1.DataBind();

        }
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            BlindingData();
        }
        private void BindingDdl()
        {
            // list search
            ddl_Search.Items.Add("Feedback ID");
            ddl_Search.Items.Add("Email Address");
            ddl_Search.Items.Add("Full Name");
            // list sort
            ddl_Sort.Items.Add("Feedback ID");
            ddl_Sort.Items.Add("Email Address");
            ddl_Sort.Items.Add("Full Name");
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string id = e.CommandArgument.ToString();
            if (e.CommandName == "view")
            {
                DataTable dt = new DataTable();
                dt = feedback_bl.GuestFeedBackSelectById(int.Parse(id));
                pnlShow.Visible = false;
                pnlUpdate.Visible = true;
                lbl_FeedBackId.Text = dt.Rows[0]["FeedBackID"].ToString();
                lbl_EmailAdress.Text = dt.Rows[0]["Email"].ToString();
                lbl_Fullname.Text = dt.Rows[0]["FullName"].ToString();
                lbl_CompanyName.Text = dt.Rows[0]["CompanyName"].ToString();
                lbl_Address.Text = dt.Rows[0]["Address"].ToString();
                lbl_City.Text = dt.Rows[0]["City"].ToString();
                lbl_Nation.Text = dt.Rows[0]["Nation"].ToString();
                lbl_PhoneNumber.Text = dt.Rows[0]["PhoneNumber"].ToString();
                lbl_PostalCode.Text = dt.Rows[0]["PostalCode"].ToString();
                lbl_Subject.Text = dt.Rows[0]["Subject"].ToString();
                txt_Comment.Text = dt.Rows[0]["Comment"].ToString();
            }
        }

        protected void lbtn_Back_Click(object sender, EventArgs e)
        {
            pnlShow.Visible = true;
            pnlUpdate.Visible = false;
        }

        protected void lbtn_Search_Click(object sender, EventArgs e)
        {

            string txtvalue = txt_Search.Text;
            string ddlvalue = ddl_Search.SelectedValue;
            if (ddlvalue == "Email Address")
            {
                GridView1.DataSource = feedback_bl.GuestFeedBackSelectByEmail(txtvalue);
                GridView1.DataBind();
            }
            else if (ddlvalue == "Feedback ID")
            {
                GridView1.DataSource = feedback_bl.GuestFeedBackSelectById(int.Parse(txtvalue));
                GridView1.DataBind();
            }
            else if (ddlvalue == "Full Name")
            {
               
            }
        }

        protected void lbtn_Refresh_Click(object sender, EventArgs e)
        {
            pnlShow.Visible = true;
            pnlUpdate.Visible = false;
            BlindingData();
        }
    }
}