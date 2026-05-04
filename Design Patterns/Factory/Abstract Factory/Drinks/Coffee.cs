namespace Factory.Abstract_Factory.Drinks;

public class Coffee : IHotDrink
{
    public int Amount { get; set; }

    public Coffee(int amount)
    {
        Amount = amount;
    }


    public void Consume()
    {
        Console.WriteLine("Coffee Consumed");
        Amount = 0;
    }
}