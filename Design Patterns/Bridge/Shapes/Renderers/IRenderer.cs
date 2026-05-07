using Bridge.Shapes.Shapes;

namespace Bridge.Shapes.Renderers;

public interface IRenderer
{
    void Render(Shape shape);
}