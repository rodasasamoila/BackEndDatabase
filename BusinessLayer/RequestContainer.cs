using System.Collections.Generic;

namespace BusinessLayer
{
    public interface IContainer
    {
        
        void AddRequest(Request request);
        
        List<Request> GetRequests();

        void DeleteRequest(int id);

    }

    public  class RequestContainer : IContainer
    {

        List<Request> requestsList = new List<Request>();


        public RequestContainer()
        {

        }

        

        public void AddRequest(Request request)
        {
            requestsList.Add(request);
        }

        public List<Request> GetRequests()
        {
            return requestsList;
        }

        public void DeleteRequest(int id)
        {
            requestsList.Remove(requestsList.Find(r => r.RequestId == id));
        }
    };
    public class DummyContainer:IContainer
    {
        List<Request> requestsList = new List<Request>();
        public void AddRequest(Request request)
        {
            request.StartHour = 123;
            requestsList.Add(request);
        }

        public List<Request> GetRequests()
        {
            return requestsList;
        }

        public void DeleteRequest(int id)
        {
            requestsList.Remove(requestsList.Find(r => r.RequestId == id));
        }
    }
}
