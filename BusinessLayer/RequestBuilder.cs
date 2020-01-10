using System;

namespace BusinessLayer
{
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
    
}
