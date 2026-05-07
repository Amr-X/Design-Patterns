using Bridge.Shapes.Renderers;
using Bridge.Shapes.Shapes;

public class Square : Shape
{
    // protected IRenderer _renderer;
    public int Width { get; set; }

    public Square(IRenderer renderer, int width) : base(renderer)
    {
        Width = width;
    }

    public override void Draw()
    {
        _renderer.Render(this);
    }
}