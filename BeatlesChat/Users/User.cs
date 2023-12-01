using BeatlesChat.Services.Interfaces;
using BeatlesChat.Users.Interfaces;
using Common;

namespace BeatlesChat.Users;

public class User: IUser
{
    protected IChatService<IUser> _chatService;
    protected ILogger _logger;

    public string Name { get; }
    
    public void ReceiveMessage(string message, string sender)
    {
        _logger.Log($"{Name} received a message:\n\t {message} \n from {sender}");
    }

    public void SendMessage(string message, string receiver)
    {
        _chatService.Notify(message, receiver, Name);
    }

    public User(string name, ILogger logger, IChatService<IUser> chatService)
    {
        Name = name;
        _logger = logger;
        _chatService = chatService;
        _chatService.Register(this);
    }
}