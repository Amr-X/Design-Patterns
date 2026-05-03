using System;

namespace SOLID.Open_Closed;

// Bad!
public class ProductFilter
{
    public static IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
    {
        return products.Where(p => p.Size == size);
    }

    public static IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
    {
        return products.Where(p => p.Color == color);
    }
    // You want to combine both or simply add other criteria
    // You add here..
    // FilterByPrice ...
    // FilterByPriceAndSizeAndColorAnd...
}
