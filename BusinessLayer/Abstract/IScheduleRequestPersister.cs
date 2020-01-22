
using BusinessLayer.ScheduleRequest.Commands;


namespace PersistanceLayer
{
    public interface IScheduleRequestPersister
    {
        void SaveScheduleRequest(AddScheduleRequestCommand request);

    }
}
