﻿namespace Common.HubCommunications;

public interface IAddress
{
    string Country { get; init; }
    string Region { get; init; }
    string Computer { get; init; }
}