using Factory.Abstract_Factory.Drinks;

namespace Factory.Abstract_Factory.DrinkFactory;

public class CoffeeFactory : IDrinkFactory
{
    public IHotDrink Produce(int amount)
    {
        Console.WriteLine("Coffee is being prepared");
        return new Coffee(amount);
    }
}