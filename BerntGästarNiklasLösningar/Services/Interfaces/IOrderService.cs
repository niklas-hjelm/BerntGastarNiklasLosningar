using BerntGästarNiklasLösningar1.Enums;
using BerntGästarNiklasLösningar1.Interfaces;

namespace BerntGästarNiklasLösningar1.Services.Interfaces;

public interface IOrderService
{
    void PlaceOder(string orderName, IEnumerable<IProduct> products, ShippingType shippingMethod);
}