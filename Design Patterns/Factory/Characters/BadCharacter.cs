namespace Factory.Characters;

// BAD!
// Violation SPR -> Character Class is now responsible for How to create itself
// Violation OCP -> You modify Character class to add new CharacterType
// Client need to know about the CharacterType enum
// Other Example is Point -> Point(1,2,Cartesian)
// The API Point(int someFirstParam,someSecondParam,CoordinateSystem)
// -> It doesn't convey the meaning
public enum CharacterType
{
    Player,
    Enemy,
}

public class BadCharacter
{
    public string Name { get; set; }

    public int Health { get; set; }

    // Let's say this we want to construct a Character based of the type of the character
    // If Player : Health = 100
    // If Enemy : Health = 1000;
    public BadCharacter(string name, CharacterType characterType)
    {
        Name = name;
        Health = characterType switch
        {
            CharacterType.Player => 100,
            CharacterType.Enemy => 1000,
            _ => throw new ArgumentException("Wrong Type"),
        };
    }

    // I can't do this
    // public BadCharacterPlayer(string name)
    // {
    //     Name = name;
    //     Health = 100;
    // }
    // public BadCharacterEnemy(string name)
    // {
    //     Name = name;
    //     Health = 1000;
    // }
}
