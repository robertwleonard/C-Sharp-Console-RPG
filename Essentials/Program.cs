using Essentials;

var enemyOne = new Enemy("The evil tree");
var enemyTwo = new Enemy("The giant sloth", 3);

Console.WriteLine(enemyOne.CapitalizeName);
Console.WriteLine(enemyTwo.GetHP());

var playerOne = new Player("Aarchane");
var playerTwo = new Player("Grafton", 4);

Console.WriteLine($"{playerOne.CapitalizeName} is level {playerOne.GetLevel()}");
Console.WriteLine($"{playerTwo.CapitalizeName} {playerTwo.GetTitle()}");