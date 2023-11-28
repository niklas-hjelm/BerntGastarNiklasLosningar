using BerntGästarNiklasLösningar1.Concretes.Strategies;
using BerntGästarNiklasLösningar1.Enums;
using BerntGästarNiklasLösningar1.Interfaces;
using BerntGästarNiklasLösningar1.Services.Interfaces;
using Common;

namespace BerntGästarNiklasLösningar1.Services;

public class ShippingService(ILogger logger) : IShippingService
{
    private readonly Dictionary<ShippingType, IShippingStrategy> _shippingStrategies = new()
    {
        { ShippingType.Truck, new ShipByTruckStrategy(logger) },
        { ShippingType.Boat, new ShipByBoatStrategy(logger) },
        { ShippingType.Plane, new ShipByFlightStrategy(logger) }
    };
    public void ShipOrder(IOrder order, ShippingType shippingMethod)
    {
        if (_shippingStrategies.ContainsKey(shippingMethod))
        {
            _shippingStrategies[shippingMethod].ShipOrder(order);
        }
        else
        {
            logger.Log($"No shipping strategy found for {shippingMethod}");
        }
    }
}