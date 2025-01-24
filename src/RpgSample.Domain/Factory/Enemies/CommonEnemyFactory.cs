using RpgSample.Domain.Entities.Enemies.Types;

namespace RpgSample.Domain.Factory.Enemies;

public class CommonEnemyFactory : IEnemyFactory
{
    public bool CanCreateType(Type type)
    {
        return type.IsAssignableTo(typeof(CommonEnemy));
    }

    public Enemy CreateEnemy(EnemyClass enemy) 
    {
        return enemy switch 
        {
            EnemyClass.Wolf => new Wolf(50, new(7, 2, 1)),

            _ => throw new NotImplementedException("Enemy not found")
        };
    }
}
