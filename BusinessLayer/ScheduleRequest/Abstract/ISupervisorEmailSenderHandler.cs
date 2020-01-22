using System.Collections.Generic;

namespace BusinessLayer
{
    public interface ISupervisorEmailSenderHandler
    {
        public void Handle(List<int> supervisorList);
    }
}