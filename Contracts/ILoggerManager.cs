namespace Contracts
{
    public interface ILoggerManager
    {
        void LogInfo(string message);
        public void LogWarn(string message);
        void LogWarning(string message);
        void LogError(string message);
        void LogDebug(string message);

    }
}
