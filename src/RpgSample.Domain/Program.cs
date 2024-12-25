using RpgSample.Domain.Service;

var playerOne = new Player(100, new Attributes(5, 5, 5));
var goblin = new Enemy(50, new Attributes(5, 4, 2));

Battle.Start(playerOne, goblin);