namespace RpgSample.Domain.Entities.Enemies;

public class Goblin(int hp, Attributes attributes) : Character(hp, attributes)
{
    public override int CurrentHit() => AttributesSecondary.HitChance;
    // public override int CurrentDamage() => _random.Next(AttributesSecondary.MinMaxDamage.Min, AttributesSecondary.MinMaxDamage.Max);

}