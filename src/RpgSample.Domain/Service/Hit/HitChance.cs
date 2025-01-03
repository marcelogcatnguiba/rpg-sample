namespace RpgSample.Domain.Service.HitService;

public class HitChance : IHitChance
{
    private readonly Random _random = new();
    public bool IsHitTarget(Character one, Character two)
    {
        int chanceToHit = 90 - two.AttributesSecondary.DodgeChance + one.CurrentHit();
        var value = _random.Next(1, 100);

        Console.WriteLine($"{one.GetType().Name}, hit chance: {chanceToHit}, valor do random foi: {value}");

        return chanceToHit >= value;
    }
}
