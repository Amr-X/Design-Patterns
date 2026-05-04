using Factory.Abstract_Factory.DrinkFactory;
using Factory.Abstract_Factory.Drinks;

namespace Factory.Abstract_Factory;

public enum DrinkType
{
    Tea,
    Coffee
}

public class HotDrinkMachine
{
    private readonly Dictionary<DrinkType, IDrinkFactory> _factories = [];

    // Not Very OCP - But you get the point 
    public HotDrinkMachine()
    {
        _factories[DrinkType.Tea] = new TeaFactory();
        _factories[DrinkType.Coffee] = new CoffeeFactory();
        //.. More here
    }

    public IHotDrink MakeDrink(DrinkType drinkType, int amount)
    {
        return _factories.TryGetValue(drinkType, out var factory)
            ? factory.Produce(amount)
            : throw new ArgumentException("Unknown drink type");
    }
}