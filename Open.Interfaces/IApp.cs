namespace Open.Interfaces;

public interface IApp
{
    /// <summary>
    ///     The logger maybe null, if the service not exist.
    /// </summary>
    ILogService? Logger { get; }

    /// <summary>
    ///     The service manager maybe null, if the service not exist.
    /// </summary>
    IServiceManager? Services { get; }

    /// <summary>
    ///     The running status. if process is closing switch to false.
    /// </summary>
    bool Running { get; }

    /// <summary>
    ///     The shutdown event will be set on close.
    /// </summary>
    ManualResetEvent ShutdownEvent { get; }

    /// <summary>
    ///     Sleep special time and return true, if process is closing return false.
    /// </summary>
    /// <param name="millisecondsTimeout">The time to sleep</param>
    /// <returns></returns>
    bool Sleep(int millisecondsTimeout);
}