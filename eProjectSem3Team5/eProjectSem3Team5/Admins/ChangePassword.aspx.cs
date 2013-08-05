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
    public partial class ChangePassword : System.Web.UI.Page
    {
        Admin_BL admin_bl = new Admin_BL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                pnlalart.Visible = false;
                pnlUpdate.Visible = true;
                if (Session["Username"]!=null)
                {
                    lbl_Username.Text =  Session["Username"].ToString();
                }
            }
        }

        protected void lbtn_update_Click(object sender, EventArgs e)
        {
            lbl_catch.Text = "";
            if (txt_OldPass.Text.Trim() =="")
            {
                lbl_catch.Text += "Enter your old password \n";
            }
            if (!txt_Password.Text.Equals(txt_ConfirmPass.Text))
            {
                lbl_catch.Text += "New passsword and confirm password not mach \n";
            }
            try
            {
                DataTable dt = new DataTable();
                int adminid = int.Parse(Session["AdminId"].ToString());
                string username = Session["Username"].ToString().Trim();
                string oldpassword = txt_OldPass.Text.Trim();
                string newpassword = txt_Password.Text.Trim();
                // check oldpassword
                dt = admin_bl.AdminCheckLogin(username, oldpassword);
                if (dt.Rows.Count < 1)
                {
                    lbl_catch.Text += "Old password incorrect \n";                    
                }
                if (lbl_catch.Text =="")
                {
                    admin_bl.AdminChangePassowrd(adminid, oldpassword, newpassword);
                    pnlUpdate.Visible = false;
                    pnlalart.Visible = true;
                }             
            }
            catch (Exception ex)
            {
                WebMsgBox.Show(ex.Message);
                throw;
            }
        }

        protected void lbtn_Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admins/Default.aspx");
        }

    }
}