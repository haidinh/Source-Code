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
    public partial class UpdateProfile : System.Web.UI.Page
    {
        Admin_BL admin_bl = new Admin_BL();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                pnlalart.Visible = false;
                pnlUpdate.Visible = true;
                if (Session["Username"] != null)
                {
                    lbl_Username.Text = Session["Username"].ToString();
                }
            }
        }

        protected void lbtn_update_Click(object sender, EventArgs e)
        {
            lbl_catch.Text = "";
            if (txt_Email.Text.Equals(""))
            {
                lbl_catch.Text = "Enter your address email \n";
            }
            if (txt_Name.Text.Equals(""))
            {
                lbl_catch.Text = "Enter your full name \n";
            }
            if (txt_Pass.Text.Trim().Equals(""))
            {
                lbl_catch.Text = "Enter your password";
            }
            try
            {
                DataTable dt = new DataTable();
                int adminid = int.Parse(Session["AdminId"].ToString());
                string username = Session["Username"].ToString().Trim();
                string password = txt_Pass.Text.Trim();
                string fullname = txt_Name.Text;
                string email = txt_Email.Text;
                // check oldpassword
                dt = admin_bl.AdminCheckLogin(username, password);
                if (dt.Rows.Count < 1)
                {
                    lbl_catch.Text += "Password incorrect \n";                    
                }
                admin_bl.AdminUpdateProfile(adminid, email, fullname);
            }
            catch (Exception ex)
            {
                WebMsgBox.Show(ex.Message);
                throw;
            }
        }

        protected void lbtn_Back_Click(object sender, EventArgs e)
        {

        }
    }
}