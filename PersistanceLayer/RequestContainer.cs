using BusinessLayer;
using BusinessLayer.ScheduleRequest.Commands;
using System.Collections.Generic;

namespace PersistanceLayer
{

    public class RequestContainer : IScheduleRequestPersister
    {

        List<AddScheduleRequestCommand> requestsList = new List<AddScheduleRequestCommand>();


        public RequestContainer()
        {

        }

        public void SaveScheduleRequest(AddScheduleRequestCommand request)
        {
            requestsList.Add(request);
        }
    };
}
