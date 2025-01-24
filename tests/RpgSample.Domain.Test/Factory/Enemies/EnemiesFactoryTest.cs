namespace RpgSample.Domain.Test.Factory.Enemies;

public class EnemiesFactoryTest
{
    [Fact]
    public void ShouldBeWolf() => new CommonEnemyFactory().CreateEnemy(EnemyClass.Wolf)
                                                .Should()
                                                .BeOfType<Wolf>();
    
}
