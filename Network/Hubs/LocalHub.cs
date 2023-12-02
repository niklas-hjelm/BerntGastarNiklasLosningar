using Common.HubCommunications;
using Network.Hubs.Interfaces;
using Network.Messages;

namespace Network.Hubs;

public class LocalHub : ILocalHub
{
    public IAddress Address { get; }

    private readonly Dictionary<IAddress, IClient> _clients = new();
    private readonly ICountryHub _countryHub;
    public LocalHub(IAddress id, ICountryHub countryHub)
    {
        Address = id;
        _countryHub = countryHub;
        _countryHub.Register(this);
    }

    public void Register(IClient participant)
    {
        _clients.Add(participant.Address, participant);
    }

    public void UnRegister(IClient participant)
    {
        _clients.Remove(participant.Address);
    }

    public void Broadcast(IMessage message)
    {
        if(_clients.TryGetValue(message.Receiver, out var client))
            client.Receive(message);
        else 
            _countryHub.Broadcast(message);
    }
}