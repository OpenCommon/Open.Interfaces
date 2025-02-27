namespace Open.Interfaces;

public interface IServiceManager
{
    /// <summary>
    ///     Load assemblies.
    ///     Multiple calls to this function are not supported
    /// </summary>
    /// <param name="files">Assembly filenames.</param>
    void Load(IEnumerable<string>? files);

    /// <summary>
    ///     Register singleton into service system.
    /// </summary>
    /// <param name="type">The type</param>
    /// <param name="instance">The instance</param>
    /// <param name="name">The name</param>
    void Register(Type type, object instance, string name = "");

    /// <summary>
    ///     Get singleton with name.
    /// </summary>
    /// <typeparam name="T">Type</typeparam>
    /// <returns>Instance, null if failed.</returns>
    T? Singleton<T>() where T : class;


    /// <summary>
    ///     Get singleton with name.
    /// </summary>
    /// <typeparam name="T">Type</typeparam>
    /// <param name="instanceName">The instance name</param>
    /// <returns>Instance, null if failed.</returns>
    T? Singleton<T>(string instanceName) where T : class;

    /// <summary>
    ///     Create instance, requires default construction.
    /// </summary>
    /// <typeparam name="T">Type</typeparam>
    /// <returns>Instance, null on failure</returns>
    T? Create<T>() where T : class;

    /// <summary>
    ///     Obtain interface implementation list
    /// </summary>
    /// <typeparam name="T">The interface</typeparam>
    /// <returns>The implementation list </returns>
    IEnumerable<Type> GetImplementationsOf<T>();
}