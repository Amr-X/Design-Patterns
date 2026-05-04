namespace Factory.Abstract_Factory.Drinks;

public class Tea : IHotDrink
{
    public int Amount { get; set; }

    public Tea(int amount)
    {
        Amount = amount;
    }

    public void Consume()
    {
        Console.WriteLine("Tea Consumed");
        Amount = 0;
    }
}