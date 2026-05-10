namespace Memento.Player;

// The *Originator*
public class Player(string name, int health, int level, string privateData)
{
    public string Name { get; set; } = name;
    public int Health { get; set; } = health;
    public int Level { get; set; } = level;

    // This showcases that SaveManager needs the see the private data to be able to save the state of the player
    // We can't do respecting Encapsulating Objects
    private string _privateData = privateData;

    /*
        - Cloning the Originator is not a great idea (Prototype)
        --- 1- It could be a huge object
        --- 2- Has irrelevant information that we don't want to save
    */

    // public Player(Player p) : this(p.Name, p.Health, p.Level, p._privateData)
    // {
    // }
    // public Player Clone() => new(this);


    // The *Memento* <- Immutable - It's a Snapshot. Why would you want to change it?
    // Store relevant info to restore player
    // The thing here is that the Originator Knows how to store its state
    public class PlayerMemento(string name, int health, int level, string privateData)
    {
        // Should be public, Visible to the Caretaker
        internal string Name { get; } = name;
        internal int Health { get; } = health;
        internal int Level { get; } = level;
        internal string PrivateData { get; } = privateData;
    }

    public PlayerMemento SaveState() => new PlayerMemento(Name, Health, Level, _privateData);

    public void RestoreState(PlayerMemento memento)
    {
        Name = memento.Name;
        Health = memento.Health;
        Level = memento.Level;
        _privateData = memento.PrivateData;
    }
}

// public class PlayerSaveManager(Player player)
// {
//     private Player _player = player;
//     public Stack<Player> History { get; } = new();

//     public void SavePlayerSate()
//     {
//         History.Push(player.Clone());
//         // Or Directly access the private data of the player
//         
//     }

// }