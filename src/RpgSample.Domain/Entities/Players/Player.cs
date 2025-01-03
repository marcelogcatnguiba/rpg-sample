using RpgSample.Domain.Entities.Equipments;

namespace RpgSample.Domain.Entities.Players;

public class Player(int hp, Attributes attributes) : Character(hp, attributes)
{
    public Equip Equipments { get; set; } = new();

    protected override int SetBaseDefense() => 4;

    public void EquipWeapon(Weapon weapon)
    {
        Equipments.FirstHand ??= new(weapon);
    }

    public override int CurrentDamage()
    {
        if(Equipments.HaveWeapon())
        {
            return AttributesSecondary.Damage + Equipments.FirstHand!.Weapon!.Damage;
        }

        return AttributesSecondary.Damage;
    }

    public override int CurrentHit()
    {
        if(Equipments.HaveWeapon())
        {
            return AttributesSecondary.HitChance + Equipments.FirstHand!.Weapon!.HitChance;
        }

        return AttributesSecondary.HitChance;
    }
}
