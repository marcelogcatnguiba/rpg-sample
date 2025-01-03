namespace RpgSample.Domain.Weapons;

public abstract class Weapon(int damage, int hit)
{
    public int Damage { get; set; } = damage;
    public int HitChance { get; set; } = hit;
}
