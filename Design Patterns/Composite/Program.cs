// Products in Boxes
// Files in Folders
// Graphics in CompoundGraphics

using Composite.Graphics;

List<CompoundGraphic> compoundGraphics = [];


var compound1 = new CompoundGraphic();
var dot1 = new Dot(1, 2, "Red");
var circle1 = new Circle(3, 4, "Red", 5);
compound1.Add(dot1);
compound1.Add(circle1);

compoundGraphics.Add(compound1);

var compound2 = new CompoundGraphic();
var dot2 = new Dot(1, 2, "Red");
var circle2 = new Circle(3, 4, "Blue", 5);
compound2.Add(dot2);
compound2.Add(circle2);

compoundGraphics.Add(compound2);

var compound3 = new CompoundGraphic();
var dot3 = new Dot(1, 2, "Red");
var circle3 = new Circle(3, 4, "Blue", 5);
compound3.Add(dot3);
compound3.Add(circle3);

compoundGraphics.Add(compound3);


// In one single call for each, we move all of them , Or draw 
compoundGraphics.ForEach(c => c.Move(10, 10));

