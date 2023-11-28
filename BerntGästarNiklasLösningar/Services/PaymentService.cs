using BerntGästarNiklasLösningar1.Interfaces;
using BerntGästarNiklasLösningar1.Payment;
using BerntGästarNiklasLösningar1.Services.Interfaces;
using Common;

namespace BerntGästarNiklasLösningar1.Services;

public class PaymentService(ILogger logger) : IPaymentService
{
    private readonly ILogger _logger = logger;
    public void ProcessPayment(IOrder order)
    {
        _logger.Log($"Payment processed for order {order.Name}, price is {order.GetPrice()} Kr");
    }

    public PaymentResultOrder ProcessPayment(PaymentRequestOrder request)
    {
        _logger.Log($"Payment processed for order {request.Order.Name}, price is {request.Order.GetPrice()} Kr");
        bool success = true;
        if (!success)
        {
            logger.Log($"Payment failed for order {request.Order.Name}");
        }

        return new PaymentResultOrder(success, request.Order);
    }
}