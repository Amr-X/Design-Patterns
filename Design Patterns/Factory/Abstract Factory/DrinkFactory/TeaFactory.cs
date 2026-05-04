
using Factory.Abstract_Factory.Drinks;

namespace Factory.Abstract_Factory.DrinkFactory;

public class TeaFactory : IDrinkFactory
{
    public IHotDrink Produce(int amount)
    {
        Console.WriteLine("Tea is being prepared");
        return new Tea(amount);
    }
}