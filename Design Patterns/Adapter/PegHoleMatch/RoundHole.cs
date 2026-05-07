namespace Adapter.PegHoleMatch;

public class RoundHole
{
    public int Radius { get; }

    public RoundHole(int radius)
    {
        Radius = radius;
    }

    public bool Fits(RoundPeg peg)
    {
        return peg.Radius <= Radius;
    }
}