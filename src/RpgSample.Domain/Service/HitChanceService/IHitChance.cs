namespace RpgSample.Domain.Service.HitChanceService;

public interface IHitChance
{
    bool IsHitTarget(Character one, Character two);
}
