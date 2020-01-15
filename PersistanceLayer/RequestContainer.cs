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

    public class RequestContainer : IContainer
    {

        List<Request> requestsList = new List<Request>();
        private readonly IValidate _valid;

        public RequestContainer(IValidate valid)
        {
            _valid = valid;
        }

        public void SaveScheduleRequest(Request request)
        {
            
            if(_valid.CheckWorkHours(request)==true && _valid.CheckDate(request)==true )
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
