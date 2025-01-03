namespace RpgSample.Domain.Entities.CharacterBase;

public abstract class Character: TargetObject
{    
    protected readonly Random _random = new();
    public Attributes Attributes { get; set; }
    public AttributesSecondary AttributesSecondary { get; private set; } = new();

    protected Character(int hp, Attributes attributes) : base(hp)
    {
        Attributes = attributes;

        AttributesSecondary.UpdateStats
        (
            minMaxDamage: SetBaseDamage(),
            defense: SetBaseDefense(), 
            hit: SetBaseHit(), 
            dodge: SetBaseDodge() 
        );
    }

    protected virtual MinMaxDamage SetBaseDamage() => new(Attributes.Strength * 1, Attributes.Strength * 2);
    protected virtual int SetBaseDefense() => 3;
    protected virtual int SetBaseHit() => Attributes.Dexterity * 5;
    protected virtual int SetBaseDodge() => Attributes.Dexterity * 5;

    public virtual int CurrentDamage() => _random.Next(AttributesSecondary.MinMaxDamage.Min, AttributesSecondary.MinMaxDamage.Max);
    public abstract int CurrentHit();

    public int GetDamage() => _random.Next(AttributesSecondary.MinMaxDamage.Min, AttributesSecondary.MinMaxDamage.Max);
    public int GetDamage(int min, int max) => _random.Next(AttributesSecondary.MinMaxDamage.Min + min, AttributesSecondary.MinMaxDamage.Max + max);

    public override string ToString()
    {
        return $"{GetType().Name} stats:\n" 
            + $"HP: {HP}\n"
            + $"{AttributesSecondary.MinMaxDamage.Min} - {AttributesSecondary.MinMaxDamage.Max}\n"
            + $"Defense: {AttributesSecondary.Defense}\n"
            + $"Hit: {AttributesSecondary.HitChance}\n"
            + $"Dodge: {AttributesSecondary.DodgeChance}\n"
            + $"IsDead {IsDead}";
    }
}
