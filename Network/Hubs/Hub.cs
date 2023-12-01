using Network.Computers.Interfaces;
using Network.Hubs.Interfaces;

namespace Network.Hubs;

public abstract class Hub(string name) : IHub
{
    public string Name { get; } = name;
    protected List<IComputer> Computers { get; } = new (); 

    public void Register(IComputer computer)
    {
        Computers.Add(computer);
    }

    public void UnRegister(IComputer computer)
    {
        Computers.Remove(computer);
    }

    public void Send(string message, string receiver, string sender)
    {
        var computer = Computers.FirstOrDefault(c => c.Name == receiver);
        computer?.Receive(message, sender);
    }

    public void Broadcast(string message, string sender)
    {
        foreach (var computer in Computers)
        {
            if(computer.Name != sender) 
                computer.Receive(message, sender);
        }
    }
}