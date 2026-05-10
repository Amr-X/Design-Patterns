namespace Memento.Player;

// The *Caretaker* 
// Tracks the player state history
// Could be in the player itself, But it violates SRP
public class PlayerSaveManager
{
    private Player _player;
    private Stack<Player.PlayerMemento> _history = new();

    public PlayerSaveManager(Player player)
    {
        _player = player;
        // The first state should be saved
        SavePlayerState();
    }

    public void SavePlayerState()
    {
        _history.Push(_player.SaveState());
    }

    public void Undo()
    {
        if (_history.TryPop(out var lastStateMemento))
        {
            _player.RestoreState(lastStateMemento);
        }
    }
}