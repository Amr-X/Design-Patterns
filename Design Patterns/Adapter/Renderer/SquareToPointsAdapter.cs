using System.Collections;

namespace Adapter.Renderer;

class SquareToPointsAdapter : IEnumerable<Point>
{
    private static readonly Dictionary<int, List<Point>> Cache = [];

    private List<Point> Points { get; }

    public SquareToPointsAdapter(Square square)
    {
        // We can get the same square again
        var hash = square.GetHashCode();
        if (Cache.TryGetValue(hash, out var points))
        {
            Points = points;
            return;
        }

        var left = square.Origin.X;
        var top = square.Origin.Y;
        var right = square.Origin.X + square.Size;
        var bottom = square.Origin.Y + square.Size;

        Points = [];
        // Adding every pixel that forms that line
        for (var x = left; x <= right; ++x)
        {
            Points.Add(new Point(x, top));
            Points.Add(new Point(x, bottom));
        }

        // Same
        for (var y = top; y <= bottom; ++y)
        {
            Points.Add(new Point(left, y));
            Points.Add(new Point(right, y));
        }

        Cache.Add(hash, Points);
    }

    public IEnumerator<Point> GetEnumerator()
    {
        return Points.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}