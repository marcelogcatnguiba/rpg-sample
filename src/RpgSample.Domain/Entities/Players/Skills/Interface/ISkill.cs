namespace RpgSample.Domain.Entities.Players.Skills.Interface;

public interface ISkill
{
    static string Name { get; } = null!;
    static string Description { get; } = null!;
    
    int Damage();
}
