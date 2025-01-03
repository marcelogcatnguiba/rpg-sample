namespace RpgSample.Domain.Factory.Players;

public static class PlayersFactory
{
    public static Character CreateCaracter(CaracterClass caracterClass) => 
        caracterClass switch
        {
            CaracterClass.Warrior => new Warrior(100, new(8, 5, 2)),

            _ => throw new NotImplementedException("Class not found")
        };
}
