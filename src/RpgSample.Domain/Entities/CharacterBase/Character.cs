namespace RpgSample.Domain.Entities.CharacterBase;

public abstract class Character: TargetObject
{    
    public Attributes Attributes { get; set; }
    public AttributesSecondary AttributesSecondary { get; private set; } = new();

    public Character(int hp, Attributes attributes) : base(hp)
    {
        Attributes = attributes;

        AttributesSecondary.UpdateStats
        (
            dmg:SetBaseDamage(),
            defense: SetBaseDefense(), 
            hit: SetBaseHit(), 
            dodge: SetBaseDodge() 
        );
    }

    protected virtual int SetBaseDamage() => Attributes.Strength * 1;
    protected virtual int SetBaseDefense() => 3;
    protected virtual int SetBaseHit() => Attributes.Dexterity * 5;
    protected virtual int SetBaseDodge() => Attributes.Dexterity * 5;

    public abstract int CurrentDamage();
    public abstract int CurrentHit();

    public override string ToString()
    {
        return $"{GetType().Name} stats:\n" 
            + $"HP: {HP}\n"
            + $"Damage: {AttributesSecondary.Damage}\n"
            + $"Current Damage: {CurrentDamage()}\n"
            + $"Defense: {AttributesSecondary.Defense}\n"
            + $"Hit: {AttributesSecondary.HitChance}\n"
            + $"Dodge: {AttributesSecondary.DodgeChance}\n"
            + $"IsDead {IsDead}";
    }
}
