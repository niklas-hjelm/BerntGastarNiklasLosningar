using Common;

namespace Network;

public record Address(string Country, string Region, string Computer) : IAddress;