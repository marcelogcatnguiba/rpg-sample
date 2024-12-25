namespace RpgSample.Domain.Entities.CharacterBase;

public abstract class Character: TargetObject
{
    private readonly HitChance _hitChance = new();
    
    public Attributes Attributes { get; set; }
    public AttributesSecondary AttributesSecondary { get; set; } = new();

    public Character(int hp, Attributes attributes) : base(hp, null)
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

        var causeDamage = AttributesSecondary.Damage - target.AttributesSecondary.Defense;
        target.SetDamage(causeDamage <= 0 ? 0 : causeDamage);

        return causeDamage;
    }

    protected virtual void SetAttributesSecondary()
    {
        SetDamage();
        SetHitChance();
        SetDodge();
        SetDefense();

        Damage = AttributesSecondary!.Damage;
    }

    protected virtual void SetDamage() => AttributesSecondary.Damage = Attributes.Strength * 1;
    protected virtual void SetHitChance() => AttributesSecondary.HitChance = Attributes.Dexterity * 5;
    protected virtual void SetDodge() => AttributesSecondary.DodgeChance = Attributes.Dexterity * 5;
    protected abstract void SetDefense();

    public override string ToString()
    {
        return $"{GetType().Name} stats:\n" 
            + base.ToString()
            +"\n"
            + $"Hit: {AttributesSecondary.HitChance}\t"
            + $"Dodge: {AttributesSecondary.DodgeChance}\t"
            + $"Defense: {AttributesSecondary.Defense}"
            + $"\nIsDead {IsDead}";
    }
}
