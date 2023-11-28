namespace Common;

public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }

    public void EmptyLine()
    {
        Console.WriteLine();
    }
}