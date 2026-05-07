using Adapter.PegHoleMatch;

public class SquareAdapter : RoundPeg // Inherit from the Target Interface that you want to match
{
    // Wrap the Service
    private SquarePeg SquarePeg { get; }

    public int Width => SquarePeg.Width * (int)Math.Sqrt(2) / 2;

    public SquareAdapter(SquarePeg squarePeg)
        : base(squarePeg.Width)
    {
        SquarePeg = squarePeg;
    }
}