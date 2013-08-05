using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eProjectSem3Team5.Admins
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"]!=null) 
            {                
                lbthoten.Text = "Xin chào : " + Session["Username"] + " - Administrator";            
            }
            else
            {
                Response.Redirect("~/Admins/Login.aspx");
            }
        }

        protected void Linkbutton_Click(object sender, EventArgs e)
        {
            LinkButton lbt = (LinkButton)sender;
            Response.Redirect("~/Admins/" + lbt.ID.Trim() + ".aspx");
        }

        protected void lbtthoat_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/Admins/Login.aspx");
        }
    }
}