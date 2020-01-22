using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.ScheduleRequest.Abstract
{
    public interface ICurrentUserIdQueryHandler
    {
        public uint Handle(Nothing nothing);
    }
}
