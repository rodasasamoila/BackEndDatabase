

using BusinessLayer.ScheduleRequest.Abstract;
using System.Collections.Generic;

namespace BusinessLayer.ScheduleRequest
{
    public class SupervisorQueryHandler : ISupervisorListQueryHandler
    {
        public List<int> Handle(CurrentUserId currentUserId)
        {
            List<int> supervisorList = new List<int>();
            supervisorList.Add(2);
            return supervisorList;
        }
    }

}
