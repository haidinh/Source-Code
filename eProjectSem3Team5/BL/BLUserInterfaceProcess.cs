using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DL;

namespace BL
{
    public class BLUserInterfaceProcess
    {
        DLUserInterfaceProcess dlUserInterfaceProcess;
        public List<Category> GetAllCategory()
        {
            if (dlUserInterfaceProcess == null)
            {
                dlUserInterfaceProcess = new DLUserInterfaceProcess();
            }
            return dlUserInterfaceProcess.GetCategory();
        }
        public List<Product> GetProductByAddedDate()
        {
            if (dlUserInterfaceProcess == null)
            {
                dlUserInterfaceProcess = new DLUserInterfaceProcess();
            }
            return dlUserInterfaceProcess.GetProductByAddedDate();
        }
        public List<Product> GetProductByMostFrequentlyViewed()
        {
            if (dlUserInterfaceProcess == null)
            {
                dlUserInterfaceProcess = new DLUserInterfaceProcess();
            }
            return dlUserInterfaceProcess.GetProductByMostFrequentlyViewed();
        }

    }


}
