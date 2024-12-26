namespace RpgSample.Domain.Entities.Enemies;

public class Goblin(int hp, Attributes attributes) : Character(hp, attributes)
{
    public override int CurrentHit()
    {
        return AttributesSecondary.HitChance;
    }

    protected override int CurrentDamage()
    {
        return AttributesSecondary.Damage;
    }

    protected override void SetDefense()
    {
        AttributesSecondary.Defense = 4;
    }
}