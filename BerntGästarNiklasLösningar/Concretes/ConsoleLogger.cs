using BerntGästarNiklasLösningar1.Interfaces;

namespace BerntGästarNiklasLösningar1.Concretes;

public class ConsoleLogger : ILogger
{
    public void Log(IProduct product, decimal price)
    {
        Console.WriteLine($"{product.Name} {price}");
    }

    public void EmptyLine()
    {
        Console.WriteLine();
    }
}