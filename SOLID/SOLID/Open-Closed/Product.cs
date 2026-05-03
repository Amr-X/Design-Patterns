using System;

namespace SOLID.Open_Closed;

public enum Color
{
    Red,
    Blue,
    Green,
    Orange,
}

public enum Size
{
    Small,
    Medium,
    Large,
}

public class Product
{
    static int m_IdCount = 0;
    public int ID { get; private set; }
    public string Name { get; set; }
    public int Amount { get; set; }
    public Color Color { get; set; }
    public Size Size { get; set; }

    public Product(string name, int amount, Color color, Size size)
    {
        ID = m_IdCount++;
        Name = name;
        Amount = amount;
        Color = color;
        Size = size;
    }
}
