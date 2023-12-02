namespace Common.HubCommunications;

public interface IClient
{
    IAddress Address { get; }
    void Receive(IMessage message);
    void Send(IAddress receiver, string message);
}