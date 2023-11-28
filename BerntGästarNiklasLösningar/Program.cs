using BerntGästarNiklasLösningar1.Concretes;
using BerntGästarNiklasLösningar1.Enums;
using BerntGästarNiklasLösningar1.Interfaces;
using BerntGästarNiklasLösningar1.Services;
using BerntGästarNiklasLösningar1.Services.Interfaces;
using Common;

var consoleLogger = new ConsoleLogger();
var productCatalog = new ProductCatalog();
productCatalog.AddProduct(new ProductA("Product A", 100));
productCatalog.AddProduct(new ProductB("Product B", 200));

productCatalog.AddProduct(new SpecialProduct("Special Product", 300, 250));
productCatalog.AddProduct(new SpecialProduct("Special ProductB", 600, 350));

ICalculator blackFridayCalculator = new BlackFridayCalculator();
IShippingService shippingService = new ShippingService(consoleLogger);
IPaymentService paymentService = new PaymentService(consoleLogger);
ICalculatorService calculatorService = new CalculatorService(blackFridayCalculator);
IOrderService orderService = new OrderService(consoleLogger,calculatorService, paymentService, shippingService);

orderService.PlaceOder("Order 1", productCatalog.GetProducts(), ShippingType.Truck);
orderService.PlaceOder("Order 2", productCatalog.GetProducts(), ShippingType.Boat);
orderService.PlaceOder("Order 3", productCatalog.GetProducts(), ShippingType.Plane);

return;