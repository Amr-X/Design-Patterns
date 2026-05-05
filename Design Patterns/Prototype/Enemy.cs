namespace Prototype;

// Making my own
public interface IPrototype<T>
{
    public T DeepCopy();
}

public class Enemy : IPrototype<Enemy> //: ICloneable It's not Generic
{
    public string Name { get; set; }
    public Weapon Weapon { get; set; }

    public Enemy()
    {
    }

    public Enemy(string name, Weapon weapon)
    {
        Name = name;
        Weapon = weapon;
    }

    // Copy Constructor -> C++
    public Enemy(Enemy other)
    {
        Name = other.Name;
        Weapon = new Weapon(other.Weapon);
    }

    // public object Clone()
    // {
    //     //return new Enemy(Name, Weapon); // Again, Weapon is a ref type, Make new Weapon
    //     return new Enemy(Name,Weapon.Clone() as Weapon);
    // }

    public override string ToString()
    {
        return $"Enemy Name: {Name}, Weapon Damage: {Weapon.Damage}";
    }

    public Enemy DeepCopy()
    {
        return new Enemy(this); // Using copy constructor
    }
}