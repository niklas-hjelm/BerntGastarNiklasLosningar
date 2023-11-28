using BerntGästarNiklasLösningar1.Concretes;
using BerntGästarNiklasLösningar1.Interfaces;
using BerntGästarNiklasLösningar1.Services.Interfaces;

namespace BerntGästarNiklasLösningar1.Builder;

public class OrderBuilder : IOrderBuilder, IOrderName
{
    private IOrder _order;

    public OrderBuilder()
    {
        _order = new Order();
    }

    public static IOrderBuilder Create()
    {
        return new OrderBuilder();
    }
    public IOrder Build()
    {
        return _order;
    }
    public IOrderName WithName(string name)
    {
        _order.WithName(name);
        return this;
    }

    public IOrderBuilder AddProduct(IProduct product)
    {
        _order.AddProduct(product);
        return this;
    }

    public IOrderBuilder AddProducts(IEnumerable<IProduct> products)
    {
        _order.AddProducts(products);
        return this;
    }

    public IOrderBuilder AddCalculatorService(ICalculatorService calculatorService)
    {
        _order.AddCalculatorService(calculatorService);
        return this;
    }
}