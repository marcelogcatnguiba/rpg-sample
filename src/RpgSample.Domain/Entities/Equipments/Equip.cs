namespace RpgSample.Domain.Entities.Equipments;

public class Equip
{
    public FirstHand? FirstHand { get; set; }

    public bool HaveWeapon() => FirstHand != null;
    public int MinDamage() => HaveWeapon() ? FirstHand!.Weapon.MinMaxDamage.Min : 0;
    public int MaxDamage() => HaveWeapon() ? FirstHand!.Weapon.MinMaxDamage.Max : 0;
}
