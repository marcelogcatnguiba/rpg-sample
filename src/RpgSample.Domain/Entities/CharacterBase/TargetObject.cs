namespace RpgSample.Domain.Entities.CharacterBase;

public abstract class TargetObject(int hp, int? damage)
{
    public int HP { get; set; } = hp;
    public int Damage { get; set; } = damage ?? 0;
    public bool IsDead { get => HP.Equals(0); }

    public override string ToString()
    {
        return $"HP: {HP}\nDamage: {Damage}";
    }
}
