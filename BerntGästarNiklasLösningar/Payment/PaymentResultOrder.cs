using BerntGästarNiklasLösningar1.Interfaces;

namespace BerntGästarNiklasLösningar1.Payment;

public class PaymentResultOrder(bool success, IOrder order)
{
    public bool Success { get; } = success;
    public IOrder Order { get; } = order;
}