namespace BerntGästarNiklasLösningar1.Interfaces;

public interface ILogger
{
    void Log(IProduct product, decimal price);
    void EmptyLine();
}