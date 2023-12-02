namespace Common;

public interface IMessage
{
    IAddress Sender { get; }
    IAddress Receiver { get; }
    string Content { get; }
}