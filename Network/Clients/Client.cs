using Common;
using Network.Clients.Interfaces;
using Network.Hubs.Interfaces;
using Network.Messages;

namespace Network.Clients;

public class Client : IClient
{
    private readonly ILocalHub _hub;
    private readonly ILogger _logger;

    public Client(Address id, ILocalHub hub, ILogger logger)
    {
        _logger = logger;
        Address = id;
        _hub = hub;
        _hub.Register(this);
    }
    public Address Address { get; }

    public void Receive(IMessage message)
    {
        _logger.Log($"{Address.Computer} received a message:\n\t {message.Content} \n\t from: {message.Sender.Computer}");
        _logger.EmptyLine();
    }

    public void Send(Address receiver, string message)
    {
        _hub.Broadcast(new Message(Address, receiver, message));
    }
}