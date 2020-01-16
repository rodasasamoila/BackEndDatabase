using PersistanceLayer;

namespace BusinessLayer
{
    public class ScheduleRequestAdder :IScheduleRequestAdder
    {
        private readonly IValidate _validate;
        private readonly IContainer _container;
        public ScheduleRequestAdder(IContainer container,IValidate validate)
        {
            _validate = validate;
            _container = container;
        }
        public void Add(Request request)
        {
            if(_validate.CheckWorkHours(request)==true && _validate.CheckDate(request)==true)
            _container.SaveScheduleRequest(request);
            
        }
    }
}
