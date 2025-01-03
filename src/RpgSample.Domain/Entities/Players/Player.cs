using RpgSample.Domain.Entities.Equipments;

namespace RpgSample.Domain.Entities.Players;

public class Player(int hp, Attributes attributes) : Character(hp, attributes)
{
    public Equip Equipments { get; set; } = new();

    public void EquipWeapon(Weapon weapon)
    {
        Equipments.FirstHand ??= new(weapon);
    }

    public override int CurrentDamage() => Equipments.HaveWeapon()
        ? GetDamage(Equipments.MinDamage(), Equipments.MaxDamage())
        : GetDamage();

    public override int CurrentHit()
    {
        if(Equipments.HaveWeapon())
        {
            return AttributesSecondary.HitChance + Equipments.FirstHand!.Weapon!.HitChance;
        }

        return AttributesSecondary.HitChance;
    }

    private int GetCurrentMinDamage() => Equipments.HaveWeapon() 
        ? Equipments.MinDamage() + AttributesSecondary.MinDamage() 
        : AttributesSecondary.MinDamage();
    
    private int GetCurrentMaxDamage() => Equipments.HaveWeapon() 
        ? Equipments.MaxDamage() + AttributesSecondary.MaxDamage() 
        : AttributesSecondary.MaxDamage();

    public override string ToString()
    {
        return base.ToString()
            + $"\n{GetCurrentMinDamage()} - {GetCurrentMaxDamage()}";
    }
}
