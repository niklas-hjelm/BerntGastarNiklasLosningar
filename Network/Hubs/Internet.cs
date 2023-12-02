using Common;
using Network.Hubs.Interfaces;
using Network.Messages;

namespace Network.Hubs;

public class Internet : IInternet
{
    public Address Address { get; }
    private readonly Dictionary<Address, ICountryHub> _countryHubs = new();
    private ILogger _logger;

    public Internet(Address address, ILogger logger)
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

    public void Receive(IMessage message)
    {
        var countryHub = 
            _countryHubs.FirstOrDefault(v => v.Key.Country == message.Receiver.Country);
        if (countryHub.Value != null)
            countryHub.Value?.Receive(message);
        else
            _logger.Log($"Message {message} was not delivered");
    }
}