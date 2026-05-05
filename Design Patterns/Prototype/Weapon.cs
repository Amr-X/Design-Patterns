namespace Prototype;

public class Weapon : IPrototype<Weapon> // : ICloneable
{
    public Weapon(int damage)
    {
        Damage = damage;
    }

    public Weapon()
    {
    }

    public Weapon(Weapon other)
    {
        Damage = other.Damage;
        // Any ref you make a new 
    }

    public int Damage { get; set; }

    public Weapon DeepCopy()
    {
        return new Weapon(this); // Using copy constructor
    }
}