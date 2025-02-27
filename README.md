# Open Interfaces

**Open Interfaces** is a lightweight .NET library that defines a set of commonly used service interfaces (
e.g., `ILogService`, `IMessageService`, etc.). The library has minimal dependencies, relying only on .NET system
libraries, and is designed to be integrated into various .NET projects as a foundational library.

## Features

- **Lightweight**: Only depends on .NET system libraries; no third-party dependencies.
- **Generic**: Defines a set of commonly used service interfaces suitable for various scenarios.
- **Extensible**: All interfaces can be implemented and extended as needed.

## Installation

Install via NuGet:

```bash
dotnet add package Open.Interfaces
```

Alternatively, search for `Open.Interfaces` in the NuGet Package Manager in Visual Studio and install it.

## Included Interfaces

Here are the main interfaces defined in the library:

### `ILogService`

A generic interface for logging.

```c#
public interface ILogService
{
    void Debug(string message);
    void Info(string message);
    void Warn(string message);
    void Error(string message);
    void Fatal(string message);
    void Exception(Exception exception);
}
```

### `IMessageService`

A generic interface for sending messages.

```c#
public interface IMessageService
{   
    void Send(object message);
    void Subscribe(Action<object,bool> handler);
}

```

## Contributing

## License

This project is licensed under the [MIT License](https://chat.deepseek.com/a/chat/s/LICENSE).

## Contact

For any questions or suggestions, please open an issue
on [GitHub Issues](https://github.com/OpenCommon/Open.Interfaces/issues) or
email [opencoder@126.com](mailto:opencoder@126.com).

------

Thank you for your interest and support! 🚀
