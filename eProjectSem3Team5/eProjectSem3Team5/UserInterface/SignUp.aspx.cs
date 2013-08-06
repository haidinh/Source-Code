using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using BL;
using Entities;

namespace eProjectSem3Team5.UserInterface
{
    public partial class SignUp : System.Web.UI.Page
    {
        BLUserInterfaceProcess blUserInterfaceProcess;
        protected void Page_Load(object sender, EventArgs e)
        {
            btnSignUp.ServerClick += btnSignUp_ServerClick;
            if (!IsPostBack)
            {
                HtmlGenericControl divRightContent = (HtmlGenericControl)Master.FindControl("divRightContent");
                divRightContent.Visible = false;
            }
        }

        void btnSignUp_ServerClick(object sender, EventArgs e)
        {
            string sEmail = txtEmail.Value.Trim();
            string sPassword = txtPassword.Value.Trim();
            string sUserName = txtName.Value.Trim();
            if (blUserInterfaceProcess == null)
            {
                blUserInterfaceProcess = new BLUserInterfaceProcess();
            }
            bool bSignUpSuccess =  blUserInterfaceProcess.SignUp(sEmail,sPassword,sUserName);
            if (bSignUpSuccess)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "name", "javascriptfunction();", true);
                Response.Redirect("Index.aspx");
            }
            else
            {
                lblSignUpError.Visible = true;
            }


        }
    }
}