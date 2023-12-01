using BeatlesChat.Services.Interfaces;
using BeatlesChat.Users.Interfaces;

namespace BeatlesChat.Services;

public class ChatService : IChatService<IUser>
{
    private readonly Dictionary<string, IUser> _users = new ();

    public void Notify(string message, string receiver, string sender)
    {
        _users[receiver].ReceiveMessage(message, sender);
    }

    public void Register(IUser user)
    {
        _users.Add(user.Name,user);
    }
}