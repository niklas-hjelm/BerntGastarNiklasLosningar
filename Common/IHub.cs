namespace Common;

public interface IHub<in T>
{
    IAddress Address { get; }
    void Register(T participant);
    void UnRegister(T participant);
    void Broadcast(IMessage message);
}