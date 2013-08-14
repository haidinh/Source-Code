using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;
using Entities;
using System.Data;
namespace BL
{
    public class Careerer_BL
    {
        Careerer_DL user = new Careerer_DL();
        #region CareererSelectAll
        public DataTable CareererSelectAll()
        {
            return user.CareererSelectAll();
        }
        #endregion

        #region CareererSelectAll
        public DataTable CareererSelectById(int id)
        {
            return user.CareererSelectById(id);
        }
        #endregion
    }
}
