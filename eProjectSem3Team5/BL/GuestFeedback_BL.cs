using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DL;
using Entities;
namespace BL
{
    public class GuestFeedback_BL
    {
        GuestFeedback_DL feedback_dl = new GuestFeedback_DL();
        #region GuestFeedBackSelectAll
        public DataTable GuestFeedBackSelectAll()
        {
            return feedback_dl.GuestFeedBackSelectAll();
        }
        #endregion

        #region GuestFeedBackSelectByEmail
        public DataTable GuestFeedBackSelectByEmail(string email)
        {
            return feedback_dl.GuestFeedBackSelectByEmail(email);
        }
        #endregion

        #region GuestFeedBackSelectById
        public DataTable GuestFeedBackSelectById(int id)
        {
            return feedback_dl.GuestFeedBackSelectById(id);
        }
        #endregion
    }
}
