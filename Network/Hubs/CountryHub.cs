using Common;
using Network.Hubs.Interfaces;
using Network.Messages;

namespace Network.Hubs;

public class CountryHub : ICountryHub
{
    public IAddress Address { get; }
    private readonly IInternet _internet;
    private readonly Dictionary<IAddress,ILocalHub> _localHubs = new();

    public CountryHub(IAddress address, IInternet internet)
    {
        Address = address;
        _internet = internet;
        _internet.Register(this);
    }
    public void Register(ILocalHub participant)
    {
        _localHubs.Add(participant.Address, participant);
    }

    public void UnRegister(ILocalHub participant)
    {
        _localHubs.Remove(participant.Address);
    }

    public void Broadcast(IMessage message)
    {
        var localHub = 
            _localHubs.FirstOrDefault(v => v.Key.Region == message.Receiver.Region);
        if (localHub.Value != null)
            localHub.Value?.Broadcast(message);
        else
            _internet.Broadcast(message);
    }
}