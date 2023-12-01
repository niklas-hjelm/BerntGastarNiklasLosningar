using Network.Hubs.Interfaces;

namespace Network.Services.Interfaces;

public interface IHubService
{
    void AddHub(IHub hub);
    void RemoveHub(string hubName);
}