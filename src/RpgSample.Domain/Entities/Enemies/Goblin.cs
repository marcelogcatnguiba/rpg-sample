namespace RpgSample.Domain.Entities.Enemies;

public class Goblin(int hp, Attributes attributes) : Character(hp, attributes)
{
    protected override void SetDefense() => AttributesSecondary.Defense = 4;
}