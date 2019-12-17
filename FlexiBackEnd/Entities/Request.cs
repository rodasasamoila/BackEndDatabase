using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlexiBackEnd
{
    public class Request
    {
        public int requestId { get; set; }
        public Boolean accepted { get; set; }
        public string deniedReason { get; set; }
        public int startHour { get; set; }
        public int endHour { get; set; }
        public DateTime creationDate { get; set; }
        public DateTime exceptionDate{get;set ;}
        public string requestType { get; set; }
      
        
    }
}
