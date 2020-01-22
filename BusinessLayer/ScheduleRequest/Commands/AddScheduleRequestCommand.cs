using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.ScheduleRequest.Commands
{
    public class AddScheduleRequestCommand
    {
        public int RequestId { get; set; }
        public Boolean? Accepted { get; set; }
        public string DeniedReason { get; set; }
        public int StartHour { get; set; }
        public int EndHour { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ExceptionDate { get; set; }
        public string RequestType { get; set; }
    }
}
