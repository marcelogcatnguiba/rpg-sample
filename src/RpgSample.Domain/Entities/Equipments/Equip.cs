namespace RpgSample.Domain.Entities.Equipments;

public class Equip
{
    public FirstHand? FirstHand { get; set; }

    public bool HaveWeapon() => FirstHand != null;
}
