using BusinessLayer.ScheduleRequest.Commands;
using System;


namespace BusinessLayer
{

    public class ValidateData : IValidate
    {
        private readonly IScheduleLimitsQueryHandler _scheduleLimitsQuery;
        public ValidateData(IScheduleLimitsQueryHandler scheduleLimitsQuery)
        {
            _scheduleLimitsQuery = scheduleLimitsQuery;

        }
        public bool CheckWorkHours(AddScheduleRequestCommand request)
        {

            if (request.StartHour < _scheduleLimitsQuery.Handle(null).StartHourMinimum || request.EndHour > _scheduleLimitsQuery.Handle(null).EndHourMaximum ||
                request.StartHour > _scheduleLimitsQuery.Handle(null).StartHourMaximum || request.EndHour < _scheduleLimitsQuery.Handle(null).StartHourMinimum)
            {
                throw new Exception("Schedule starting hours or ending hours are not in the correct interval");
            }
            if (request.StartHour != request.EndHour - 9)
            {
                throw new Exception("Schedule should have an 8 hour shift");
            }
            return true;
        }
        public bool CheckDate(AddScheduleRequestCommand request)
        {

            int result = DateTime.Compare(request.ExceptionDate, DateTime.Now.AddHours(-5));
            if (result > 0)
            {
                return true;
            }
            else
            {
                throw new Exception("The exception date is in a previous date compared to the current date");
            }
        }
    }
}
