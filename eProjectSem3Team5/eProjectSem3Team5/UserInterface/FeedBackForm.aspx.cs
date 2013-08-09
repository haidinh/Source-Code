using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using BL;
using Entities;

namespace eProjectSem3Team5.UserInterface
{
    public partial class FeedBackForm : System.Web.UI.Page
    {
        BLUserInterfaceProcess blUserInterfaceProcess;
        protected void Page_Load(object sender, EventArgs e)
        {
            btnSubmit.ServerClick += btnSubmit_ServerClick;
        }

        void btnSubmit_ServerClick(object sender, EventArgs e)
        {
            GuestFeedBack objGuestFeedBack = new GuestFeedBack();
            objGuestFeedBack.Email = txtEmail.Value.Trim();
            objGuestFeedBack.FullName = txtFullName.Value.Trim();
            objGuestFeedBack.CompanyName = txtCompanyName.Value.Trim();
            objGuestFeedBack.Address = txtAddress.Value.Trim();
            objGuestFeedBack.City = txtCity.Value.Trim();
            objGuestFeedBack.Nation = txtNation.Value.Trim();
            objGuestFeedBack.PhoneNumber = txtPhoneNumber.Value.Trim();
            objGuestFeedBack.PostalCode = txtPostalCode.Value.Trim();
            objGuestFeedBack.Subject = txtSubject.Value.Trim();
            objGuestFeedBack.Comment = txtAreaMessage.Value.Trim();
            if (blUserInterfaceProcess == null)
            {
                blUserInterfaceProcess = new BLUserInterfaceProcess();
            }
            bool bAddFeedBack =  blUserInterfaceProcess.AddFeedBack(objGuestFeedBack);
            if (bAddFeedBack)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "MyKey", "Notify('Your message has been sent!');", true);
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "MyKey", "Notify('Failed. Check your connection!');", true);
            }



        }
    }
}