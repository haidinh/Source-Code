﻿using System;
using BL;
using MyWeb.Common;
using System.Data;
namespace eProjectSem3Team5.Admins
{
    public partial class Login : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
        }
        Admin_BL admin_bl = new Admin_BL();
        protected void btnLogon_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = admin_bl.AdminCheckLogin(txtUsername.Text.Trim(), txtPassword.Text.Trim());
                if (dt.Rows.Count == 1)
                {
                    Session["Username"] = txtUsername.Text.Trim();
                    Session["AdminId"] = dt.Rows[0]["AdminID"].ToString().Trim();
                    Response.Redirect("~/Admins/Default.aspx");
                }
                else
                {
                    WebMsgBox.Show("Username or password incorrect, try again.");
                }
            }
            catch (Exception ex)
            {
                WebMsgBox.Show(ex.Message);
                throw;
            }
        }
        protected void btnHuyBo_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Home.aspx");
        }
    }
}