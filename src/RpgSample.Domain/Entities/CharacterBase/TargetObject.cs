namespace RpgSample.Domain.Entities.CharacterBase;

public abstract class TargetObject(int hp)
{
    public int HP { get; set; } = hp;
    public bool IsDead { get => HP < 0; }

    public void SetDamage(int damage) => HP -= damage;
}
