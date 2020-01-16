using BusinessLayer;
using System.Collections.Generic;

namespace PersistanceLayer
{

    public class RequestContainer : IContainer
    {

        List<Request> requestsList = new List<Request>();


        public RequestContainer()
        {

        }

        public void SaveScheduleRequest(Request request)
        {
            requestsList.Add(request);
        }

        public List<Request> GetAllMyRequests()
        {
            return requestsList;
        }

        public void DeleteRequest(int id)
        {
            requestsList.Remove(requestsList.Find(r => r.RequestId == id));
        }

        public List<Request> GetRequestsForReview()
        {
            return requestsList.FindAll(r=>r.Accepted==null);
        }
    };
}
