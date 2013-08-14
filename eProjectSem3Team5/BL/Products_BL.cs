using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DL;
using System.Data;
namespace BL
{
    public class Products_BL
    {
        Products_DL products_dl = new Products_DL();
        #region ProductSelectAll
        public DataTable ProductSelectAll()
        {
            return products_dl.ProductSelectAll();
        }
        #endregion

        #region ProductSelectByID
        public DataTable ProductSelectByID(int id)
        {
            return products_dl.ProductSelectByID(id);
        }
        #endregion

        #region ProductSelectByCategory
        public DataTable ProductSelectByCategory(int id)
        {
            return products_dl.ProductSelectByCategory(id);
        }
        #endregion

        #region ProductInsert
        public void ProductInsert(Product pro)
        {
            products_dl.ProductInsert(pro);
        }
        #endregion

        #region ProductDelete
        public void ProductDelete(int id)
        {
            products_dl.ProductDelete(id);
        }
        #endregion

        #region ProductUpdate
        public void ProductUpdate(Product pro)
        {
            products_dl.ProductUpdate(pro);
        }
        #endregion 
    }
}
