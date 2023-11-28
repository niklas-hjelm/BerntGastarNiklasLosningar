using BerntGästarNiklasLösningar1.Abstracts;
using BerntGästarNiklasLösningar1.Services.Interfaces;

namespace BerntGästarNiklasLösningar1.Concretes;

public class SpecialProduct(string name, decimal price) : Product(name, price), ISpecialProduct
{
    private readonly decimal specialPrice;

    public SpecialProduct(string name, decimal price, decimal specialPrice) : this(name, price)
    {
        this.specialPrice = specialPrice;
    }

    public string Name { get; }
    public decimal Price { get; }
    public decimal GetSpecialPrice()
    {
        return specialPrice;
    }
}