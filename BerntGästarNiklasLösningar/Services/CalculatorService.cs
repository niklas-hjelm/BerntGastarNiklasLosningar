using BerntGästarNiklasLösningar1.Concretes;
using BerntGästarNiklasLösningar1.Interfaces;
using BerntGästarNiklasLösningar1.Services.Interfaces;
using Common;

namespace BerntGästarNiklasLösningar1.Services;

public class CalculatorService(ICalculator? calculator) : ICalculatorService
{
    private ICalculator _calculator = calculator ?? new StandardPriceCalculator();

    public decimal Calculate(IProduct product)
    {
        return _calculator.CalculatePrice(product);
    }

    public decimal Calculate(IEnumerable<IProduct> products)
    {
        return products.Sum(product => _calculator.CalculatePrice(product));
    }
}