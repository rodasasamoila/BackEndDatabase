using BusinessLayer.ScheduleRequest.Commands;

namespace BusinessLayer
{
    public interface IScheduleRequestAdder
    {
        void Add(AddScheduleRequestCommand request);
    }
}
