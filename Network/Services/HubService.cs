using Network.Hubs.Interfaces;
using Network.Services.Interfaces;

namespace Network.Services;

public abstract class HubService : IHubService
{
    protected Dictionary<string, IHub> Hubs { get; } = new();
    public void AddHub(IHub hub)
    {
        Hubs.Add(hub.Name, hub);
    }

    public void RemoveHub(string hubName)
    {
        Hubs.Remove(hubName);
    }
}