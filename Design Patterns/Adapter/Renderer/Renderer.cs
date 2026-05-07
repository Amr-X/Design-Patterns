using System.Reflection.PortableExecutable;

namespace Adapter.Renderer;

// Only know how to render a single pixel on screen
public class Renderer
{
    public void RenderPixel(Point coordinate)
    {
        // Act as if we are rendering actual pixels on screen
        Console.SetCursorPosition(coordinate.X, coordinate.Y); // (0,0) is top left
        Console.Write("*");
    }

    public void RenderPixels(IEnumerable<Point> points)
    {
        foreach (var point in points)
        {
            RenderPixel(point);
        }
    }
    // We can add here a method to render a square, It violate SRP
    // More importantly, This class's source code isn't under out control, It's a Dll File
}