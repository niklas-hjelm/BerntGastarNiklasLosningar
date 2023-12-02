using Network.Clients.Interfaces;
using Network.Messages;

namespace Network.Hubs.Interfaces;

public interface IHub<in T>
{
    Address Address { get; }
    void Register(T participant);
    void UnRegister(T participant);
    void Broadcast(IMessage message);
}