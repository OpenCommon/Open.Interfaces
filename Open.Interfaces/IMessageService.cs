namespace Open.Interfaces;

public interface IMessageService
{   
    void Send(object message);

    void Subscribe(Action<object,bool> handler);
}
