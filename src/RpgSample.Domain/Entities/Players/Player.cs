namespace RpgSample.Domain.Entities.Players;

public class Player(int hp, Attributes attributes) : Character(hp, attributes)
{
    private int _weaponDamage;

    public void SetWeapon(int dmg)
    {
        _weaponDamage = dmg;
        Damage += _weaponDamage;
    }

    protected override void SetDefense() => AttributesSecondary.Defense = 3;
}
