using BerntGästarNiklasLösningar1.Interfaces;
using BerntGästarNiklasLösningar1.Services.Interfaces;

namespace BerntGästarNiklasLösningar1.Concretes;

public class Order : IOrder
{
    private ICalculatorService _calculatorService;

    public string Name { get; set; }

    public List<IProduct> Products { get; set; } = new ();
    public IOrder WithName(string name)
    {
        Name = name;
        return this;
    }

    public IOrder AddProduct(IProduct product)
    {
        Products.Add(product);
        return this;
    }

    public IOrder AddProducts(IEnumerable<IProduct> products)
    {
        Products.AddRange(products);
        return this;
    }

    public IOrder AddCalculatorService(ICalculatorService calculatorService)
    {
        _calculatorService = calculatorService;
        return this;
    }

    public decimal GetPrice()
    {
        return _calculatorService.Calculate(Products);
    }
}