using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class RequestContainer
    {

        List<Request> requestsList = new List<Request>();
       

        private RequestContainer()
        {

        }

        public static RequestContainer Instance
        {
            get { return Nested.instance; }
        }

        private class Nested
        {
            static Nested()
            {

            }

            internal static readonly RequestContainer instance = new RequestContainer();

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

        class RequestBuilder
        {
            private Request _request;

            public RequestBuilder()
            {

                _request = new Request();
                _request.CreationDate = new DateTime();
                _request.ExceptionDate = new DateTime();
                _request.DeniedReason = " ";
                _request.EndHour = 18;
                _request.StartHour = 9;
                
            }

            public RequestBuilder WithAccepted(bool? accepted)
            {
                _request.Accepted = accepted;
                return this;
            }

            public RequestBuilder WithRequestType(string requestType)
            {
                _request.RequestType = requestType;
                return this;
            }

            public Request Build()
            {
                return _request;
            }
        }
    };
}
