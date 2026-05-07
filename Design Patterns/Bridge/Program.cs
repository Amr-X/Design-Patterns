using Bridge.Electronic.Devices;
using Bridge.Electronic.Remotes;
using Bridge.Shapes.Renderers;
using Bridge.Shapes.Shapes;

#region Bad

// I want a remote control for my TV

var tVRemote = new Bridge.Electronic.Bad_Example.TVRemote();

// I want same remote to control my Radio
// We make a class for it 
var radioRemote = new Bridge.Electronic.Bad_Example.RadioRemote();


// Same Remote for other thing
// You go and make that 

#endregion


// It's a very simple pattern - Maybe I complicated it a bit
// You don't want RedSquare or a RedCircle Class
// You just want a Shape that has some color
// New Shape(new Red())
// Not RedShape , BlueShape, GreenShape

#region Good

// I want a remote control to control a Device

var Tv = new TV();
var remote = new Remote(Tv);

var radio = new Radio();
var remote2 = new Remote(radio);

#endregion

#region Shapes

var openGl = new OpenGl();
// No need for OpenGlSquare, OpenGlTriangle
var square = new Square(openGl, 5);
square.Draw();

// Now, We have a problem
// Each time an shape is needed, we create one and passing the renderer to it
// OpenGl all over the place
var square1 = new Square(openGl, 5);
var square2 = new Square(openGl, 5);
var square3 = new Square(openGl, 5);
var square4 = new Square(openGl, 5);

// A factory would be a great thing here
var shapeFactory = new ShapeFactory(openGl); // Gives all types of objects with OpenGl Renderer

var s1 = shapeFactory.MakeSquare(5);
var s2 = shapeFactory.MakeSquare(5);
var s3 = shapeFactory.MakeSquare(5);
var s4 = shapeFactory.MakeSquare(5);
var s5 = shapeFactory.MakeSquare(5);


var vulkan = new Vulkan();
// No need for VulkanSquare, VulkanTriangle
var triangle = new Triangle(vulkan, 50, 10);
var triangle2 = new Triangle(openGl, 60, 20);
triangle.Draw();
triangle2.Draw();

#endregion

class ShapeFactory
{
    private readonly IRenderer Renderer;

    public ShapeFactory(IRenderer renderer)
    {
        Renderer = renderer;
    }

    public Square MakeSquare(int width) => new(Renderer, width);
    public Triangle MakeTriangle(int baseLength, int height) => new(Renderer, baseLength, height);
}