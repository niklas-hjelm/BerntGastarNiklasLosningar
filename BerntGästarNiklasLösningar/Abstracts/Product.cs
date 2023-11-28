using BerntGästarNiklasLösningar1.Interfaces;

namespace BerntGästarNiklasLösningar1.Abstracts;

public abstract class Product(string name, decimal price) : IProduct
{
    public string Name { get; } = name;
    public decimal Price { get; } = price;
}