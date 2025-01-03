namespace RpgSample.Domain.Entities.CharacterAttributes;

public class AttributesSecondary
{
    public MinMaxDamage MinMaxDamage { get; set; } = new();
    public int Defense { get; set; }
    public int HitChance { get; private set; }
    public int DodgeChance { get; private set; }

    public void UpdateStats(MinMaxDamage? minMaxDamage, int? defense, int? hit, int? dodge)
    {
        if(MinMaxDamage != null)
        {
            MinMaxDamage = minMaxDamage!;
        }

        if(defense != null)
        {
            Defense = (int)defense;
        }

        if(hit != null)
        {
            HitChance = (int)hit;
        }

        if(dodge != null)
        {
            DodgeChance = (int)dodge;
        }
    }

    public int MinDamage() => MinMaxDamage.Min;
    public int MaxDamage() => MinMaxDamage.Max;
}