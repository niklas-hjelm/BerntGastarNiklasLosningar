using BerntGästarNiklasLösningar1.Services.Interfaces;

namespace BerntGästarNiklasLösningar1.Interfaces;

public interface IOrder
{
    public string Name { get; set; }
    IOrder WithName(string name);
    IOrder AddProduct(IProduct product);
    IOrder AddProducts(IEnumerable<IProduct> products);
    IOrder AddCalculatorService(ICalculatorService calculatorService);
    decimal GetPrice();
}