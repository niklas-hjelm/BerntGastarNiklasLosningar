using BerntGästarNiklasLösningar1.Interfaces;

namespace BerntGästarNiklasLösningar1.Services.Interfaces;

public interface ICalculatorService
{
    decimal Calculate(IProduct product);
    decimal Calculate(IEnumerable<IProduct> products);
}