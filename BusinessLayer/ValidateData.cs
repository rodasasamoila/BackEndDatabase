using System;


namespace BusinessLayer
{

    public class ValidateData : IValidate
    {

        public ValidateData()
        {


        }
        public bool CheckWorkHours(Request request)
        {

            if (request.StartHour < 7 || request.EndHour > 22 || request.StartHour > 13 || request.EndHour < 16)
            {
                throw new Exception("Schedule starting hours or ending hours are not in the correct interval");
            }
            if (request.StartHour != request.EndHour - 9)
            {
                throw new Exception("Schedule should have an 8 hour shift");
            }
            return true;
        }
        public bool CheckDate(Request request)
        {

            int result = DateTime.Compare(request.ExceptionDate, DateTime.Now.AddHours(-5));
            if (result > 0)
            {
                return true;
            }
            else
            {
                throw new Exception("The exception date is in a previous date compared to the current date");
            }
        }
    }
}
