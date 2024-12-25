namespace RpgSample.Domain.Entities.CharacterBase;

public abstract class TargetObject(int hp, int? damage)
{
    public int HP { get; set; } = hp;
    public int Damage { get; set; } = damage ?? 0;
    public bool IsDead { get => HP.Equals(0); }

    protected virtual void SetDamage(int damage) => HP -= damage;
    public override string ToString() => $"HP: {HP}\nDamage: {Damage}";
}
