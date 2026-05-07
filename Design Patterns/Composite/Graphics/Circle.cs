namespace Composite.Graphics;

// Circle is a Dot and a Radius
public class Circle : Dot
{
    public int Radius { get; set; }

    public Circle(int x, int y, string color, int radius)
        : base(x, y, color)
    {
        Radius = radius;
    }

    public new void Draw()
    {
        Console.WriteLine($"Drawing a circle with color {Color} and radius {Radius}");
    }
}