namespace RpgSample.Domain.Entities.CharacterBase;

public abstract class Character: TargetObject
{    
    protected readonly Random _random = new();
    public Attributes Attributes { get; set; }
    public AttributesSecondary AttributesSecondary { get; private set; } = new();

    protected Character(int hp, Attributes attributes) : base(hp)
    {
        Attributes = attributes;
        AttributesSecondary.UpdateStats(Attributes);
    }

    public virtual int CurrentHit() => AttributesSecondary.HitChance;

    public virtual int CurrentCriticalChance() => AttributesSecondary.CriticalChance;

    public virtual int CurrentDamage() => 
        _random.Next(AttributesSecondary.MinDamage(), 
                     AttributesSecondary.MaxDamage());

    public int GetDamage() => 
        _random.Next(AttributesSecondary.MinDamage(), 
                     AttributesSecondary.MaxDamage());

    public int GetDamage(int min, int max) => 
        _random.Next(AttributesSecondary.MinDamage() + min, 
                     AttributesSecondary.MaxDamage() + max);

    public override string ToString() => 
        $"{GetType().Name} stats:\n" 
            + $"HP: {HP}\n"
            + $"Att Secondary: \n{AttributesSecondary}";
    
}
