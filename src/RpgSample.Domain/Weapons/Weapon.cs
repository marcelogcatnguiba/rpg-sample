namespace RpgSample.Domain.Weapons;

public abstract class Weapon(MinMaxDamage minMaxDamage, int hit)
{
    public MinMaxDamage MinMaxDamage { get; set; } = minMaxDamage;
    public int HitChance { get; set; } = hit;
}
