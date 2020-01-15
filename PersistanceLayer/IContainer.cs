using BusinessLayer;
using System.Collections.Generic;

namespace PersistanceLayer
{
    public interface IContainer
    {

        void SaveScheduleRequest(Request request);

        List<Request> GetAllMyRequests();

        List<Request> GetRequestsForReview();
        void DeleteRequest(int id);

    }
}
