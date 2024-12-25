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
        if(_hitChance.IsHitTarget(this, target))
        {
            target.SetDamage(AttributesSecondary.Damage);
            return AttributesSecondary.Damage;
        }

        return 0;
    }

    protected virtual void SetAttributesSecondary()
    {
        AttributesSecondary = new()
        {
            Damage = Attributes.Strength * 1,
            HitChance = Attributes.Dexterity * 5,
            DodgeChance = Attributes.Dexterity * 5
        };

        Damage = AttributesSecondary!.Damage;
    }

    public override string ToString()
    {
        return $"{GetType().Name} stats:\n" 
            + base.ToString()
            +"\n"
            + $"Hit: {AttributesSecondary.HitChance}\t"
            + $"Dodge: {AttributesSecondary.DodgeChance}"
            + $"\nIsDead {IsDead}";
    }
}
