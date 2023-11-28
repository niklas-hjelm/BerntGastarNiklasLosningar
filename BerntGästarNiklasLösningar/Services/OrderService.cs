using BerntGästarNiklasLösningar1.Builder;
using BerntGästarNiklasLösningar1.Enums;
using BerntGästarNiklasLösningar1.Interfaces;
using BerntGästarNiklasLösningar1.Services.Interfaces;
using Common;

namespace BerntGästarNiklasLösningar1.Services;

public class OrderService(ILogger logger, ICalculatorService calculatorService, IPaymentService paymentProcessor, IShippingService shippingService) : IOrderService
{
    private readonly ILogger _logger = logger;
    private IPaymentService _paymentProcessor = paymentProcessor;
    private IShippingService _shippingService = shippingService;

    public void PlaceOder(string orderName, IEnumerable<IProduct> products, ShippingType shippingMethod)
    {
        _logger.Log($"Order {orderName} placed for products.");
        
        IOrderBuilder orderBuilder = OrderBuilder.Create();
        IOrder order = orderBuilder
            .AddProducts(products)
            .AddCalculatorService(calculatorService)
            .WithName(orderName)
            .Build();

        _paymentProcessor.ProcessPayment(order);
        _shippingService.ShipOrder(order, shippingMethod);
    }
}