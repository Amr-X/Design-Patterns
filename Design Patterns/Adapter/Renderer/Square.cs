namespace Adapter.Renderer;

public class Square
{
    public Point Origin { get; }
    public int Size { get; }

    public Square(Point start, int size)
    {
        Origin = start;
        Size = size;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Origin, Size);
    }
}