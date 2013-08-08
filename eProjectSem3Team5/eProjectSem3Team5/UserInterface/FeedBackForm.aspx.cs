using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eProjectSem3Team5.UserInterface
{
    public partial class FeedBackForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnSubmit.ServerClick += btnSubmit_ServerClick;
        }

        void btnSubmit_ServerClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}