using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public interface IValidate
    {
        bool CheckWorkHours(Request request);
        bool CheckDate(Request request);
    }

    public class ValidateData : IValidate
    {
        public bool CheckWorkHours(Request request)
        {
            if (request.StartHour < 7 || request.EndHour > 22 || request.StartHour > 13 || request.EndHour < 16)
            {
                return false;
            }
            if (request.StartHour != request.EndHour - 9)
            {
                return false;
            }
            return true;
        }
        public bool CheckDate(Request request)
        {
            
            int result = DateTime.Compare(request.ExceptionDate, DateTime.Now.AddHours(-1));
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
