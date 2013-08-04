using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product
    {
        public int ProductID{get;set;}
        public int CategoryID{get;set;}
        public string ProductName{get;set;}
        public int Output{get;set;}
        public double MadeGoodsSize{get;set;}
        public string MachineSize{get;set;}
        public double Weight{get;set;}
        public string Picture{get;set;}
        public string ExtraDescription{get;set;}
        public decimal UnitPrice{get;set;}
        public int FrequentlyViewed{get;set;}
    }   
}
