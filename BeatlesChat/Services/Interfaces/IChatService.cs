namespace BeatlesChat.Services.Interfaces;

public interface IChatService<in T> where T : class
{
    void Notify(string message, string receiver, string sender);

    void Register(T user);
}