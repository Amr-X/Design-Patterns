using Bridge.Shapes.Renderers;

namespace Bridge.Shapes.Shapes;

public abstract class Shape
{
    protected IRenderer _renderer;

    protected Shape(IRenderer renderer)
    {
        _renderer = renderer;
    }

    // Shape shouldn't draw itself but whatever
    public abstract void Draw();
}