using BusinessLayer.ScheduleRequest.Abstract;


namespace BusinessLayer
{
    public class CurrentUserQueryHandler : ICurrentUserIdQueryHandler
    {
        public uint Handle(Nothing nothing)
        {
            return 1;
        }
    }
}
