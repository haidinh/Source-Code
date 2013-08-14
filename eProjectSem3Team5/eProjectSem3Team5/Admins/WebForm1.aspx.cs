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
    public partial class WebForm1 : System.Web.UI.Page
    {
        Admin_BL admin_bl = new Admin_BL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                pnlShow.Visible = true;
                pnlUpdate.Visible = false;
                pnlChangePass.Visible = false;
                if (Session["Username"] != null)
                {
                    lbl_Username.Text = Session["Username"].ToString();
                    lbl_UsernamePass.Text = Session["Username"].ToString();
                    lbl_UsernamePro.Text = Session["Username"].ToString();
                }
                int adminid = int.Parse(Session["AdminId"].ToString());
                DataTable dt = new DataTable();
                dt = admin_bl.AdminSelectById(adminid);
                lbl_Name.Text = dt.Rows[0]["Name"].ToString();
                lbl_Email.Text = dt.Rows[0]["Email"].ToString();
                txt_Email.Text = dt.Rows[0]["Email"].ToString();
                txt_Name.Text = dt.Rows[0]["Name"].ToString();               
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
                if (lbl_catch.Text=="")
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
                    lbl_catch.Text = "Update profile success";
                }
                
            }
            catch (Exception ex)
            {
                WebMsgBox.Show(ex.Message);
                throw;
            }
        }

        protected void lbtn_change_Click(object sender, EventArgs e)
        {
            lbl_catchPass.Text = "";
            if (txt_OldPass.Text.Trim() == "")
            {
                lbl_catchPass.Text += "Enter your old password \n";
            }
            if (!txt_Password.Text.Equals(txt_ConfirmPass.Text))
            {
                lbl_catchPass.Text += "New passsword and confirm password not mach \n";
            }
            try
            {
                if (lbl_catchPass.Text=="")
                {
                    int adminid = int.Parse(Session["AdminId"].ToString());
                    string username = Session["Username"].ToString().Trim();
                    string oldpassword = txt_OldPass.Text.Trim();
                    string newpassword = txt_Password.Text.Trim();
                    // check oldpassword
                    DataTable dt = new DataTable();
                    dt = admin_bl.AdminCheckLogin(username, oldpassword);
                    if (dt.Rows.Count < 1)
                    {
                        lbl_catchPass.Text += "Old password incorrect \n";
                    }
                    if (lbl_catchPass.Text == "")
                    {
                        admin_bl.AdminChangePassowrd(adminid, oldpassword, newpassword);
                        pnlUpdate.Visible = false;
                        lbl_catchPass.Text = "Change password success";
                    }
                }
               
              
            }
            catch (Exception ex)
            {
                WebMsgBox.Show(ex.Message);
                throw;
            }
        }

        protected void lbtn_view_Click(object sender, EventArgs e)
        {
            pnlShow.Visible = true;
            pnlUpdate.Visible = false;
            pnlChangePass.Visible = false;
        }

        protected void lbtn_changepassword_Click(object sender, EventArgs e)
        {
            pnlShow.Visible = false;
            pnlUpdate.Visible = false;
            pnlChangePass.Visible = true;
        }

        protected void lbtn_updateprofile_Click(object sender, EventArgs e)
        {
            pnlShow.Visible = false;
            pnlUpdate.Visible = true;
            pnlChangePass.Visible = false;
        }
    }
}