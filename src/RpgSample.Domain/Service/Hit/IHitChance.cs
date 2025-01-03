namespace RpgSample.Domain.Service.Hit;

public interface IHitChance
{
    bool IsHitTarget(Character one, Character two);
}
