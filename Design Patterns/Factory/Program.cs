using Factory.Abstract_Factory;
using Factory.Abstract_Factory.DrinkFactory;
using Factory.Characters;

// Bad Usage
var player = new BadCharacter("PlayerName1", CharacterType.Player);
var enemy = new BadCharacter("EnemyName1", CharacterType.Enemy);


// Good Usage - Factor Method
// var player1 = Character.CreatePlayer("PlayerName2");
// var enemy1 = Character.CreateEnemy("EnemyName2");

// Or -> Factory Class
var player2 = Character.Factory.CreatePlayer("PlayerName3");

// - TPL With Task.Factory.StartNew();
// var player3 = Character.FactoryInstance.CreatePlayer("PlayerName4");


var tf = new TeaFactory(); // Change this with CoffeeFactory if you want
var drink = tf.Produce(200);
drink.Consume();

// HotDrinkMachine uses it
var machine = new HotDrinkMachine();
var drink1 = machine.MakeDrink(DrinkType.Tea, 100);
drink1.Consume();



