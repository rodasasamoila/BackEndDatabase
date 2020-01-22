using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.ScheduleRequest.Validator
{
    public class ScheduleLimitsQueryHandler : IScheduleLimitsQueryHandler
    {
        public ScheduleLimitsCommand Handle(Nothing nothing)
        {
            return new ScheduleLimitsCommand();
        }
    }
}
