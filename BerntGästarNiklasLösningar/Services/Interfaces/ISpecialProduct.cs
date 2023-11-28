using BerntGästarNiklasLösningar1.Interfaces;

namespace BerntGästarNiklasLösningar1.Services.Interfaces;

public interface ISpecialProduct : IProduct
{
    decimal GetSpecialPrice();
}