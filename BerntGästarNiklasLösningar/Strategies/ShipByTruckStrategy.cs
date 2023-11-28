using BerntGästarNiklasLösningar1.Interfaces;
using Common;

namespace BerntGästarNiklasLösningar1.Concretes.Strategies;

public class ShipByTruckStrategy(ILogger logger) : ShipByStrategy(logger)
{
    public override void ShipOrder(IOrder order)
    {
        Logger.Log($"Order {order.Name} is shipped by truck");
    }
}