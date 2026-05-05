

using Prototype;

var enemy = new Enemy("Zombie", new Weapon(100));

#region Bad

List<Enemy> enemies = new List<Enemy>();

for (int i = 0; i < 10; i++)
{
    // enemies.Add(enemy); // Shallow Copy
    // enemies.Add(enemy.Clone() as Enemy); // Deep Copy using ICloneable - But Still Bad
}

enemies.ForEach(Console.WriteLine);

#endregion

#region Good

// Can be used as a template for new enemies
// And Yeah, That is simply the problem
var enemyPrototype = new Enemy(enemy); // Using copy constructor
var enemyPrototype2 = enemy.DeepCopy(); // Interface - Uses copy constructor
var enemyPrototype3 = enemy.DeepCopyJson(); // Object <==> Json String

List<Enemy> enemies2 = [];

for (int i = 0; i < 10; i++)
{
    enemies2.Add(enemyPrototype2.DeepCopy());
}

#endregion
