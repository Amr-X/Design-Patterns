using System.Text;
using Builder.Car;
using Builder.Html;

// Problem: Objects get complex to create, You don't have control over the creation order, Alot of parameters to work with, And it's not Readable
static void BadBuilder()
{
    // Without the builder

    List<string> items = ["item 1", "item 2", "item 3", "item 4"];
    var rootTag = new HtmlElement("ul");
    // We add and build it manually
    foreach (var item in items)
    {
        var e = new HtmlElement("il", item);
        rootTag.Elements.Add(e);
    }
    // ***************************************************
    // Manually building the car
    // Not Readable - Too many parameters
    Car car = new Car("Model S", "Red", 2022, true, true, true, 2000, true);
}

static void GoodBuilder()
{
    // Here you don't even have to know about HtmlElement existence
    HtmlBuilder htmlBuilder = new HtmlBuilder("ul");

    // Non-fluent
    htmlBuilder.AddElement("li", "item 1");
    htmlBuilder.AddElement("li", "item 2");
    htmlBuilder.AddElement("li", "item 3");
    htmlBuilder.AddElement("li", "item 4");
    // ***************************************************
    CarBuilder cb = new CarBuilder();
    // Fluent interface - Chaining methods together
    var myCar = cb.MakeModel("Model S")
        .OfColor("Red")
        .InYear(2022)
        .HasSunroof(true)
        .HasLeatherSeats(true)
        .HasGPS(true)
        .WithEngineCC(2000)
        .Car;
}
static void BadBuilderStepwise()
{
    // Without stepwise builder
    // You can do the requirement we wanted
    // But you have invalid states, Like setting the color before the model
    // Which you get a "Model S" with "Blue" color, Which is not valid
    CarBuilder cb = new CarBuilder();
    var myCar = cb.OfColor("Blue").MakeModel("Model S"); // BAD!
}
static void GoodBuilderStepwise()
{
    // With stepwise builder
    // We Force the order
    CarBuilderStepwise cb = new CarBuilderStepwise();
    var myCar = cb.Create() // IModelStep
        .MakeModel("Model S") // IColorStep
        .OfColor("Red") // IYearStep
        .InYear(2022) // CarBuilderStepwise
        .Build(); // Car
}
