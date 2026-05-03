using System.Diagnostics;
using SOLID;
using SOLID.Dependency_Inversion;
using SOLID.Liskov_Substitution;
using SOLID.Open_Closed;
using SOLID.Single_Responsibility;

// SingleResponsibilityExample();
// OpenClosedExample();
// LiskovSubstitutionExample();

static void SingleResponsibilityExample()
{
    Book b = new();

    b.AddPage("Content For Page 1");
    b.AddPage("Content For Page 2");
    var path = @"MyBookFile.txt";

    // Bad
    // b.SaveToFile(path);

    b.AddPage("Content For Page 3");
    b.AddPage("Content For Page 4");

    // b.SaveToFile(path, overwrite: true);

    // Good
    FilePersistence filePersistence = new();
    filePersistence.SaveAsTxt(b, path);

    Process.Start(new ProcessStartInfo { FileName = path, UseShellExecute = true });
}
static void OpenClosedExample()
{
    // Note: A Problem I faced here: I added a new member to the Product class
    // That means I have to add for each Product I Created in the Application
    // An Amount for. Solutions are Builder, Factory, Which I don't know yet.
    var mouse = new Product("Mouse", 50, Color.Green, Size.Medium);
    var orange = new Product("Orange", 20, Color.Orange, Size.Small);
    var apple = new Product("Apple", 10, Color.Red, Size.Medium);
    var house = new Product("House", 1000, Color.Blue, Size.Large);
    List<Product> products = [mouse, orange, apple, house];

    // We want to filter them by some specification (Size, and/or Color)
    Console.WriteLine("Medium Size Products (Old)");
    foreach (var p in ProductFilter.FilterBySize(products, Size.Medium))
    {
        Console.WriteLine($"\t- {p.Name} - {p.Color} Color - {p.Size} Size.");
    }

    Console.WriteLine("Medium Size Products (New)");
    var sizeSpec = new SizeSpecification(Size.Medium);
    var colorSpec = new ColorSpecification(Color.Red);
    foreach (var p in Filter.FilterBy(products, colorSpec))
    {
        Console.WriteLine($"\t- {p.Name} - {p.Color} Color");
    }
}
static void OpenClosedExample2()
{
    List<Product> products =
    [
        new("Mouse", 50, Color.Green, Size.Medium),
        new("Orange", 20, Color.Orange, Size.Small),
        new("Apple", 10, Color.Red, Size.Medium),
        new("Monitor", 1000, Color.Blue, Size.Large),
    ];

    products.Sort(new ProductNameComparer());

    foreach (var p in products)
    {
        Console.WriteLine($"\t{p.Name} - {p.Color} - {p.Size}");
    }
}
static void LiskovSubstitutionExample()
{
    // If code expects a Rectangle, a Square should work with no weird behavior.

    // Replacing Base Types with any of it's Derived Types should work the same
    Rectangle rc = new()
    {
        Width = 10,
        Height = 20, // Area = 200
    };
    Console.WriteLine(rc.Area);
    // Replace
    Rectangle sq = new Square
    {
        Width = 10,
        Height = 20, // Area =  400
    };
    Console.WriteLine(sq.Area);
}
static void LiskovSubstitutionExample2()
{
    // Bad!
    // Bird b = new Bird();
    // b.Fly(); // Some bird is flying..

    // // Replacing - The Principle Says We shouldn't get any surprising/incorrect results
    // You are expecting a bird can fly and Ostrich is a bird therefore Ostrich Can Fly!
    // Bird b2 = new Ostrich();
    // b2.Fly(); // Does Nothing!

    // Good
    FlyingBird b = new FlyingBird();
    b.Fly();

    //FlyingBird o = new Ostrich(); // I Can't do that - Ostrich isn't a FlyingBird // This is Good
    FlyingBird s = new Sparrow();
    s.Fly();
}
static void DependencyInversionExample()
{
    var paypal = new Paypal();
    var stripe = new Stripe();

    var person = new Person("Amr");
    var book = new Product("Book", 100, Color.Red, Size.Medium);

    // Chose any Payment Method
    var store = new Store(paypal);
    store.Buy(book, person);

    var store2 = new Store(stripe);
    store2.Buy(book, person);
}
