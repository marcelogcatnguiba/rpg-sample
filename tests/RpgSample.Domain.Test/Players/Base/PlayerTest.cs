using RpgSample.Domain.Weapons;

namespace RpgSample.Domain.Test.Players.Base;

public class PlayerTest
{
    [Fact]
    public void ShouldEquipWeapon()
    {
        var warrior = PlayersFactory.CreateCaracter(CaracterClass.Warrior);
        var sword = new Sword(new(5, 10), 5);

        warrior.EquipWeapon(sword);

        warrior.Equipments.HaveWeapon().Should().BeTrue();
    }
}
