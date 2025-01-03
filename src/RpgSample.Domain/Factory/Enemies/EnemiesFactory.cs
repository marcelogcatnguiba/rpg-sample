namespace RpgSample.Domain.Factory.Enemies;

public static class EnemiesFactory
{
    public static Character CreateEnemy(EnemyClass enemyClass) => 
        enemyClass switch 
        {
            EnemyClass.Wolf => new Wolf(50, new(7, 2, 1)),

            _ => throw new NotImplementedException("Enemy not found")
        };
    
}
