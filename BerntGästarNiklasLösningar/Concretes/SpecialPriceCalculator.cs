using BerntGästarNiklasLösningar1.Abstracts;
using BerntGästarNiklasLösningar1.Interfaces;
using BerntGästarNiklasLösningar1.Services.Interfaces;

namespace BerntGästarNiklasLösningar1.Concretes;

public class SpecialPriceCalculator : Calculator
{
    public override decimal CalculatePrice(IProduct product)
    {
        if (product is ISpecialProduct specialProduct)
        {
            return specialProduct.GetSpecialPrice();
        }

        return product.Price;
    }
}