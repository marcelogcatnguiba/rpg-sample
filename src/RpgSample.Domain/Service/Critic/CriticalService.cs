
namespace RpgSample.Domain.Service.Critic;

public class CriticalService : ICriticalService
{
    private readonly Random _random = new();

    public bool IsCriticalHit(Character character)
    {
        var chance = _random.Next(1, 100);

        return chance <= character.CurrentCriticalChance();
    }
}
