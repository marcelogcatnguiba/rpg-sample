using RpgSample.Domain.Entities.Equipments;

namespace RpgSample.Domain.Entities.Players;

public class Player(int hp, Attributes attributes) : Character(hp, attributes)
{
    public Equip Equipments { get; set; } = new();

    protected override int SetBaseDefense() => 4;

    public void EquipWeapon(Weapon weapon)
    {
        Equipments.FirstHand ??= new();

        Equipments.FirstHand.Weapon = weapon;
    }

    public override int CurrentDamage()
    {
        if(Equipments.FirstHand != null && Equipments.FirstHand.Weapon != null)
        {
            return AttributesSecondary.Damage + Equipments.FirstHand!.Weapon!.Damage;
        }

        return AttributesSecondary.Damage;
    }

    public override int CurrentHit()
    {
        if(Equipments.FirstHand != null && Equipments.FirstHand.Weapon != null)
        {
            return AttributesSecondary.HitChance + Equipments.FirstHand!.Weapon!.HitChance;
        }

        return AttributesSecondary.HitChance;
    }
}
