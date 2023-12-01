namespace Network.Computers.Interfaces;

public interface IComputer
{
    string Name { get; }
    void Receive(string message, string sender);
}