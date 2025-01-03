var warrior = PlayersFactory.CreateCaracter(CaracterClass.Warrior);
var wolf = EnemiesFactory.CreateEnemy(EnemyClass.Wolf);

BattleService.Start(warrior, wolf);