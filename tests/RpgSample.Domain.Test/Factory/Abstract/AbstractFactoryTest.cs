using RpgSample.Domain.Entities.Enemies.Types;
using RpgSample.Domain.Factory.Abstract;

namespace RpgSample.Domain.Test.Factory.Abstract;

public class AbstractFactoryTest
{
    [Fact]
    public void DeveRetornarUmaFactoryDeEnemy()
    {
        var factory = new AbstractFactory();

        var result = factory.CreateEnemy(typeof(CommonEnemy), EnemyClass.Wolf);

        result.Should().BeOfType<Wolf>();
    }
}
