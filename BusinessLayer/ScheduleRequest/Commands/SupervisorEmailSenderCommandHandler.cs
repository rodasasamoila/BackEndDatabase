using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class SupervisorEmailSenderCommandHandler : ISupervisorEmailSenderHandler
    {

        public void Handle(List<int> supervisorList)
        {
           if(supervisorList.Count<1)
            {
                throw new Exception("The list of supervisor is empty");
            }
        }
    }
}
