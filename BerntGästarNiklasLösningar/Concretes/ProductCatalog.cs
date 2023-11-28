using BerntGästarNiklasLösningar1.Interfaces;

namespace BerntGästarNiklasLösningar1.Concretes;

public class ProductCatalog : IProductCatalog
{
    private readonly ICollection<IProduct> _products = new List<IProduct>();

    public void AddProduct(IProduct product)
    {
        _products.Add(product);
    }

    public IEnumerable<IProduct> GetProducts()
    {
        return _products;
    }
}