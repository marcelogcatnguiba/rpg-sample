namespace RpgSample.Domain.Factory.Enemies;

public interface IEnemyFactory
{
    bool CanCreateType(Type type);
    Enemy CreateEnemy(EnemyClass enemy);
}
