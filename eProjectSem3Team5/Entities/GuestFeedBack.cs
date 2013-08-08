using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class GuestFeedBack
    {
        public int FeedBackID { set; get; }
        public string Email { set; get; }
        public string FullName { set; get; }        
        public string CompanyName { set; get; }
        public string Address { set; get; }
        public string City { set; get; }
        public string Nation { set; get; }
        public string PhoneNumber { set; get; }
        public string PostalCode { set; get; }
        public string Subject { set; get; }
        public string Comment { set; get; }
    }
}
