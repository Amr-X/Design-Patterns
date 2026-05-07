using Bridge.Shapes.Shapes;

namespace Bridge.Shapes.Renderers;

public class Vulkan : IRenderer
{
    public void Render(Shape shape)
    {
        Console.WriteLine($"Rendering {shape.GetType().Name} with Vulkan");
    }
}