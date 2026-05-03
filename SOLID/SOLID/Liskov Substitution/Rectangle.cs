using System;

namespace SOLID.Liskov_Substitution;

public class Rectangle
{
    protected int m_width;
    public int Width { get; set; }
    protected int m_height;
    public int Height { get; set; }

    public int Area => Width * Height;
}
