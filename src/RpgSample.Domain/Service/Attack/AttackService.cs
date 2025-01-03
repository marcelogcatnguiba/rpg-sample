namespace RpgSample.Domain.Service.Attack;

public class AttackService : IAttackService
{
    private readonly HitChance _hitChance = new();

    public int Attack(Character attacker, Character target)
    {
        if(attacker.IsDead)
        {
            return 0;
        }
        
        if(!_hitChance.IsHitTarget(attacker, target))
        {
            return 0;
        }

        var causeDamage = attacker.CurrentDamage() - target.AttributesSecondary.Defense;
        target.SetDamage(causeDamage <= 0 ? 0 : causeDamage);

        return causeDamage;
    }
}
