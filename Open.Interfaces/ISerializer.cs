namespace Open.Interfaces;

/// <summary>
///     Simple serialization interface
/// </summary>
public interface ISerializer
{
    /// <summary>
    ///     Serialize objects into byte arrays.
    /// </summary>
    /// <param name="source">The object.</param>
    /// <returns>Serialized object data</returns>
    byte[] Save(object source);

    /// <summary>
    ///     Deserialize data into objects.
    /// </summary>
    /// <typeparam name="T">The type of the object</typeparam>
    /// <param name="data">Serialized object data.</param>
    /// <returns></returns>
    T Load<T>(byte[] data);
}