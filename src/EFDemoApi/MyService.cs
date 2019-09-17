namespace EFDemoApi
{
    public interface IMyService
    {
        string GetValue();
    }

    public class MyService : IMyService
    {
        public string GetValue()
        {
            return nameof(MyService);
        }
    }
}