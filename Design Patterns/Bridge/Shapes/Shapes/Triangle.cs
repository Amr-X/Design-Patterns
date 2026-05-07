using Bridge.Shapes.Renderers;

namespace Bridge.Shapes.Shapes;

public class Triangle : Shape
{
    // protected IRenderer _renderer;
    public int Base { get; set; }
    public int Height { get; set; }

    public Triangle(IRenderer renderer, int triBase, int height) : base(renderer)
    {
        Base = triBase;
        Height = height;
    }

    public override void Draw()
    {
        _renderer.Render(this);
    }
}