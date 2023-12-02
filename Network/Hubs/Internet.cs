using Common;
using Common.HubCommunications;
using Network.Hubs.Interfaces;
using Network.Messages;

namespace Network.Hubs;

public class Internet : IInternet
{
    public IAddress Address { get; }
    private readonly Dictionary<IAddress, ICountryHub> _countryHubs = new();
    private ILogger _logger;

    public Internet(IAddress address, ILogger logger)
    {
        Address = address;
        _logger = logger;
    }
    public void Register(ICountryHub participant)
    {
        _countryHubs.Add(participant.Address, participant);
    }

    public void UnRegister(ICountryHub participant)
    {
        _countryHubs.Remove(participant.Address);
    }

    public void Broadcast(IMessage message)
    {
        var countryHub = 
            _countryHubs.FirstOrDefault(v => v.Key.Country == message.Receiver.Country);
        if (countryHub.Value != null)
            countryHub.Value?.Broadcast(message);
        else
            _logger.Log($"Message {message} was not delivered");
    }
}