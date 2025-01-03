namespace RpgSample.Domain.Entities.CharacterAttributes;

public class AttributesSecondary
{
    public int Damage { get; set; }
    public int Defense { get; set; }
    public int HitChance { get; private set; }
    public int DodgeChance { get; private set; }

    public void UpdateStats(int? dmg, int? defense, int? hit, int? dodge)
    {
        if(dmg != null)
        {
            Damage = (int)dmg;
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
}