namespace Open.Interfaces.LogMedia;
public class LogItem
{
    public DateTime Time { get; } = DateTime.Now;
    public LogLevel Level { get; }
    public string Message { get; }
    public int ThreadId { get; } 
    public LogItem(LogLevel level, string message)
    {
        ThreadId = Thread.CurrentThread.ManagedThreadId;
        Time = DateTime.Now;
        Level = level;
        Message = message;
    }
}
