namespace Factory.Characters;

// Good
// A method is responsible for creating the object in some way and returning it to client - Factory Method
public class Character
{
    // Think of it like this
    // You have a constructor overloads having a descriptive name

    // public static Character CreatePlayer(string name) => new(name, 100);
    // public static Character CreateEnemy(string name) => new(name, 1000);

    public string Name { get; set; }

    public int Health { get; set; }

    // Private? Why? It's up to you, if you want to force the client to use your factory method only to create the object
    private Character(string name, int health)
    {
        Name = name;
        Health = health;
    }

    // Factory Class - The above Violate SRP
    // Dedicated class to create the object
    // Inner Class To See The Constructor
    public static class Factory
    {
        public static Character CreatePlayer(string name) => new(name, 100);

        public static Character CreateEnemy(string name) => new(name, 1000);
    }
    // Remove the static <====

    // Or Expose the Factory as a property or Static Field
    // public static readonly Factory FactoryInstance = new(); // Can't name it Factory
    // public static Factory GetFactory => new();
}
