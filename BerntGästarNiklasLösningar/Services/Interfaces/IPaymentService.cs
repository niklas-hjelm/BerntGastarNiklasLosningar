using BerntGästarNiklasLösningar1.Interfaces;
using BerntGästarNiklasLösningar1.Payment;

namespace BerntGästarNiklasLösningar1.Services.Interfaces;

public interface IPaymentService
{
    void ProcessPayment(IOrder order);
    PaymentResultOrder ProcessPayment(PaymentRequestOrder request);
}