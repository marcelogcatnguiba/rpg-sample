namespace RpgSample.Domain.Entities.Enemies;

public class Goblin(int hp, Attributes attributes) : Character(hp, attributes)
{
    #region Base
    protected override int SetBaseDamage() => base.SetBaseDamage() + 5;
    
    #endregion

    public override int CurrentHit() => AttributesSecondary.HitChance;
    public override int CurrentDamage() => AttributesSecondary.Damage;

}