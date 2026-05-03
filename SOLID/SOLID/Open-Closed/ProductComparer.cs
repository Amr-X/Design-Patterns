using System.Collections.Generic;

namespace SOLID.Open_Closed;

public class ProductNameComparer : IComparer<Product>
{
    public int Compare(Product? x, Product? y)
    {
        return string.Compare(x?.Name, y?.Name, StringComparison.Ordinal);
    }
}
