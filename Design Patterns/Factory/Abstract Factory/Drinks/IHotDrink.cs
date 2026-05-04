namespace Factory.Abstract_Factory.Drinks;

public interface IHotDrink
{
    int Amount { get; set; }
    public void Consume();
}