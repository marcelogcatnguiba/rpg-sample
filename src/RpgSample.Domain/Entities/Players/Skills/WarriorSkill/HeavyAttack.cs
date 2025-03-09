using RpgSample.Domain.Entities.Players.Skills.Interface;

namespace RpgSample.Domain.Entities.Players.Skills.WarriorSkill;

public class HeavyAttack(Warrior warrior) : ISkill
{
    private readonly Warrior _warrior = warrior;

    public static string Name => nameof(Name);

    public static string Description => "Causa o dobro de dano";

    public int Damage()
    {
        return _warrior.CurrentDamage() * 2;
    }
}
