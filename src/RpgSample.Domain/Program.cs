var warrior = PlayersFactory.CreateCaracter(CaracterClass.Warrior);
var wolf = new CommonEnemyFactory().CreateEnemy(EnemyClass.Wolf);

BattleService.Start(warrior, wolf);