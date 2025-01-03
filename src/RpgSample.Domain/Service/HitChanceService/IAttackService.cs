namespace RpgSample.Domain.Service.HitChanceService;

public interface IAttackService
{
    int Attack(Character attacker, Character target);
}
