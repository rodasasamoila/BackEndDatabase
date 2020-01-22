using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.ScheduleRequest.Abstract
{
    public interface ISupervisorListQueryHandler
    {
        public List<int> Handle(CurrentUserId currentUserId);

    }
}
