using Bridge.Shapes.Shapes;

namespace Bridge.Shapes.Renderers;

public class OpenGl : IRenderer
{
    public void Render(Shape shape)
    {
        Console.WriteLine($"Rendering {shape.GetType().Name} with OpenGl");
    }
}