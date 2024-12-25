
namespace RpgSample.Domain.Service;

public class HitChance : IHitChance
{
    private readonly Random _random = new();
    public bool IsHitTarget(Character one, Character two)
    {
        int chanceToHit = 90 - two.AttributesSecondary.DodgeChance + one.AttributesSecondary.HitChance;
        var value = _random.Next(1, 100);

        Console.WriteLine($"{one.GetType().Name}, hit chance: {chanceToHit}, valor do random foi: {value}");

        return chanceToHit >= value;
    }
}
