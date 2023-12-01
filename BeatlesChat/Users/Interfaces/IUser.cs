using BeatlesChat.Services.Interfaces;

namespace BeatlesChat.Users.Interfaces;

public interface IUser
{
    string Name { get; }

    void ReceiveMessage(string message, string sender);
    void SendMessage(string message, string receiver);
}