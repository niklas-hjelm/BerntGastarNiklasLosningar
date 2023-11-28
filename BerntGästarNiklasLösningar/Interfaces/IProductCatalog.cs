namespace BerntGästarNiklasLösningar1.Interfaces;

public interface IProductCatalog
{
    void AddProduct(IProduct product);
    IEnumerable<IProduct> GetProducts();
}