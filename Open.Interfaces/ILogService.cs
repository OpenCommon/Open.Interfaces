namespace Open.Interfaces;

public interface ILogService
{
    void Debug(string message);

    void Info(string message);

    void Warn(string message);

    void Error(string message);

    void Fatal(string message);

    void Exception(Exception exception);
}