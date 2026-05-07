namespace Composite.Graphics;

// The inheritance here is CRUCIAL
// CompoundGraphic is-a Graphic
// Which means we can have a CG inside one another - Forming a tree structure
public class CompoundGraphic : IGraphic
{
    public string Color
    {
        // Or, Print all of them
        get => "No Color for Compound Graphic";
        set;
    }

    // It's just a bunch of graphics object
    // Whenever we want to move a group of graphics, we simply delegate the job to every single graphic so every single one moves
    private readonly List<IGraphic> Graphics;

    public CompoundGraphic()
    {
        Graphics = [];
    }

    public void Add(IGraphic graphic)
    {
        // Adding a compound graphic, Dot, Circle, Anything works
        Graphics.Add(graphic);
    }

    public void Draw()
    {
        Console.WriteLine("Drawing a compound graphic:");
        // Could be a CG that does that recursively
        Graphics.ForEach(g => g.Draw());
    }

    public void Move(int x, int y)
    {
        Console.WriteLine($"Moving the compound graphic to coordinates ({x}, {y})");
        // Same
        Graphics.ForEach(g => g.Move(x, y));
    }

    // You can have something fancy to print the tree or something here
    // Checking if it's a Leaf or not
}

