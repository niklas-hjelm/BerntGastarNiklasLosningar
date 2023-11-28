using BerntGästarNiklasLösningar1.Interfaces;
using Common;

namespace BerntGästarNiklasLösningar1.Concretes.Strategies;

public abstract class ShipByStrategy(ILogger logger) : IShippingStrategy
{
    protected ILogger Logger { get; set; } = logger;
    public abstract void ShipOrder(IOrder order);
}