namespace RpgSample.Domain.Test.Factory.Enemies;

public class EnemiesFactoryTest
{
    [Fact]
    public void ShouldBeWolf() => EnemiesFactory.CreateEnemy(EnemyClass.Wolf)
                                                .Should()
                                                .BeOfType<Wolf>();
    
}
