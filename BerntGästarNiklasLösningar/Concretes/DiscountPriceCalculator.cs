using BerntGästarNiklasLösningar1.Abstracts;
using BerntGästarNiklasLösningar1.Interfaces;

namespace BerntGästarNiklasLösningar1.Concretes;

public class DiscountPriceCalculator(decimal discount) : Calculator
{
    public decimal Discount { get; } = discount;

    public override decimal CalculatePrice(IProduct product)
    {
        return product.Price * Discount;
    }
}