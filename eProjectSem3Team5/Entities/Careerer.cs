using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Careerer
    {
        public int CareererID { set; get; }
        public string EmailAddress { set; get; }
        public string Password { set; get; }
        public string UserName { set; get; }
        public string FullName { set; get; }        
        public int Age { set; get; }
        public bool Gender { set; get; }
        public string Address { set; get; }
        public string City { set; get; }
        public string Nation { set; get; }
        public string CV { set; get; }
        public string Education { set; get; }
    }
}
