namespace RpgSample.Domain.Factory.Players;

public static class PlayersFactory
{
    public static Character CreateCaracter(CaracterClass caracterClass) => 
        caracterClass switch
        {
            CaracterClass.Warrior => new Warrior(100, new(8, 5, 2)),

            CaracterClass.Ranger => new Ranger(70, new(8, 5, 2)),
            
            CaracterClass.Mage => new Mage(50, new(8, 5, 2)),

            _ => throw new NotImplementedException("Class not found")
        };
}
