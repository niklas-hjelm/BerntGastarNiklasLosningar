using Network.Messages;

namespace Network.Clients.Interfaces;

public interface IClient
{
    Address Address { get; }
    void Receive(IMessage message);
    void Send(Address receiver, string message);
}