using BerntGästarNiklasLösningar1.Concretes;
using BerntGästarNiklasLösningar1.Interfaces;

var productCatalog = new ProductCatalog();
productCatalog.AddProduct(new ProductA("Product A", 100));
productCatalog.AddProduct(new ProductB("Product B", 200));

var standardPriceCalculator = new StandardPriceCalculator();
var discountPriceCalculator = new DiscountPriceCalculator(0.9m);
var blackFridayCalculator = new BlackFridayCalculator();

var consoleLogger = new ConsoleLogger();

DisplayProducts(productCatalog, standardPriceCalculator, consoleLogger);
consoleLogger.EmptyLine();
DisplayProducts(productCatalog, discountPriceCalculator, consoleLogger);
consoleLogger.EmptyLine();
DisplayProducts(productCatalog, blackFridayCalculator, consoleLogger);
Console.ReadLine();
return;

void DisplayProducts(IProductCatalog productCatalog1, ICalculator standardPriceCalculator, ILogger consoleLogger1)
{
    foreach (var product in productCatalog1.GetProducts())
    {
        var price = standardPriceCalculator.CalculatePrice(product);
        consoleLogger1.Log(product, price);
    }
}