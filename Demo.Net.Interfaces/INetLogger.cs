namespace Demo.Net.Interfaces
{
    public interface INetLogger
    {
        string UserId { get; set; }

        string GetGuid();

        void Warning(string msg);

        void Error(string msg);
    }
}

