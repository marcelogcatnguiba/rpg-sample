namespace RpgSample.Domain.Test.Factory.Players;

public class PlayersFactoryTest
{
    [Fact]
    public void ShouldBeWarrior() => PlayersFactory.CreateCaracter(CaracterClass.Warrior)
                                                   .Should()
                                                   .BeOfType<Warrior>();
    
    [Fact]
    public void ShouldBeRanger() => PlayersFactory.CreateCaracter(CaracterClass.Ranger)
                                                  .Should()
                                                  .BeOfType<Ranger>();
    
    [Fact]
    public void ShouldBeMage() => PlayersFactory.CreateCaracter(CaracterClass.Mage)
                                                .Should()
                                                .BeOfType<Mage>();
}
