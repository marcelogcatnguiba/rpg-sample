namespace RpgSample.Domain.Entities;

public class Player : Character
{
    private int _weaponDamage;
    private readonly int _precision;

    public Player(int hp, Attributes attributes) : base(hp, attributes)
    {
        _precision = Attributes.Dexterity;
    }
    
    public void SetWeapon(int dmg)
    {
        _weaponDamage = dmg;
        Damage += _weaponDamage;
    }
}
