var playerOne = new Player(100, new Attributes(5, 5, 5));
var goblin = new Goblin(50, new Attributes(5, 4, 2));

BattleService.Start(playerOne, goblin);