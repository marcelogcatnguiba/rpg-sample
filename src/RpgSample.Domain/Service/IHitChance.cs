namespace RpgSample.Domain.Service;

public interface IHitChance
{
    bool IsHitTarget(Character one, Character two);
}
