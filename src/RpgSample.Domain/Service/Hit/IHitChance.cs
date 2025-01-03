namespace RpgSample.Domain.Service.HitService;

public interface IHitChance
{
    bool IsHitTarget(Character one, Character two);
}
