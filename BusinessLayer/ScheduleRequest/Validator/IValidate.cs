using BusinessLayer.ScheduleRequest.Commands;

namespace BusinessLayer
{
    public interface IValidate
    {
        bool CheckWorkHours(AddScheduleRequestCommand request);
        bool CheckDate(AddScheduleRequestCommand request);
    }
}
