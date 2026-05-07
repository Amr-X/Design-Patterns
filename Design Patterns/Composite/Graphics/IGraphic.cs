namespace Composite.Graphics;

public interface IGraphic
{
    public string Color { get; set; }

    public void Draw();
    public void Move(int x, int y);
}