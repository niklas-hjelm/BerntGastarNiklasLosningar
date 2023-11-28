using BerntGästarNiklasLösningar1.Interfaces;

namespace BerntGästarNiklasLösningar1.Concretes.Strategies;

public interface IShippingStrategy
{
    void ShipOrder(IOrder order);
}