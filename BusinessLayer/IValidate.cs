namespace BusinessLayer
{
    public interface IValidate
    {
        bool CheckWorkHours(Request request);
        bool CheckDate(Request request);
    }
}
