namespace Network.Messages;

public interface IMessage
{
    Address Sender { get; }
    Address Receiver { get; }
    string Content { get; }
}