
using System.Reflection;

namespace RpgSample.Domain.Factory.Abstract;

public class AbstractFactory : IAbstractFactory
{
    public Enemy? CreateEnemy(Type monsterType, EnemyClass enemy)
    {

        var list = Assembly
            .GetExecutingAssembly()
            .GetTypes()
            .Where(x => x.IsAssignableTo(typeof(IEnemyFactory)) && !x.IsAbstract)
            .Select(x => Activator.CreateInstance(x) as IEnemyFactory);
        
        var factory = list.FirstOrDefault(x => x is null || x.CanCreateType(monsterType));

        if(factory is null)
        {
            return null;
        }

        return factory.CreateEnemy(enemy);
    }
}
