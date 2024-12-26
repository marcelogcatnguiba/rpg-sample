namespace RpgSample.Domain.Entities.CharacterBase;

public abstract class Character: TargetObject
{
    private readonly HitChance _hitChance = new();
    
    public Attributes Attributes { get; set; }
    public AttributesSecondary AttributesSecondary { get; set; } = new();

    public Character(int hp, Attributes attributes) : base(hp)
    {
        Attributes = attributes;
        SetAttributesSecondary();
    }

    public virtual int Attack(Character target)
    {
        if(!_hitChance.IsHitTarget(this, target))
        {
            return 0;
        }

        var causeDamage = CurrentDamage() - target.AttributesSecondary.Defense;
        target.SetDamage(causeDamage <= 0 ? 0 : causeDamage);

        return causeDamage;
    }

    protected virtual void SetAttributesSecondary()
    {
        SetDamage();
        SetHitChance();
        SetDodge();
        SetDefense();
    }

    protected virtual void SetDamage() => AttributesSecondary.Damage = Attributes.Strength * 1;
    protected virtual void SetHitChance() => AttributesSecondary.HitChance = Attributes.Dexterity * 5;
    protected virtual void SetDodge() => AttributesSecondary.DodgeChance = Attributes.Dexterity * 5;
    protected abstract void SetDefense();

    protected abstract int CurrentDamage();
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
