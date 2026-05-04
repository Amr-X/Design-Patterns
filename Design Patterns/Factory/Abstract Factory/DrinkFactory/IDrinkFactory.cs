
using Factory.Abstract_Factory.Drinks;

namespace Factory.Abstract_Factory.DrinkFactory;

public interface IDrinkFactory
{
    public IHotDrink Produce(int amount);
}