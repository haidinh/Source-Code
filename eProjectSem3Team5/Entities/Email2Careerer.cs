using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Email2Careerer
    {
        public int Email2CareererID { set; get; }
        public int AdminID { set; get; }
        public int CareererID { set; get; }
        public string Title { set; get; }
        public string Content { set; get; }
        public DateTime SentDate { set; get; }
    }
}
