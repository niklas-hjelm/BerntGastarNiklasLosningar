using BerntGästarNiklasLösningar1.Concretes;
using BerntGästarNiklasLösningar1.Interfaces;

var productCatalog = new ProductCatalog();
productCatalog.AddProduct(new ProductA("Product A", 100));
productCatalog.AddProduct(new ProductB("Product B", 200));

var priceCalculator = new StandardPriceCalculator();
var consoleLogger = new ConsoleLogger();

DisplayProducts(productCatalog, priceCalculator, consoleLogger);
consoleLogger.EmptyLine();
return;

void DisplayProducts(IProductCatalog productCatalog1, ICalculator standardPriceCalculator, ILogger consoleLogger1)
{
    foreach (var product in productCatalog1.GetProducts())
    {
        var price = standardPriceCalculator.CalculatePrice(product);
        consoleLogger1.Log(product, price);
    }
}