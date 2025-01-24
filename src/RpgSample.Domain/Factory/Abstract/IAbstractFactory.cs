namespace RpgSample.Domain.Factory.Abstract;

public interface IAbstractFactory
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="monsterType">classe que o monstro herda</param>
    /// <param name="enemy">tipo enumerado do monstro</param>
    /// <returns></returns>
    Enemy? CreateEnemy(Type monsterType, EnemyClass enemy);
}
