namespace RpgSample.Domain.Entities.CharacterAttributes;

public class AttributesSecondary
{
    public MinMaxDamage MinMaxDamage { get; set; } = new();
    public int Defense { get; set; }
    public int HitChance { get; private set; }
    public int DodgeChance { get; private set; }
    public int CriticalChance { get; set; } = 15;

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

    public void UpdateStats(Attributes attributes)
    {
        MinMaxDamage.Min = attributes.Strength * 1;
        MinMaxDamage.Max = attributes.Strength * 2;

        Defense = attributes.Strength / 2;
        
        HitChance = attributes.Dexterity * 1;
        DodgeChance = attributes.Dexterity * 1;
    }

    public int MinDamage() => MinMaxDamage.Min;
    public int MaxDamage() => MinMaxDamage.Max;

    public override string ToString() => 
          $"Damage: {MinDamage()} - {MaxDamage()}\n"
        + $"Defense: {Defense}\n"
        + $"Hit: {HitChance}\n"
        + $"Dodge: {DodgeChance}\n";
}