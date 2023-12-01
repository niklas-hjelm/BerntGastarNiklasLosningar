using Common;
using Network.Computers.Interfaces;

namespace Network.Computers;

public abstract class Computer(ILogger logger, string name) : IComputer
{
    public string Name { get; } = name;
    public void Receive(string message, string sender)
    {
        logger.Log($"{Name} received message from {sender}: {message}");
    }
}