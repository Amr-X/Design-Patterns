namespace Composite.Graphics;

public class Dot : IGraphic
{
    public int X { get; set; }
    public int Y { get; set; }
    public string Color { get; set; }

    public Dot(int x, int y, string color)
    {
        X = x;
        Y = y;
        Color = color;
    }

    public void Draw()
    {
        Console.WriteLine($"Drawing a dot with color {Color}");
    }

    public void Move(int x, int y)
    {
        Console.WriteLine($"Moving the dot to coordinates ({x}, {y})");
        X = x;
        Y = y;
    }
}