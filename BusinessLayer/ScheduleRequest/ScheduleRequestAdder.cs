using BusinessLayer.ScheduleRequest;
using BusinessLayer.ScheduleRequest.Abstract;
using BusinessLayer.ScheduleRequest.Commands;
using PersistanceLayer;

namespace BusinessLayer
{
    public class ScheduleRequestAdder : IScheduleRequestAdder
    {
        private readonly IValidate _validateData;
        private readonly IScheduleRequestPersister _scheduleRequestPersister;
        private readonly ICurrentUserIdQueryHandler _currentUser;
        private readonly ISupervisorListQueryHandler _supervisorList;
        private readonly ISupervisorEmailSenderHandler _emailSender;

        public ScheduleRequestAdder(IScheduleRequestPersister scheduleRequestPersister, IValidate validateData, ICurrentUserIdQueryHandler currentUser, ISupervisorListQueryHandler supervisorList, ISupervisorEmailSenderHandler emailSender)
        {
            _validateData = validateData;
            _scheduleRequestPersister = scheduleRequestPersister;
            _currentUser = currentUser;
            _supervisorList = supervisorList;
            _emailSender = emailSender;
        }

        public void Add(AddScheduleRequestCommand request)
        {
            if (IsRequestValid(request))
            {
                _scheduleRequestPersister.SaveScheduleRequest(request);
                SendEmail();
            }

        }

        private bool IsRequestValid(AddScheduleRequestCommand request)
        {
            return _validateData.CheckWorkHours(request) && _validateData.CheckDate(request);
        }

        private void SendEmail()
        {
            CurrentUserId currentUserId = new CurrentUserId(_currentUser.Handle(new Nothing()));
            _emailSender.Handle(_supervisorList.Handle(currentUserId));
        }
    }
}
