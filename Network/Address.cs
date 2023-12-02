using Common.HubCommunications;

namespace Network;

public record Address(string Country, string Region, string Computer) : IAddress;