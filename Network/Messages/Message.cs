using Common;

namespace Network.Messages;

public class Message(IAddress sender, IAddress receiver, string content) : IMessage
{
    public IAddress Sender { get; } = sender;
    public IAddress Receiver { get; } = receiver;
    public string Content { get; } = content;
}