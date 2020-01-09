using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class RequestForReview
    {
        public int Id { get; set; }
        public string RequestSender { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ExceptionDate { get; set; }
        public int StartHour { get; set; }
        public string RequestType { get; set; }
    }
}
