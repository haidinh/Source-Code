using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testlayout
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] != null)
            {
                lbl_username.Text = Session["Username"] + " - Administrator";
            }
            else
            {
                Response.Redirect("~/Admins/Login.aspx");
            }
        }

        protected void lbtn_logout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/Admins/Login.aspx");
        }

        protected void lbtn_Changepassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admins/WebForm1.aspx");
        }
    }
}