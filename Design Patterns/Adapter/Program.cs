using Adapter.PegHoleMatch;
using Adapter.Renderer;

#region Renderer

// Task: Draw the square using the Renderer class
var square = new Square(new Point(5, 2), 5);

// But, Hey, We only how to render pixels, How can we make use of the existing Renderer class to do so?
// Adapt -> Convert Square to a bunch of points and render

var renderer = new Renderer(); // An Existing System
// renderer.RenderSquare(square); // Nah, We can't afford to change existing code

// IEnumerable<Point> 
var adapter = new SquareToPointsAdapter(square); // Adapter

renderer.RenderPixels(adapter);

#endregion


#region PegHoleMatch

var roundHole = new RoundHole(5);

var roundPeg = new RoundPeg(5);
roundHole.Fits(roundPeg); // Everything is fine

// Can We fit a square? No
var squarePeg = new SquarePeg(5);
// roundHole.Fits(squarePeg);

// We Adapt -
// In order for the SquareAdapter to work
// We have to inherit from RoundPeg (SquareAdapter is a RoundPeg
// And wrap the SquarePeg inside it
var squareAdapter = new SquareAdapter(squarePeg);
roundHole.Fits(squareAdapter); // Now it works

#endregion
