using Network.Computers.Interfaces;

namespace Network.Hubs.Interfaces;

public interface IHub
{
    string Name { get; }
    void Register(IComputer computer);
    void UnRegister(IComputer computer);
    void Send(string message, string receiver, string sender);
    void Broadcast(string message, string sender);
}