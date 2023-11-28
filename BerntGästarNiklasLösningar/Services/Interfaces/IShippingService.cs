using BerntGästarNiklasLösningar1.Concretes.Strategies;
using BerntGästarNiklasLösningar1.Enums;
using BerntGästarNiklasLösningar1.Interfaces;

namespace BerntGästarNiklasLösningar1.Services.Interfaces;

public interface IShippingService
{
    void ShipOrder(IOrder order, ShippingType shippingMethod);
}