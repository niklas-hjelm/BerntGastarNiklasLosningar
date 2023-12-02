namespace Network.Messages;

public class Message(Address sender, Address receiver, string content) : IMessage
{
    public Address Sender { get; } = sender;
    public Address Receiver { get; } = receiver;
    public string Content { get; } = content;
}