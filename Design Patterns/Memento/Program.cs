using Memento.Player;

// We want to save the state of some object, So that we can restore it later
// - Don't break encapsulation, Don't expose internal state of the object
// - It's not a blind copy of the object, Only relevant info 

// 3 Components to this
// 1- The thing we want to save its state (Originator)
// 2- The small capsule that holds the essential info to restore the state
//   - that the player can use to save and restore its state with (Memento)
// 3- The controller that tracks the history of the states - We want to keep it blind to the internal state of the originator (Caretaker)

#region Good

var player = new Player("John", 100, 1, "SecretData");
var saveManager = new PlayerSaveManager(player); // <- Tracks our player save history

// Player is changing
player.Health -= 10;
player.Level += 1;

// Save Player State
saveManager.SavePlayerState();

// Player is Dead
player.Health = 0;
// Game Over

// We Undo
saveManager.Undo();

#endregion


