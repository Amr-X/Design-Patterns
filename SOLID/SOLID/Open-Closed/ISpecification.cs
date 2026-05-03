using System;

namespace SOLID.Open_Closed;

// Good
public interface ISpecification<T>
{
    public bool IsSatisfied(T t);
}

public class ColorSpecification : ISpecification<Product>
{
    private Color color;

    public ColorSpecification(Color color)
    {
        this.color = color;
    }

    public bool IsSatisfied(Product product)
    {
        return product.Color == color;
    }
}

public class SizeSpecification : ISpecification<Product>
{
    private Size size;

    public SizeSpecification(Size size)
    {
        this.size = size;
    }

    public bool IsSatisfied(Product product)
    {
        return product.Size == size;
    }
}
// You Extend Here ....
