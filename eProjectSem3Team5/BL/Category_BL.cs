using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data;
using DL;
namespace BL
{
    public class Category_BL
    {
        Category_DL category_dl = new Category_DL();
        #region CategorySelectAll
        public DataTable CategorySelectAll()
        {
            return category_dl.CategorySelectAll();
        }
        #endregion 

        #region CategorySelectById
        public DataTable CategorySelectById(int id)
        {
            return category_dl.CategorySelectById(id);
        }
        #endregion 

        #region CategoryInsert
        public void CategoryInsert(Category cate)
        {
            category_dl.CategoryInsert(cate);
        }
        #endregion 

        #region CategoryDelete
        public void CategoryDelete(int id)
        {
            category_dl.CategoryDelete(id);
        }
        #endregion 

        #region CategoryUpdate
        public void CategoryUpdate(Category cate)
        {
            category_dl.CategoryUpdate(cate);
        }
        #endregion 
    }
}
