using BerntGästarNiklasLösningar1.Abstracts;
using BerntGästarNiklasLösningar1.Interfaces;

namespace BerntGästarNiklasLösningar1.Concretes;

public class DiscountPriceCalculator : Calculator
{
    public decimal Discount { get; set; } = 0.9m;

    public override decimal CalculatePrice(IProduct product)
    {
        return product.Price * Discount;
    }
}