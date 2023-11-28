using BerntGästarNiklasLösningar1.Interfaces;
using BerntGästarNiklasLösningar1.Services.Interfaces;

namespace BerntGästarNiklasLösningar1.Builder;

public interface IOrderBuilder
{
    IOrderBuilder AddProduct(IProduct product);
    IOrderBuilder AddProducts(IEnumerable<IProduct> products);
    IOrderBuilder AddCalculatorService(ICalculatorService calculatorService);
    IOrderName WithName(string name);
}