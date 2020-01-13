using BusinessLayer;
using System.Collections.Generic;

namespace PersistanceLayer
{
    public interface IContainer
    {

        void SaveScheduleRequest(Request request);

        List<Request> GetAllMyRequests();

        void DeleteRequest(int id);

    }

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
    };
}
