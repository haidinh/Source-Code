using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;
using Entities;

namespace eProjectSem3Team5.UserInterface
{
    public partial class Login : System.Web.UI.Page
    {
        BLUserInterfaceProcess blUserInterfaceProcess;
        protected void Page_Load(object sender, EventArgs e)
        {
            btnLogin.ServerClick += btnLogin_ServerClick;
        }

        void btnLogin_ServerClick(object sender, EventArgs e)
        {
            string sEmail = txtEmail.Value.Trim();
            string sPassword = txtPassword.Value.Trim();
            if (blUserInterfaceProcess == null)
            {
                blUserInterfaceProcess = new BLUserInterfaceProcess();
            }
            Careerer objCareerer = blUserInterfaceProcess.Login(sEmail, sPassword);
            if (objCareerer != null)
            {
                lblError.Visible = false;
                Session["userName"] = objCareerer.EmailAddress;
                Session["CareererID"] = objCareerer.CareererID;
                Response.Redirect("Index.aspx");
            }
            else
            {
                lblError.Visible = true;
            }


        }
    }
}